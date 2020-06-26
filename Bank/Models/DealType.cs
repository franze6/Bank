using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Models
{
    public class DealType
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double dealPersent { get; set; }

        public DealType(int id, string name, double dealPersent)
        {
            Id = id;
            Name = name;
            this.dealPersent = dealPersent;
        }
    }
}
