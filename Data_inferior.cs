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
        private int poc;
        public Data_inferior()
        {
            InitializeComponent();
            RellenarGrid();
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

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            int V = data_inferior_2.Rows.Add();

            data_inferior_2.Rows[V].Cells[0].Value = com_lunes_2.Text;
            data_inferior_2.Rows[V].Cells[1].Value = com_martes_2.Text;
            data_inferior_2.Rows[V].Cells[2].Value = com_miercoles_2.Text;
            data_inferior_2.Rows[V].Cells[3].Value = com_jueves_2.Text;
            data_inferior_2.Rows[V].Cells[4].Value = com_viernes_2.Text;
            data_inferior_2.Rows[V].Cells[5].Value = com_sabado_2.Text;
            data_inferior_2.Rows[V].Cells[6].Value = com_domingo_2.Text;
        }

        private void data_inferior_2_load(object sender, EventArgs e)
        {
            com_miercoles_2.Items.Add("miercoles");
            com_martes_2.Items.Add("martes");
            com_lunes_2.Items.Add("lunes");
            com_jueves_2.Items.Add("jueves");
            com_viernes_2.Items.Add("viernes");
            com_sabado_2.Items.Add("sabado");
            com_domingo_2.Items.Add("domingo");

        }


        private void data_inferior_2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            poc = data_inferior_2.CurrentRow.Index;
            com_lunes_2.Text = data_inferior_2[0, poc].Value.ToString();
            com_martes_2.Text = data_inferior_2[1, poc].Value.ToString();
            com_miercoles_2.Text = data_inferior_2[2, poc].Value.ToString();
            com_jueves_2.Text = data_inferior_2[3, poc].Value.ToString();
            com_viernes_2.Text = data_inferior_2[4, poc].Value.ToString();
            com_sabado_2.Text = data_inferior_2[5, poc].Value.ToString();
            com_domingo_2.Text = data_inferior_2[6, poc].Value.ToString();
        }
        private void RellenarGrid()
        {

            List<Ejercicios> ejercicios = new List<Ejercicios>();
            ejercicios.Add(new Ejercicios("Sentadilla", "Descanso", "Sentadilla", "Descanso", "Hip thrust", "Descanso", "Descanso"));
            ejercicios.Add(new Ejercicios("Extención en máquina", "Descanso", "Extención en máquina", "Descanso", "Sentadilla Búlgara", "Descanso", "Descanso"));
            ejercicios.Add(new Ejercicios("Prensa", "Descanso", "Peso muerto", "Descanso", "Peso muerto", "Descanso", "Descanso"));
            ejercicios.Add(new Ejercicios("Aductores en máquina", "Descanso", "Femoral en máquina", "Descanso", "Femoral en máquina", "Descanso", "Descanso"));
            ejercicios.Add(new Ejercicios("Zancadas", "Descanso", "Pantorillas", "Descanso", "Patada de glúteo", "Descanso", "Descanso"));



            foreach (Ejercicios e in ejercicios)
            {
                int rowIndex = data_inferior_2.Rows.Add();
                DataGridViewRow row = data_inferior_2.Rows[rowIndex];
                row.Cells[0].Value = e.Lunes;
                row.Cells[1].Value = e.Martes;
                row.Cells[2].Value = e.Miércoles;
                row.Cells[3].Value = e.Jueves;
                row.Cells[4].Value = e.Viernes;
                row.Cells[5].Value = e.Sábado;
                row.Cells[6].Value = e.Domingo;

            }
        }

        private void btn_eliminar_2_Click(object sender, EventArgs e)
        {
            data_inferior_2.Rows.RemoveAt(poc);
        }
        private void datainferior_Load(object sender, EventArgs e)
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

   
   
