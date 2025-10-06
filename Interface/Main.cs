using FlightLib;
using GUI;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;

namespace Interface
{
    public partial class Main : Form
    {
        FlightPlanList FlightList = new FlightPlanList();
        PictureBox[] misPics = new PictureBox[100];
        int numPics = 0;
        bool press = false;
        public Main()
        {
            InitializeComponent();
        }

        private void miPanel_MouseMove(object sender, MouseEventArgs e)
        {
            posicionLbl.Text = "X= " + e.X + ", Y=" + e.Y; //MEJORA: cuando el mouse salga del panel, que lo diga
        }

        private void miPanel_MouseLeave(object sender, EventArgs e)
        {
            posicionLbl.Text = "Mouse fuera del panel";
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //FlightList.Mover(2, 1);
        //for (int i = 0; i < FlightList.DameNum(); i++)
        //  misPics[i].Location = new Point(FlightList.Dame(i).GetX(), FlightList.Dame(i).GetY());
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            reloj.Interval = 100; //milisegundos
            if (press == false)
            {
                reloj.Start();
                Automatico_button.Text = "Parar";
                press = true;
            }
            else
            {
                reloj.Stop();
                Automatico_button.Text = "Automatico";
                press = false;
            }
        }

        private void reloj_Tick(object sender, EventArgs e) //MEJORA: Poder decidir durante cuanto tiempo quieres que se haga la simulacion
        {
            FlightList.Mover(1);
            double distanciaSeguridad = 10; //MEJORA: el usuario puede decidir la distancia de seguridad
            bool[,] conflictos = FlightList.Conflicto(distanciaSeguridad);
            for (int i = 0; i < numPics; i++)
            {
                FlightPlan vuelo = FlightList.GetFlightPlan(i);
                misPics[i].Location = new Point((int)vuelo.getCurrentPosition().GetX(), (int)vuelo.getCurrentPosition().GetY());

                //aqui detecto conflictos i tal
                bool enConflicto = false;
                for (int j = 0; j < numPics; j++)
                {
                    if (i != j && conflictos[i, j])
                    {
                        enConflicto = true;
                        break; // con que haya un conflicto yasirve
                    }
                }

                if (enConflicto)
                    misPics[i].BackColor = Color.Yellow;
                else
                    misPics[i].BackColor = Color.Red;

            }
        }

        private void NuevoPunto_Stripmenu_button_Click(object sender, EventArgs e)
        {
            Añadir_punto form = new Añadir_punto();
            form.ShowDialog();
            FlightPlan p = form.DamePlan();
            FlightList.AddFlightPlan(p);
            PictureBox pic = new PictureBox(); //MEJORA: poner imagen de un avión
            pic.Size = new Size(10, 10);
            pic.BackColor = Color.Red; //MEJORA: poner ID encima
            pic.Location = new Point((int)p.getCurrentPosition().GetX(), (int)p.getCurrentPosition().GetY());
            miPanel.Controls.Add(pic);
            misPics[numPics] = pic;
            numPics++;
        }

        private void listarPuntosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mostrar_puntos form = new Mostrar_puntos();
            form.TomaLista(FlightList);
            form.ShowDialog();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }
    }
}
