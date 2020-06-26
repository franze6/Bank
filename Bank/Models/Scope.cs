
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Models
{
    class Scope
    {
        public int Id { get; set; }

        public int clientId { get; set; }
        
        public int money { get; set; }

        public Scope(int id, int clientId, int money)
        {
            Id = id;
            this.clientId = clientId;
            this.money = money;
        }
    }
}
