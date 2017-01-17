using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBA.BL.Domain;

namespace TBA.DAL
{
    public class WorldRepositoryHC : IWorldRepository
    {
        private List<Plain> worlds;
        private List<Room> rooms;


        public Door CreateDoor(Door door)
        {
            throw new NotImplementedException();
        }

        public Plain CreatePlain(Plain Plain)
        {
            throw new NotImplementedException();
        }

        public Room CreateRoom(Room room)
        {
            throw new NotImplementedException();
        }

        public Room getRoom(int rooomNumber)
        {
            throw new NotImplementedException();
        }

        public void openDoor(int doorNumber)
        {
            throw new NotImplementedException();
        }

        public Door ReadDoor(int DoorNumber)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Door> ReadDoors(int RoomNumber)
        {
            throw new NotImplementedException();
        }

        public Plain ReadPlain(int Plain)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Plain> ReadPlains()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Room> ReadRooms(int plainNumber)
        {
            throw new NotImplementedException();
        }

        public void UpdateDoor(Door door)
        {
            throw new NotImplementedException();
        }

        public void UpdatePlain(Plain plain)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<World> ReadWorld()
        {
            throw new NotImplementedException();
        }

        public World CreateWorld(World world)
        {
            throw new NotImplementedException();
        }

        public World ReadWorld(int world)
        {
            throw new NotImplementedException();
        }

        public void UpdateWorld(World world)
        {
            throw new NotImplementedException();
        }
    }
}
