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
    public partial class ConsultaPorMaestro : Form
    {
        
        public ConsultaPorMaestro()
        {
            InitializeComponent();
          
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConsultaPorMaestro_Load(object sender, EventArgs e)
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
                    cmbNombreMaestro.Items.Add(lector.GetValue(0).ToString());

                }
            }
            Conn.Close();
        }

        private void cmbNombreMaestro_SelectedIndexChanged(object sender, EventArgs e)
        {
            DGVConsultaXMaestro.Rows.Clear();
            int ClaveMaestro = Convert.ToInt32(cmbNombreMaestro.SelectedItem.ToString());

            string strCon = "Data Source=LAPTOP-SUAH9OKO\\SQL;Initial Catalog=ControlAulas;Integrated Security=True";
            SqlConnection Conn = UsoDB.ConectaBD(strCon);
            if (Conn == null)
            {
                MessageBox.Show("Error al conectar");

            }
            SqlDataReader lector = null;
            string strComando = "select NombreMAteria,ClaveAula,ClaveAula,Horario from MATERIA WHERE ClaveMaestro="+ClaveMaestro;
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
                 DGVConsultaXMaestro.Rows.Add(lector.GetValue(0).ToString(), lector.GetValue(1).ToString(), lector.GetValue(2).ToString(), lector.GetValue(3).ToString());

                }
            }
            Conn.Close();
        }
    }
}
