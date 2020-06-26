using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Models
{
    class Collector
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public Collector(int id, string fio, string phone, string email)
        {
            Id = id;
            this.Name = fio;
            Phone = phone;
            Email = email;
        }
    }
}
