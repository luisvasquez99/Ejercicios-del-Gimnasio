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
    public partial class Data_cardio : Form
    {
        private int poc;
        public Data_cardio()
        {
            InitializeComponent();
        }
        private void Data_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(closeform);
        }
        private void closeform(object sender, FormClosedEventArgs e)
        {
            Form_grupos_musculares fmrprincipal = new Form_grupos_musculares();
            this.Hide();
            fmrprincipal.Show();
        }

        private void btn_Agregar_1_Click(object sender, EventArgs e)
        {
            int V = data_cardio_1.Rows.Add();

            data_cardio_1.Rows[V].Cells[0].Value = com_lunes_1.Text;
            data_cardio_1.Rows[V].Cells[1].Value = com_martes_1.Text;
            data_cardio_1.Rows[V].Cells[2].Value = com_miercoles_1.Text;
            data_cardio_1.Rows[V].Cells[3].Value = com_jueves_1.Text;
            data_cardio_1.Rows[V].Cells[4].Value = com_viernes_1.Text;
            data_cardio_1.Rows[V].Cells[5].Value = com_sabado_1.Text;
            data_cardio_1.Rows[V].Cells[6].Value = com_domingo_1.Text;
        }
        private void data_cardio_load(object sender, EventArgs e)
        {
            com_miercoles_1.Items.Add("miercoles");
            com_martes_1.Items.Add("martes");
            com_lunes_1.Items.Add("lunes");
            com_jueves_1.Items.Add("jueves");
            com_viernes_1.Items.Add("viernes");
            com_sabado_1.Items.Add("sabado");
            com_domingo_1.Items.Add("domingo");

        }

        private void btn_eliminar_1_Click_1(object sender, EventArgs e)
        {
            data_cardio_1.Rows.RemoveAt(poc);
        }

        private void data_cardio_1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            poc = data_cardio_1.CurrentRow.Index;
            com_lunes_1.Text = data_cardio_1[0, poc].Value.ToString();
            com_martes_1.Text = data_cardio_1[1, poc].Value.ToString();
            com_miercoles_1.Text = data_cardio_1[2, poc].Value.ToString();
            com_jueves_1.Text = data_cardio_1[3, poc].Value.ToString();
            com_viernes_1.Text = data_cardio_1[4, poc].Value.ToString();
            com_sabado_1.Text = data_cardio_1[5, poc].Value.ToString();
            com_domingo_1.Text = data_cardio_1[6, poc].Value.ToString();
        }
        private void datacardio_Load(object sender, EventArgs e)
        {

            this.FormClosed += new FormClosedEventHandler(Closeform);
        }
        private void Closeform(object sender, FormClosedEventArgs e)
        {
            Form_grupos_musculares fmrprincipal = new Form_grupos_musculares();
            this.Hide();
            fmrprincipal.Show();
        }
    }
}