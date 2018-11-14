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
    public partial class BajaAsignacion : Form
    {

        public BajaAsignacion()
        {
            InitializeComponent();
           
        }

        private void BTNBorrar_Click(object sender, EventArgs e)
        {
            string strCon = "Data Source=LAPTOP-SUAH9OKO\\SQL;Initial Catalog=ControlAulas;Integrated Security=True";
            SqlConnection Conn = UsoDB.ConectaBD(strCon);
            if (Conn == null)
            {
                MessageBox.Show("Error al conectar");

            }
            SqlDataReader lector = null;
            string strComando = "DELETE  FROM AULA WHERE Asignada=0";
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
                    DGVBorrar.Rows.Add(lector.GetValue(0).ToString());
                }
            }
            Conn.Close();
        }

        private void BajaAsignacion_Load(object sender, EventArgs e)
        {
            string strCon = "Data Source=LAPTOP-SUAH9OKO\\SQL;Initial Catalog=ControlAulas;Integrated Security=True";
            SqlConnection Conn = UsoDB.ConectaBD(strCon);
            if (Conn == null)
            {
                MessageBox.Show("Error al conectar");

            }
            SqlDataReader lector = null;
            string strComando = "Select ClaveAula  FROM AULA WHERE Asignada=0";
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
                    DGVBorrar.Rows.Add(lector.GetValue(0).ToString());
                }
            }
            Conn.Close();

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
