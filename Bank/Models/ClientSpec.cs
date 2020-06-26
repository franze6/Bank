using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Models
{
    class ClientSpec
    {
        public int Id { get; set; }

        public double Value { get; set; }

        public string Name { get; set; }

        public ClientSpec(int id, double value, string name)
        {
            Id = id;
            Value = value;
            Name = name;
        }
    }
}
