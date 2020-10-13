﻿using SimpleNetManager;
using SimpleNetCore;
using System;
using System.Collections.Generic;

namespace UnityRemoteConsole
{
    [Serializable]
    public class MethodData2Client : INetSerializable
    {
        public MethodData data = new MethodData();
        public void Deserialize(NetDataReader reader)
        {
            data.Deserialize(reader);
        }

        public void Serialize(NetDataWriter writer)
        {
            data.Serialize(writer);
        }
    }
}
