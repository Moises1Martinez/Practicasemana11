using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Practicasemana11
{
    public partial class Fmtest : Form
    {
        public Fmtest()
        {
            InitializeComponent();
        }

        private void btntest_Click(object sender, EventArgs e)
        {
            string connectionString = "";
            MySqlConnection conn;

            try
            {
                connectionString = @"Server=Localhost;Database=smis071221;
                                    Uid=root;Pwd=usbw;SSL Mode=None";
                conn = new MySqlConnection(connectionString);
                conn.Open();
                //MessageBox.Show("Se establecio conexion a la base datos");
                MetroFramework.MetroMessageBox.Show(this, "CONEXION EXITOSA", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
            catch (Exception Ex)
            {

                //MessageBox.Show(Ex.Message);
                MetroFramework.MetroMessageBox.Show(this, Ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
