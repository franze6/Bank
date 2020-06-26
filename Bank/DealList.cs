using Bank.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class DealList : Form
    {
        int currentClientId = 0;
        DBWorker db;
        List<int> ids;
        public DealList(int clientId)
        {
            InitializeComponent();
            currentClientId = clientId;

            db = new DBWorker();
            if (!db.Connect())
            {
                MessageBox.Show("Не удалось подключиться к бд");
                this.Close();
                return;
            }

            ids = new List<int>();

            try
            {
                var deals = db.GetViewDealsByClientId(clientId);

                foreach (var deal in deals)
                {
                    dealListTable.Rows.Add(deal.toArray());
                    ids.Insert(dealListTable.Rows.GetLastRow(DataGridViewElementStates.Visible), deal.Id);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                this.Close();
            }

        }

        private void dealListTable_CellDoubleClick(object sender, DataGridViewCellEventArgs ea)
        {
            try
            {
                Deal deal = db.GetDealById(ids[ea.RowIndex]);
                DealForm df = new DealForm(deal);
                df.ShowDialog();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                this.Close();
            }
        }
    }
}
