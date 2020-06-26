using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Models
{
    class ClientType
    {
        public int Id { get; set; }

        public double Value { get; set; }

        public string Name { get; set; }

        public ClientType(int id, double value, string name)
        {
            Id = id;
            Value = value;
            Name = name;
        }
    }


}
