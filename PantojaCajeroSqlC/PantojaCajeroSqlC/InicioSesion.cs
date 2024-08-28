using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PantojaCajeroSqlC
{
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void UsuarioT_TextChanged(object sender, EventArgs e)
        {
            UsuarioT.MaxLength = 6;
            string currentText = UsuarioT.Text;


            for (int i = 0; i < currentText.Length; i++)
            {
                if (!char.IsDigit(currentText[i]))
                {
                    UsuarioT.Text = currentText.Remove(i, 1);

                    UsuarioT.SelectionStart = UsuarioT.Text.Length;
                    break;
                }

            }
        }

        private void ContraseñaT_TextChanged(object sender, EventArgs e)
        {
            ContraseñaT.MaxLength = 4;
            string currentText = ContraseñaT.Text;


            for (int i = 0; i < currentText.Length; i++)
            {
                if (!char.IsDigit(currentText[i]))
                {
                    ContraseñaT.Text = currentText.Remove(i, 1);

                    ContraseñaT.SelectionStart = ContraseñaT.Text.Length;
                    break;
                }

            }
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            Form1 cancelar = new Form1();
            cancelar.Show();
            this.Hide();
        }
    }
}
