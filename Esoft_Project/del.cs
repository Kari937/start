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
    public partial class FormDemand : Form
    {
        public FormDemand()
        {
            InitializeComponent();
            comboBoxType.SelectedIndex = 0;
            ShowAgent();
            ShowClient();
            ShowDemandSet();

        }
        void ShowAgent()
        {
            comboBoxIdAgent.Items.Clear();
            foreach (Table_2 agentSet in Program.fir.Table_2)
            {
                string[] item = { agentSet.Id.ToString() + ".", agentSet.FirstName, agentSet.MiddleName, agentSet.LastName };
                comboBoxIdAgent.Items.Add(string.Join(" ", item));
            }
        }
        void ShowClient()
        {
            comboBoxIdClient.Items.Clear();
            foreach (Table_1 clientsSet in Program.fir.Table_1)
            {
                string[] item = { clientsSet.id.ToString() + ".", clientsSet.FirstName, clientsSet.MiddleName, clientsSet.LastName };
                comboBoxIdClient.Items.Add(string.Join(" ", item));
            }
        }

        void ShowDemandSet()
        {
            listViewRealEstateSet_Apartment.Items.Clear();
            listViewRealEstateSet_House.Items.Clear();
            listViewRealEstateSet_Land.Items.Clear();

            foreach (DemandSet demand in Program.fir.DemandSet)
            {
                if (demand.Type == 0)
                {
                    ListViewItem item = new ListViewItem(new string[]
                   {
                        demand.IdAgent.ToString(),
                        demand.Table_2.LastName +  " "  +  demand.Table_2.FirstName.Remove( 1)+ "."
                        +  demand.Table_2.MiddleName.Remove( 1)+ ".",
                        demand.IdClient.ToString(),
                        demand.Table_1.LastName +  " "  +  demand.Table_1.FirstName.Remove( 1)+ "."
                        +  demand.Table_1.MiddleName.Remove( 1)+ ".",
                        demand.MinPrice.ToString(), demand.MaxPrice.ToString(), demand.MinArea.ToString(),
                        demand.MaxArea.ToString(), demand.MinRooms.ToString(), demand.MaxArea.ToString(),
                        demand.MinFloor.ToString(), demand.MaxFloor.ToString()
                   });
                    item.Tag = demand;
                    listViewRealEstateSet_Apartment.Items.Add(item);
                }
                else if (demand.Type == 1)
                {
                    ListViewItem item = new ListViewItem(new string[]
                   {
                        demand.IdAgent.ToString(),
                        demand.Table_2.LastName +  " "  +  demand.Table_2.FirstName.Remove( 1)+ "."
                        +  demand.Table_2.MiddleName.Remove( 1)+ ".",
                        demand.IdClient.ToString(),
                        demand.Table_1.LastName +  " "  +  demand.Table_1.FirstName.Remove( 1)+ "."
                        +  demand.Table_1.MiddleName.Remove( 1)+ ".",
                        demand.MinPrice.ToString(), demand.MaxPrice.ToString(), demand.MinArea.ToString(),
                        demand.MaxArea.ToString(), demand.MinFloors.ToString(), demand.MaxFloors.ToString()
                   });
                    item.Tag = demand;
                    listViewRealEstateSet_House.Items.Add(item);
                }
                else
                {
                    ListViewItem item = new ListViewItem(new string[]
                   {
                        demand.IdAgent.ToString(),
                        demand.Table_2.LastName +  " "  +  demand.Table_2.FirstName.Remove( 1)+ "."
                        +  demand.Table_2.MiddleName.Remove( 1)+ ".",
                        demand.IdClient.ToString(),
                        demand.Table_1.LastName +  " "  +  demand.Table_1.FirstName.Remove( 1)+ "."
                        +  demand.Table_1.MiddleName.Remove( 1)+ ".",
                        demand.MinPrice.ToString(), demand.MaxPrice.ToString(), demand.MinArea.ToString(),
                        demand.MaxArea.ToString()
                   });
                    item.Tag = demand;
                    listViewRealEstateSet_Land.Items.Add(item);
                }
                listViewRealEstateSet_Apartment.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                listViewRealEstateSet_House.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                listViewRealEstateSet_Land.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormDemand_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedIndex == 0)
            {
               
                listViewRealEstateSet_Apartment.Visible = true;
                labelMinRooms.Visible = true;
                textBoxMinRooms.Visible = true;
                labelMaxRooms.Visible = true;
                textBoxMaxRooms.Visible = true;
                labelMinFloor.Visible = true;
                labelMaxFloor.Visible = true;
                textBoxMaxFloors.Visible = true;
                textBoxMinFloors.Visible = true;
            

                listViewRealEstateSet_House.Visible = false;
                listViewRealEstateSet_Land.Visible = false;
                labelMinFloors.Visible = false;
                textBoxMinFloor.Visible = false;
                textBoxMaxFloor.Visible = false;



                comboBoxIdAgent.Text = "";
                comboBoxIdClient.Text = "";
                textBoxMinPrice.Text = "";
                textBoxMaxPrice.Text = "";
                textBoxMinArea.Text = "";
                textBoxMaxArea.Text = "";
                textBoxMinRooms.Text = "";
                textBoxMinRooms.Text = "";
                textBoxMinFloor.Text = "";
                textBoxMaxFloor.Text = "";
            }

            else if (comboBoxType.SelectedIndex == 1)
            {
                listViewRealEstateSet_House.Visible = true;
               
                textBoxMinFloors.Visible = true;
               
                textBoxMaxFloors.Visible = true;
       
                labelMinFloor.Visible = true;
                labelMaxFloor.Visible = true;

                listViewRealEstateSet_Apartment.Visible = false;
                listViewRealEstateSet_Land.Visible = false;
                labelMinRooms.Visible = false;
                textBoxMinRooms.Visible = false;
                labelMaxRooms.Visible = false;
                textBoxMaxRooms.Visible = false;

                labelMinFloors.Visible = false;
                labelMaxFloors.Visible = false;
                textBoxMinFloor.Visible = false;
                textBoxMaxFloor.Visible = false;

                textBoxMaxFloor.Visible = false;

                comboBoxIdAgent.Text = "";
                comboBoxIdClient.Text = "";
                textBoxMinPrice.Text = "";
                textBoxMaxPrice.Text = "";
                textBoxMinArea.Text = "";
                textBoxMaxArea.Text = "";
                textBoxMinFloors.Text = "";
                textBoxMaxFloors.Text = "";
            }
          
            else if (comboBoxType.SelectedIndex == 2)
            {
                listViewRealEstateSet_Land.Visible = true;

                listViewRealEstateSet_Apartment.Visible = false;
                listViewRealEstateSet_House.Visible = false;
                labelMinRooms.Visible = false;
                textBoxMinRooms.Visible = false;
                labelMaxRooms.Visible = false;
                textBoxMaxRooms.Visible = false;
                labelMinFloor.Visible = false;
                textBoxMinFloor.Visible = false;
                labelMaxFloor.Visible = false;
                textBoxMaxFloor.Visible = false;
                labelMinFloors.Visible = false;
                textBoxMinFloors.Visible = false;
                labelMaxFloors.Visible = false;
                textBoxMaxFloors.Visible = false;

                comboBoxIdAgent.Text = "";
                comboBoxIdClient.Text = "";
                textBoxMinPrice.Text = "";
                textBoxMaxPrice.Text = "";
                textBoxMinArea.Text = "";
                textBoxMaxArea.Text = "";
            }
        }



        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxIdAgent.SelectedItem != null && comboBoxIdClient.SelectedItem != null)
            {
                DemandSet demand = new DemandSet();
                demand.IdAgent = Convert.ToInt32(comboBoxIdAgent.SelectedItem.ToString().Split('.')[0]);
                demand.IdClient = Convert.ToInt32(comboBoxIdClient.SelectedItem.ToString().Split('.')[0]);
                if (textBoxMinPrice.Text != "")
                {
                    demand.MinPrice = Convert.ToInt64(textBoxMinPrice.Text);
                }
                else demand.MinPrice = null;
                if (textBoxMaxPrice.Text != "")
                {
                    demand.MaxPrice = Convert.ToInt64(textBoxMaxPrice.Text);
                }
                else demand.MaxPrice = null;
                if (textBoxMinArea.Text != "")
                {
                    demand.MinArea = Convert.ToDouble(textBoxMinArea.Text);
                }
                else demand.MinArea = null;
                if (textBoxMaxArea.Text != "")
                {
                    demand.MaxArea = Convert.ToDouble(textBoxMaxArea.Text);
                }
                else demand.MaxArea = null;


                if (comboBoxType.SelectedIndex == 0)
                {
                    demand.Type = 0;
                    if (textBoxMinRooms.Text != "")
                    {
                        demand.MinRooms = Convert.ToInt32(textBoxMinRooms.Text);
                    }
                    else demand.MinRooms = null;
                    if (textBoxMaxRooms.Text != "")
                    {
                        demand.MaxRooms = Convert.ToInt32(textBoxMaxRooms.Text);
                    }
                    else demand.MaxRooms = null;
                    if (textBoxMinFloor.Text != "")
                    {
                        demand.MinFloor = Convert.ToInt32(textBoxMinFloor.Text);
                    }
                    else demand.MinFloor = null;
                    if (textBoxMaxFloor.Text != "")
                    {
                        demand.MaxFloor = Convert.ToInt32(textBoxMaxFloor.Text);
                    }
                    else demand.MaxFloor = null;
                }

                else if (comboBoxType.SelectedIndex == 1)
                {
                    demand.Type = 1;

                    if (textBoxMinFloors.Text != "")
                    {
                        demand.MinFloors = Convert.ToInt32(textBoxMinFloors.Text);
                    }
                    else demand.MinFloors = null;
                    if (textBoxMaxFloors.Text != "")
                    {
                        demand.MaxFloors = Convert.ToInt32(textBoxMaxFloors.Text);
                    }
                    else demand.MaxFloors = null;
                }

                else
                {
                    demand.Type = 2;
                }
                Program.fir.DemandSet.Add(demand);
                Program.fir.SaveChanges();
                ShowDemandSet();
            }
            else MessageBox.Show("Выберете Риелтора и Клиента", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedIndex == 0)
            {
                if (listViewRealEstateSet_Apartment.SelectedItems.Count == 1)
                {
                    try
                    {
                        DemandSet demand = listViewRealEstateSet_Apartment.SelectedItems[0].Tag as DemandSet;
                        demand.IdAgent = Convert.ToInt32(comboBoxIdAgent.SelectedItem.ToString().Split('.')[0]);
                        demand.IdClient = Convert.ToInt32(comboBoxIdClient.SelectedItem.ToString().Split('.')[0]);
                        if (textBoxMinPrice.Text != "")
                        {
                            demand.MinPrice = Convert.ToInt64(textBoxMinPrice.Text);
                        }
                        else demand.MinPrice = null;
                        if (textBoxMaxPrice.Text != "")
                        {
                            demand.MaxPrice = Convert.ToInt64(textBoxMaxPrice.Text);
                        }
                        else demand.MaxPrice = null;
                        if (textBoxMinArea.Text != "")
                        {
                            demand.MinArea = Convert.ToDouble(textBoxMinArea.Text);
                        }
                        else demand.MinArea = null;
                        if (textBoxMaxArea.Text != "")
                        {
                            demand.MaxArea = Convert.ToDouble(textBoxMaxArea.Text);
                        }
                        else demand.MaxArea = null;
                        if (textBoxMinRooms.Text != "")
                        {
                            demand.MinRooms = Convert.ToInt32(textBoxMinRooms.Text);
                        }
                        else demand.MinRooms = null;
                        if (textBoxMaxRooms.Text != "")
                        {
                            demand.MaxRooms = Convert.ToInt32(textBoxMaxRooms.Text);
                        }
                        else demand.MaxRooms = null;
                        if (textBoxMinFloor.Text != "")
                        {
                            demand.MinFloor = Convert.ToInt32(textBoxMinFloor.Text);
                        }
                        else demand.MinFloor = null;
                        if (textBoxMaxFloor.Text != "")
                        {
                            demand.MaxFloor = Convert.ToInt32(textBoxMaxFloor.Text);
                        }
                        else demand.MaxFloor = null;

                        Program.fir.SaveChanges();
                        ShowDemandSet();
                    }
                    catch (Exception ex)
                    { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
            else if (comboBoxType.SelectedIndex == 1)
            {
                if (listViewRealEstateSet_House.SelectedItems.Count == 1)
                {
                    try
                    {
                        DemandSet demand = listViewRealEstateSet_House.SelectedItems[0].Tag as DemandSet;
                        demand.IdAgent = Convert.ToInt32(comboBoxIdAgent.SelectedItem.ToString().Split('.')[0]);
                        demand.IdClient = Convert.ToInt32(comboBoxIdClient.SelectedItem.ToString().Split('.')[0]);
                        if (textBoxMinPrice.Text != "")
                        {
                            demand.MinPrice = Convert.ToInt64(textBoxMinPrice.Text);
                        }
                        else demand.MinPrice = null;
                        if (textBoxMaxPrice.Text != "")
                        {
                            demand.MaxPrice = Convert.ToInt64(textBoxMaxPrice.Text);
                        }
                        else demand.MaxPrice = null;
                        if (textBoxMinArea.Text != "")
                        {
                            demand.MinArea = Convert.ToDouble(textBoxMinArea.Text);
                        }
                        else demand.MinArea = null;
                        if (textBoxMaxArea.Text != "")
                        {
                            demand.MaxArea = Convert.ToDouble(textBoxMaxArea.Text);
                        }
                        else demand.MaxArea = null;
                        if (textBoxMinFloors.Text != "")
                        {
                            demand.MinFloors = Convert.ToInt32(textBoxMinFloors.Text);
                        }
                        else demand.MinFloors = null;
                        if (textBoxMaxFloors.Text != "")
                        {
                            demand.MaxFloors = Convert.ToInt32(textBoxMaxFloors.Text);
                        }
                        else demand.MaxFloors = null;

                        Program.fir.SaveChanges();
                        ShowDemandSet();
                    }
                    catch (Exception ex)
                    { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }

            else
            {
                if (listViewRealEstateSet_Land.SelectedItems.Count == 1)
                {
                    try
                    {
                        DemandSet demand = listViewRealEstateSet_Land.SelectedItems[0].Tag as DemandSet;
                        demand.IdAgent = Convert.ToInt32(comboBoxIdAgent.SelectedItem.ToString().Split('.')[0]);
                        demand.IdClient = Convert.ToInt32(comboBoxIdClient.SelectedItem.ToString().Split('.')[0]);
                        if (textBoxMinPrice.Text != "")
                        {
                            demand.MinPrice = Convert.ToInt64(textBoxMinPrice.Text);
                        }
                        else demand.MinPrice = null;
                        if (textBoxMaxPrice.Text != "")
                        {
                            demand.MaxPrice = Convert.ToInt64(textBoxMaxPrice.Text);
                        }
                        else demand.MaxPrice = null;
                        if (textBoxMinArea.Text != "")
                        {
                            demand.MinArea = Convert.ToDouble(textBoxMinArea.Text);
                        }
                        else demand.MinArea = null;
                        if (textBoxMaxArea.Text != "")
                        {
                            demand.MaxArea = Convert.ToDouble(textBoxMaxArea.Text);
                        }
                        else demand.MaxArea = null;

                        Program.fir.SaveChanges();
                        ShowDemandSet();
                    }
                    catch (Exception ex)
                    { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
        }

        private void listViewRealEstateSet_Apartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewRealEstateSet_Apartment.SelectedItems.Count == 1)
            {
                DemandSet demand = listViewRealEstateSet_Apartment.SelectedItems[0].Tag as DemandSet;

                comboBoxIdAgent.SelectedIndex = comboBoxIdAgent.FindString(demand.IdAgent.ToString());
                comboBoxIdClient.SelectedIndex = comboBoxIdClient.FindString(demand.IdClient.ToString());
                textBoxMinPrice.Text = demand.MinPrice.ToString();
                textBoxMaxPrice.Text = demand.MaxPrice.ToString();
                textBoxMinArea.Text = demand.MinArea.ToString();
                textBoxMaxArea.Text = demand.MaxArea.ToString();
                textBoxMinRooms.Text = demand.MinRooms.ToString();
                textBoxMaxRooms.Text = demand.MaxRooms.ToString();
                textBoxMinFloor.Text = demand.MinFloor.ToString();
                textBoxMaxFloor.Text = demand.MaxFloor.ToString();
            }
            else
            {
                comboBoxIdAgent.SelectedItem = null;
                comboBoxIdClient.SelectedItem = null;
                textBoxMinPrice.Text = "";
                textBoxMaxPrice.Text = "";
                textBoxMinArea.Text = "";
                textBoxMaxArea.Text = "";
                textBoxMinRooms.Text = "";
                textBoxMaxRooms.Text = "";
                textBoxMinFloor.Text = "";
                textBoxMaxFloor.Text = "";
            }
        }

        private void listViewRealEstateSet_House_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewRealEstateSet_House.SelectedItems.Count == 1)
            {
                DemandSet demand = listViewRealEstateSet_House.SelectedItems[0].Tag as DemandSet;

                comboBoxIdAgent.SelectedIndex = comboBoxIdAgent.FindString(demand.IdAgent.ToString());
                comboBoxIdClient.SelectedIndex = comboBoxIdClient.FindString(demand.IdClient.ToString());
                textBoxMinPrice.Text = demand.MinPrice.ToString();
                textBoxMaxPrice.Text = demand.MaxPrice.ToString();
                textBoxMinArea.Text = demand.MinArea.ToString();
                textBoxMaxArea.Text = demand.MaxArea.ToString();
                textBoxMinFloors.Text = demand.MinFloors.ToString();
                textBoxMaxFloors.Text = demand.MaxFloors.ToString();
            }
            else
            {
                comboBoxIdAgent.SelectedItem = null;
                comboBoxIdClient.SelectedItem = null;
                textBoxMinPrice.Text = "";
                textBoxMaxPrice.Text = "";
                textBoxMinArea.Text = "";
                textBoxMaxArea.Text = "";
                textBoxMinFloors.Text = "";
                textBoxMaxFloors.Text = "";
            }
        }

        private void listViewRealEstateSet_Land_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewRealEstateSet_Land.SelectedItems.Count == 1)
            {
                DemandSet demand = listViewRealEstateSet_Land.SelectedItems[0].Tag as DemandSet;

                comboBoxIdAgent.SelectedIndex = comboBoxIdAgent.FindString(demand.IdAgent.ToString());
                comboBoxIdClient.SelectedIndex = comboBoxIdClient.FindString(demand.IdClient.ToString());
                textBoxMinPrice.Text = demand.MinPrice.ToString();
                textBoxMaxPrice.Text = demand.MaxPrice.ToString();
                textBoxMinArea.Text = demand.MinArea.ToString();
                textBoxMaxArea.Text = demand.MaxArea.ToString();
            }
            else
            {
                comboBoxIdAgent.SelectedItem = null;
                comboBoxIdClient.SelectedItem = null;
                textBoxMinPrice.Text = "";
                textBoxMaxPrice.Text = "";
                textBoxMinArea.Text = "";
                textBoxMaxArea.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxType.SelectedIndex == 0)
                {
                    if (listViewRealEstateSet_Apartment.SelectedItems.Count == 1)
                    {
                        DemandSet demand = listViewRealEstateSet_Apartment.SelectedItems[0].Tag as DemandSet;
                        Program.fir.DemandSet.Remove(demand);
                        Program.fir.SaveChanges();
                        ShowDemandSet();
                    }

                    comboBoxIdAgent.SelectedItem = null;
                    comboBoxIdClient.SelectedItem = null;
                    textBoxMinPrice.Text = "";
                    textBoxMaxPrice.Text = "";
                    textBoxMinArea.Text = "";
                    textBoxMaxArea.Text = "";
                    textBoxMinRooms.Text = "";
                    textBoxMinRooms.Text = "";
                    textBoxMinFloor.Text = "";
                    textBoxMaxFloor.Text = "";
                }

                else if (comboBoxType.SelectedIndex == 1)
                {
                    if (listViewRealEstateSet_House.SelectedItems.Count == 1)
                    {
                        DemandSet demand = listViewRealEstateSet_House.SelectedItems[0].Tag as DemandSet;
                        Program.fir.DemandSet.Remove(demand);
                        Program.fir.SaveChanges();
                        ShowDemandSet();
                    }

                    comboBoxIdAgent.SelectedItem = null;
                    comboBoxIdClient.SelectedItem = null;
                    textBoxMinPrice.Text = "";
                    textBoxMaxPrice.Text = "";
                    textBoxMinArea.Text = "";
                    textBoxMaxArea.Text = "";
                    textBoxMinFloors.Text = "";
                    textBoxMaxFloors.Text = "";
                }

                else
                {
                    if (listViewRealEstateSet_Land.SelectedItems.Count == 1)
                    {
                        DemandSet demand = listViewRealEstateSet_Land.SelectedItems[0].Tag as DemandSet;
                        Program.fir.DemandSet.Remove(demand);
                        Program.fir.SaveChanges();
                        ShowDemandSet();
                    }

                    comboBoxIdAgent.SelectedItem = null;
                    comboBoxIdClient.SelectedItem = null;
                    textBoxMinPrice.Text = "";
                    textBoxMaxPrice.Text = "";
                    textBoxMinArea.Text = "";
                    textBoxMaxArea.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

   

