using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snek_Server
{
    /*
     * byte[] token = bytes(name) + bytes(key)
     * SHA1(token) -> Guid
     */

    /// <summary>
    /// Represents a client instance
    /// </summary>
    public class Client
    {
        /// <summary>
        /// Gets and returns the client's ID.
        /// </summary>
        public Guid Id
        {
            get { return clientId; }
        }
        /// <summary>
        /// Gets and returns the client's name.
        /// </summary>
        public string Name
        {
            get { return name; }
        }
        /// <summary>
        /// Gets and returns the client's color.
        /// </summary>
        public int Color
        {
            get { return color; }
        }

        private Guid clientId;
        private string name;
        private int color;
    }
}
