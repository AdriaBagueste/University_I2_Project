using FlightLib;
using GUI;
using System.Diagnostics.Eventing.Reader;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Interface
{
    public partial class Main : Form
    {
        FlightPlanList FlightList = new FlightPlanList();
        PictureBox[] misPics = new PictureBox[100];
        int numPics = 0;
        bool press = false;
        double distanciaSeguridad = 10;

        public Main()
        {
            InitializeComponent();
            reloj.Interval = 100;
        }

        private void config_change()
        {
            if (float.TryParse(Tick_speed_entry.Text, out float tickSpeedPerSecond) && tickSpeedPerSecond > 0 && float.TryParse(Safe_distance_entry.Text, out float Safe_distance) && Safe_distance > 0)
            {
                int tickIntervalMs = (int)(1000 / tickSpeedPerSecond);


                reloj.Interval = tickIntervalMs;
                distanciaSeguridad = Safe_distance;

                Tick_speed_info_label.Text = $"Velocidad del reloj: {tickSpeedPerSecond} Ticks/segundo";
                Safe_distance_info_label.Text = $"Distancia de seguridad: {Safe_distance} metros";


            }
            else
            {
                MessageBox.Show("Entra un número positivo válido",
                    "Input inválido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
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

        private void Move_button_click(object sender, EventArgs e)
        {
            if (press == false)
            {
                reloj.Start();
                Move_button.Text = "Parar";
                press = true;
            }
            else
            {
                reloj.Stop();
                Move_button.Text = "Mover";
                press = false;
            }
        }
        private void reloj_Tick(object sender, EventArgs e)
        {
            FlightList.Mover(1);
            bool[,] conflictos = FlightList.Conflicto(distanciaSeguridad);

            for (int i = 0; i < numPics; i++)
            {
                FlightPlan vuelo = FlightList.GetFlightPlan(i);
                if (vuelo == null) continue;

                misPics[i].Location = new Point(
                    (int)vuelo.getCurrentPosition().GetX(),
                    (int)vuelo.getCurrentPosition().GetY()
                );

                bool enConflicto = false;
                for (int j = 0; j < numPics; j++)
                {
                    if (i != j && conflictos[i, j])
                    {
                        enConflicto = true;
                        break;
                    }
                }

                misPics[i].BackColor = enConflicto ? Color.Yellow : Color.Red;
            }

            DibujarTrayectorias();

            DibujarDistanciaSeguridad(distanciaSeguridad);
        }

        private void DibujarTrayectorias()
        {
            using (Graphics g = miPanel.CreateGraphics())
            {
                g.Clear(miPanel.BackColor);

                using (Pen pen = new Pen(Color.Blue, 2))
                {
                    for (int i = 0; i < numPics; i++)
                    {
                        FlightPlan vuelo = FlightList.GetFlightPlan(i);
                        if (vuelo == null)
                            continue;

                        Point origen = new Point(
                            (int)vuelo.getCurrentPosition().GetX(),
                            (int)vuelo.getCurrentPosition().GetY()
                        );

                        Point destino = new Point(
                            (int)vuelo.getFinalPosition().GetX(),
                            (int)vuelo.getFinalPosition().GetY()
                        );

                        g.DrawLine(pen, origen, destino);
                    }
                }
            }
        }

        private void DibujarDistanciaSeguridad(double distanciaSeguridad)
        {
            using (Graphics g = miPanel.CreateGraphics())
            {
                using (Pen pen = new Pen(Color.Green, 1))
                {
                    pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;

                    for (int i = 0; i < numPics; i++)
                    {
                        FlightPlan vuelo = FlightList.GetFlightPlan(i);
                        if (vuelo == null)
                            continue;


                        double x = vuelo.getCurrentPosition().GetX();
                        double y = vuelo.getCurrentPosition().GetY();

                        float diametro = (float)(distanciaSeguridad * 2);
                        float esquinaX = (float)(x - distanciaSeguridad);
                        float esquinaY = (float)(y - distanciaSeguridad);

                        g.DrawEllipse(pen, esquinaX, esquinaY, diametro, diametro);
                    }
                }
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
            this.WindowState = FormWindowState.Maximized;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void miPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Config_submit_button_Click(object sender, EventArgs e)
        {
            config_change();
        }

        private void Tick_speed_label_Click(object sender, EventArgs e)
        {

        }
    }
}
