using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snek_Server
{
    /// <summary>
    /// Represents a game session instance.
    /// </summary>
    public class Session
    {
        private Guid sessionId;
        private SessionState state;

    }

    /// <summary>
    /// Represents an enumeration containing possible session states.
    /// </summary>
    public enum SessionState
    {
        None,
        Lobby,
        Game
    };
}
