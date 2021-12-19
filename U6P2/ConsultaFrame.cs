using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        string defaulttab;
        public ConsultaFrame()
        {
            InitializeComponent();
            inicializar();
        }

        public ConsultaFrame(string tab) {
            InitializeComponent();
            inicializar();
            comboBox1.SelectedValue = tab;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mi rodilla shonen");
        }

        public void inicializar() {
            mysql.conectar();
            //Construir ComboBox
            comboBox1.DataSource = mysql.construirComboBox();
            comboBox1.DisplayMember = "tablename";
            comboBox1.ValueMember = "tablename";
            //Construir Tabla
            actualizartabla();
            //Modo de autosize
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoResizeColumns();
            //Mensaje de label1
            label1.Text = "BASE DE DATOS: \"" + mysql.getBasedatos()+"\"";
            mysql.desconectar();
            


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizartabla();
        }

        private void insertar_Click(object sender, EventArgs e)
        {
            string cadena = comboBox1.SelectedValue + "";
            Inserta inserta = new Inserta(cadena);
            this.Hide();
            inserta.Closed += (s, args) => this.Close();
            inserta.Show();

            



        }

        private void modificar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows == null)
            {
                MessageBox.Show("SELECCIONE UN REGISTRO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                string id;
                if (comboBox1.SelectedValue.ToString().Equals("asignacion"))
                {
                    id = dataGridView1.SelectedRows[0].Cells[0].Value + "";
                    id += "," + dataGridView1.SelectedRows[0].Cells[1].Value + ""; ;
                }
                else
                {
                    id = dataGridView1.SelectedRows[0].Cells[0].Value + ""; ;
                }
                string tabla = comboBox1.SelectedValue+"";
            Modifica modifica = new Modifica(id,tabla);
            this.Hide();
                modifica.Closed += (s, args) => this.Close();
                modifica.Show();
            }
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows == null) {
                MessageBox.Show("SELECCIONE UN REGISTRO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string tabla = comboBox1.SelectedValue + "";
                string condicion = "";

                switch (tabla)
                {
                    case "asignacion":
                        condicion = "Id_trab=\'" + dataGridView1.SelectedRows[0].Cells[0].Value
                            + "\' AND id_obra=\'" + dataGridView1.SelectedRows[0].Cells[1].Value + "\'";
                        break;
                    case "obra":
                        condicion = "id_obra=\'" + dataGridView1.SelectedRows[0].Cells[0].Value + "\'";
                        break;
                    case "trabajador":
                        condicion = "Id_trab=\'" + dataGridView1.SelectedRows[0].Cells[0].Value + "\'";
                        break;
                }
                mysql.conectar();
                if (mysql.eliminar(tabla, condicion))
                {
                    MessageBox.Show("Eliminacion Exitosa", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Hubo un error en la eliminacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                mysql.desconectar();
                actualizartabla();
            }
        }

        public void actualizartabla() {
            //Actualizar tabla
            mysql.conectar();
            string s = comboBox1.SelectedValue + "";
            dataGridView1.DataSource = mysql.consultar(s);
            Debug.WriteLine(dataGridView1.Columns.Count);
            mysql.desconectar();
            //dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
        }
    }
}
