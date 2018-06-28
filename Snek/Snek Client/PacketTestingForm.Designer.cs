namespace Snek_Client
{
    partial class PacketTestingForm
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
            this.BoardCanvas = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BoardCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // BoardCanvas
            // 
            this.BoardCanvas.BackColor = System.Drawing.Color.Black;
            this.BoardCanvas.Location = new System.Drawing.Point(8, 47);
            this.BoardCanvas.Name = "BoardCanvas";
            this.BoardCanvas.Size = new System.Drawing.Size(768, 768);
            this.BoardCanvas.TabIndex = 0;
            this.BoardCanvas.TabStop = false;
            this.BoardCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.BoardCanvas_Paint);
            // 
            // PacketTestingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 820);
            this.Controls.Add(this.BoardCanvas);
            this.Name = "PacketTestingForm";
            this.Text = "PacketTestingForm";
            ((System.ComponentModel.ISupportInitialize)(this.BoardCanvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox BoardCanvas;
    }
}