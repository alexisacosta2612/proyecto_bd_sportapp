using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Runtime.Intrinsics.Arm;
using Mysqlx.Crud;
using Microsoft.VisualBasic;
namespace proyecto__
{
    public class AdmonBD
    {

        public MySqlConnection connection;

        public AdmonBD()
        {
            this.Connect();
        }
        public void Disconnect()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
                MessageBox.Show("Conexión cerrada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public List<usuarios> consulta()
        {
            List<usuarios> data = new List<usuarios>();
            usuarios item;
            int id;
            string name;
            string cuenta;
            string contraseña;
            int monto;
            try
            {
                string query = "SELECT * FROM usuarios";
                MySqlCommand command = new MySqlCommand(query, this.connection);

                // Ejecutar la consulta y leer los resultados
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    // Ejemplo: mostrar los datos de las columnas
                    id = Convert.ToInt32(reader["id"]);
                    name = Convert.ToString(reader["name"]) ?? "";
                    cuenta = Convert.ToString(reader["cuenta"]) ?? "";
                    contraseña = Convert.ToString(reader["contraseña"]) ?? "";
                    monto = Convert.ToInt32(reader["monto"]);


                    item = new usuarios(id, name, cuenta,contraseña, monto);
                    data.Add(item);

                }
                reader.Close();
                data.ForEach((p) =>
                {
                    //MessageBox.Show(p.Id + "," + p.Producto + "," + p.Imagen + "," + p.Precio);

                });

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer la tabla de la base de datos: " + ex.Message);
                this.Disconnect();
            }
            return data;
        }
        public usuarios const_reguser(int idp)
        {
            usuarios item = null;
            int id;
            string name;
            string cuenta;
            string contraseña;
                int monto;
            try
            {
                string query = "SELECT * FROM usuarios where id=" + idp + ";";
                MySqlCommand command = new MySqlCommand(query, this.connection);
                // Ejecutar la consulta y leer los resultados
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())  //solo encontrara un registro da una vuelta
                {
                    id = Convert.ToInt32(reader["id"]);
                    name = Convert.ToString(reader["name"]) ?? "";
                    cuenta = Convert.ToString(reader["cuenta"]) ?? "";
                    contraseña = Convert.ToString(reader["contraseña"]) ?? "";
                    monto = Convert.ToInt32(reader["monto"]);

                    item = new usuarios(id, name, cuenta, contraseña, monto);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer la tabla de la base de usuarios: " + ex.Message);
                this.Disconnect();
            }
            return item;
           

        }
       /* public void valid_accs(int idp, string password)
        {
            usuarios user = const_reguser(idp);
            if (user != null)
            {
                if (user.Contraseña == password)
                {
                    MessageBox.Show("Acceso concedido");
                    Form3 f3 = new Form3();
                    this.Hide();
                    f3.ShowDialog();
                    this.Show();
                }
            }
        }*/


        public void Connect()
        {
            string cadena = "Server=localhost; Database=registros; User=root; Password=; SslMode=none;";
            try
            {
                connection = new MySqlConnection(cadena);
                connection.Open();
                MessageBox.Show("Conexión establecida exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar con la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
