using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2_Hotels
{
    public partial class FormNewHotel : Form
    {

        HotelBook hotelbook;
        FormHotel FH;

        public FormNewHotel(FormHotel fh)
        {
            InitializeComponent();
            this.FH = fh;
            hotelbook = FH.hotelbook;
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int errorCount = 0;

            // Triming the input text and check empty
            string hotelName = tbxName.Text.Trim();
            if (isEmpty(hotelName,lblHotelName)) {
                errorCount++;
            }
            string country = tbxCountry.Text.Trim();
            if (isEmpty(country, lblCountry))
            {
                errorCount++;
            }
            string city = tbxCity.Text.Trim();
            if (isEmpty(city, lblCity))
            {
                errorCount++;
            }
            int postalCode;
            if (!int.TryParse(tbxPostalCode.Text.Trim(), out postalCode))
            {
                errorCount++;
            }
            else {
                lblPostalCode.Visible = false;
            }
            string address = tbxAddress.Text.Trim();
            if (isEmpty(address, lblAddress))
            {
                errorCount++;
            }
            string hotelPhone = tbxHotelPhone.Text.Trim();
            if (isEmpty(hotelPhone, lblTelephone))
            {
                errorCount++;
            }
            int ranking;
            if (!int.TryParse(tbxRanking.Text.Trim(), out ranking))
            {
                errorCount++;
            }
            else {
                lblRanking.Visible = false;
            }
            string fullName = tbxMngrFullname.Text.Trim();
            if (isEmpty(fullName, lblMgrName))
            {
                errorCount++;
            }
            string phoneNumber = tbxMngrPhone.Text.Trim();
            if (isEmpty(phoneNumber, lblMgrPhone))
            {
                errorCount++;
            }
            string emailAdd = tbxMngrEmail.Text.Trim();
            if (isEmpty(emailAdd, lblMgrEmail))
            {
                errorCount++;
            }

            DateTime dob = dtpMngrDob.Value;
            
            // Get data from checklistbox
            List<EnumRoomType> roomTypes = new List<EnumRoomType>();
            foreach (string s in clbxRoomType.CheckedItems)
            {
                roomTypes.Add((EnumRoomType)Enum.Parse(typeof(EnumRoomType), s));
            }
            List<EnumServiceType> services = new List<EnumServiceType>();
            foreach (string s in clbxServices.CheckedItems)
            {
                services.Add((EnumServiceType)Enum.Parse(typeof(EnumServiceType), s));
            }

            // Saving new hotel
            if (errorCount == 0)
            {   // If no error, start to create object and save to file                
                Person person = new Person(fullName, dob, phoneNumber, emailAdd);
                Hotel hotel = new Hotel(hotelName, address, postalCode, city, country, hotelPhone, ranking, services, roomTypes, person);
                hotelbook.hotels.Add(hotel);
                Serializer slz = new Serializer();
                slz.persist(hotelbook);
                MessageBox.Show("New hotel is successfully added!");
                clearFields();
                refreshHotelList();
            }
            else
            {   // If there is  error, show warning to user
                MessageBox.Show("Please check your input fields!","Errors",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        public void clearFields() {
            // Clear all textboxes and checked items
            tbxName.Clear();
            tbxCountry.Clear();
            tbxCity.Clear();
            tbxPostalCode.Clear();
            tbxAddress.Clear();
            tbxHotelPhone.Clear();
            tbxRanking.Clear();            
            tbxMngrFullname.Clear();
            tbxMngrPhone.Clear();
            tbxMngrEmail.Clear();
            dtpMngrDob.Value = DateTime.Today;
            clearCheckedListBox(clbxRoomType);
            clearCheckedListBox(clbxServices);

            // Make required mark visible
            lblHotelName.Visible = true;
            lblCountry.Visible = true;
            lblCity.Visible = true;
            lblPostalCode.Visible = true;
            lblAddress.Visible = true;
            lblTelephone.Visible = true;
            lblRanking.Visible = true;
            lblMgrName.Visible = true;
            lblMgrPhone.Visible = true;
            lblMgrEmail.Visible = true;
        }

        private void clearCheckedListBox(CheckedListBox clb) {
            for (int i = 0; i < clb.Items.Count; i++) { 
                clb.SetItemChecked(i,false);
            }
            clb.ClearSelected();
        }

        private void refreshHotelList() {
            FH.lbxHotels.DataSource = null;
            hotelbook.hotels = hotelbook.hotels.OrderBy(x => x.name).ToList();
            FH.lbxHotels.DataSource = hotelbook.hotels;
            FH.lbxHotels.DisplayMember = "name";
        }

        private bool isEmpty(string s, Label lbl) {
            if (string.IsNullOrEmpty(s))
            {
                lbl.Visible = true;
                return true;
            }
            else {
                lbl.Visible = false;
                return false;
            }
        }

    }
}
