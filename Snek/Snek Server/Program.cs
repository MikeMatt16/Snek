using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snek_Server
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome
            Console.WriteLine("Welcome to Snek server");

            //Begin
            Server.Start(25565);

            //Loop
            while(Server.IsRunning)
            {
                string input = Console.ReadLine().Trim();

                //Handle
                if (!string.IsNullOrEmpty(input))
                    HandleInput(input);
            }
        }

        private static void HandleInput(string input)
        {

        }
    }
}
