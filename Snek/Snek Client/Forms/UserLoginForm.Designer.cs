namespace Snek_Client.Forms
{
    partial class UserLoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.UsernameTextbox = new System.Windows.Forms.TextBox();
            this.PasscodeTextbox = new System.Windows.Forms.TextBox();
            this.PasscodeLabel = new System.Windows.Forms.Label();
            this.CancelSetupButton = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.ForeColor = System.Drawing.Color.White;
            this.UsernameLabel.Location = new System.Drawing.Point(12, 15);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(118, 24);
            this.UsernameLabel.TabIndex = 0;
            this.UsernameLabel.Text = "Username:";
            // 
            // UsernameTextbox
            // 
            this.UsernameTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.UsernameTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UsernameTextbox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTextbox.ForeColor = System.Drawing.Color.Black;
            this.UsernameTextbox.Location = new System.Drawing.Point(136, 17);
            this.UsernameTextbox.Name = "UsernameTextbox";
            this.UsernameTextbox.Size = new System.Drawing.Size(306, 26);
            this.UsernameTextbox.TabIndex = 1;
            this.UsernameTextbox.TextChanged += new System.EventHandler(this.UsernameTextbox_TextChanged);
            this.UsernameTextbox.Enter += new System.EventHandler(this.UsernameTextbox_Enter);
            this.UsernameTextbox.Leave += new System.EventHandler(this.UsernameTextbox_Leave);
            // 
            // PasscodeTextbox
            // 
            this.PasscodeTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PasscodeTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasscodeTextbox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasscodeTextbox.ForeColor = System.Drawing.Color.Black;
            this.PasscodeTextbox.Location = new System.Drawing.Point(136, 62);
            this.PasscodeTextbox.Name = "PasscodeTextbox";
            this.PasscodeTextbox.Size = new System.Drawing.Size(306, 26);
            this.PasscodeTextbox.TabIndex = 3;
            this.PasscodeTextbox.TextChanged += new System.EventHandler(this.PasscodeTextbox_TextChanged);
            this.PasscodeTextbox.Enter += new System.EventHandler(this.PasscodeTextbox_Enter);
            this.PasscodeTextbox.Leave += new System.EventHandler(this.PasscodeTextbox_Leave);
            // 
            // PasscodeLabel
            // 
            this.PasscodeLabel.AutoSize = true;
            this.PasscodeLabel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasscodeLabel.ForeColor = System.Drawing.Color.White;
            this.PasscodeLabel.Location = new System.Drawing.Point(12, 60);
            this.PasscodeLabel.Name = "PasscodeLabel";
            this.PasscodeLabel.Size = new System.Drawing.Size(118, 24);
            this.PasscodeLabel.TabIndex = 2;
            this.PasscodeLabel.Text = "Passcode:";
            // 
            // CancelSetupButton
            // 
            this.CancelSetupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(20)))), ((int)(((byte)(0)))));
            this.CancelSetupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelSetupButton.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelSetupButton.ForeColor = System.Drawing.Color.White;
            this.CancelSetupButton.Image = global::Snek_Client.Properties.Resources.Cancel_Icon_Small;
            this.CancelSetupButton.Location = new System.Drawing.Point(216, 97);
            this.CancelSetupButton.Name = "CancelSetupButton";
            this.CancelSetupButton.Size = new System.Drawing.Size(110, 34);
            this.CancelSetupButton.TabIndex = 5;
            this.CancelSetupButton.Text = "  Cancel";
            this.CancelSetupButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelSetupButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CancelSetupButton.UseVisualStyleBackColor = false;
            this.CancelSetupButton.Click += new System.EventHandler(this.CancelSetupButton_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(255)))));
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.Image = global::Snek_Client.Properties.Resources.User_Add_Icon_Small;
            this.LoginButton.Location = new System.Drawing.Point(332, 97);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(110, 34);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "  Login";
            this.LoginButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoginButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // AliasSetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(124)))), ((int)(((byte)(178)))));
            this.ClientSize = new System.Drawing.Size(471, 144);
            this.Controls.Add(this.CancelSetupButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PasscodeTextbox);
            this.Controls.Add(this.PasscodeLabel);
            this.Controls.Add(this.UsernameTextbox);
            this.Controls.Add(this.UsernameLabel);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AliasSetupForm";
            this.Text = "Snek - User Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.TextBox UsernameTextbox;
        private System.Windows.Forms.TextBox PasscodeTextbox;
        private System.Windows.Forms.Label PasscodeLabel;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button CancelSetupButton;
    }
}