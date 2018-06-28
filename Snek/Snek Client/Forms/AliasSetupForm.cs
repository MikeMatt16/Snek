using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snek_Client.Forms
{
    /// <summary>
    /// Alias Setup Form - Allows user to enter Alias and Psscode to be used for Server Connections
    /// </summary>
    public partial class AliasSetupForm : Form
    {
        public AliasSetupForm()
        {
            InitializeComponent();
        }

        public string UsernameValue { get { return UsernameTextbox.Text; } set { UsernameTextbox.Text = value; } }
        public string PasscodeValue { get { return PasscodeTextbox.Text; } set { PasscodeTextbox.Text = value; } }
    }
}
