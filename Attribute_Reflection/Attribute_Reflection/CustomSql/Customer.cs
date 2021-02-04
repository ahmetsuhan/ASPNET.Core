using System;
using System.Collections.Generic;
using System.Text;

namespace Attribute_Reflection.CustomSql
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [IgnoreQuery(allowSelect:true,allowUpdate:false,allowInsert:false)]
        public DateTime Birthdate { get; set; }
        public int Age { get; set; }
    }
}
