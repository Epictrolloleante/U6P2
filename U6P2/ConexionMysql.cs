using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace U6P2
{
    internal class ConexionMysql
    {
        string usuario = "postgres",
            contraseña = "root",
            host = "localhost",
            port = "5432",
            basedatos = "";
        NpgsqlConnection con;

        public ConexionMysql(string bd)
        {
            basedatos = bd;
        }

        public string getBasedatos()
        {
            return basedatos;
        }

        public void conectar()
        {
            try
            {
                Debug.WriteLine("Conexion a la BD");
                string cadenaConexion = "Server=" + host + ";Port=" + port + ";User Id=" + usuario
                    + ";Password=" + contraseña + ";Database=" + basedatos + ";";
                con = new NpgsqlConnection(cadenaConexion);
                con.Open();
                Debug.WriteLine("Conexion exitosa");
            }
            catch (Exception e)
            {
                Debug.WriteLine("Ha ocurrido la sig excepcion: " + e.Message);
                con.Close();
            }

        }

        public void desconectar()
        {
            try
            {
                con.Close();
                Debug.WriteLine("Desconectado de la BD");
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Ha ocurrido la sig excepcion: " + ex.Message);
            }
        }

        public DataTable consultar(string tabla)
        {
            try
            {
                string query = "SELECT * FROM \"" + tabla + "\" ;";
                NpgsqlCommand conector = new NpgsqlCommand(query, con);
                NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
                DataTable tablad = new DataTable();
                datos.Fill(tablad);
                return tablad;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Ha ocurrido la sig excepcion: " + ex.Message);
                return null;
            }
        }

        public DataTable consultaIndividual(string tabla,string id)
        {
            try
            {
                string query = "SELECT * FROM \"" + tabla + "\" " +"WHERE " + id +  ";";
                NpgsqlCommand conector = new NpgsqlCommand(query, con);
                NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
                DataTable tablad = new DataTable();
                datos.Fill(tablad);
                return tablad;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Ha ocurrido la sig excepcion: " + ex.Message);
                return null;
            }
        }
        public DataTable construirComboBox()
        {
            try
            {
                string query = "SELECT tablename FROM pg_tables WHERE schemaname = 'public' ORDER BY tablename ASC;";
                NpgsqlCommand conector = new NpgsqlCommand(query, con);
                NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
                DataTable tablad = new DataTable();

                datos.Fill(tablad);
                return tablad;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Ha ocurrido la sig excepcion: " + ex.Message);
                return null;
            }

        }

        public bool insertar(string tabla, string values)
        {
            try
            {

                string query = "INSERT INTO " + tabla + " VALUES(" + values + ");";
                NpgsqlCommand comando = new NpgsqlCommand(query, con);
                Debug.WriteLine(query);
                comando.ExecuteNonQuery();
                Debug.WriteLine("Insercion Exitosa");
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool modificar(string tabla, string values)
        {
            try
            {
                string query = "UPDATE " + tabla + " SET " + values + ";";
                NpgsqlCommand comando = new NpgsqlCommand(query, con);
                Debug.WriteLine(query);
                comando.ExecuteNonQuery();
                Debug.WriteLine("Modificacion Exitosa");
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool eliminar(string tabla, string condicion)
        {
            try
            {

                string query = "DELETE FROM " + tabla + " WHERE " + condicion + ";";
                NpgsqlCommand comando = new NpgsqlCommand(query, con);
                Debug.WriteLine(query);
                comando.ExecuteNonQuery();
                Debug.WriteLine("Eliminacion Exitosa");
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Error: "+ ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        /*
        public ResultSet consultaIndividual(string tabla, string id)
        {
            try
            {
                ResultSet rs;
                Statement stmt = (Statement)con.createStatement();
                string query = "SELECT * FROM " + tabla + " WHERE " + id + ";";
                rs = stmt.executeQuery(query);
                return rs;
            }
            catch (SQLException ex)
            {
                Logger.getLogger(ConexionMysql.class.getName()).log(Level.SEVERE, null, ex);
        return null;
                }
            }


                

        






        */


    }
}
