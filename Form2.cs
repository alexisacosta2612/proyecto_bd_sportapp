using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto__
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }



        private void buttonlogin_Click(object sender, EventArgs e)
        {
            AdmonBD obj = new AdmonBD();

            string cuenta = textBoxcuenta.Text; // Campo de cuenta
            string contraseña = textBoxcontraseña.Text; // Campo de contraseña

            try
            {
                string query = $"SELECT * FROM usuarios WHERE cuenta = '{cuenta}' AND contraseña = '{contraseña}'";
                MySqlCommand command = new MySqlCommand(query, obj.connection);
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows) // Si se encuentra al menos un registro
                {
                    reader.Close();
                    Form3 form3 = new Form3();
                    form3.Show(); // Mostrar Form3
                    this.Hide(); // Ocultar este formulario
                }
                else
                {
                    reader.Close();
                    MessageBox.Show("Cuenta o contraseña incorrecta.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al validar usuario: " + ex.Message);
            }
            finally
            {
                obj.Disconnect();
            }
        }
    }
       
}
