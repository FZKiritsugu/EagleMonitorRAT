﻿using System;

/* 
|| AUTHOR Arsium ||
|| github : https://github.com/arsium       ||
*/

namespace PacketLib.Packet
{
    [Serializable]
    public class BaseIpPacket : IPacket
    {
        public BaseIpPacket(string baseIp) : base()
        {
            this.PacketType = PacketType.CONNECTED;
            this.BaseIp = baseIp;
        }

        public string HWID { get; set; }
        public string BaseIp { get; set; }
        public byte[] Plugin { get; set; }
        public PacketType PacketType { get; }
        public PacketState PacketState { get; set; }
        public string Status { get; set; }
        public string DatePacketStatus { get; set; }
        public int PacketSize { get; set; }
    }
}
