using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Models
{
    public class Client
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public string Cred { get; set; }

        public string Adress { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public int TypeId { get; set; }

        public int SpecId { get; set; }
    }
}
