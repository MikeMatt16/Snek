using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Snek_Server
{
    /// <summary>
    /// Represents the server singleton.
    /// </summary>
    internal static class Server
    {
        /// <summary>
        /// Gets and returns <see langword="true"/> if the server is running; otherwise, <see langword="false"/>.
        /// </summary>
        public static bool IsRunning
        {
            get { return IsRunning; }
        }

        private static int port = 25565;
        private static volatile bool isRunning = false;
        private static Socket udpSocket;
        private static byte[] rcvPacket = new byte[SnakePacket.MaximumLength];

        /// <summary>
        /// Starts the server using the specified port number.
        /// </summary>
        /// <param name="port">The port to listen on.</param>
        public static void Start(int port)
        {
            //Setup
            Server.port = port;

            //Prepare
            udpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            EndPoint remoteEndPoint = new IPEndPoint(IPAddress.Any, port);

            //Listen
            udpSocket.BeginReceiveFrom(rcvPacket, 0, rcvPacket.Length, SocketFlags.None, ref remoteEndPoint, ReceiveCallback, null);
        }

        private static void ReceiveCallback(IAsyncResult ar)
        {
            //Get end point
            EndPoint remoteEndPoint = new IPEndPoint(IPAddress.Any, port);

            udpSocket.EndReceiveFrom(ar, ref remoteEndPoint);
        }
    }
}
