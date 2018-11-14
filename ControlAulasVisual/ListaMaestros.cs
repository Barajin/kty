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
    public partial class ListaMaestros : Form
    {
        
        public ListaMaestros()
        {
            InitializeComponent();
           
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListaMaestros_Load(object sender, EventArgs e)
        {
            string strCon = "Data Source=LAPTOP-SUAH9OKO\\SQL;Initial Catalog=ControlAulas;Integrated Security=True";
            SqlConnection Conn = UsoDB.ConectaBD(strCon);
            if (Conn == null)
            {
                MessageBox.Show("Error al conectar");

            }
            SqlDataReader lector = null;
            string strComando = "SELECT NombreMaestro,Domicilio,FormacionAcademica FROM Maestro";
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
                    DGVvistaMaestros.Rows.Add(lector.GetValue(0).ToString(), lector.GetValue(1).ToString(), lector.GetValue(2).ToString());
                }
            }
            Conn.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
