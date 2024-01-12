using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Reservation
{
    class Reservation
    {
        private static int nrSeeder = 0;
        private string name;
        private int numberOfNight;

        public List<string> roomList = new List<string>();
        public List<double> totalPrice = new List<double>();

        public Reservation(string name, int noOfNights)
        {
            this.name = name;
            this.numberOfNight = noOfNights;
            nrSeeder++;
        }
        public string Name => this.name;
        public int NumberNight => this.numberOfNight;

        public void AddRoom()
        {
            Room room = new Room(nrSeeder);
            roomList.Add(room.GetInfo());
            totalPrice.Add(room.GetPriceOneNight());
        }

        public void AddRoom(RoomType type, bool isSmoking)
        {
            Room room = new Room(nrSeeder, type, isSmoking);
            roomList.Add(room.GetInfo());
            totalPrice.Add(room.GetPriceOneNight());
        }

        public double GetTotalPrice(double total)
        {
            foreach (double d in totalPrice)
            {
               total += d;
            }
            return total;
        }

        public string GetInfo()
        {
            return $"Reservation of {this.name} with {this.numberOfNight} nights";
        }
    }
}
