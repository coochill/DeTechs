namespace FEnd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.navbar = new System.Windows.Forms.FlowLayoutPanel();
            this.lpn = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Weatherbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.navbar.SuspendLayout();
            this.lpn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // navbar
            // 
            this.navbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(55)))), ((int)(((byte)(87)))));
            this.navbar.Controls.Add(this.lpn);
            this.navbar.Controls.Add(this.Weatherbtn);
            this.navbar.Controls.Add(this.button1);
            this.navbar.Controls.Add(this.button2);
            this.navbar.Dock = System.Windows.Forms.DockStyle.Left;
            this.navbar.Location = new System.Drawing.Point(0, 0);
            this.navbar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.navbar.Name = "navbar";
            this.navbar.Size = new System.Drawing.Size(269, 655);
            this.navbar.TabIndex = 20;
            // 
            // lpn
            // 
            this.lpn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(55)))), ((int)(((byte)(87)))));
            this.lpn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lpn.Controls.Add(this.pictureBox1);
            this.lpn.Location = new System.Drawing.Point(3, 2);
            this.lpn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lpn.Name = "lpn";
            this.lpn.Size = new System.Drawing.Size(271, 219);
            this.lpn.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Weatherbtn
            // 
            this.Weatherbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(55)))), ((int)(((byte)(87)))));
            this.Weatherbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Weatherbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Weatherbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Weatherbtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Weatherbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Weatherbtn.Image = ((System.Drawing.Image)(resources.GetObject("Weatherbtn.Image")));
            this.Weatherbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Weatherbtn.Location = new System.Drawing.Point(0, 223);
            this.Weatherbtn.Margin = new System.Windows.Forms.Padding(0);
            this.Weatherbtn.Name = "Weatherbtn";
            this.Weatherbtn.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.Weatherbtn.Size = new System.Drawing.Size(272, 66);
            this.Weatherbtn.TabIndex = 1;
            this.Weatherbtn.Text = "                 WEATHER \r\n                 FORECAST\r\n";
            this.Weatherbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Weatherbtn.UseVisualStyleBackColor = false;
            this.Weatherbtn.Click += new System.EventHandler(this.Weatherbtn_Click);
            // 
            // button1
            // 
            this.button1.AccessibleDescription = "";
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(55)))), ((int)(((byte)(87)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 289);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(272, 92);
            this.button1.TabIndex = 2;
            this.button1.Text = "                 EARTHQUAKE\r\n                 AND FIRE\r\n                 DETECTOR" +
    "\r\n";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseMnemonic = false;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AccessibleDescription = "";
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(55)))), ((int)(((byte)(87)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 381);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(272, 92);
            this.button2.TabIndex = 3;
            this.button2.Text = "                 \r\n                  EXIT\r\n\r\n";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseMnemonic = false;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(268, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1105, 655);
            this.panel1.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 655);
            this.Controls.Add(this.navbar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.navbar.ResumeLayout(false);
            this.lpn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel navbar;
        private System.Windows.Forms.Button Weatherbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel lpn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
    }
}

