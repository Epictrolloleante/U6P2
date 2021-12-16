using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U6P2
{
    public partial class ConsultaFrame : Form
    {
        ConexionMysql mysql = new ConexionMysql("obras");
        public ConsultaFrame()
        {
            InitializeComponent();
            inicializar();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mi rodilla shonen");
        }

        public void inicializar() {
            mysql.conectar();
            comboBox1.DataSource = mysql.construirComboBox();
            comboBox1.DisplayMember = "tablename";
            comboBox1.ValueMember = "tablename";
            string s= comboBox1.SelectedValue+"";
            dataGridView1.DataSource = mysql.consultar(s);
            label1.Text = "BASE DE DATOS: \"" + mysql.getBasedatos()+"\"";
            mysql.desconectar();
            


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            mysql.conectar();
            string s = comboBox1.SelectedValue + "";
            dataGridView1.DataSource = mysql.consultar(s);
            mysql.desconectar();
        }
    }
}
