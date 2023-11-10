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
                if(ctr is Panel && ctr.Name == "panel" + tx.Tag.ToString())
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
    }
}
            

        
    
