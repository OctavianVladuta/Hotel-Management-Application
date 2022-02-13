using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log_In
{
    class Room
    {
        public int RoomNumber { get; set; }
        public int TypeRoom { get; set; }
        public string Disponibility { get; set; }

        public override bool Equals(object obj)
        {
            if (!(obj is Room))
            {
                return false;
            }

            Room room = obj as Room;

            return room.RoomNumber == RoomNumber && room.TypeRoom == TypeRoom && room.Disponibility == Disponibility;
        }


        public override string ToString()
        {
            return $"{RoomNumber},{TypeRoom},{Disponibility}";
        }
    }
}
