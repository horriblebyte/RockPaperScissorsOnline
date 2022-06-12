using System;
using System.Collections.Generic;

namespace ServerRPS.Classes.Models {
    public class Room {
        public string RoomID { get; set; }
        public List<Player> RoomPlayerList { get; set; }
        public DateTime RoomCreateDate { get; set; }
        public int RoomLimit { get; } = 2;
    }
}