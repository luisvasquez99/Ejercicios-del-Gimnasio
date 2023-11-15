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
    public partial class Data_inferior : Form
    {
        public Data_inferior()
        {
            InitializeComponent();
        }
        private void Dataa_Load(object sender, EventArgs e)
        {

            this.FormClosed += new FormClosedEventHandler(closeform);
        }
        private void closeform(object sender, FormClosedEventArgs e)
        {
            Form_grupos_musculares Fmrprincipal = new Form_grupos_musculares();
            this.Hide();
            Fmrprincipal.Show();
        }

    }
    }
   
