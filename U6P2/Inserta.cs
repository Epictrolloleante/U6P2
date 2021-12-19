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
    public partial class Inserta : Form
    {
        private string values;
        private string[] tabla = { "asignacion", "obra", "trabajador" };
        ConexionMysql mysql;
        public Inserta(string tabla)
        {
            InitializeComponent();
            switch (tabla)
            {
                case "asignacion":
                    tabControl1.SelectedIndex = 0;
                    break;
                case "obra":
                    tabControl1.SelectedIndex = 1;
                    break;
                case "trabajador":
                    tabControl1.SelectedIndex = 2;
                    break;

            }

        }

        private void regresaI_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsultaFrame consultaFrame = new ConsultaFrame(tabControl1.SelectedTab.Text.ToLower());
            Debug.WriteLine(tabControl1.SelectedTab.Text.ToLower());
            consultaFrame.Closed += (s, args) => this.Close();
            consultaFrame.Show();
        }

        private void insertaI_Click(object sender, EventArgs e)
        {
            try
            {

                int tab = tabControl1.SelectedIndex;

                mysql = new ConexionMysql("obras");
                mysql.conectar();

                if (tab == 0)
                {
                    values = Id_trabA.Text + ",'" + Id_obraA.Text + "'," + Dias.Text;
                    
                }
                if (tab == 1)
                {
                    values = "'" + Id_obra.Text + "','" + Direccion.Text + "','" + Tipo.Text + "'";
                    
                }
                if (tab == 2)
                {
                    DateTime storefecha = Fecha.Value;
                    int año = storefecha.Year;
                    int mes = storefecha.Month;
                    int dia = storefecha.Day;
                    string fecha2 = año + "/" + mes + "/" + dia;
                    values = Id_trab.Text + ",'" + Nombre.Text + "'," + Sueldo.Text + ",'"
                            + fecha2 + "','" + Oficio.SelectedItem + "'";
                   
                }

                if (mysql.insertar(tabla[tab], values))
                {
                    MessageBox.Show("Insercion Exitosa", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Limpiar campos
                    Id_trabA.Text = "";
                    Id_obraA.Text = "";
                    Dias.Text = "";
                    Id_obra.Text = "";
                    Direccion.Text = "";
                    Tipo.Text = "";
                    Id_trab.Text = "";
                    Nombre.Text = "";
                    Sueldo.Text = "";
                    Fecha.Value = DateTime.Now;
                    Oficio.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Hubo un error en la insercion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                mysql.desconectar();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error: " + ex.Message);
                mysql.desconectar();
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
