using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using LibreriaBD;

namespace ControlAulasVisual
{
    public partial class AsignarAula : Form
    {

        public AsignarAula()
        {
            InitializeComponent();

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AsignarAula_Load(object sender, EventArgs e)
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
                    cmbClaveMaestro.Items.Add(lector.GetValue(0).ToString());

                }
            }
            Conn.Close();

            string strCon2 = "Data Source=LAPTOP-SUAH9OKO\\SQL;Initial Catalog=ControlAulas;Integrated Security=True";
            SqlConnection Conn2 = UsoDB.ConectaBD(strCon2);
            if (Conn2 == null)
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

        private void btnAlta_Click(object sender, EventArgs e)
        {
            if (txtMateria.Text == "" || cmbClaveMaestro.Text == "" || CMBClaveAula.Text == "")
            {

                MessageBox.Show("Ingresa los datos faltantes", "Datos incompletos ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            string NombreMateria = txtMateria.Text;
            int ClaveMaestro = Convert.ToInt32(cmbClaveMaestro.SelectedItem.ToString());
            string ClaveAula = CMBClaveAula.SelectedItem.ToString();
            int Horario = Convert.ToInt32(NUDHora.Value);




            string strCon = "Data Source=LAPTOP-SUAH9OKO\\SQL;Initial Catalog=ControlAulas;Integrated Security=True";
            SqlConnection Conn = UsoDB.ConectaBD(strCon);
            if (Conn == null)
            {
                MessageBox.Show("Error al conectar");

            }
            else
            {
                string strCommandoSQL = "INSERT INTO MATERIA(NombreMateria,ClaveMaestro,ClaveAula,Horario)";
                strCommandoSQL += "VALUES(@NombreMateria,@ClaveMaestro,@ClaveAula,@Horario)";
                SqlCommand cmd = new SqlCommand(strCommandoSQL, Conn);
                cmd.Parameters.AddWithValue("@NombreMateria", NombreMateria);
                cmd.Parameters.AddWithValue("@ClaveMaestro", ClaveMaestro);
                cmd.Parameters.AddWithValue("@ClaveAula", ClaveAula);
                cmd.Parameters.AddWithValue("@Horario", Horario);

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

                MessageBox.Show("Asignacion completada", "Asignacion correcta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Conn.Close();

                string strCon2 = "Data Source=LAPTOP-SUAH9OKO\\SQL;Initial Catalog=ControlAulas;Integrated Security=True";
                SqlConnection Conn2 = UsoDB.ConectaBD(strCon2);
                if (Conn == null)
                {
                    MessageBox.Show("Error al conectar");

                }
                else
                {
                   // int asignada = 1;
                    string strCommandoSQL2 = "UPDATE AULA SET Asignada=1 Where AULA.ClaveAula='"+ClaveAula+"'";
                    MessageBox.Show(strCommandoSQL2);

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

                       
                        Conn2.Close();
                    
                   
                }

            }
        }
        public void LimpiarAsignacionAulas()
        {
            txtMateria.Clear();

        }

        private void cmbClaveMaestro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

    

        
       
     