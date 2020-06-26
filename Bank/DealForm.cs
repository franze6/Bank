using Bank.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class DealForm : Form
    {
        Deal deal;
        List<Collector> collectors;
        DBWorker db;
        bool isNewDeal = false;
        int currentClientId;
        public DealForm(Deal deal)
        {
            InitializeComponent();
            db = new DBWorker();
            if (!db.Connect())
            {
                MessageBox.Show("Не удалось подключиться к бд");
                this.Close();
                return;
            }
            try
            {
                ViewDeal vDeal = db.GetViewDealById(deal.Id);

                this.deal = deal;
                clientFioTB.Text = vDeal.clientFIO;
                employFioTB.Text = vDeal.employFIO;
                dealTypeTB.Text = vDeal.type;
                dealDateTB.Text = vDeal.date;
                scopeNumTB.Text = vDeal.scopeId.ToString();
                dealSumTB.Text = vDeal.sum.ToString();
                isAppeal.Checked = vDeal.appeal;
                isClose.Checked = vDeal.isClose;

                collectors = db.GetCollectors();
                collectorFioCB.DataSource = collectors;
                collectorFioCB.DisplayMember = nameof(Collector.Name);
                collectorFioCB.ValueMember = nameof(Collector.Id);
                collectorFioCB.SelectedValue = deal.collectorId;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                this.Close();
            }
        }

        public DealForm(Client client, Employ employ, DealType dealType)
        {
            InitializeComponent();
            db = new DBWorker();
            db.Connect();
            isNewDeal = true;
            deal = new Deal();
            deal.clientId = client.Id;
            deal.employId = employ.Id;
            deal.typeId = dealType.Id;
            clientFioTB.Text = client.Name;
            employFioTB.Text = employ.Name;

            dealTypeTB.Text = dealType.Name;
            try
            {
                scopeCB.DataSource = db.GetScopesByClientId(client.Id);
                scopeCB.DisplayMember = nameof(Scope.Id);
                scopeCB.ValueMember = nameof(Scope.Id);

                collectorFioCB.Enabled = false;
                isAppeal.Enabled = true;

                datePick.Visible = true;
                dealDateTB.Visible = false;

                scopeNumTB.Visible = false;
                scopeCB.Visible = true;

                dealSumTB.ReadOnly = false;

                finishPersentL.Visible = true;
                finishPersentValueL.Visible = true;
                finishPersentValueL.Text = (db.GetDealPersent(client.Id, dealType.Id) - 1).ToString("P", CultureInfo.InvariantCulture);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                this.Close();
            }

            currentClientId = client.Id;
        }

        private void saveB_Click(object sender, EventArgs ea)
        {
            try
            {
                if (isNewDeal)
                {
                    int result;
                    if (!int.TryParse(dealSumTB.Text, out result))
                    {
                        MessageBox.Show("Не верно введена сумма");
                        return;
                    }
                    deal.sum = result;
                    deal.scopeId = (int)scopeCB.SelectedValue;
                    db.newDeal(deal);
                    MessageBox.Show("Создана новая сделка!");
                }
                else
                {
                    if (collectors.Exists(x => x.Id == (int)collectorFioCB.SelectedValue))
                        db.attachCollector(deal.Id, (int)collectorFioCB.SelectedValue);
                    MessageBox.Show("Изменения сохранены!");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                this.Close();
            }
            this.Close();
        }

        private void isAppeal_CheckedChanged(object sender, EventArgs e)
        {
            if (!isNewDeal) return;
            if (isAppeal.Checked)
            {
                AppealList al = new AppealList(currentClientId, true);
                al.FormClosed += Al_FormClosed;
                al.ShowDialog();
            }
        }

        private void Al_FormClosed(object sender, FormClosedEventArgs e)
        {
            deal.appealId = ((AppealList)sender).selectedId;
            deal.appeal = deal.appealId > 0;
        }
    }
}
