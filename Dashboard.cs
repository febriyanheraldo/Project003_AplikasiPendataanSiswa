using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BelajarCrud
{
    public partial class Dashboard : Form
    {
        public MySqlCommand cmd;
        public MySqlDataReader dr;
        public String id;
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btSiswa_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            panel3.Visible = false;
            Siswa FormAktif = new Siswa();

            FormAktif.MdiParent = this;
            FormAktif.Show();
            FormAktif.Dock = DockStyle.Fill;
            label1.Text = "Kelola Data Siswa";
        }

        private void btGuru_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            panel3.Visible = false;
            Guru FormAktif = new Guru();

            FormAktif.MdiParent = this;
            FormAktif.Show();
            FormAktif.Dock = DockStyle.Fill;
            label1.Text = "Kelola Data Guru";
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            panel3.Visible = true;
            label1.Text = "Aplikasi Pendataan Nilai";
        }

        private void btMapel_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            panel3.Visible = false;
            Mapel FormAktif = new Mapel();

            FormAktif.MdiParent = this;
            FormAktif.Show();
            FormAktif.Dock = DockStyle.Fill;
            label1.Text = "Kelola Data Mata Pelajaran";
        }

        private void btNilai_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            panel3.Visible = false;
            Nilai FormAktif = new Nilai();

            FormAktif.MdiParent = this;
            FormAktif.Show();
            FormAktif.Dock = DockStyle.Fill;
            label1.Text = "Kelola Data Nilai";
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
