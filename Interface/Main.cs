using Clases;
using FlightLib;
using GUI;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing.Text;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace Interface
{
    public partial class Main : Form
    {
        FlightPlanList FlightList = new FlightPlanList();
        PictureBox[] misPics = new PictureBox[100];
        int numPics = 0;
        bool press = false;
        double SafeDistance = 10;

        public Main()
        {
            InitializeComponent();
            reloj.Interval = 100;
        }
        private void Main_Load(object sender, EventArgs e)
        { this.WindowState = FormWindowState.Maximized; }

        private void config_change()
        {
            if (float.TryParse(Tick_speed_entry.Text, out float tickSpeedPerSecond) && tickSpeedPerSecond > 0 && float.TryParse(Safe_distance_entry.Text, out float Safe_distance) && Safe_distance > 0)
            {
                int tickIntervalMs = (int)(1000 / tickSpeedPerSecond);


                reloj.Interval = tickIntervalMs;
                SafeDistance = Safe_distance;

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

        private void Automatic_button_click(object sender, EventArgs e)
        {
            if (press == false)
            {
                reloj.Start();
                Automatic_button.Text = "Parar";
                press = true;
            }
            else
            {
                reloj.Stop();
                Automatic_button.Text = "Automatico";
                press = false;
            }
        }

        private void reloj_Tick(object sender, EventArgs e)
        {
            FlightList.Move(1);
            bool[,] conflictos = FlightList.Conflict(SafeDistance);

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

                if (enConflicto)
                {
                    Conflicto_label.Text = "HAY CONFLICTO";
                    Conflicto_label.ForeColor = Color.Red;
                }
                else
                {
                    Conflicto_label.Text = "NO HAY CONFLICTO";
                    Conflicto_label.ForeColor = Color.Green;
                }


                misPics[i].BackColor = enConflicto ? Color.Yellow : Color.Red;
            }

            DrawTrajectory();

            DrawSafeDistance(SafeDistance);
        }

        private void DrawTrajectory()
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

        private void DrawSafeDistance(double distanciaSeguridad)
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
            SaveFlightPlanToJson(p);
            PictureBox pic = new PictureBox(); //MEJORA: poner imagen de un avión
            pic.Size = new Size(10, 10);
            pic.BackColor = Color.Red; //MEJORA: poner ID encima
            pic.Location = new Point((int)p.getCurrentPosition().GetX(), (int)p.getCurrentPosition().GetY());
            miPanel.Controls.Add(pic);
            misPics[numPics] = pic;
            numPics++;
            Load_Flights();
            DrawTrajectory();
            DrawSafeDistance(SafeDistance);
        }

        private void SaveFlightPlanToJson(FlightPlan newPlan)
        {
            // 🔹 Ruta hacia la carpeta GUI (sube 3 niveles desde bin/Debug/netX.x)
            string guiFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\GUI");

            // 🔹 Nos aseguramos de que la carpeta exista
            Directory.CreateDirectory(guiFolderPath);

            // 🔹 Ruta completa del archivo dentro de GUI
            string filePath = Path.Combine(guiFolderPath, "flightplans.json");

            List<Dictionary<string, object>> flightPlans = new List<Dictionary<string, object>>();

            // 🔹 Si el archivo ya existe, leemos los datos existentes
            if (File.Exists(filePath))
            {
                try
                {
                    string jsonData = File.ReadAllText(filePath);
                    flightPlans = JsonSerializer.Deserialize<List<Dictionary<string, object>>>(jsonData)
                                  ?? new List<Dictionary<string, object>>();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al leer el archivo JSON: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    flightPlans = new List<Dictionary<string, object>>();
                }
            }

            // 🔹 Creamos el nuevo registro
            var newFlight = new Dictionary<string, object>
    {
        { "Id", newPlan.getId() },
        { "Velocidad", newPlan.getVel() },
        { "PosicionInicial", new { X = newPlan.getCurrentPosition().GetX(), Y = newPlan.getCurrentPosition().GetY() } },
        { "PosicionFinal", new { X = newPlan.getFinalPosition().GetX(), Y = newPlan.getFinalPosition().GetY() } }
    };

            // 🔹 Lo agregamos a la lista
            flightPlans.Add(newFlight);

            // 🔹 Guardamos el archivo con formato legible
            var options = new JsonSerializerOptions { WriteIndented = true };
            try
            {
                string jsonString = JsonSerializer.Serialize(flightPlans, options);
                File.WriteAllText(filePath, jsonString);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el archivo JSON: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // (Opcional) Mensaje para confirmar la ruta
            // MessageBox.Show($"Archivo guardado en:\n{Path.GetFullPath(filePath)}");
        }

        private void Config_submit_button_Click(object sender, EventArgs e)
        { config_change(); }

        private void Move_button_click(object sender, EventArgs e)
        {
            FlightList.Move(1);

            for (int i = 0; i < numPics; i++)
            {
                FlightPlan vuelo = FlightList.GetFlightPlan(i);
                if (vuelo == null) continue;

                misPics[i].Location = new Point(
                    (int)vuelo.getCurrentPosition().GetX(),
                    (int)vuelo.getCurrentPosition().GetY()
                );

                DrawTrajectory();

                DrawSafeDistance(SafeDistance);

            }
        }

        private void Load_Flights()
        {

            {
                if (FlightList == null)
                {
                    MessageBox.Show("No se ha encontrado ninguna lista");
                    return;
                }

                Flights_View.RowCount = FlightList.GetNum();

                Flights_View.ColumnCount = 4;

                Flights_View.Columns[0].HeaderText = "ID";
                Flights_View.Columns[1].HeaderText = "Velocidad";
                Flights_View.Columns[2].HeaderText = "Posicion";
                Flights_View.Columns[3].HeaderText = "Destino";

                for (int i = 0; i < FlightList.GetNum(); i++)
                {
                    Flights_View.Rows[i].Cells[0].Value = (FlightList.GetFlightPlan(i).getId());
                    Flights_View.Rows[i].Cells[1].Value = (FlightList.GetFlightPlan(i).getVel());
                    Flights_View.Rows[i].Cells[2].Value = string.Format("X: {0:F2}, Y: {1:F2}", FlightList.GetFlightPlan(i).getCurrentPosition().GetX(), FlightList.GetFlightPlan(i).getCurrentPosition().GetY());
                    Flights_View.Rows[i].Cells[3].Value = string.Format("X: {0:F2}, Y: {1:F2}", FlightList.GetFlightPlan(i).getFinalPosition().GetX(), FlightList.GetFlightPlan(i).getFinalPosition().GetY());
                }
            }
        }

        private void Restart_button_Click(object sender, EventArgs e)
        { FlightList.Restart_Flights(); }

        private void Presimulacion_conflict_button_Click(object sender, EventArgs e)
        {
            bool hasConflict = false;
            bool[,] conflicts = FlightList.Conflict(SafeDistance);

            for (int i = 0; i < numPics && !hasConflict; i++)
            {
                var flightA = FlightList.GetFlightPlan(i);
                if (flightA == null) continue;

                for (int j = i + 1; j < numPics; j++) // check only upper triangle (avoid duplicates)
                {
                    var flightB = FlightList.GetFlightPlan(j);
                    if (flightB == null) continue;

                    if (conflicts[i, j])
                    {
                        hasConflict = true;
                        break;
                    }
                }
            }

            MessageBox.Show(hasConflict
                ? "Sí habrá conflictos"
                : "No habrá conflictos");
        }

        private void Import_flightplan_button_Click(object sender, EventArgs e)
        {
            ImportFlightPlansFromJson();
        }

        private void ImportFlightPlansFromJson()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "JSON files (*.json)|*.json";
                openFileDialog.Title = "Selecciona un archivo de FlightPlans";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    try
                    {
                        string jsonData = File.ReadAllText(filePath);

                        var importedFlights = JsonSerializer.Deserialize<List<Dictionary<string, JsonElement>>>(jsonData);

                        if (importedFlights == null || importedFlights.Count == 0)
                        {
                            MessageBox.Show("El archivo no contiene FlightPlans válidos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        foreach (var flightDict in importedFlights)
                        {
                            string id = flightDict["Id"].GetString() ?? "Vuelo";
                            double velocidad = flightDict["Velocidad"].GetDouble();

                            var posIni = flightDict["PosicionInicial"];
                            var posFin = flightDict["PosicionFinal"];

                            double xIni = posIni.GetProperty("X").GetDouble();
                            double yIni = posIni.GetProperty("Y").GetDouble();
                            double xFin = posFin.GetProperty("X").GetDouble();
                            double yFin = posFin.GetProperty("Y").GetDouble();

                            FlightPlan p = new FlightPlan(id, xIni, yIni, xFin, yFin, velocidad);

                            FlightList.AddFlightPlan(p);

                            PictureBox pic = new PictureBox();
                            pic.Size = new Size(10, 10);
                            pic.BackColor = Color.Red;
                            pic.Location = new Point((int)xIni, (int)yIni);
                            miPanel.Controls.Add(pic);

                            misPics[numPics] = pic;
                            numPics++;
                        }

                        Load_Flights();
                        DrawTrajectory();
                        DrawSafeDistance(SafeDistance);

                        MessageBox.Show("Importación completada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al importar el archivo JSON:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Flights_View_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            FlightPlan vueloSeleccionado = FlightList.GetFlightPlan(e.RowIndex);
            if (vueloSeleccionado == null) return;

            string mensaje = "";

            for (int i = 0; i < FlightList.GetNum(); i++)
            {
                FlightPlan otroVuelo = FlightList.GetFlightPlan(i);
                if (otroVuelo == null || otroVuelo == vueloSeleccionado) continue;

                double dx = vueloSeleccionado.getCurrentPosition().GetX() - otroVuelo.getCurrentPosition().GetX();
                double dy = vueloSeleccionado.getCurrentPosition().GetY() - otroVuelo.getCurrentPosition().GetY();
                double distancia = Math.Sqrt(dx * dx + dy * dy);

                mensaje += $"Distancia a {otroVuelo.getId()}: {distancia:F2} metros\n";
            }

            MessageBox.Show(mensaje, $"Distancias desde {vueloSeleccionado.getId()}", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



    }
}
