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
    public partial class FormHotel : Form
    {
        private Serializer slz = new Serializer();
        public HotelBook hotelbook;

        public FormHotel()
        {
            InitializeComponent();
        }

        private void FormHotel_Load(object sender, EventArgs e)
        {
            hotelbook = new HotelBook();
            fillListBox(lbxHotels);
        }

        private void btnNewHotel_Click(object sender, EventArgs e)
        {
            FormNewHotel fnh = new FormNewHotel(this);
            fnh.Show();
        }

        private void btnRmvHotel_Click(object sender, EventArgs e)
        {
            Hotel h = (Hotel)lbxHotels.SelectedItem;
            hotelbook.hotels.Remove(h);
            slz.persist(hotelbook);
            fillListBox(lbxHotels);
        }

        private void btnEditDetails_Click(object sender, EventArgs e)
        {
            changeInputState(true); // Enable textboxes
            Hotel h = (Hotel)lbxHotels.SelectedItem;
            tbxRanking.Text = h.ranking.ToString();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            int currIdx = lbxHotels.SelectedIndex;  //Get selected hotel's index

            string errText = null;
            changeInputState(false); //Disable textboxes 
            btnEditDetails.Visible = true;

            // Get hotel information
            string hotelName = tbxName.Text.Trim();
            string country = tbxCountry.Text.Trim();
            string city = tbxCity.Text.Trim();
            int postalCode;
            if (!int.TryParse(tbxPostalCode.Text.Trim(), out postalCode))
            {
                errText += "\n" + "Please enter a valid postal code";
            }
            string address = tbxAddress.Text.Trim();
            string hotelPhone = tbxHotelPhone.Text.Trim();
            int ranking;
            if (!int.TryParse(tbxRanking.Text.Trim(), out ranking))
            {
                errText += "\n" + "Please enter a valid ranking number";
            }
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

            // Get hotel manager information
            string fullName = tbxMngrFullname.Text.Trim();
            string phoneNumber = tbxMngrPhone.Text.Trim();
            string emailAdd = tbxMngrEmail.Text.Trim();
            DateTime dob = dtpMngrDob.Value;

            // Changing hotel's information
            if (errText == null)
            {   // If no error
                Person person = new Person(fullName, dob, phoneNumber, emailAdd);
                Hotel hotel = new Hotel(hotelName, address, postalCode, city, country, hotelPhone, ranking, services, roomTypes, person);
                Hotel h = (Hotel)lbxHotels.SelectedItem;
                hotelbook.hotels.Remove(h);
                hotelbook.hotels.Add(hotel);
                Serializer slz = new Serializer();
                slz.persist(hotelbook);
                fillListBox(lbxHotels);
            }
            else
            {   // If there is error, show message box
                MessageBox.Show("Errors\n" + errText);
            }

            lbxHotels.SelectedIndex = currIdx;  //Select the hotel on listbox
        }

        private void lbxHotels_SelectedIndexChanged(object sender, EventArgs e)
        {
            resetFields();
            Hotel h = (Hotel)lbxHotels.SelectedItem;
            if (h != null)
            {
                tbxName.Text = h.name;
                tbxCountry.Text = h.country;
                tbxCity.Text = h.city;
                tbxPostalCode.Text = h.postalCode.ToString();
                tbxAddress.Text = h.address;
                tbxHotelPhone.Text = h.hotelPhone;
                foreach (EnumRoomType r in h.roomTypes)
                {
                    clbxRoomType.SetItemChecked(clbxRoomType.Items.IndexOf(r.ToString()), true);
                }
                foreach (EnumServiceType s in h.services)
                {
                    clbxServices.SetItemChecked(clbxServices.Items.IndexOf(s.ToString()), true);
                }
                tbxMngrFullname.Text = h.person.fullName;
                tbxMngrPhone.Text = h.person.phoneNumber;
                tbxMngrEmail.Text = h.person.email;
                dtpMngrDob.Value = h.person.birthday;
                int rank = h.ranking;
                tlpRanking.Controls.Clear();
                fillStarRanking(1, rank);   //Filling yellow star by type 1
                fillStarRanking(2, 5 - rank);   //Filling grey star by type 2
            }
        }

        private void summaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSummary fs = new FormSummary(this);
            fs.Show();
        }

        private void programInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Software by Hieu Tran");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fillListBox(ListBox lbx) {
            hotelbook = (HotelBook)slz.read(hotelbook); //Get hotelbook from the xml file
            hotelbook.hotels = hotelbook.hotels.OrderBy(x => x.name).ToList();  //Order the list of hotels
            lbxHotels.DataSource = null;
            lbxHotels.DataSource = hotelbook.hotels;
            lbxHotels.DisplayMember = "name";
        }
        
        private void fillStarRanking(int type, int rank)
        {            
            Image img = null;
            switch (type)
            {
                case 1:
                    img = Assignment2_Hotels.Properties.Resources.star_yellow_small;
                    break;
                case 2:
                    img = Assignment2_Hotels.Properties.Resources.star_gray_small;
                    break;
                default:
                    img = Assignment2_Hotels.Properties.Resources.star_gray_small;
                    break;
            }
            for (int i = 0; i < rank; i++)
            {
                PictureBox pbx = new PictureBox();
                pbx.Image = img;
                pbx.BackgroundImageLayout = ImageLayout.Tile;
                tlpRanking.Controls.Add(pbx);
            }
        }

        private void resetFields()
        {
            tbxName.Clear();
            tbxCountry.Clear();
            tbxCity.Clear();
            tbxPostalCode.Clear();
            tbxAddress.Clear();
            tbxHotelPhone.Clear();
            clearCheckedListBox(clbxRoomType);
            clearCheckedListBox(clbxServices);
            dtpMngrDob.Value = DateTime.Now;
            tbxMngrEmail.Clear();
            tbxMngrFullname.Clear();
            tbxMngrPhone.Clear();            
        }

        private void clearCheckedListBox(CheckedListBox clb)
        {
            for (int i = 0; i < clb.Items.Count; i++)
            {
                clb.SetItemChecked(i, false);
            }
            clb.ClearSelected();
        }

        private void changeInputState(bool b)
        {
            btnSaveChanges.Visible = b;
            btnEditDetails.Visible = b;
            tbxName.Enabled = b;
            tbxCountry.Enabled = b;
            tbxCity.Enabled = b;
            tbxPostalCode.Enabled = b;
            tbxAddress.Enabled = b;
            tbxHotelPhone.Enabled = b;
            dtpMngrDob.Enabled = b;
            tbxMngrEmail.Enabled = b;
            tbxMngrFullname.Enabled = b;
            tbxMngrPhone.Enabled = b;
            tbxRanking.Visible = b;
            dtpMngrDob.Enabled = b;
            clbxRoomType.Enabled = b;
            clbxServices.Enabled = b;
            if (b == true)
            {
                lblRank.Text = "Ranking (0-5)";
                tlpRanking.Visible = false;
            }
            else
            {
                lblRank.Text = "Ranking";
                tlpRanking.Visible = true;
            }
        }
    }
}