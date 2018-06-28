using System;

namespace Snek_Server
{
    public class GameStatePacket : SnakePacket
    {
        public GameStatePacket()
        {

        }
    }

    public class MovementPacket : SnakePacket
    {
        public PlayerDesignation Player
        {
            get { return (PlayerDesignation)(data & 0xf); }
            set
            {

            }
        }
        public Direction Direction
        {
            get { return (Direction)((data & 0xf0) >> 4); }
            set
            {

            }
        }
        
        private byte data;
    }

    /// <summary>
    /// Represents a basic snake packet.
    /// </summary>
    public class SnakePacket
    {
        /// <summary>
        /// Represents the minimum length of a snake packet.
        /// </summary>
        public const int MinimumLength = 3;
        /// <summary>
        /// Represents the maximum length of a snake packet;
        /// </summary>
        public const int MaximumLength = 2051;  //15 bpt * 32 rows * 32 columns / 8 bits per byte = 2048 bytes + 3 byte base packet
        /// <summary>
        /// Gets or sets the packet type.
        /// </summary>
        public PacketType Type
        {
            get { return (PacketType)type; }
            set { type = (byte)value; }
        }
        /// <summary>
        /// Gets or sets the length of the packet data in bytes.
        /// </summary>
        public ushort Length
        {
            get { return length; }
            set { length = value; }
        }

        private byte type;
        private ushort length;

        /// <summary>
        /// Gets and returns a byte array containing the packet information.
        /// </summary>
        /// <returns>An array of <see cref="byte"/> elements.</returns>
        public virtual byte[] ToPacket()
        {
            //Prepare
            byte[] packet = new byte[3];

            //Setup
            packet[0] = type;
            Array.Copy(BitConverter.GetBytes(length), 0, packet, 1, 2);

            //Return
            return packet;
        }
        /// <summary>
        /// Copies the data contained within the packet to this instance.
        /// </summary>
        /// <param name="packet">The array of <see cref="byte"/> elements that contain the snake packet.</param>
        public virtual void FromPacket(byte[] packet)
        {
            //Check
            if (packet == null) throw new ArgumentNullException(nameof(packet));
            if (packet.Length < MinimumLength) throw new ArgumentException("Invalid packet.", nameof(packet));

            //Get type and length
            type = packet[0];
            length = BitConverter.ToUInt16(packet, 1);
        }
    }

    [Flags]
    public enum Direction : byte
    {
        None = 0,
        Up = 0x1,
        Down = 0x2,
        Left = 0x4,
        Right = 0x8
    };

    public enum PlayerDesignation : byte
    {
        Player1 = 0,
        Player2 = 1,
        Player3 = 2,
        Player4 = 3,
    };

    /// <summary>
    /// Represents an enumeration containing possible packet types.
    /// </summary>
    public enum PacketType : byte
    {
        None = 0,
        Ping = 1,
        Connect = 2,
        Quit = 3,

        TileUpdate = 4,
        GameUpdate = 5
    };
}
