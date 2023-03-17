using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Analytics_TestCase
{
    public class RowModel
    {
        public bool IsKey { get; set; }

        string name;

        public string Name
        {
            get => name;
            set
            {
                if (value == null)
                    throw new ArgumentException("Invalid name. Pass valid string");
                else
                    name = value;
            }
        }

        string type;

        public string Type
        {
            get => type;
            set
            {
                if (value == null)
                    throw new ArgumentException("Invalid name. Pass valid string");
                else
                    type = value;
            }
        }

        public RowModel(string name, string type, bool isKey) 
        {
            Name = name;
            Type = type;
            IsKey = isKey;
        }

        public RowModel()
        {
            Name = String.Empty;
            Type = String.Empty;
            IsKey = false;
        }
    }
}
