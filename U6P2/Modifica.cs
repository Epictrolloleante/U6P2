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
    public partial class Modifica : Form
    {
        string tabla;
        public Modifica(string id, string tabla)
        {
            InitializeComponent();
            //Debug.WriteLine("Tabs:"+tabControl1.TabPages.Count);
            tabControl1.TabPages.RemoveAt(0);
            tabControl1.TabPages.RemoveAt(0);
            tabControl1.TabPages.RemoveAt(0);
            this.tabla = tabla;
            ConexionMysql mysql = new ConexionMysql("obras");
            mysql.conectar();
            DataTable rs;
            switch (tabla)
            {
                case "asignacion":
                    id = "Id_trab= '" + id.Substring(0, id.IndexOf(',')) + "' AND Id_obra= '" + id.Substring(id.IndexOf(',')+1 , (id.Length- id.IndexOf(','))-1) + "'";
                    //Debug.WriteLine("id: " + id);
                    tabControl1.TabPages.Add(tabPage1);
                    rs = mysql.consultaIndividual(tabla, id);
                    try
                    {

                        Id_trabA.Text = rs.Rows[0][0] + "";
                        Id_obraA.Text = rs.Rows[0][1] + "";
                        Dias.Text = rs.Rows[0][2] + "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case "obra":
                    id = "Id_obra= '" + id + "'";
                    tabControl1.TabPages.Add(tabPage2);
                    rs = mysql.consultaIndividual(tabla, id);
                    try
                    {
                        Id_obra.Text = rs.Rows[0][0] + "";
                        Direccion.Text = rs.Rows[0][1] + "";
                        Tipo.Text = rs.Rows[0][2] + "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case "trabajador":
                    id = "Id_trab= '" + id + "'";
                    tabControl1.TabPages.Add(tabPage3);
                    rs = mysql.consultaIndividual(tabla, id);
                    try
                    {
                        Id_trab.Text = (rs.Rows[0][0] + "");
                        Nombre.Text = (rs.Rows[0][1] + "");
                        Sueldo.Text = (rs.Rows[0][2] + "");
                        DateTime date = DateTime.Parse(rs.Rows[0][3] + "");
                        Fecha.Value = date;



                        switch (rs.Rows[0][4] + "".ToUpper())
                        {
                            case "CARPINTERO":
                                Oficio.SelectedIndex = 0;
                                break;
                            case "FONTANERO":
                                Oficio.SelectedIndex = 1;
                                break;
                            case "HERRERO":
                                Oficio.SelectedIndex = 2;
                                break;
                            case "ELECTRICO":
                                Oficio.SelectedIndex = 3;
                                break;
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }
            mysql.desconectar();
        }

        private void ModificaI_Click(object sender, EventArgs e)
        {
            ConexionMysql mysql = new ConexionMysql("obras");
            mysql.conectar();
            String values = "";
            switch (tabla)
            {
                case "asignacion":
                    values += "Dias= '" + Dias.Text + "' ";
                    values += "WHERE Id_trab= '" + Id_trabA.Text + "' ";
                    values += "AND Id_obra= '" + Id_obraA.Text + "' ";

                    break;

                case "obra":
                    values += "Direccion= '" + Direccion.Text + "', ";
                    values += "Tipo= '" + Tipo.Text + "' ";
                    values += "WHERE Id_obra= '" + Id_obra.Text + "' ";
                    break;

                case "trabajador":
                    values += "Nombre= '" + Nombre.Text + "', ";
                    values += "Sueldo_hr= '" + Sueldo.Text + "', ";
                    DateTime storefecha = Fecha.Value;
                    int año = storefecha.Year;
                    int mes = storefecha.Month;
                    int dia = storefecha.Day;
                    string fecha2 = año + "/" + mes + "/" + dia;
                    values += "Fecha_ingreso= '" + fecha2 + "', ";
                    values += "Oficio= '" + Oficio.SelectedItem + "' ";
                    values += "WHERE Id_trab= '" + Id_trab.Text + "' ";
                    break;
            }
            Debug.WriteLine(values);
            if (mysql.modificar(tabla, values))
            {
                MessageBox.Show("Modificacion Exitosa", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Hubo un error en la Modificacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mysql.desconectar();
        }

        private void regresaI_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsultaFrame consultaFrame = new ConsultaFrame(tabControl1.SelectedTab.Text.ToLower());
            consultaFrame.Closed += (s, args) => this.Close();
            consultaFrame.Show();
        }
    }
}
