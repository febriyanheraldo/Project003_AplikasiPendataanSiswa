namespace BelajarCrud
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btLogout = new System.Windows.Forms.Button();
            this.btNilai = new System.Windows.Forms.Button();
            this.btMapel = new System.Windows.Forms.Button();
            this.btGuru = new System.Windows.Forms.Button();
            this.btSiswa = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 128);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(338, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aplikasi Pendataan Nilai";
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(255, 128);
            this.panel4.TabIndex = 0;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PowderBlue;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.btNilai);
            this.panel2.Controls.Add(this.btMapel);
            this.panel2.Controls.Add(this.btGuru);
            this.panel2.Controls.Add(this.btSiswa);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 128);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(255, 522);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btLogout);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 443);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(255, 79);
            this.panel5.TabIndex = 5;
            // 
            // btLogout
            // 
            this.btLogout.BackColor = System.Drawing.Color.Coral;
            this.btLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogout.Location = new System.Drawing.Point(12, 9);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(237, 58);
            this.btLogout.TabIndex = 4;
            this.btLogout.Text = "Logout";
            this.btLogout.UseVisualStyleBackColor = false;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // btNilai
            // 
            this.btNilai.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btNilai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNilai.Location = new System.Drawing.Point(12, 285);
            this.btNilai.Name = "btNilai";
            this.btNilai.Size = new System.Drawing.Size(237, 58);
            this.btNilai.TabIndex = 3;
            this.btNilai.Text = "Nilai";
            this.btNilai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btNilai.UseVisualStyleBackColor = false;
            this.btNilai.Click += new System.EventHandler(this.btNilai_Click);
            // 
            // btMapel
            // 
            this.btMapel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btMapel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMapel.Location = new System.Drawing.Point(12, 206);
            this.btMapel.Name = "btMapel";
            this.btMapel.Size = new System.Drawing.Size(237, 58);
            this.btMapel.TabIndex = 2;
            this.btMapel.Text = "Mapel";
            this.btMapel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btMapel.UseVisualStyleBackColor = false;
            this.btMapel.Click += new System.EventHandler(this.btMapel_Click);
            // 
            // btGuru
            // 
            this.btGuru.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btGuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGuru.Location = new System.Drawing.Point(12, 129);
            this.btGuru.Name = "btGuru";
            this.btGuru.Size = new System.Drawing.Size(237, 58);
            this.btGuru.TabIndex = 1;
            this.btGuru.Text = "Guru";
            this.btGuru.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btGuru.UseVisualStyleBackColor = false;
            this.btGuru.Click += new System.EventHandler(this.btGuru_Click);
            // 
            // btSiswa
            // 
            this.btSiswa.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btSiswa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSiswa.Location = new System.Drawing.Point(12, 54);
            this.btSiswa.Name = "btSiswa";
            this.btSiswa.Size = new System.Drawing.Size(237, 58);
            this.btSiswa.TabIndex = 0;
            this.btSiswa.Text = "Siswa";
            this.btSiswa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSiswa.UseVisualStyleBackColor = false;
            this.btSiswa.Click += new System.EventHandler(this.btSiswa_Click);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(255, 128);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(745, 522);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard – Aplikasi Pendataan Nilai";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.Button btNilai;
        private System.Windows.Forms.Button btMapel;
        private System.Windows.Forms.Button btGuru;
        private System.Windows.Forms.Button btSiswa;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
    }
}