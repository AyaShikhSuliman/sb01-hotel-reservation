using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Reservation
{
    class Room
    {
        private int number;
        private RoomType type;
        private bool isSmoking;

        public Room(int nr)
        {
            this.number = nr;
            this.type = RoomType.NORMAL;
            this.isSmoking = false;
        }

        public Room(int nr, RoomType type, bool isSmoking) : this(nr)
        {
            this.type = type;
            this.isSmoking = isSmoking;
        }

        public double GetPriceOneNight()
        {
            if (this.type == RoomType.SINGLE && this.isSmoking)
            {
                return 75+9.95;
            }
            else if (this.type == RoomType.SINGLE)
            {
                return 75;
            }
            else if (this.type == RoomType.NORMAL && this.isSmoking)
            {
                return 100+9.95;
            }
            else if (this.type == RoomType.NORMAL)
            {
                return 100;
            }
            else if (this.type == RoomType.FAMILY && this.isSmoking)
            {
                return 150+9.95;
            }
            else if (this.type == RoomType.FAMILY)
            {
                return 150;
            }
            else
            {
                return 0;
            }
        }

        public string SmokingType()
        {
            if (this.isSmoking)
                return "smoking";
            else
                return "non smoking";
        }

        public string GetInfo()
        {
            return ($"Room {this.number}: {this.type} - {this.SmokingType()}");
        }
    }
}
