using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Attribute_Reflection.CustomSql
{
    public class SqlGenerator
    {
        public List<string> BuidInsertScript(List<Customer> customers,string tableName)
        {
            var sqlTemplate = "Insert Into {0} ({1}) values ({2})";
            List<string> columns = new List<string>();
            List<string> values = new List<string>();

            List<string> insertScript = new List<string>();
            foreach (var item in customers)
            {
                var itemProperties = item.GetType().GetProperties();
                foreach (PropertyInfo propertyInfo in itemProperties)
                {
                    var ignoreQueryAttribute = propertyInfo.GetCustomAttribute<IgnoreQueryAttribute>();

                    if (ignoreQueryAttribute == null)
                    {
                        columns.Add(propertyInfo.Name);
                        values.Add(propertyInfo.GetValue(item,null).ToString()); /// benim üzerinde bulunduğum nesnenin değerini bana bulup getiriyor.
                        continue;
                    }

                }

                insertScript.Add(string.Format(sqlTemplate, tableName,
                string.Join(",", columns),
                string.Join(",", values)));
                columns.Clear();
                values.Clear();


            }

            return insertScript;

        }
    }
}
