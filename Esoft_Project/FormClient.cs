using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esoft_Project
{
    public partial class FormClient : Form
    {
        public FormClient()
        {
            InitializeComponent();
            ShowClient();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Table_1 clientSet = new Table_1();
            clientSet.FirstName = textBoxFirstName.Text;
            clientSet.MiddleName = textBoxMiddleName.Text;
            clientSet.LastName = textBoxLastName.Text;
            clientSet.Phone = textBoxPhone.Text;
            clientSet.Email = textBoxEmail.Text;
            Program.fir.Table_1.Add(clientSet);
            Program.fir.SaveChanges();
            ShowClient();
        }
        private void listViewClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewClient.SelectedItems.Count == 1)
            {
                Table_1 clientSet = listViewClient.SelectedItems[0].Tag as Table_1;
                textBoxFirstName.Text = clientSet.FirstName;
                textBoxMiddleName.Text = clientSet.MiddleName;
                textBoxLastName.Text = clientSet.LastName;
                textBoxPhone.Text = clientSet.Phone;
                textBoxEmail.Text = clientSet.Email;

            }
            else
            {
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
            }
        }

        void ShowClient()
        {
            listViewClient.Items.Clear();
            foreach (Table_1 clientsSet in Program.fir.Table_1)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    clientsSet.id.ToString(), clientsSet.FirstName, clientsSet.MiddleName, clientsSet.LastName, clientsSet.Phone, clientsSet.Email
                });
                item.Tag = clientsSet;
                listViewClient.Items.Add(item);
            }
            listViewClient.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewClient.SelectedItems.Count == 1)
            {
                Table_1 clientSet = listViewClient.SelectedItems[0].Tag as Table_1;
                clientSet.FirstName = textBoxFirstName.Text;
                clientSet.MiddleName = textBoxMiddleName.Text;
                clientSet.LastName = textBoxLastName.Text;
                clientSet.Phone = textBoxPhone.Text;
                clientSet.Email = textBoxEmail.Text;
                Program.fir.SaveChanges();
                ShowClient();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewClient.SelectedItems.Count == 1)
                {
                    Table_1 clientSet = listViewClient.SelectedItems[0].Tag as Table_1;
                    Program.fir.Table_1.Remove(clientSet);
                    Program.fir.SaveChanges();
                    ShowClient();
                }
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void labelFirstName_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormClient_Load(object sender, EventArgs e)
        {

        }
    }
}


       


    

