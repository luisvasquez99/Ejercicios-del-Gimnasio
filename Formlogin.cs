using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejecicios_del_Gym
{
    public partial class formlogin : Form
    {
        public formlogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Tbxusuario_TextChanged(object sender, EventArgs e)
        { }

        private void Tbxusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {
                    MessageBox.Show("Unicamente letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;

                }

            }
        }

        private void tbxcontra_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (e.KeyChar >= 123 && e.KeyChar <= 255)
                {

                    return;
                }
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            {
                Tbxusuario.Text = Convert.ToString("");
                tbxcontra.Text = Convert.ToString("");
            }
        }

        private void btncontinuar_Click(object sender, EventArgs e)
        {
            {

                if (Tbxusuario.Text == "Admin" && tbxcontra.Text == "Admin10")
                {
                    Formstar form1 = new Formstar();
                    this.Hide();
                    form1.Show();

                }
            }
        }

        private void pbocultar_Click(object sender, EventArgs e)
        {
            {
                pbocultar.BringToFront();
                tbxcontra.PasswordChar = '\0';
            }
        }

        private void pbmostrar_Click(object sender, EventArgs e)
        {
            {
                pbmostrar.BringToFront();
                tbxcontra.PasswordChar = '*';
            }
        }
    }
    
        }
    

