using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaBD;
using System.Data.SqlClient;

namespace ControlAulasVisual
{
    public partial class Modificaciones : Form
    {
        bool cambios=false;
        bool cambios2 = false;
        
        public Modificaciones()
        {
            InitializeComponent();
           
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Modificaciones_Load(object sender, EventArgs e)
        {
            string strCon = "Data Source=LAPTOP-SUAH9OKO\\SQL;Initial Catalog=ControlAulas;Integrated Security=True";
            SqlConnection Conn = UsoDB.ConectaBD(strCon);
            if (Conn == null)
            {
                MessageBox.Show("Error al conectar");

            }
            SqlDataReader lector = null;
            string strComando = "SELECT ClaveMaestro FROM Maestro";
            SqlCommand cmd = new SqlCommand(strComando, Conn);
            try
            {
                lector = cmd.ExecuteReader();
            }
            catch
            {
                MessageBox.Show("Error consulta");
            }
            if (lector.HasRows)
            {

                while (lector.Read())
                {
                    CMBClaveMaestro.Items.Add(lector.GetValue(0).ToString());

                }
            }
            Conn.Close();

            string strCon2 = "Data Source=LAPTOP-SUAH9OKO\\SQL;Initial Catalog=ControlAulas;Integrated Security=True";
            SqlConnection Conn2 = UsoDB.ConectaBD(strCon2);
            if (Conn == null)
            {
                MessageBox.Show("Error al conectar");

            }
            SqlDataReader lector2 = null;
            string strComando2 = "SELECT ClaveAula FROM AULA ";
            SqlCommand cmd2 = new SqlCommand(strComando2, Conn2);
            try
            {
                lector2 = cmd2.ExecuteReader();
            }
            catch
            {
                MessageBox.Show("Error consulta");
            }
            if (lector2.HasRows)
            {

                while (lector2.Read())
                {
                    CMBClaveAula.Items.Add(lector2.GetValue(0).ToString());

                }
            }
            Conn.Close();
        }

        private void txtHorario_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (cambios == false || cambios2 == false)
            {
                MessageBox.Show("Selecciona un registro a modificar", "Selecciona los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string claveAula = CMBClaveAula.Text;
                string claveMaestro = CMBClaveMaestro.Text;

                string strCon2 = "Data Source=LAPTOP-SUAH9OKO\\SQL;Initial Catalog=ControlAulas;Integrated Security=True";
                SqlConnection Conn2 = UsoDB.ConectaBD(strCon2);
                if (Conn2 == null)
                {
                    MessageBox.Show("Error al conectar");

                }
                else
                {
                    
                    int  horario = 0;
                    string strCommandoSQL2 = "UPDATE MATERIA SET Horario=" + horario;
                    strCommandoSQL2 += "Where ClaveMaestro=" + claveMaestro+ "AND ClaveAula='" + claveAula + "'";

                    SqlCommand cmd2 = new SqlCommand(strCommandoSQL2, Conn2);
                 



                    try
                    {
                        cmd2.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                    MessageBox.Show("Cambios Correctos", "Cambios Correctos", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    Conn2.Close();
                }
            }
        }

        private void CMBClaveAula_SelectedIndexChanged(object sender, EventArgs e)
        {
            cambios2 = true;
        }

        private void CMBClaveMaestro_SelectedIndexChanged(object sender, EventArgs e)
        {
            cambios = true;
        }

        private void lblClaveMaestro_Click(object sender, EventArgs e)
        {

        }
    }
}





























