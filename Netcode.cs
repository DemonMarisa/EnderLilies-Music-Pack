using EnderLiliesMusicPack.MusicSystem;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;

namespace EnderLiliesMusicPack
{
    //音乐事件的网络同步
    //从灾厄那里复制的
    public class Netcode
    {
        public static void HandlePacket(Mod mod, BinaryReader reader, int whoAmI)
        {
            try
            {
                LiliMessageType msgType = (LiliMessageType)reader.ReadByte();
                switch (msgType)
                {
                    //
                    // 音乐事件同步
                    //
                    case LiliMessageType.MusicEventSyncRequest:
                        LiliesMusicEventSystem.FulfillSyncRequest(whoAmI);
                        break;

                    case LiliMessageType.MusicEventSyncResponse:
                        LiliesMusicEventSystem.ReceiveSyncResponse(reader);
                        break;

                    //
                    // 说实话这段也是从灾厄独立出来的，但是我觉得没必要改了，只做了注释汉化
                    // 默认情况: 我不知道数据包有多少字节，所以没法安全的读取数据。
                    // 现在引发异常，而不是让网络流损坏。
                    //
                    default:
                        EnderLiliesMusicPack.Instance.Logger.Error($"Failed to parse LiliesMusicPack packet: No LiliesMusicPack packet exists with ID {msgType}.");
                        throw new Exception("Failed to parse LiliesMusicPack packet: Invalid LiliesMusicPack packet ID.");
                }
            }
            catch (Exception e)
            {
                if (e is EndOfStreamException eose)
                    EnderLiliesMusicPack.Instance.Logger.Error("Failed to parse LiliesMusicPack packet: Packet was too short, missing data, or otherwise corrupt.", eose);
                else if (e is ObjectDisposedException ode)
                    EnderLiliesMusicPack.Instance.Logger.Error("Failed to parse LiliesMusicPack packet: Packet reader disposed or destroyed.", ode);
                else if (e is IOException ioe)
                    EnderLiliesMusicPack.Instance.Logger.Error("Failed to parse LiliesMusicPack packet: An unknown I/O error occurred.", ioe);
                else
                    throw; // 这要么会使游戏崩溃，要么会被TML的捕获

            }
        }
    }
    public enum LiliMessageType : byte
    {
        // 音乐事件
        MusicEventSyncRequest,
        MusicEventSyncResponse,
    }
}
