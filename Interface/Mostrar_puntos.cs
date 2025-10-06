using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlightLib;

namespace Interface
{
    public partial class Mostrar_puntos : Form
    {
        FlightPlanList miLista = new FlightPlanList();
        public Mostrar_puntos()
        {
            InitializeComponent();
        }

        public void TomaLista(FlightPlanList lista)
        {
            this.miLista = lista;
        }
        private void MostrarPuntos_Load(object sender, EventArgs e)
        {
            if (miLista == null)
            {
                MessageBox.Show("No se ha encontrado ninguna lista");
                return;
            }

            PuntosView.RowCount = miLista.DameNum();

            PuntosView.ColumnCount = 4;

            PuntosView.Columns[0].HeaderText = "ID";
            PuntosView.Columns[1].HeaderText = "Velocidad";
            PuntosView.Columns[2].HeaderText = "Posicion";
            PuntosView.Columns[3].HeaderText = "Destino";

            for (int i = 0; i < miLista.DameNum(); i++)
            {
                PuntosView.Rows[i].Cells[0].Value = (miLista.GetFlightPlan(i).getId());
                PuntosView.Rows[i].Cells[1].Value = (miLista.GetFlightPlan(i).getVel());
                PuntosView.Rows[i].Cells[2].Value = string.Format("X: {0:F2}, Y: {1:F2}", miLista.GetFlightPlan(i).getCurrentPosition().GetX(), miLista.GetFlightPlan(i).getCurrentPosition().GetY());
                PuntosView.Rows[i].Cells[3].Value = string.Format("X: {0:F2}, Y: {1:F2}", miLista.GetFlightPlan(i).getFinalPosition().GetX(), miLista.GetFlightPlan(i).getFinalPosition().GetY());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PuntosView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
