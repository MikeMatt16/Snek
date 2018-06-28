using System;

namespace Snek_Server
{
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

    /// <summary>
    /// Represents an enumeration containing possible packet types.
    /// </summary>
    public enum PacketType : byte
    {
        None = 0,
        Ping = 1,
        Connect = 2,
    }
}
