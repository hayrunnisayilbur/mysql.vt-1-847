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

namespace mysql.vt_1_847
{
    public partial class FormElestiri : Form
    {
        public FormElestiri()
        {
            InitializeComponent();
        }

        private void FormElestiri_Load(object sender, EventArgs e)
        {
            string baglantiMetin = "Server=localhost;Database=film_arsiv;Uid=root;Pwd=";

            using (MySqlConnection baglan = new MySqlConnection(baglantiMetin))
            {
                baglan.Open(); //veritabanı bağlantısı aç
                string sorgu = "SELECT * FROM elestiriler;"; //sorgumuz

                MySqlCommand cmd = new MySqlCommand(sorgu, baglan);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }
    }
}
