using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mysql.vt_1_847
{
    public partial class Form1 : Form
    {
        string baglantiMetin = "Server=localhost;Database=film_arsiv;Uid=root;Pwd=";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (MySqlConnection baglan = new MySqlConnection(baglantiMetin))
            {
                baglan.Open(); //veritabanı bağlantısı aç
                string sorgu = "SELECT * FROM filmler;"; //sorgumuz

                MySqlCommand cmd = new MySqlCommand(sorgu, baglan);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgw.DataSource = dt;
            }
        }

        private void btnElestiriForm_Click(object sender, EventArgs e)
        {
            FormElestiri formElestiri = new FormElestiri();
            formElestiri.ShowDialog();
        }

        private void btnFilmElestiri_Click(object sender, EventArgs e)
        {
            FormFilmElestiri formFilmElestiri = new FormFilmElestiri();
            formFilmElestiri.ShowDialog();
        }
    }
}