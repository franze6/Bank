using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Models
{
    class Appeal
    {
        public int Id { get; set; }

        public int clientId { get; set; }

        public int employId { get; set; }

        public int typeId { get; set; }

        public string date { get; set; }

        public int mark { get; set; }

        public Appeal(int id, int clientId, int employId, int typeId, string date, int mark)
        {
            Id = id;
            this.clientId = clientId;
            this.employId = employId;
            this.typeId = typeId;
            this.date = date;
            this.mark = mark;
        }
    }
}
