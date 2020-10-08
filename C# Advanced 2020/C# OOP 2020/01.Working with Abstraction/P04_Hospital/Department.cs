using System.Collections.Generic;
using System.Linq;

namespace P04_Hospital
{
    public class Department
    {
        private readonly List<Room> rooms;
        
        private Department()
        {
            this.rooms = new List<Room>();
            this.InitializeRooms();
        }

        public Department(string name)
            : this()
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public IReadOnlyCollection<Room> Rooms =>
            this.Rooms;

        public Room GetFirstFreeRoom()
        {
            return this.rooms
                .First(r => r.Count < 3);
        }

        private void InitializeRooms()
        {
            for (byte i = 1; i <= 20; i++)
            {
                this.rooms.Add(new Room(i));
            }
        }
    }
}
