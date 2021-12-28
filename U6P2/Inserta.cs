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
                    if (Id_trabA.Text == "" || Id_obraA.Text == "")
                    {
                        MessageBox.Show("Id_Trab o Id_Obra no llenado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    values = Id_trabA.Text + ",'" + Id_obraA.Text + "'," + Dias.Text;
                    
                }
                if (tab == 1)
                {
                    if (Id_obra.Text == "")
                    {
                        MessageBox.Show("Id_Obra no llenado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    values = "'" + Id_obra.Text + "','" + Direccion.Text + "','" + Tipo.Text + "'";
                    
                }
                if (tab == 2)
                {
                    if (Id_trab.Text == "")
                    {
                        MessageBox.Show("Id_Trab no llenado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
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

        private void Id_trabA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                Console.Beep();
            }
            if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
                Console.Beep();
            }
            if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
                Console.Beep();
            }



            /*if(!((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8))
            {
                e.Handled = true;
                Console.Beep();
            }*/
        }

        private void Id_trabA_KeyUp(object sender, KeyEventArgs e)
        {
            if ("".Equals(Id_trabA.Text))
            {
                msg1.Text = "";
                Id_trabA.BackColor = Color.White;
            }
            else
            {
                int id = int.Parse(Id_trabA.Text);
                if (id >= 10 && id <= 5000)
                {
                    msg1.Text = "";
                    Id_trabA.BackColor = Color.White;
                }
                else
                {
                    msg1.Text = "Id_trab entre 10 y 5000";
                    Id_trabA.BackColor = Color.Red;
                }
                
            }
        }

        private void Id_obraA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Id_obraA.Text.Length >= 4)
            {
                if (!char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                    Console.Beep();
                }
            }
            if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
                Console.Beep();
            }
        }

        private void Id_obra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Id_obra.Text.Length >= 4)
            {
                if (!char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                    Console.Beep();
                }
            }
            if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
                Console.Beep();
            }
        }

        private void Dias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                Console.Beep();
            }
            if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
                Console.Beep();
            }
            if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
                Console.Beep();
            }
        }

        private void Id_trab_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                Console.Beep();
            }
            if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
                Console.Beep();
            }
            if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
                Console.Beep();
            }
        }

        private void Id_trab_KeyUp(object sender, KeyEventArgs e)
        {
            if ("".Equals(Id_trab.Text))
            {
                msg2.Text = "";
                Id_trab.BackColor = Color.White;
            }
            else
            {
                int id = int.Parse(Id_trab.Text);
                if (id >= 10 && id <= 5000)
                {
                    msg2.Text = "";
                    Id_trab.BackColor = Color.White;
                }
                else
                {
                    msg2.Text = "Id_trab entre 10 y 5000";
                    Id_trab.BackColor = Color.Red;
                }

            }
        }

        private void Sueldo_KeyUp(object sender, KeyEventArgs e)
        {
            if ("".Equals(Sueldo.Text))
            {
                msg3.Text = "";
                Sueldo.BackColor = Color.White;
            }
            else
            {
                double sd = double.Parse(Sueldo.Text);
                if (sd >= 2000 && sd <= 40000)
                {
                    msg3.Text = "";
                    Sueldo.BackColor = Color.White;
                }
                else
                {
                    msg3.Text = "Sueldo_hr entre 2000 y 40000";
                    Sueldo.BackColor = Color.Red;
                }

            }
        }

        private void Sueldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                Console.Beep();
            }
            if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
                Console.Beep();
            }
            if (char.IsPunctuation(e.KeyChar) && Sueldo.Text.IndexOf(".") != -1)
            {
                e.Handled = true;
                Console.Beep();
            }
        }

        private void Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                Console.Beep();
            }
            if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
                Console.Beep();
            }
        }
    }
}
