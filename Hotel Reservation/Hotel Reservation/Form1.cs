using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Reservation
{
    public partial class Form1 : Form
    {
        private List<Reservation> reservations = new List<Reservation>();
        List<string> reservationList = new List<string>();
        double totalPrice;

        public Form1()
        {
            InitializeComponent();
            foreach (var type in Enum.GetValues(typeof(RoomType)))
            {
                cbRoomType.Items.Add(type);
            }
            cbRoomType.SelectedItem = RoomType.NORMAL;
            nudAmountOfNights.Value = 1;
            nudAmountOfNights.Minimum = 1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Reservation reserve = new Reservation(tbFullName.Text, Convert.ToInt32(nudAmountOfNights.Value));
            string roomType = cbRoomType.Text;
            RoomType currentRoom = (RoomType)cbRoomType.SelectedIndex;

            reserve.AddRoom(currentRoom, chbSmoking.Checked);
            reservationList.Add(reserve.GetInfo());

            foreach (string item in reserve.roomList)
            {
                lbRoom.Items.Add(item);
            }
            totalPrice += reserve.GetTotalPrice(0);
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            lbReservation.Items.Clear();
            foreach (string item in reservationList)
            {
                lbReservation.Items.Add(item);
            }
            lbReservation.Items.Add($"Total price is {totalPrice}");
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            lbRoom.Items.Clear();
            reservationList.Clear();
            lbReservation.Items.Clear();
            totalPrice = 0;
        }
    }
}
