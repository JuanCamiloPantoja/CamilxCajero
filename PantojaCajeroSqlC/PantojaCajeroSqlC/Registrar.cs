using PantojaCajeroSqlC.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PantojaCajeroSqlC
{
    public partial class Registrar : Form
    {
        public Registrar()
        {
            InitializeComponent();
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            Form1 cancelar = new Form1();
            cancelar.Show();
            this.Hide();
        }

        private void NumDocuT_TextChanged(object sender, EventArgs e)
        {
            NumDocuT.MaxLength = 10;
            string currentText = NumDocuT.Text;


            for (int i = 0; i < currentText.Length; i++)
            {
                if (!char.IsDigit(currentText[i]))
                {
                    NumDocuT.Text = currentText.Remove(i, 1);

                    NumDocuT.SelectionStart = NumDocuT.Text.Length;
                    break;
                }

            }
        }

        private void ClaveT_TextChanged(object sender, EventArgs e)
        {
            ClaveT.MaxLength = 4;
            string currentText = ClaveT.Text;


            for (int i = 0; i < currentText.Length; i++)
            {
                if (!char.IsDigit(currentText[i]))
                {
                    ClaveT.Text = currentText.Remove(i, 1);

                    ClaveT.SelectionStart = ClaveT.Text.Length;
                    break;
                }

            }
        }

        private void EdadT_TextChanged(object sender, EventArgs e)
        {
            EdadT.MaxLength = 3;
            string currentText = EdadT.Text;


            for (int i = 0; i < currentText.Length; i++)
            {
                if (!char.IsDigit(currentText[i]))
                {
                    EdadT.Text = currentText.Remove(i, 1);

                    EdadT.SelectionStart = EdadT.Text.Length;
                    break;
                }

            }
        }

        private void BtGuardar_Click(object sender, EventArgs e)
        {
            Form1 guardar = new Form1();
            guardar.Show();
            this.Hide();

            try
            {
                SqlConnection Conexion = new SqlConnection("Server=CAMILO\\SQLEXPRESS;Database=CajeroCAM;persist security info=True; Integrated security=True");
                SqlCommand Realiza = new SqlCommand();
                Realiza.Connection = Conexion;
                Usuario usuario = new Usuario();
                usuario.Nombre = NombreT.Text;
                usuario.Apellido = ApellidpT.Text;
                usuario.Edad = int.Parse(EdadT.Text);
                usuario.TipDocumento = TipDocu.Text;
                usuario.Documento = int.Parse(NumDocuT.Text);
                usuario.Clave = int.Parse(ClaveT.Text);
                Realiza.CommandText = "insert into Registrar (Nombre,Apellido,Edad,TipDocumento,Documento,Clave) values(@Nombre,@Apellido,@Edad,@TipDocumento,@Documento,@Clave)";
                Realiza.CommandType = System.Data.CommandType.Text;
                Realiza.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                Realiza.Parameters.AddWithValue("@Apellido", usuario.Apellido);
                Realiza.Parameters.AddWithValue("@Edad", usuario.Edad);
                Realiza.Parameters.AddWithValue("@TipDocumento", usuario.TipDocumento);
                Realiza.Parameters.AddWithValue("@Documento", usuario.Documento);
                Realiza.Parameters.AddWithValue("@Clave", usuario.Clave);
                Conexion.Open();
                Realiza.ExecuteNonQuery();
                string cadena = "select top 1 * from Registrar order by NumCuenta desc";
                SqlCommand comando = new SqlCommand(cadena, Conexion);
                SqlDataReader registros = comando.ExecuteReader();
                if (registros.Read())
                {

                    string numeroDeCuenta = registros["NumCuenta"].ToString();
                    MessageBox.Show($"Su número de cuenta es {numeroDeCuenta}", "Número de Cuenta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se encontraron registros.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Conexion.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

    }
}

