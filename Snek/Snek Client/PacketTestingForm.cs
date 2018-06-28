using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snek_Client
{
    public partial class PacketTestingForm : Form
    {
        public PacketTestingForm()
        {
            InitializeComponent();
        }
        private const byte BoardWidth = 32;
        private const byte BoardHeight = 32;
        
        private void BoardCanvas_Paint(object sender, PaintEventArgs e)
        {
            for (int x = 0; x < BoardWidth; x++)
            {
                for (int y = 0; y < BoardHeight; y++)
                {
                    Point canvasPoint = GetBoardPoint(x, y);

                    e.Graphics.DrawLine(Pens.Gray, canvasPoint.X, 0, canvasPoint.X, BoardCanvas.Height);

                    e.Graphics.DrawLine(Pens.Gray, 0, canvasPoint.Y, BoardCanvas.Width, canvasPoint.Y);
                }
            }
        }

        private Point GetBoardPoint(int columnIndex, int rowIndex)
        {
            int x = columnIndex * (BoardCanvas.Width / BoardWidth);
            int y = rowIndex * (BoardCanvas.Height / BoardHeight);

            Point newPoint = new Point(x, y);

            return newPoint;
        }
    }
}
