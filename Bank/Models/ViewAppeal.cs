using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Models
{
    public class ViewAppeal
    {
        public int Id { get; set; }

        public string clientFio { get; set; }

        public string employFio { get; set; }

        public string type { get; set; }

        public string date { get; set; }

        public int mark { get; set; }

        public ViewAppeal(int id, string clientFio, string employFio, string type, string date, int mark)
        {
            Id = id;
            this.clientFio = clientFio;
            this.employFio = employFio;
            this.type = type;
            this.date = date;
            this.mark = mark;
        }

        public object[] toArray()
        {
            object[] list = new object[6];
            list[0] = Id;
            list[1] = clientFio;
            list[2] = employFio;
            list[3] = type;
            list[4] = date;
            list[5] = mark;
            return list;
        }
    }
}
