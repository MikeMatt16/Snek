using System;
using System.Drawing;
using System.Windows.Forms;

namespace Snek_Client.Forms
{
    /// <summary>
    /// User Login Form - Allows user to enter Username and Psscode to be used for Server Connections
    /// </summary>
    public partial class UserLoginForm : Form
    {
        //Alternate Labels for Textboxes
        private const string _alternateUsernameLabel = "<new user>";
        private const string _alternatePasscodeLabel = "<user passcode>";

        public UserLoginForm()
        {
            InitializeComponent();

            //Set Alternate Textbox Labels
            UsernameTextbox.Text = _alternateUsernameLabel;
            PasscodeTextbox.Text = _alternatePasscodeLabel;
        }
        
        /// <summary>
        /// User Entered Value for Username
        /// </summary>
        public string UsernameValue { get { return UsernameTextbox.Text; } set { UsernameTextbox.Text = value; } }

        /// <summary>
        /// User Entered Value for Passcode
        /// </summary>
        public string PasscodeValue { get { return PasscodeTextbox.Text; } set { PasscodeTextbox.Text = value; } }

        private void UsernameTextbox_Enter(object sender, EventArgs e)
        {
            //Clear the textbox alternate label
            if(UsernameTextbox.Text == _alternateUsernameLabel)
            {
                UsernameTextbox.Text = string.Empty;
            }
        }

        private void UsernameTextbox_Leave(object sender, EventArgs e)
        {
            //Set textbox alternate label
            if(UsernameTextbox.Text == string.Empty)
            {
                UsernameTextbox.Text = _alternateUsernameLabel;
            }
        }

        private void PasscodeTextbox_Enter(object sender, EventArgs e)
        {
            //Clear the textbox alternate label
            if (PasscodeTextbox.Text == _alternatePasscodeLabel)
            {
                PasscodeTextbox.Text = string.Empty;
            }
        }

        private void PasscodeTextbox_Leave(object sender, EventArgs e)
        {
            //Set textbox alternate label
            if (PasscodeTextbox.Text == string.Empty)
            {
                PasscodeTextbox.Text = _alternatePasscodeLabel;
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            //Check if Username has been entered
            if(string.IsNullOrWhiteSpace(UsernameValue) || UsernameValue == _alternateUsernameLabel)
            {
                //Username is Invalid
                MessageBox.Show("Username Required");
                return;
            }

            //Check if Passcode has been entered
            if (string.IsNullOrWhiteSpace(PasscodeValue) || PasscodeValue == _alternatePasscodeLabel)
            {
                //Passcode is Invalid
                MessageBox.Show("Passcode Require");
                return;
            }

            //Login
            Login(UsernameValue, PasscodeValue);
        }
        
        private void UsernameTextbox_TextChanged(object sender, EventArgs e)
        {
            //Allow Alternate Label
            if (UsernameTextbox.Text == _alternateUsernameLabel)
            {
                //Enable Alternate Label Forecolor
                UsernameTextbox.ForeColor = Color.Gray;

                return;
            }
            else
            {
                //Disable Alternate Label Forecolor
                UsernameTextbox.ForeColor = Color.Black;
            }

            //Start Value
            string newValue = UsernameTextbox.Text;

            //Original Selection
            int selectionStart = UsernameTextbox.SelectionStart;

            //Number of Invalid Chars Removed
            int removedChars = 0;

            //Make sure Text is not empty
            if (UsernameTextbox.Text.Length > 0)
            {
                //Loop through our characters
                for (int i = newValue.Length - 1; i >= 0; i--)
                {
                    //Remove Characters that are not aA-zZ OR 0-9
                    if (!char.IsLetterOrDigit(newValue[i]))
                    {
                        //Remove Char
                        newValue = newValue.Remove(i, 1);

                        //Increment Char Removal Count
                        removedChars++;
                    }
                }

                //Adjust Selection
                if (removedChars > 0)
                    selectionStart -= removedChars;

                //Clamp Selection
                selectionStart = Math.Max(0, selectionStart);
                selectionStart = Math.Min(newValue.Length, selectionStart);

                //Set Text and Selection
                UsernameTextbox.Text = newValue;
                UsernameTextbox.SelectionStart = selectionStart;
            }
        }

        private void PasscodeTextbox_TextChanged(object sender, EventArgs e)
        {
            if (PasscodeTextbox.Text == _alternatePasscodeLabel)
            {
                //Enable Alternate Label Forecolor
                PasscodeTextbox.ForeColor = Color.Gray;

                return;
            }
            else
            {
                //Disable Alternate Label Forecolor
                PasscodeTextbox.ForeColor = Color.Black;
            }
        }

        private void CancelSetupButton_Click(object sender, EventArgs e)
        {
            CancelLogin();
        }

        /// <summary>
        /// Performs User Login - Using entered Username & Passcode
        /// </summary>
        private void Login(string username, string passcode)
        {
            //TODO: User Login - Send Server User Data
            throw new NotImplementedException();
        }

        /// <summary>
        /// Cancels User Login
        /// </summary>
       private void CancelLogin()
        {
            throw new NotImplementedException();
        }
    }
}
