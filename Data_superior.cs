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
    public partial class Data_superior : Form
    {
        private int poc;

        public Data_superior()
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
        private void Data_superior_load(object sender, EventArgs e)
        {
            com_miercoles.Items.Add("miercoles");
            com_martes.Items.Add("martes");
            com_lunes.Items.Add("lunes");
            com_jueves.Items.Add("jueves");
            com_viernes.Items.Add("viernes");
            com_sabado.Items.Add("sabado");
            com_domingo.Items.Add("domingo");
            
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            int V = data_superior_1.Rows.Add();

            data_superior_1.Rows[V].Cells[0].Value = com_lunes.Text;
            data_superior_1.Rows[V].Cells[1].Value = com_martes.Text;
            data_superior_1.Rows[V].Cells[2].Value = com_miercoles.Text;
            data_superior_1.Rows[V].Cells[3].Value = com_jueves.Text;
            data_superior_1.Rows[V].Cells[4].Value = com_viernes.Text; 
            data_superior_1.Rows[V].Cells[5].Value = com_sabado.Text;
            data_superior_1.Rows[V].Cells[6].Value = com_domingo.Text;




        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
           data_superior_1.Rows.RemoveAt(poc);

        }

        private void data_superior_1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            poc = data_superior_1.CurrentRow.Index;
            com_lunes.Text = data_superior_1[0, poc].Value.ToString();
            com_martes.Text = data_superior_1[1, poc].Value.ToString();
            com_miercoles.Text = data_superior_1[2, poc].Value.ToString();
            com_jueves.Text = data_superior_1[3, poc].Value.ToString();
            com_viernes.Text = data_superior_1[4, poc].Value.ToString();
            com_sabado.Text = data_superior_1[5, poc].Value.ToString();
            com_domingo.Text = data_superior_1[6, poc].Value.ToString();
        }

        

       
    }
}
