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
    public partial class FormSupply : Form
    {
        public FormSupply()
        {
            InitializeComponent();
            ShowAgent();
            ShowClient();
            ShowRealEstate();
            ShowSupplySet();
        }
        void ShowAgent()
        {
            comboBoxAgents.Items.Clear();
            foreach (Table_2 agentSet in Program.fir.Table_2)
            {
                string[] item = { agentSet.Id.ToString() + ".", agentSet.FirstName, agentSet.MiddleName, agentSet.LastName };
                comboBoxAgents.Items.Add(string.Join(" ", item));
            }
        }
        void ShowClient()
        {
            comboBoxClients.Items.Clear();
            foreach (Table_1 clientsSet in Program.fir.Table_1)
            {
                string[] item = { clientsSet.id.ToString() + ".", clientsSet.FirstName, clientsSet.MiddleName, clientsSet.LastName };
                comboBoxClients.Items.Add(string.Join(" ", item));
            }
        }
        void ShowRealEstate()

        {
            comboBoxRealEstate.Items.Clear();
            foreach (RealEstateSet realEstateSet in Program.fir.RealEstateSet)
            {
                string[] item = { realEstateSet.Id.ToString() + ".", realEstateSet.Address_City + ",", realEstateSet.Address_Steet + ",", "д." + realEstateSet.Address_House + ",", "кв" + realEstateSet.Address_Number };
                comboBoxRealEstate.Items.Add(string.Join(" ", item));
            }
        }
        private void comboBoxAgents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxClients_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxRealEstate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void FormSupply_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxAgents.SelectedItem != null && comboBoxClients.SelectedItem != null && comboBoxRealEstate != null && textBoxPrice.Text != "")
            {
                SupplySet supply = new SupplySet();
                supply.IdAgent = Convert.ToInt32(comboBoxAgents.SelectedItem.ToString().Split('.')[0]);
                supply.IdClient = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split('.')[0]);
                supply.IdRealEstate = Convert.ToInt32(comboBoxRealEstate.SelectedItem.ToString().Split('.')[0]);
                supply.Price = Convert.ToInt64(textBoxPrice.Text);
                Program.fir.SupplySet.Add(supply);
                Program.fir.SaveChanges();
                ShowSupplySet();
            }
            else MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void ShowSupplySet()
        {
            listViewSupplySet.Items.Clear();
            foreach (SupplySet supply in Program.fir.SupplySet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    supply.IdAgent.ToString(), 
                    supply.Table_2.LastName+" "+ supply.Table_2.FirstName+ " "+ supply.Table_2.MiddleName,

                    supply.IdClient.ToString(),
                    supply.Table_1.LastName+" "+ supply.Table_2.FirstName+ " "+ supply.Table_1.MiddleName,

                    supply.IdRealEstate.ToString(), 
                    "г"+supply.RealEstateSet.Address_City + ",ул." +supply.RealEstateSet.Address_Steet+ ", д."+ supply.RealEstateSet.Address_House+ ",кв"+ supply.RealEstateSet.Address_Number,

                    supply.Price.ToString()
                });
                item.Tag = supply;
                listViewSupplySet.Items.Add(item);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewSupplySet.SelectedItems.Count == 1)
            {
                SupplySet supply = listViewSupplySet.SelectedItems[0].Tag as SupplySet;
                supply.IdAgent = Convert.ToInt32(comboBoxAgents.SelectedItem.ToString().Split('.')[0]);
                supply.IdClient = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split('.')[0]);
                supply.IdRealEstate = Convert.ToInt32(comboBoxRealEstate.SelectedItem.ToString().Split('.')[0]);
                supply.Price = Convert.ToInt64(textBoxPrice.Text);
                Program.fir.SaveChanges();
                ShowSupplySet();
            }
        }

        private void listViewSupplySet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewSupplySet.SelectedItems.Count == 1)
            {
                SupplySet supply = listViewSupplySet.SelectedItems[0].Tag as SupplySet;

                comboBoxAgents.SelectedIndex = comboBoxAgents.FindString(supply.IdAgent.ToString());
                comboBoxClients.SelectedIndex = comboBoxClients.FindString(supply.IdClient.ToString());
                comboBoxRealEstate.SelectedIndex = comboBoxRealEstate.FindString(supply.IdRealEstate.ToString());
                textBoxPrice.Text = supply.Price.ToString();
            }

            else
            {
                comboBoxAgents.SelectedItem = null;
                comboBoxAgents.SelectedItem = null;
                comboBoxRealEstate.SelectedItem = null;
                textBoxPrice.Text = "";

            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewSupplySet.SelectedItems.Count == 1)
                {
                    SupplySet supply = listViewSupplySet.SelectedItems[0].Tag as SupplySet;
                    Program.fir.SupplySet.Remove(supply);
                    Program.fir.SaveChanges();
                    ShowSupplySet();
                }
                comboBoxAgents.SelectedItem = null;
                comboBoxAgents.SelectedItem = null;
                comboBoxRealEstate.SelectedItem = null;
                textBoxPrice.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
