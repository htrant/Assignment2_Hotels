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
    public partial class FormSummary : Form
    {
        FormHotel FH;
        HotelBook hotelbook;

        public FormSummary(FormHotel fh)
        {
            InitializeComponent();
            this.FH = fh;
            hotelbook = FH.hotelbook;
        }

        private void FormSummary_Load(object sender, EventArgs e)
        {            
            tbxTotalAmount.Text = hotelbook.hotels.Count().ToString();
            fillComboBox();
        }

        private void btnListHotels_Click(object sender, EventArgs e)
        {
            fillHotelTable(hotelbook.hotels);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<Hotel> resultHotels = new List<Hotel>(hotelbook.hotels);

            if (cbxRanking.SelectedIndex > 0)
            {
                foreach (Hotel h in hotelbook.hotels)
                {
                    if (h.ranking != int.Parse(cbxRanking.SelectedItem.ToString()))
                    {
                        resultHotels.Remove(h);
                    }
                }
            }
            if (cbxCountry.SelectedIndex > 0)
            {
                foreach (Hotel h in hotelbook.hotels)
                {
                    if (h.country != cbxCountry.SelectedItem.ToString())
                    {
                        resultHotels.Remove(h);
                    }
                }
            }
            if (cbxCountry.SelectedIndex == 0 && cbxRanking.SelectedIndex == 0)
            {
                resultHotels.Clear();
            }
            fillHotelTable(resultHotels);
        }

        private void fillComboBox()
        {   
            List<string> items = new List<string>();
            foreach (Hotel h in hotelbook.hotels)
            {
                if (!items.Contains(h.country))
                {
                    items.Add(h.country);
                }
            }
            items.Sort();
            items.Insert(0, "-- Choose a country --");
            cbxCountry.DataSource = items;
            cbxCountry.SelectedIndex = 0;
            cbxRanking.SelectedIndex = 0;
        }

        private void fillHotelTable(List<Hotel> resultHotels)
        {
            dgvResult.Rows.Clear();
            foreach (Hotel h in resultHotels)
            {
                dgvResult.Rows.Add(h.name, h.ranking, h.city, h.country, h.hotelPhone);
            }            
        }

    }
}
