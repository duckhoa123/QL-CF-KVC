using System.Reflection;
using System.Xml;

namespace QL_COFFE_KVC
{
    public class QueryManager
    {
        Assembly _assembly { get; } = typeof(QueryManager).Assembly;
        XmlNode _controllers;

        public static QueryManager Instance { get; } = new QueryManager();

        QueryManager()
        {
            var xmldoc = new XmlDocument();
            xmldoc.Load(_assembly.GetManifestResourceStream("QL_COFFE_KVC.Resources.Queries.xml"));
            _controllers = xmldoc.DocumentElement;
        }

        public string GetQuery(string controller, string name)
        {
            return _controllers.SelectSingleNode($"controller[@name='{controller}']/actions/action[@name='{name}']")?.InnerText;
        }
    }
}
