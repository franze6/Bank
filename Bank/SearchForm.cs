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
    public partial class SearchForm : Form
    {
        DBWorker db;
        List<ClientSpec> clientSpec;
        List<ClientType> clientType;

        bool isNewClient = false;

        Client currentClient = null;
        Employ currentEmploy = null;
        public SearchForm(Employ employ)
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
                clientSpec = db.GetClientSpecs();
                clientType = db.GetClientTypes();

                clientTypeTB.DataSource = clientType;
                clientTypeTB.DisplayMember = nameof(ClientType.Name);
                clientTypeTB.ValueMember = nameof(ClientType.Id);

                clientSpecTB.DataSource = clientSpec;
                clientSpecTB.DisplayMember = nameof(ClientType.Name);
                clientSpecTB.ValueMember = nameof(ClientType.Id);

                currentEmploy = employ;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                this.Close();
            }
        }

        private void searchB_Click(object sender, EventArgs e)
        {
            if(fioTB.Text.Length < 3 && creadTB.Text.Length < 3 && phoneTB.Text.Length < 3)
            {
                MessageBox.Show("fsdfsd");
                return;
            }

            var client = new Client();
            client.Name = fioTB.Text;
            client.Cred = creadTB.Text;
            client.Phone = phoneTB.Text;

            try
            {
                client = db.SearchClient(client);



                fioTB.Text = client.Name;
                creadTB.Text = client.Cred;
                phoneTB.Text = client.Phone;

                clientSpecTB.Enabled = true;
                clientSpecTB.SelectedValue = client.SpecId;

                clientTypeTB.Enabled = true;
                clientTypeTB.SelectedValue = client.TypeId;

                adressTB.Enabled = true;
                adressTB.Text = client.Adress;

                emailTB.Enabled = true;
                emailTB.Text = client.Email;

                saveB.Enabled = true;

                fioTB.Enabled = false;

                startVisitB.Enabled = true;

                viewAppealB.Enabled = true;
                viewDealB.Enabled = true;

                currentClient = client;
            }
            catch
            {
                DialogResult result = MessageBox.Show("Клиент не найден!\nЖелаете создать нового?", "Информация", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    isNewClient = true;
                    clientSpecTB.Enabled = true;
                    clientTypeTB.Enabled = true;
                    adressTB.Enabled = true;
                    emailTB.Enabled = true;
                    saveB.Enabled = true;
                    resetFilds();
                }
            }
        }

        private void resetB_Click(object sender, EventArgs e)
        {
            resetFilds();
            clientSpecTB.Enabled = false;
            clientTypeTB.Enabled = false;
            adressTB.Enabled = false;
            emailTB.Enabled = false;
            saveB.Enabled = false;
            startVisitB.Enabled = false;
            currentClient = null;
        }

        private void saveB_Click(object sender, EventArgs ea)
        {
            try
            {
                if (isNewClient)
                {
                    db.addClient(GenerateClient());
                    MessageBox.Show("Клиент добавлен!");
                }
                else
                {
                    db.updateClient(GenerateClient());
                    MessageBox.Show("Информация успешно обновлена");
                }
                currentClient = GenerateClient();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                this.Close();
            }
        }

        private void resetFilds()
        {
            fioTB.Text = "";
            creadTB.Text = "";
            phoneTB.Text = "";
            adressTB.Text = "";
            emailTB.Text = "";
            fioTB.Enabled = true;
            viewDealB.Enabled = false;
            viewAppealB.Enabled = false;
        }

        private Client GenerateClient()
        {
            var client = new Client();
            client.Id = currentClient.Id;
            client.TypeId = (int)clientTypeTB.SelectedValue;
            client.SpecId = (int)clientSpecTB.SelectedValue;
            client.Name = fioTB.Text;
            client.Cred = creadTB.Text;
            client.Adress = adressTB.Text;
            client.Phone = phoneTB.Text;
            client.Email = emailTB.Text;

            return client;
        }

        private void startVisitB_Click(object sender, EventArgs e)
        {
            if (currentClient == null) return;
            VisitForm vf = new VisitForm(currentClient, currentEmploy);
            vf.ShowDialog();
        }

        private void viewDealB_Click(object sender, EventArgs e)
        {
            if (currentClient == null) return;
            DealList dl = new DealList(currentClient.Id);
            dl.ShowDialog();
        }

        private void viewAppealB_Click(object sender, EventArgs e)
        {
            if (currentClient == null) return;
            AppealList al = new AppealList(currentClient.Id, false);
            al.ShowDialog();
        }
    }
}
