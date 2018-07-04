using System;
using System.Collections.Generic;
using System.Text;

namespace Cassandra.NET.Models
{
    internal class Query
    {
        public Query()
        {
        }

        public Query(string statment, object[] values)
        {
            Statement = statment;
            Values = values;
        }

        public string Statement { get; set; }
        public object[] Values { get; set; }
    }
}
