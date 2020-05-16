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
    public partial class FormRealEstate : Form
    {
        public FormRealEstate()
        {
            InitializeComponent();
            comboBoxType.SelectedIndex = 0;
            ShowRealEstateSet();
        }

        private void labelType_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCoordinate_latitude_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedIndex == 0)
            {
                listViewRealEstateSet_Apartment.Visible = true;
                labelFloor.Visible = true;
                textBoxFloor.Visible = true;
                labelRooms.Visible = true;
                textBoxRooms.Visible = true;

                listViewRealEstateSet_House.Visible = false;
                listViewRealEstateSet_Land.Visible = false;
                labelTotalFloors.Visible = false;
                textBoxTotalFloors.Visible = false;

                textBoxAddress_City.Text = "";
                textBoxAddress_City.Text = "";
                textBoxAddress_Street.Text = "";
                textBoxAddress_Number.Text = "";
                textBoxCoordinate_latitude.Text = "";
                textBoxCoordinate_longitude.Text = "";
                textBoxTotalArea.Text = "";
                textBoxRooms.Text = "";
                textBoxFloor.Text = "";

            }
            else if (comboBoxType.SelectedIndex == 1)
            {
                listViewRealEstateSet_House.Visible = true;
                labelTotalFloors.Visible = true;
                textBoxTotalFloors.Visible = true;

                listViewRealEstateSet_Land.Visible = false;
                listViewRealEstateSet_Apartment.Visible = false;
                labelFloor.Visible = false;
                textBoxFloor.Visible = false;
                labelRooms.Visible = false;
                textBoxRooms.Visible = false;

                textBoxAddress_City.Text = "";
                textBoxAddress_House.Text = "";
                textBoxAddress_Street.Text = "";
                textBoxAddress_Number.Text = "";
                textBoxCoordinate_latitude.Text = "";
                textBoxCoordinate_longitude.Text = "";
                textBoxTotalArea.Text = "";
                textBoxTotalFloors.Text = "";

            }
            else if (comboBoxType.SelectedIndex == 2)
            {
                listViewRealEstateSet_Land.Visible = true;

                listViewRealEstateSet_House.Visible = false;
                listViewRealEstateSet_Apartment.Visible = false;
                labelFloor.Visible = false;
                textBoxFloor.Visible = false;
                labelRooms.Visible = false;
                textBoxRooms.Visible = false;
                labelTotalFloors.Visible = false;
                textBoxTotalFloors.Visible = false;

                textBoxAddress_City.Text = "";
                textBoxAddress_House.Text = "";
                textBoxAddress_Street.Text = "";
                textBoxAddress_Number.Text = "";
                textBoxCoordinate_latitude.Text = "";
                textBoxCoordinate_longitude.Text = "";
                textBoxTotalArea.Text = "";



            }
        }

        private void listViewRealEstateSet_Land_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormRealEstate_Load(object sender, EventArgs e)
        {

        }

        private void listViewRealEstateSet_Apartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        void ShowRealEstateSet()
        {
            listViewRealEstateSet_Apartment.Items.Clear();
            listViewRealEstateSet_House.Items.Clear();
            listViewRealEstateSet_Land.Items.Clear();

            foreach (RealEstateSet realEstate in Program.fir.RealEstateSet)
            {
                if (realEstate.Type == 0)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        realEstate.Address_City, realEstate.Address_Steet, realEstate.Address_House,realEstate.Address_Number,realEstate.Coordinate_latitude.ToString(),realEstate.Coordinate_longitude.ToString(), realEstate.TotalArea.ToString(), realEstate.Rooms.ToString(),realEstate.Floor.ToString()
                    });

                    item.Tag = realEstate;

                    listViewRealEstateSet_Apartment.Items.Add(item);
                }

                else if (realEstate.Type == 1)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        realEstate.Address_City, realEstate.Address_Steet,realEstate.Address_House, realEstate.Address_Number, realEstate.Coordinate_latitude.ToString(), realEstate.Coordinate_longitude.ToString(),realEstate.TotalArea.ToString(),realEstate.TotalFloors.ToString()
                    });

                    item.Tag = realEstate;

                    listViewRealEstateSet_House.Items.Add(item);
                }
                else
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        realEstate.Address_City,realEstate.Address_Steet, realEstate.Address_House, realEstate.Address_Number, realEstate.Coordinate_latitude.ToString(),realEstate.Coordinate_longitude.ToString(),realEstate.TotalArea.ToString()
                    });

                    item.Tag = realEstate;

                    listViewRealEstateSet_Land.Items.Add(item);
                }

            }

            listViewRealEstateSet_Apartment.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewRealEstateSet_House.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewRealEstateSet_Land.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            RealEstateSet realEstate = new RealEstateSet();
            realEstate.Address_City = textBoxAddress_City.Text;
            realEstate.Address_House = textBoxAddress_House.Text;
            realEstate.Address_Steet = textBoxAddress_Street.Text;
            realEstate.Address_Number = textBoxAddress_Number.Text;
           
            if (textBoxCoordinate_latitude.Text != "") { realEstate.Coordinate_latitude = Convert.ToDouble(textBoxCoordinate_latitude.Text); }
            if (realEstate.Coordinate_latitude < -90)
            {
                realEstate.Coordinate_latitude = -90;
                textBoxCoordinate_latitude.Text = "-90";

            }
            if (realEstate.Coordinate_latitude > 90)
            {
                realEstate.Coordinate_latitude = 90;
                textBoxCoordinate_latitude.Text = "90";

            }
            if (textBoxCoordinate_longitude.Text != "") { realEstate.Coordinate_longitude = Convert.ToDouble(textBoxCoordinate_longitude.Text); }
            if (realEstate.Coordinate_longitude < -180)
            {
                realEstate.Coordinate_longitude = -180;
                textBoxCoordinate_longitude.Text = "-180";
            }
            if (realEstate.Coordinate_longitude >180)
            {
                realEstate.Coordinate_longitude = 180;
                textBoxCoordinate_longitude.Text = "180";
            }
            if (textBoxTotalArea.Text != "") { realEstate.TotalArea = Convert.ToDouble(textBoxTotalArea.Text); }
            if (comboBoxType.SelectedIndex == 0)
            {
                realEstate.Type = 0;
                if (textBoxRooms.Text != "") { realEstate.Rooms = Convert.ToInt32(textBoxRooms.Text); };
                if (textBoxFloor.Text != "") { realEstate.Floor = Convert.ToInt32(textBoxFloor.Text); };

            }
            else if (comboBoxType.SelectedIndex == 1)
            {
                realEstate.Type = 1;
                if(textBoxTotalFloors.Text != "") { realEstate.TotalFloors = Convert.ToInt32(textBoxTotalFloors.Text); };
            }
            else
            {
                realEstate.TotalFloors = 2;
            }
            Program.fir.RealEstateSet.Add(realEstate);
            Program.fir.SaveChanges();
            ShowRealEstateSet();
        



        }
        

        }

    }

    

