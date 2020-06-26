using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Models
{
    class ViewDeal
    {
        public int Id { get; set; }

        public string collectorFIO { get; set; }

        public string clientFIO { get; set; }

        public string employFIO { get; set; }

        public int scopeId { get; set; }

        public bool appeal { get; set; }

        public string type { get; set; }

        public string date { get; set; }

        public int sum { get; set; }

        public bool isClose { get; set; }

        public ViewDeal(int id, string collectorFIO, string clientFIO, string employFIO, int scopeId, bool appeal, string type, string date, int sum, bool isClose)
        {
            this.collectorFIO = collectorFIO;
            this.clientFIO = clientFIO;
            this.employFIO = employFIO;
            this.scopeId = scopeId;
            this.appeal = appeal;
            this.type = type;
            this.date = date;
            this.sum = sum;
            this.isClose = isClose;
            this.Id = id;
        }

        public object[] toArray()
        {
            object[] results = new object[10];
            results[8] = collectorFIO;
            results[0] = clientFIO;
            results[1] = employFIO;
            results[7] = scopeId;
            results[6] = appeal;
            results[2] = type;
            results[3] = date;
            results[4] = sum;
            results[5] = isClose;
            results[9] = Id;

            return results;
        }
    }
}
