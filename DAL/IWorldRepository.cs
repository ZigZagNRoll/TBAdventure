using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBA.BL.Domain;

namespace TBA.DAL
{
    public interface IWorldRepository
    {
        #region World
        IEnumerable<World> ReadWorld();
        World CreateWorld(World world);
        World ReadWorld(int world);
        void UpdateWorld(World world);
        #endregion

        #region World
        IEnumerable<Plain> ReadPlains();
        Plain CreatePlain(Plain Plain);
        Plain ReadPlain(int Plain);
        void UpdatePlain(Plain plain);
        #endregion

        #region Room
        IEnumerable<Room> ReadRooms(int plainNumber);
        Room getRoom(int rooomNumber);
        Room CreateRoom(Room room);
        #endregion

        #region Door
        IEnumerable<Door> ReadDoors(int RoomNumber);
        Door ReadDoor(int DoorNumber);
        Door CreateDoor(Door door);
        void UpdateDoor(Door door);
        void openDoor(int doorNumber);

        #endregion

    }
}
