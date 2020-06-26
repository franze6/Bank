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
    public partial class AppealList : Form
    {
        DBWorker db;
        public int selectedId = 0;
        bool closeToClick;
        List<int> ids;
        public AppealList(int clientId, bool closeToClick)
        {
            InitializeComponent();
            db = new DBWorker();
            if(!db.Connect())
            {
                MessageBox.Show("Не удалось подключиться к бд");
                this.Close();
                return;
            }
            ids = new List<int>();

            this.closeToClick = closeToClick;

            try
            {
                List<ViewAppeal> appeals = db.GetAppealsByClientId(clientId);

                foreach (ViewAppeal appeal in appeals)
                {
                    appealListTable.Rows.Add(appeal.toArray());
                    ids.Insert(appealListTable.Rows.GetLastRow(DataGridViewElementStates.Visible), appeal.Id);
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                this.Close();
            }
        }

        private void appealListTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedId = ids[e.RowIndex];
            if (closeToClick) this.Close();
        }
    }
}
