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
    public partial class Form_grupos_musculares : Form
    {
        public Form_grupos_musculares()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Data_inferior form1 = new Data_inferior();
            this.Hide();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Data_superior form1 = new Data_superior();
            this.Hide();
            form1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Data_cardio form1 = new Data_cardio();
            this.Hide();
            form1.Show();
        }

        private void Form_grupos_musculares_Load(object sender, EventArgs e)
        {
                this.FormClosed += new FormClosedEventHandler(closeform);
            }
            private void closeform(object sender, FormClosedEventArgs e)
            {
                Formadmin fmrprincipal = new Formadmin();
                this.Hide();
                fmrprincipal.Show();

            }

        private void btn_semanal_Click(object sender, EventArgs e)
        {

        }
    }
    }

