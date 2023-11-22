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
    public partial class Formadmin : Form
    {
        public Formadmin()
        {
            InitializeComponent();
        }
        private void btnMouseEnter(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            foreach (Control ctr in panel_login.Controls)
            {
                if (ctr is Button)
                {
                    bt.ForeColor = Color.Black;
                }
            }



        }
        private void btnMouseLeave(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            foreach (Control ctr in panel_login.Controls)
            {
                if (ctr is Button)
                {
                    bt.ForeColor = Color.Black;
                }
            }
        }
        private void txtEnter(object sender, EventArgs e)
        {
            TextBox tx = sender as TextBox;
            foreach (Control ctr in panel_registroo.Controls)
            {
                if (ctr is Panel && ctr.Name == "panel" + tx.Tag.ToString())
                {
                    ctr.BackColor = Color.White;
                }
            }
        }
        private void txtLeave(object sender, EventArgs e)
        {
            TextBox tx = sender as TextBox;
            foreach (Control ctr in panel_registroo.Controls)
            {
                if (ctr is Panel && ctr.Name == "panel" + tx.Tag.ToString())
                {
                    ctr.BackColor = Color.Black;
                }
            }
        }
        private bool controlTimer = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!controlTimer)
            {
                panel_contenedor.Left += 10;
                panel_registroo.BringToFront();
                if (panel_contenedor.Left == 400)
                {
                    timer1.Stop();
                    controlTimer = true;
                }
            }
            else
            {
                panel_contenedor.Left -= 10;
                panel_inicio.BringToFront();
                if (panel_contenedor.Left == 0)
                {
                    timer1.Stop();
                    controlTimer = false;
                }
            }
        }

        private void btnregistro_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnacceder_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void Formadmin_Load(object sender, EventArgs e)

        {
            this.FormClosed += new FormClosedEventHandler(closeform);
        }
        private void closeform(object sender, FormClosedEventArgs e)
        {
            Formadmin fmrprincipal = new Formadmin();
            this.Hide();
            fmrprincipal.Show();


        }

        private void btn_acceder_formadmin_Click(object sender, EventArgs e)
        {
            if(tbx_usuario_ini.Text == "Ronnie Coleman" && tbx_contra_ini.Text == "Ronnie11")
            {
                Form_grupos_musculares form1 = new Form_grupos_musculares();
                this.Hide();
                form1.Show();


            }

            if (string.IsNullOrEmpty(tbx_usuario_ini.Text) || string.IsNullOrEmpty(tbx_contra_ini.Text))

            {
                MessageBox.Show("Usuario o contraseña incorrecta");
            }

        }

        private void btnregis_Click(object sender, EventArgs e)
        {
            {
           


            }

            
            {
            
            }
        }

        private void tbx_nom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Unicamente letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;

            }

        }

        private void pb_mostrar_Click(object sender, EventArgs e)
        {
            pb_ocultar.BringToFront();
            tbx_contraseña.PasswordChar = '\0';
        }

        private void pb_ocultar_Click(object sender, EventArgs e)
        {
            pb_mostrar.BringToFront();
            tbx_contraseña.PasswordChar = '*';
        }

        private void tbx_nom_TextChanged(object sender, EventArgs e)
        {

        }

        private void pb_mostrar1_Click(object sender, EventArgs e)
        {
            pb_ocultar1.BringToFront();
            tbx_contra_ini.PasswordChar = '\0';
        }

        private void pb_ocultar1_Click(object sender, EventArgs e)
        {
            pb_mostrar1.BringToFront();
            tbx_contra_ini.PasswordChar = '*';
        }

        private void tbx_contraseña_TextChanged(object sender, EventArgs e)
        {
            if (tbx_contraseña.Text.Length >= 8)
            {
                MessageBox.Show("Maximo 8 caracteres verifique su contraseña");
            }
        }

        private void tbx_contra_ini_TextChanged(object sender, EventArgs e)
        {
            if (tbx_contra_ini.Text.Length >= 8) 
            {
                MessageBox.Show("Máximo 8 caracteres verifique su contraseña");
            }
        
        }

       

        private void pb_ocultarcon_Click_1(object sender, EventArgs e)
        {
            pb_mostrarcon.BringToFront();
            tbx_confirmarcon.PasswordChar = '*';
        }

        private void pb_mostrarcon_Click(object sender, EventArgs e)
        {
            pb_ocultarcon.BringToFront();
            tbx_confirmarcon.PasswordChar = '\0';
        }
    }
}
            

        
    
