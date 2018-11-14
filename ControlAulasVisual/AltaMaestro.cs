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
    public partial class AltaMaestro : Form
    {

        bool cambio = false;


        public AltaMaestro()
        {
            InitializeComponent();


        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AltaMaestro_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void txtNombreMaestro_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (cambio == false)
            {
                MessageBox.Show("Para continuar selecciona un nivel de formación", "Selecciona un nivel de formación ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpiar();
            }

        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreMaestro = txtNombreMaestro.Text.ToUpper();
                string domicilio = txtDomicilio.Text.ToUpper();
                string formacion = cmbFormacion.SelectedItem.ToString().ToUpper();

                if (txtDomicilio.Text == "" || txtNombreMaestro.Text == "" || cmbFormacion.Text == "")
                {
                    MessageBox.Show("Ingresa los datos faltantes", "Datos incompletos ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    string strCon = "Data Source=LAPTOP-SUAH9OKO\\SQL;Initial Catalog=ControlAulas;Integrated Security=True";
                    SqlConnection Conn = UsoDB.ConectaBD(strCon);
                    if (Conn == null)
                    {
                        MessageBox.Show("Error al conectar");

                    }
                    else
                    {
                        SqlCommand command = new SqlCommand();
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "dbo.VerificarNombreMaestro";
                        command.Connection = Conn;
                        command.Parameters.AddWithValue("@NombreMaestro", nombreMaestro);
                        SqlDataReader lector = null;
                        lector = command.ExecuteReader();
                        if (lector.HasRows)
                        {
                            MessageBox.Show("Error de claves");
                        }
                        else
                        {
                            string strCon2 = "Data Source=LAPTOP-SUAH9OKO\\SQL;Initial Catalog=ControlAulas;Integrated Security=True";
                            SqlConnection Conn2 = UsoDB.ConectaBD(strCon2);

                            string strCommandoSQL2 = "INSERT INTO Maestro(NombreMaestro,FormacionAcademica,Domicilio)";
                            strCommandoSQL2 += "VALUES(@NombreMaestro,@FormacionAcademica,@Domicilio)";
                            SqlCommand cmd = new SqlCommand(strCommandoSQL2, Conn2);
                            cmd.Parameters.AddWithValue("@NombreMaestro", nombreMaestro);
                            cmd.Parameters.AddWithValue("@FormacionAcademica", formacion);
                            cmd.Parameters.AddWithValue("@Domicilio", domicilio);



                            try
                            {
                                cmd.ExecuteNonQuery();
                            }
                            catch (SqlException ex)
                            {
                                MessageBox.Show(ex.Message);
                                limpiar();
                                return;

                            }

                            MessageBox.Show("El maestro se dio de alta", "Alta completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Conn.Close();
                        }
                    }
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Ingresa los datos faltantes", "Datos incompletos ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            limpiar();
        


        }
        private void cmbFormacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            cambio = true;
        }
        private void limpiar()
        {
            
            txtDomicilio.Clear();
            txtNombreMaestro.Clear();
        }
    }
}

    

       

