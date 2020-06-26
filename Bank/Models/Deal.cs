using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Models
{
    public class Deal
    {
        public int Id { get; set; }

        public int collectorId { get; set; }

        public int clientId { get; set; }

        public int employId { get; set; }

        public int scopeId { get; set; }

        public int typeId { get; set; }

        public bool appeal { get; set; }

        public string date { get; set; }

        public int sum { get; set; }

        public bool isClose { get; set; }

        public int appealId { get; set; }

        public Deal(int id, int collectorId, int clientId, int employId, int scopeId, bool appeal, int typeId, string date, int sum, bool isClose)
        {
            Id = id;
            this.collectorId = collectorId;
            this.clientId = clientId;
            this.employId = employId;
            this.scopeId = scopeId;
            this.typeId = typeId;
            this.appeal = appeal;
            this.date = date;
            this.sum = sum;
            this.isClose = isClose;
            appealId = 0;
        }

        public Deal()
        {
        }
    }
}
