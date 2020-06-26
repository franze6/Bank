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
    public partial class VisitForm : Form
    {

        DBWorker db;
        Client client;
        Employ employ;
        public VisitForm(Client client, Employ employ)
        {
            InitializeComponent();
            db = new DBWorker();
            if (!db.Connect())
            {
                MessageBox.Show("Не удалось подключиться к бд");
                this.Close();
                return;
            }
            this.client = client;
            this.employ = employ;
        }

        private void typeVisitCB_SelectedIndexChanged(object sender, EventArgs ea)
        {
            try
            {
                subTypeL.Visible = true;
                subTypeCB.Visible = true;
                if (typeVisitCB.SelectedIndex == (int)VisitType.Appeal)
                {
                    subTypeL.Text = "Тип обращения:";
                    subTypeCB.DataSource = db.GetAppealTypes();
                    subTypeCB.DisplayMember = nameof(DealType.Name);
                    subTypeCB.ValueMember = nameof(DealType.Id);
                }
                else if (typeVisitCB.SelectedIndex == (int)VisitType.Deal)
                {
                    subTypeL.Text = "Тип сделки:";
                    subTypeCB.DataSource = db.GetDealTypes();
                    subTypeCB.DisplayMember = nameof(AppealType.Name);
                    subTypeCB.ValueMember = nameof(AppealType.Id);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                this.Close();
            }
        }

        private void continueB_Click(object sender, EventArgs ea)
        {
            try
            {
                if (typeVisitCB.SelectedIndex == (int)VisitType.Appeal)
                {
                    db.newAppeal(client.Id, employ.Id, ((List<AppealType>)subTypeCB.DataSource).Find(x => x.Id == (int)subTypeCB.SelectedValue).Id);
                    MessageBox.Show("Обращение зарегестрировано!");
                }
                else if (typeVisitCB.SelectedIndex == (int)VisitType.Deal)
                {
                    DealType dt = ((List<DealType>)subTypeCB.DataSource).Find(x => x.Id == (int)subTypeCB.SelectedValue);
                    DealForm df = new DealForm(client, employ, dt);
                    df.ShowDialog();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                this.Close();
            }
        }

        private void subTypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            continueB.Enabled = true;
        }
    }
}
