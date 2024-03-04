using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace QL_COFFE_KVC
{
    public static class Utils
    {

        public static Dictionary<Type, string> SqlType { get; }
        public static Dictionary<Type, string> SqlTypeWithoutSize { get; }

        static Utils()
        {
            SqlType = new Dictionary<Type, string>() { { typeof(string), "nvarchar(max)" }, { typeof(DateTime), "datetime" }, { typeof(TimeSpan), "time" }, { typeof(bool), "bit" }, { typeof(Int16), "smallint" }, { typeof(Int32), "int" }, { typeof(Int64), "bigint" }, { typeof(byte), "tinyint" }, { typeof(byte[]), "varbinary(max)" }, { typeof(char), "nchar(1)" }, { typeof(char[]), "nchar(max)" }, { typeof(decimal), "numeric(38,12)" }, { typeof(double), "numeric(38,12)" }, { typeof(float), "real" }, { typeof(object), "nvarchar(max)" }, { typeof(Guid), "uniqueidentifier" } };
            SqlTypeWithoutSize = new Dictionary<Type, string>() { { typeof(string), "[N]varchar([SIZE])" }, { typeof(DateTime), "datetime" }, { typeof(TimeSpan), "time" }, { typeof(bool), "bit" }, { typeof(Int16), "smallint" }, { typeof(Int32), "int" }, { typeof(Int64), "bigint" }, { typeof(byte), "tinyint" }, { typeof(byte[]), "varbinary([SIZE])" }, { typeof(char), "nchar(1)" }, { typeof(char[]), "[N]char([SIZE])" }, { typeof(decimal), "numeric([SIZE])" }, { typeof(double), "numeric([SIZE])" }, { typeof(float), "real" }, { typeof(object), "[N]varchar([SIZE])" }, { typeof(Guid), "uniqueidentifier" } };
        }

        public static string DataSetToScript(this DataSet ds, params int[] tableDeclare)
        {
            if (ds == null || ds.Tables.Count == 0) return string.Empty;
            var sb = new StringBuilder();
            ds.Tables.ForIndex<DataTable>((x, i) => TableToScript(sb, x, $"@${x.TableName.SafeColumnName()}", tableDeclare.Contains(i), SqlType, SqlTypeWithoutSize));
            return sb.ToString();
        }

        public static void TableToScript(StringBuilder parent, DataTable table, string tableName, bool declare, Dictionary<Type, string> sqlTypes, Dictionary<Type, string> SqlTypeWithoutSize)
        {
            var l = new List<string>();
            table.Columns.ForEach<DataColumn>(x => l.Add($"[{x.ColumnName.SafeColumnName()}] {sqlTypes[x.DataType]}"));
            parent.AppendLine($"declare {tableName} table ({string.Join(", ", l)})");
            AppendTable(table, parent, $"insert into {tableName} select ");

            if (!declare) return;
            List<string> l2 = new(), l3 = new();
            var rowOfTable = table.Rows.Count > 0 ? table.Rows[0] : null;
            table.Columns.ForEach<DataColumn>(x =>
            {
                var colName = x.ColumnName.SafeColumnName();
                l2.Add($"@${colName} {GetSizeOfValueByType(SqlTypeWithoutSize[x.DataType], x.DataType, rowOfTable?[x.ColumnName])}");
                l3.Add($"@${colName} = {colName}");
            });

            parent.AppendLine($"declare {string.Join(", ", l2)}");
            parent.AppendLine($"select {string.Join(", ", l3)} from {tableName}");
            parent.AppendLine();
        }

        public static void AppendTable(DataTable table, StringBuilder parent, string queryInsert)
        {
            var l = new List<object>();
            foreach (DataRow row in table.Rows)
            {
                for (var i = 0; i < table.Columns.Count; i++)
                {
                    l.Add(ToValue(row[table.Columns[i].ColumnName], table.Columns[i].DataType));
                }
                parent.AppendLine(queryInsert + string.Join(",", l));
                l.Clear();
            }
        }

        public static object ToValue(object value, Type type)
        {
            if (value == null || value.Equals(DBNull.Value)) return "null";
            return type.ToString() switch
            {
                "System.Boolean" => ToValueBoolean(value),
                "System.DateTime" => ToValueDateTime(value),
                "System.TimeSpan" => ToValueTimeSpan(value),
                "System.Int16" => ToValueInt16(value),
                "System.Int32" => ToValueInt32(value),
                "System.Int64" => ToValueInt64(value),
                "System.Decimal" => ToValueDecimal(value),
                "System.Single" => ToValueFloat(value),
                "System.Byte" => ToValueByte(value),
                "System.Char" or "System.Char[]" or "System.String" or "System.Guid" or "System.Object" => ToValueText(value),
                "System.Byte[]" or "System.Object" or _ => "null",
            };
        }

        public static object ToValueText(object value) => $"N'{value.ToString().Safe()}'";

        public static object ToValueDateTime(object value)
        {
            if (value == null || value.Equals("") || value.Equals(default(DateTime))) return "null";
            if (value is DateTime date) return $"'{date.ToISOString()}'";
            if (DateTime.TryParse(value.ToString(), out var result)) return $"'{result.ToISOString()}'";
            return "null";
        }

        public static object ToValueBoolean(object value) => Convert.ToInt32(Convert.ToBoolean(value));

        public static object ToValueTimeSpan(object value) => $"'{TimeSpan.Parse(value.ToString())}'";

        public static object ToValueInt16(object value) => Convert.ToInt16(value);

        public static object ToValueInt32(object value) => Convert.ToInt32(value);

        public static object ToValueInt64(object value) => Convert.ToInt64(value);

        public static object ToValueDecimal(object value) => Convert.ToDouble(value);

        public static object ToValueFloat(object value) => Convert.ToSingle(value);

        public static object ToValueByte(object value) => Convert.ToByte(value);

        public static string ToISOString(this DateTime date)
        {
            return date.ToString("yyyy-MM-ddTHH:mm:ss.fff");
        }

        public static bool IsPrimaryKey(this string key, string pattern = @"'`~!@#$%^&*(),;""")
        {
            if (string.IsNullOrEmpty(key)) return true;
            if (key.IndexOf(' ') == 0) return false;
            key = key.Replace("“", @"""").Replace("’", "'");
            foreach (char k in key) if (pattern.Contains(k)) return false;
            return !key.IsUnicode();
        }

        public static bool IsUnicode(this string input)
        {
            return Regex.IsMatch(input, "[^\u0000-\u007F]");
        }

        public static bool IsSqlUnicode(this string input)
        {
            return input.Any(c => c > 255);
        }

        public static DataTable AddRowValue(this DataTable dt, string columnName, object value, Type columnType = null)
        {
            if (!dt.Columns.Contains(columnName))
            {
                if (columnType == null) dt.Columns.Add(columnName);
                else dt.Columns.Add(columnName, columnType);
            }
            DataRow dr;
            if (dt.Rows.Count == 0)
            {
                dr = dt.NewRow();
                dt.Rows.Add(dr);
            }
            else dr = dt.Rows[0];
            dr[columnName] = value;
            return dt;
        }

        public static DataTable AddRowValue(this DataTable dt, int rowIndex, string columnName, object value, Type columnType = null)
        {
            if (!dt.Columns.Contains(columnName))
            {
                if (columnType == null) dt.Columns.Add(columnName);
                else dt.Columns.Add(columnName, columnType);
            }
            if (dt.Rows.Count == rowIndex)
                dt.Rows.Add(dt.NewRow());
            DataRow dr = dt.Rows[rowIndex];
            dr[columnName] = value;
            return dt;
        }

        public static DataSet AddTable(this DataSet ds, DataTable dt)
        {
            ds.Tables.Add(dt);
            return ds;
        }

        public static DataSet DataFromArray(params Param[] values)
        {
            var data = new DataSet();
            data.AddTable(new DataTable());
            foreach (var item in values)
            {
                data.Tables[0].AddRowValue(item.Name, item.Value, item.TypeValue);
            }
            return data;
        }

        public static void AddCloneRow(this DataTable table, DataRow row)
        {
            var index = table.Rows.Count;
            foreach (DataColumn column in table.Columns)
            {
                if (row.Table.Columns.Contains(column.ColumnName))
                    table.AddRowValue(index, column.ColumnName, row[column.ColumnName], column.DataType);
            }
        }

        public static void UpdateRow(this DataTable table, int index, DataRow row)
        {
            foreach (DataColumn column in table.Columns)
            {
                if (row.Table.Columns.Contains(column.ColumnName))
                    table.Rows[index][column] = row[column.ColumnName];
            }
        }

        #region Private
        static string GetSizeOfValueByType(string input, Type colType, object value)
        {
            if (colType == typeof(string) || colType == typeof(byte[]) || colType == typeof(char[]) || colType == typeof(object)) return SizeOfString(input, value);
            if (colType == typeof(double) || colType == typeof(decimal)) SizeOfNumber(input, value);
            return input;
        }

        static string SizeOfString(string input, object value)
        {
            var strValue = value?.ToString();
            if (string.IsNullOrEmpty(strValue)) return input.Replace("[N]", "").Replace("[SIZE]", "1");
            if (strValue.IsUnicode()) return input.Replace("[N]", "n").Replace("[SIZE]", strValue.Length.ToString());
            return input.Replace("[N]", "").Replace("[SIZE]", strValue.Length.ToString());
        }

        static string SizeOfNumber(string input, object value)
        {
            if (value == null || value.Equals(0)) return input.Replace("[SIZE]", "1, 0");
            if (value is not decimal decimalValue) return input.Replace("[SIZE]", "1, 0");
            var size = decimalValue.ToString().Replace(',', '.').Split('.');
            if (size.Length == 0) return input.Replace("[SIZE]", $"{size[0]}, 4");
            return input.Replace("[SIZE]", $"{size[0]}, {size[1]}");
        }
        #endregion
    }
}
