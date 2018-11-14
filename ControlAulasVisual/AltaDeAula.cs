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
    public partial class AltaDeAula : Form
    {

        bool cambio = false;
        public AltaDeAula()
        {
            InitializeComponent();

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NUDNumeroAula_ValueChanged(object sender, EventArgs e)
        {
            if (cambio == false)
            {
                MessageBox.Show("Selecciona un aula", "Seleccione un aula para continuar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NUDNumeroAula.Value = 0;
                CMBEdificio.Focus();
            }
            else if (cambio == true)
            {
                string claveaula = NUDNumeroAula.Text.ToString();
                string edificio = CMBEdificio.SelectedItem.ToString();
                txtClaveAula.Text = String.Concat(edificio, claveaula);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            NUDNumeroAula.Value = 0;

            string edificio = CMBEdificio.SelectedItem.ToString();
            string claveaula = txtClaveAula.Text.ToString();
            txtClaveAula.Text = String.Concat(edificio, claveaula);

        }

        private void CMBEdificio_Click(object sender, EventArgs e)
        {
            cambio = true;
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {

            try
            {

                string claveAula = txtClaveAula.Text;

                int asignada = 0;
                char edificio = claveAula[1];
                string descripcion = txtDescripcion.Text;
                int cupo = Convert.ToInt32(NUDCupo.Value);
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
                    command.CommandText = "dbo.VerificarAula";
                    command.Connection = Conn;
                    command.Parameters.AddWithValue("@ClaveAula", claveAula);
                    SqlDataReader lector = null;
                    lector = command.ExecuteReader();
                    if (lector.HasRows)
                    {
                        MessageBox.Show("Error de claves");
                        lector.Close();
                    }
                    else
                    {
                        lector.Close();

                        string strCommandoSQL2 = "INSERT INTO Aula(ClaveAula,Descripcion,Edificio,Asignada)";
                        strCommandoSQL2 += "VALUES(@ClaveAula,@Descripcion,@Edificio,@Asignada)";
                        SqlCommand cmd = new SqlCommand(strCommandoSQL2, Conn);
                        cmd.Parameters.AddWithValue("@ClaveAula", claveAula);
                        cmd.Parameters.AddWithValue("@Descripcion", descripcion);
                        cmd.Parameters.AddWithValue("@Edificio", edificio);
                        cmd.Parameters.AddWithValue("@Asignada", asignada);

                        try
                        {
                            cmd.ExecuteNonQuery();
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show(ex.Message);
                            return;
                        }

                        MessageBox.Show("Aula dada de alta", "El aula se dio de alta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Conn.Close();
                    }


                }
            }

            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Ingresa los datos correctamente", "Datos erroneos o incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }
        private void Limpiar()
        {
            txtClaveAula.Clear();
            txtDescripcion.Clear();
            NUDCupo.Value = 1;
            NUDNumeroAula.Value = 0;
        }
        private void AltaDeAula_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}

    

      
       
