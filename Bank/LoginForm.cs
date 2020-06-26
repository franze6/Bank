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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            DBWorker db = new DBWorker();
            if (!db.Connect())
            {
                MessageBox.Show("Не удалось подключиться к бд");
                this.Close();
                return;
            }
            try
            {
                emlpoyListCB.DataSource = db.GetEmployList();
                emlpoyListCB.DisplayMember = nameof(Employ.Name);
                emlpoyListCB.ValueMember = nameof(Employ.Id);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                this.Close();
            }
        }

        private void startWorkB_Click(object sender, EventArgs e)
        {
            List<Employ> employs = (List<Employ>)emlpoyListCB.DataSource;
            SearchForm sf = new SearchForm(employs.Find(x=> x.Id == (int)emlpoyListCB.SelectedValue));
            sf.Show();
            this.Visible = false;
            sf.FormClosed += Sf_FormClosed;
        }

        private void Sf_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
