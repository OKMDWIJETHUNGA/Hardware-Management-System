namespace Hardware_System
{
    partial class ForgotPassword
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UNameTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NewpasswordTb = new System.Windows.Forms.TextBox();
            this.RestBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.conformTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 562);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(438, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Hardware System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(427, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Username";
            // 
            // UNameTb
            // 
            this.UNameTb.Location = new System.Drawing.Point(326, 249);
            this.UNameTb.Name = "UNameTb";
            this.UNameTb.Size = new System.Drawing.Size(374, 32);
            this.UNameTb.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "New Password";
            // 
            // NewpasswordTb
            // 
            this.NewpasswordTb.Location = new System.Drawing.Point(326, 353);
            this.NewpasswordTb.Name = "NewpasswordTb";
            this.NewpasswordTb.Size = new System.Drawing.Size(374, 32);
            this.NewpasswordTb.TabIndex = 15;
            // 
            // RestBtn
            // 
            this.RestBtn.BackColor = System.Drawing.Color.DarkBlue;
            this.RestBtn.FlatAppearance.BorderSize = 0;
            this.RestBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RestBtn.ForeColor = System.Drawing.Color.White;
            this.RestBtn.Location = new System.Drawing.Point(430, 511);
            this.RestBtn.Name = "RestBtn";
            this.RestBtn.Size = new System.Drawing.Size(186, 39);
            this.RestBtn.TabIndex = 16;
            this.RestBtn.Text = "Reset Password";
            this.RestBtn.UseVisualStyleBackColor = false;
            this.RestBtn.Click += new System.EventHandler(this.RestBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.Red;
            this.BackBtn.ForeColor = System.Drawing.Color.White;
            this.BackBtn.Location = new System.Drawing.Point(782, 12);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(40, 40);
            this.BackBtn.TabIndex = 20;
            this.BackBtn.Text = "X";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // conformTb
            // 
            this.conformTb.Location = new System.Drawing.Point(326, 453);
            this.conformTb.Name = "conformTb";
            this.conformTb.Size = new System.Drawing.Size(374, 32);
            this.conformTb.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(321, 412);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "conform Password";
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 15;
            this.gunaElipse1.TargetControl = this;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(736, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 38;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(834, 562);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.conformTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.RestBtn);
            this.Controls.Add(this.NewpasswordTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UNameTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgotPassword";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RestBtn;
        private System.Windows.Forms.TextBox NewpasswordTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UNameTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.TextBox conformTb;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.Button button1;

    }
}