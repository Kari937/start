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
    public partial class FormRieltors : Form
    {
        public FormRieltors()
        {
            InitializeComponent();
            ShowRieltors();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Table_2 rieltorsSet = new Table_2();
            rieltorsSet.FirstName = textBoxFirstName.Text;
            rieltorsSet.MiddleName = textBoxMiddleName.Text;
            rieltorsSet.LastName = textBoxLastName.Text;
            rieltorsSet.Percentage = textBoxPercentage.Text;
            Program.fir.Table_2.Add(rieltorsSet);
            Program.fir.SaveChanges();
            ShowRieltors();
        }
        void ShowRieltors()
        {
            listViewRieltors.Items.Clear();
            foreach (Table_2 rieltorsSet in Program.fir.Table_2)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
rieltorsSet.Id.ToString(), rieltorsSet.FirstName, rieltorsSet.MiddleName, rieltorsSet.LastName, rieltorsSet.Percentage
                });
                item.Tag = rieltorsSet;
                listViewRieltors.Items.Add(item);
            }
            listViewRieltors.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewRieltors.SelectedItems.Count == 1)
            {
                Table_2 rieltorsSet = listViewRieltors.SelectedItems[0].Tag as Table_2;
                rieltorsSet.FirstName = textBoxFirstName.Text;
                rieltorsSet.MiddleName = textBoxMiddleName.Text;
                rieltorsSet.LastName = textBoxLastName.Text;
                rieltorsSet.Percentage = textBoxPercentage.Text;
                Program.fir.SaveChanges();
                ShowRieltors();
            }
        }

        private void listViewRieltors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewRieltors.SelectedItems.Count == 1)
            {
                Table_2 rieltorsSet = listViewRieltors.SelectedItems[0].Tag as Table_2;
                textBoxFirstName.Text = rieltorsSet.FirstName;
                textBoxMiddleName.Text = rieltorsSet.MiddleName;
                textBoxLastName.Text = rieltorsSet.LastName;
                textBoxPercentage.Text = rieltorsSet.Percentage;

            }
            else
            {
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPercentage.Text = "";

            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewRieltors.SelectedItems.Count == 1)
                {
                    Table_2 rieltorsSet = listViewRieltors.SelectedItems[0].Tag as Table_2;
                    Program.fir.Table_2.Remove(rieltorsSet);
                    Program.fir.SaveChanges();
                    ShowRieltors();
                }
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPercentage.Text = "";

            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
