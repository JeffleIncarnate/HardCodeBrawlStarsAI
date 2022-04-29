namespace HardCodeBrawlStarsAI
{
    partial class Form1
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
            this.scrcpy = new System.Windows.Forms.Button();
            this.capture = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // scrcpy
            // 
            this.scrcpy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.scrcpy.Location = new System.Drawing.Point(23, 21);
            this.scrcpy.Name = "scrcpy";
            this.scrcpy.Size = new System.Drawing.Size(113, 46);
            this.scrcpy.TabIndex = 0;
            this.scrcpy.Text = "Start Scrcpy";
            this.scrcpy.UseVisualStyleBackColor = true;
            this.scrcpy.Click += new System.EventHandler(this.scrcpy_Click);
            // 
            // capture
            // 
            this.capture.Location = new System.Drawing.Point(160, 21);
            this.capture.Name = "capture";
            this.capture.Size = new System.Drawing.Size(135, 46);
            this.capture.TabIndex = 1;
            this.capture.Text = "Capture Screen";
            this.capture.UseVisualStyleBackColor = true;
            this.capture.Click += new System.EventHandler(this.capture_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(365, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1338, 682);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1715, 743);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.capture);
            this.Controls.Add(this.scrcpy);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button scrcpy;
        private System.Windows.Forms.Button capture;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

