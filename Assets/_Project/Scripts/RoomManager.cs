using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityAtoms.BaseAtoms;

public class RoomManager : MonoBehaviour
{
    public StringEvent RoomChangeEvent;

    private Room[] _rooms;
    private Room _currentRoom;

    private void Start() {
        _rooms = GetComponentsInChildren<Room>();
        _currentRoom = _rooms.First(r => r.IsEntrance);

        ShowCurrentRoom();
    }

    public void ShowCurrentRoom()
    {
        foreach (Room r in _rooms) SetVisibility(r, false);
        _currentRoom.SetVisibility(true);
        RoomChangeEvent.Raise(_currentRoom.Name);
    }

    public void SetVisibility(Room room, bool visibility)
    {
        room.SetVisibility(visibility);
    }

    public void SetVisibility(int index, bool visibility)
    {
        SetVisibility(_rooms[index], visibility);
    }

    public int GetRoomIndex(Room room)
    {
        return -1;
    }
}
