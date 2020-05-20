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
    public partial class FormDeal : Form
    {
        public FormDeal()
        {
            InitializeComponent();
            ShowSupply();
            ShowDemand();
            ShowDealSet();

        }
        void ShowSupply()
        {
            comboBoxSupply.Items.Clear();
            foreach (SupplySet supplySet in Program.fir.SupplySet)
            {
                string[] item = {supplySet.Id.ToString() + ". ", "Риелтор: " + supplySet.Table_2.LastName,
                supplySet.Table_2.FirstName.Remove(1) + ".", supplySet.Table_2.MiddleName.Remove(1) + ".",
                " Клиент: " + supplySet.Table_1.LastName, supplySet.Table_1.FirstName.Remove(1) + ".",
                supplySet.Table_1.MiddleName.Remove(1) + "."};
                comboBoxSupply.Items.Add(string.Join(" ", item));
            }
        }
        void ShowDemand()
        {
            comboBoxDemand.Items.Clear();
            foreach (DemandSet demandSet in Program.fir.DemandSet)
            {
                string[] item = {demandSet.Id.ToString() + ". ", "Риелтор: " + demandSet.Table_2.LastName,
                demandSet.Table_2.FirstName.Remove(1) + ".", demandSet.Table_2.MiddleName.Remove(1) + ".",
                "Клиент: " + demandSet.Table_1.LastName, demandSet.Table_1.FirstName.Remove(1) + ".",
                demandSet.Table_1.MiddleName.Remove(1) + "."};
                comboBoxDemand.Items.Add(string.Join(" ", item));
            }
        }
        void Deductions()
        {
            if (comboBoxSupply.SelectedItem != null && comboBoxDemand.SelectedItem != null)
            {
                SupplySet supplySet = Program.fir.SupplySet.Find(Convert.ToInt32(comboBoxSupply.SelectedItem.ToString().Split('.')[0]));
                DemandSet demandSet = Program.fir.DemandSet.Find(Convert.ToInt32(comboBoxDemand.SelectedItem.ToString().Split('.')[0]));

                double customerCompanyDeductions = Convert.ToDouble(supplySet.Price * 0.03);
                textCustomerCompanyDeductions.Text = customerCompanyDeductions.ToString("0.00");

                if (demandSet.Table_2.Percentage != null)
                {
                    double agentCustomerDedutions = customerCompanyDeductions * Convert.ToDouble(demandSet.Table_2.Percentage) / 100.00;
                    textBoxAgentCustomerDeductions.Text = agentCustomerDedutions.ToString("0.00");
                }
                else
                {
                    double agentCustomerDedutions = customerCompanyDeductions * 0.45;
                    textBoxAgentCustomerDeductions.Text = agentCustomerDedutions.ToString("0.00");
                }
            }
            else
            {
                textCustomerCompanyDeductions.Text = "";
                textBoxAgentCustomerDeductions.Text = "";
            }

            if (comboBoxSupply.SelectedItem != null)
            {
                SupplySet supplySet = Program.fir.SupplySet.Find(Convert.ToInt32(comboBoxSupply.SelectedItem.ToString().Split('.')[0]));

                double sellerCompanyDeductions;
                if (supplySet.RealEstateSet.Type == 0)
                {
                    sellerCompanyDeductions = Convert.ToDouble(36000 + supplySet.Price * 0.01);
                    textBoxSellerCompanyDeductions.Text = sellerCompanyDeductions.ToString("0.00");
                }
                else if (supplySet.RealEstateSet.Type == 1)
                {
                    sellerCompanyDeductions = Convert.ToDouble(36000 + supplySet.Price * 0.01);
                    textBoxSellerCompanyDeductions.Text = sellerCompanyDeductions.ToString("0.00");
                }
                else
                {
                    sellerCompanyDeductions = Convert.ToDouble(36000 + supplySet.Price * 0.01);
                    textBoxSellerCompanyDeductions.Text = sellerCompanyDeductions.ToString("0.00");
                }

                if (supplySet.Table_2.Percentage != null)
                {
                    double agentSellerDeductions = sellerCompanyDeductions * Convert.ToDouble(supplySet.Table_2.Percentage) / 100.00;
                    textBoxAgentSellerDeductions.Text = agentSellerDeductions.ToString("0.00");
                }
                else
                {
                    double agentSellerDeductions = sellerCompanyDeductions * 0.45;
                    textBoxAgentSellerDeductions.Text = agentSellerDeductions.ToString("0.00");
                }
            }
            else
            {
                textBoxSellerCompanyDeductions.Text = "";
                textBoxAgentSellerDeductions.Text = "";
                textCustomerCompanyDeductions.Text = "";
                textBoxAgentCustomerDeductions.Text = "";
            }
        }
        void ShowDealSet()
        {
            listViewDealSet.Items.Clear();
            foreach (DealSet deal in Program.fir.DealSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    deal.SupplySet.Table_1.LastName + " " + deal.SupplySet.Table_1.FirstName.Remove(1) + "." +
                    deal.SupplySet.Table_1.MiddleName.Remove(1) + ".",
                    deal.SupplySet.Table_2.LastName + " " + deal.SupplySet.Table_2.FirstName.Remove(1) + "." +
                    deal.SupplySet.Table_2.MiddleName.Remove(1) + ".",
                    deal.DemandSet.Table_1.LastName + " " + deal.DemandSet.Table_1.FirstName.Remove(1) + "." +
                    deal.DemandSet.Table_1.MiddleName.Remove(1) + ".",
                    deal.DemandSet.Table_2.LastName + " " + deal.DemandSet.Table_2.FirstName.Remove(1) + "." +
                    deal.DemandSet.Table_2.MiddleName.Remove(1) + ".",
                    "г." +  deal.SupplySet.RealEstateSet.Address_City + ", ул." + deal.SupplySet.RealEstateSet.Address_Steet +
                    ", д." + deal.SupplySet.RealEstateSet.Address_House + ", кв." + deal.SupplySet.RealEstateSet.Address_Number,
                    deal.SupplySet.Price.ToString()
                });
                item.Tag = deal;
                listViewDealSet.Items.Add(item);
            }
        }
            private void FormDeal_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxSupply_SelectedIndexChanged(object sender, EventArgs e)
        {
            Deductions();
        }

        private void comboBoxDemand_SelectedIndexChanged(object sender, EventArgs e)
        {
            Deductions();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxDemand.SelectedItem != null && comboBoxSupply.SelectedItem != null)
            {
                DealSet deal = new DealSet();
                deal.IdSupply = Convert.ToInt32(comboBoxSupply.SelectedItem.ToString().Split('.')[0]);
                deal.IdDemand = Convert.ToInt32(comboBoxDemand.SelectedItem.ToString().Split('.')[0]);
                Program.fir.DealSet.Add(deal);
                Program.fir.SaveChanges();
                ShowDealSet();
            }
            else MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewDealSet.SelectedItems.Count == 1)
                {
                    DealSet deal = listViewDealSet.SelectedItems[0].Tag as DealSet;
                    deal.IdSupply = Convert.ToInt32(comboBoxSupply.SelectedItem.ToString().Split('.')[0]);
                    deal.IdDemand = Convert.ToInt32(comboBoxDemand.SelectedItem.ToString().Split('.')[0]);
                    textBoxAgentCustomerDeductions.Enabled = false;
                    textBoxAgentSellerDeductions.Enabled = false;
                    textBoxSellerCompanyDeductions.Enabled = false;
                    textCustomerCompanyDeductions.Enabled = false;

                    Program.fir.SaveChanges();
                    ShowDealSet();
                }
            }
            catch { }
        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewDealSet.SelectedItems.Count == 1)
                {
                    DealSet deal = listViewDealSet.SelectedItems[0].Tag as DealSet;
                    Program.fir.DealSet.Remove(deal);
                    Program.fir.SaveChanges();
                    ShowDealSet();
                }
                comboBoxSupply.SelectedItem = null;
                comboBoxDemand.SelectedItem = null;
            }
            catch { MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

    }
}
    
    

