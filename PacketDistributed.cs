using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PacketDistributed
{
    public static PacketDistributed CreatePacket(MessageID packetID)
    {
        PacketDistributed packet = null;
        switch (packetID)
        {
            //case MessageID.PACKET_CG_CONNECTED_HEARTBEAT: { packet = new CG_CONNECTED_HEARTBEAT(); } break;
        }
        if (null != packet)
        {
            packet.packetID = packetID;
        }
        return packet;
    }
    public void SendPacket()
    {
        NetWorkLogic.GetMe().SendPacket(this);
    }

    public PacketDistributed ParseFrom(byte[] data, int nLen)
    {
        //    //CodedInputStream input = CodedInputStream.CreateInstance(data, 0, nLen);
        //    PacketDistributed inst = MergeFrom(input, this);
        //    //input.CheckLastTagWas(0);
        //    return inst;
        return null;
    }
    public abstract int SerializedSize();
    public abstract void WriteTo(CodedOutputStream data);
    public abstract PacketDistributed MergeFrom(CodedInputStream input, PacketDistributed _Inst);
    public abstract bool IsInitialized();

    public MessageID GetPacketID() { return packetID; }
    protected MessageID packetID;
}
