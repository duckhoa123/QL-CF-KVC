using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace QL_COFFE_KVC
{
    public static class XmlUtils
    {
        public static XmlNode GetNode(string path, string nodePath)
        {
            if (!File.Exists(path))
                return null;

            var xmldoc = new XmlDocument();
            xmldoc.Load(path);
            return xmldoc.DocumentElement.SelectSingleNode(nodePath);
        }

        public static XmlNode GetNode(string path, string nodePath, string nameSpace, string nameSpaceAlias)
        {
            if (!File.Exists(path))
                return null;

            var xmlReader = new XmlTextReader(path) { XmlResolver = new XmlUrlResolver(), EntityHandling = EntityHandling.ExpandEntities };
            var xmldoc = new XmlDocument();
            try { xmldoc.Load(xmlReader); }
            catch (Exception ex)
            {
                xmlReader.Dispose();
                throw new Exception(ex.Message, ex);
            }
            xmlReader.Dispose();
            if (string.IsNullOrWhiteSpace(nodePath))
                return xmldoc.DocumentElement;

            if (string.IsNullOrWhiteSpace(nameSpace))
                return xmldoc.DocumentElement.SelectSingleNode(nodePath);

            var ns = new XmlNamespaceManager(xmldoc.NameTable);
            ns.AddNamespace(nameSpaceAlias, nameSpace);
            return xmldoc.DocumentElement.SelectSingleNode(nodePath, ns);
        }

        public static XmlNode GetNode(string path, string nodePath, string nameSpace, string nameSpaceAlias, out XmlNamespaceManager namespaceManager)
        {
            if (!File.Exists(path))
            {
                namespaceManager = null;
                return null;
            }

            var xmlReader = new XmlTextReader(path) { XmlResolver = new XmlUrlResolver(), EntityHandling = EntityHandling.ExpandEntities };
            var xmldoc = new XmlDocument();
            try { xmldoc.Load(xmlReader); }
            catch (Exception ex)
            {
                xmlReader.Dispose();
                throw new Exception(ex.Message, ex);
            }
            xmlReader.Dispose();
            if (string.IsNullOrWhiteSpace(nodePath))
            {
                namespaceManager = null;
                return xmldoc.DocumentElement;
            }

            if (string.IsNullOrWhiteSpace(nameSpace))
            {
                namespaceManager = null;
                return xmldoc.DocumentElement.SelectSingleNode(nodePath);
            }

            namespaceManager = new XmlNamespaceManager(xmldoc.NameTable);
            namespaceManager.AddNamespace(nameSpaceAlias, nameSpace);
            return xmldoc.DocumentElement.SelectSingleNode(nodePath, namespaceManager);
        }

        public static string Attribute(this XmlNode node, string name, string defaultValue = "")
        {
            if (node == null) return defaultValue;
            if (node.Attributes[name] is XmlAttribute attribute) return attribute.Value;
            return node[name] == null ? defaultValue : node[name].InnerText;
        }

        public static bool HasAttribute(this XmlNode node, string name)
        {
            return node.Attributes[name] != null;
        }
    }

}
