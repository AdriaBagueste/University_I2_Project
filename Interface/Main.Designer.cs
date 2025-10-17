using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Interface
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            miPanel = new Panel();
            posicionLbl = new Label();
            menuStrip1 = new MenuStrip();
            nuevoPuntoToolStripMenuItem = new ToolStripMenuItem();
            NuevoPunto_Stripmenu_button = new ToolStripMenuItem();
            ListaPuntos_StripMenu_Button = new ToolStripMenuItem();
            Automatic_button = new Button();
            reloj = new System.Windows.Forms.Timer(components);
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel2 = new Panel();
            Presimulacion_conflict_button = new Button();
            Restart_button = new Button();
            button1 = new Button();
            Controles_label = new Label();
            panel3 = new Panel();
            Conflicto_label = new Label();
            Safe_distance_info_label = new Label();
            Tick_speed_info_label = new Label();
            Info_label = new Label();
            panel4 = new Panel();
            Safe_distance_units_label = new Label();
            Safe_distance_label = new Label();
            Safe_distance_entry = new TextBox();
            Tick_speed_units_label = new Label();
            Tick_speed_label = new Label();
            Tick_speed_entry = new TextBox();
            Config_submit_button = new Button();
            Config_label = new Label();
            panel5 = new Panel();
            Flights_View = new DataGridView();
            panel6 = new Panel();
            label1 = new Label();
            Import_flightplan_button = new Button();
            menuStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Flights_View).BeginInit();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // miPanel
            // 
            miPanel.BackColor = SystemColors.AppWorkspace;
            miPanel.Font = new System.Drawing.Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            miPanel.Location = new Point(101, 24);
            miPanel.Margin = new Padding(2);
            miPanel.Name = "miPanel";
            miPanel.Size = new Size(961, 612);
            miPanel.TabIndex = 0;
            miPanel.MouseLeave += miPanel_MouseLeave;
            miPanel.MouseMove += miPanel_MouseMove;
            // 
            // posicionLbl
            // 
            posicionLbl.BorderStyle = BorderStyle.FixedSingle;
            posicionLbl.Location = new Point(101, 0);
            posicionLbl.Margin = new Padding(2, 0, 2, 0);
            posicionLbl.Name = "posicionLbl";
            posicionLbl.Size = new Size(961, 22);
            posicionLbl.TabIndex = 5;
            posicionLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { nuevoPuntoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 1, 0, 1);
            menuStrip1.Size = new Size(1628, 24);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // nuevoPuntoToolStripMenuItem
            // 
            nuevoPuntoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { NuevoPunto_Stripmenu_button, ListaPuntos_StripMenu_Button });
            nuevoPuntoToolStripMenuItem.Name = "nuevoPuntoToolStripMenuItem";
            nuevoPuntoToolStripMenuItem.Size = new Size(69, 22);
            nuevoPuntoToolStripMenuItem.Text = "Opciones";
            // 
            // NuevoPunto_Stripmenu_button
            // 
            NuevoPunto_Stripmenu_button.Name = "NuevoPunto_Stripmenu_button";
            NuevoPunto_Stripmenu_button.Size = new Size(144, 22);
            NuevoPunto_Stripmenu_button.Text = "Nuevo Punto";
            NuevoPunto_Stripmenu_button.Click += NuevoPunto_Stripmenu_button_Click;
            // 
            // ListaPuntos_StripMenu_Button
            // 
            ListaPuntos_StripMenu_Button.Name = "ListaPuntos_StripMenu_Button";
            ListaPuntos_StripMenu_Button.Size = new Size(144, 22);
            ListaPuntos_StripMenu_Button.Text = "Listar Puntos";
            // 
            // Automatic_button
            // 
            Automatic_button.Location = new Point(64, 19);
            Automatic_button.Margin = new Padding(2);
            Automatic_button.Name = "Automatic_button";
            Automatic_button.Size = new Size(101, 25);
            Automatic_button.TabIndex = 8;
            Automatic_button.Text = "Automático";
            Automatic_button.UseVisualStyleBackColor = true;
            Automatic_button.Click += Automatic_button_click;
            // 
            // reloj
            // 
            reloj.Tick += reloj_Tick;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.347181F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90.65282F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 558F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Controls.Add(miPanel, 1, 1);
            tableLayoutPanel1.Controls.Add(posicionLbl, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 2);
            tableLayoutPanel1.Controls.Add(panel5, 2, 1);
            tableLayoutPanel1.Controls.Add(panel6, 2, 0);
            tableLayoutPanel1.Controls.Add(Import_flightplan_button, 2, 2);
            tableLayoutPanel1.Location = new Point(0, 27);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 3.54691076F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 96.45309F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 375F));
            tableLayoutPanel1.Size = new Size(1623, 1014);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.Location = new Point(3, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(93, 610);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74.377594F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.622406F));
            tableLayoutPanel2.Controls.Add(panel2, 0, 0);
            tableLayoutPanel2.Controls.Add(panel3, 1, 0);
            tableLayoutPanel2.Controls.Add(panel4, 0, 1);
            tableLayoutPanel2.Location = new Point(102, 641);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 46.59686F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 53.40314F));
            tableLayoutPanel2.Size = new Size(959, 191);
            tableLayoutPanel2.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(Presimulacion_conflict_button);
            panel2.Controls.Add(Restart_button);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(Automatic_button);
            panel2.Controls.Add(Controles_label);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(707, 83);
            panel2.TabIndex = 2;
            // 
            // Presimulacion_conflict_button
            // 
            Presimulacion_conflict_button.Location = new Point(251, 20);
            Presimulacion_conflict_button.Name = "Presimulacion_conflict_button";
            Presimulacion_conflict_button.Size = new Size(75, 23);
            Presimulacion_conflict_button.TabIndex = 11;
            Presimulacion_conflict_button.Text = "Conflicto?";
            Presimulacion_conflict_button.UseVisualStyleBackColor = true;
            Presimulacion_conflict_button.Click += Presimulacion_conflict_button_Click;
            // 
            // Restart_button
            // 
            Restart_button.Location = new Point(170, 20);
            Restart_button.Name = "Restart_button";
            Restart_button.Size = new Size(75, 23);
            Restart_button.TabIndex = 10;
            Restart_button.Text = "Reiniciar";
            Restart_button.UseVisualStyleBackColor = true;
            Restart_button.Click += Restart_button_Click;
            // 
            // button1
            // 
            button1.Location = new Point(-1, 20);
            button1.Name = "button1";
            button1.Size = new Size(60, 23);
            button1.TabIndex = 9;
            button1.Text = "Mover";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Move_button_click;
            // 
            // Controles_label
            // 
            Controles_label.AutoSize = true;
            Controles_label.BorderStyle = BorderStyle.FixedSingle;
            Controles_label.Location = new Point(0, 0);
            Controles_label.Name = "Controles_label";
            Controles_label.Size = new Size(135, 17);
            Controles_label.TabIndex = 2;
            Controles_label.Text = "Controles del simulador";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(Conflicto_label);
            panel3.Controls.Add(Safe_distance_info_label);
            panel3.Controls.Add(Tick_speed_info_label);
            panel3.Controls.Add(Info_label);
            panel3.Location = new Point(716, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(240, 83);
            panel3.TabIndex = 3;
            // 
            // Conflicto_label
            // 
            Conflicto_label.BorderStyle = BorderStyle.FixedSingle;
            Conflicto_label.Location = new Point(0, 51);
            Conflicto_label.Name = "Conflicto_label";
            Conflicto_label.Size = new Size(240, 31);
            Conflicto_label.TabIndex = 3;
            Conflicto_label.Text = "NO HAY CONFLICTO";
            Conflicto_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Safe_distance_info_label
            // 
            Safe_distance_info_label.BorderStyle = BorderStyle.FixedSingle;
            Safe_distance_info_label.Location = new Point(0, 34);
            Safe_distance_info_label.Name = "Safe_distance_info_label";
            Safe_distance_info_label.Size = new Size(240, 17);
            Safe_distance_info_label.TabIndex = 2;
            Safe_distance_info_label.Text = "Distancia de seguridad: 10 metros";
            Safe_distance_info_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Tick_speed_info_label
            // 
            Tick_speed_info_label.BorderStyle = BorderStyle.FixedSingle;
            Tick_speed_info_label.Location = new Point(0, 17);
            Tick_speed_info_label.Name = "Tick_speed_info_label";
            Tick_speed_info_label.Size = new Size(240, 17);
            Tick_speed_info_label.TabIndex = 1;
            Tick_speed_info_label.Text = "Velocidad del reloj: 100 Ticks/segundo";
            Tick_speed_info_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Info_label
            // 
            Info_label.BorderStyle = BorderStyle.FixedSingle;
            Info_label.Location = new Point(0, 0);
            Info_label.Name = "Info_label";
            Info_label.Size = new Size(240, 17);
            Info_label.TabIndex = 0;
            Info_label.Text = "Información del simulador";
            Info_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(Safe_distance_units_label);
            panel4.Controls.Add(Safe_distance_label);
            panel4.Controls.Add(Safe_distance_entry);
            panel4.Controls.Add(Tick_speed_units_label);
            panel4.Controls.Add(Tick_speed_label);
            panel4.Controls.Add(Tick_speed_entry);
            panel4.Controls.Add(Config_submit_button);
            panel4.Controls.Add(Config_label);
            panel4.Location = new Point(3, 92);
            panel4.Name = "panel4";
            panel4.Size = new Size(707, 96);
            panel4.TabIndex = 4;
            // 
            // Safe_distance_units_label
            // 
            Safe_distance_units_label.AutoSize = true;
            Safe_distance_units_label.Location = new Point(265, 57);
            Safe_distance_units_label.Name = "Safe_distance_units_label";
            Safe_distance_units_label.Size = new Size(44, 15);
            Safe_distance_units_label.TabIndex = 7;
            Safe_distance_units_label.Text = "metros";
            // 
            // Safe_distance_label
            // 
            Safe_distance_label.AutoSize = true;
            Safe_distance_label.Location = new Point(-1, 57);
            Safe_distance_label.Name = "Safe_distance_label";
            Safe_distance_label.Size = new Size(132, 15);
            Safe_distance_label.TabIndex = 6;
            Safe_distance_label.Text = "Distancia de seguridad: ";
            // 
            // Safe_distance_entry
            // 
            Safe_distance_entry.Location = new Point(159, 54);
            Safe_distance_entry.Name = "Safe_distance_entry";
            Safe_distance_entry.Size = new Size(100, 23);
            Safe_distance_entry.TabIndex = 5;
            // 
            // Tick_speed_units_label
            // 
            Tick_speed_units_label.AutoSize = true;
            Tick_speed_units_label.Location = new Point(265, 28);
            Tick_speed_units_label.Name = "Tick_speed_units_label";
            Tick_speed_units_label.Size = new Size(84, 15);
            Tick_speed_units_label.TabIndex = 4;
            Tick_speed_units_label.Text = "Ticks/segundo";
            // 
            // Tick_speed_label
            // 
            Tick_speed_label.AutoSize = true;
            Tick_speed_label.Location = new Point(-1, 28);
            Tick_speed_label.Name = "Tick_speed_label";
            Tick_speed_label.Size = new Size(146, 15);
            Tick_speed_label.TabIndex = 3;
            Tick_speed_label.Text = "Velocidad del reloj (1-100):";
            // 
            // Tick_speed_entry
            // 
            Tick_speed_entry.Location = new Point(159, 25);
            Tick_speed_entry.Name = "Tick_speed_entry";
            Tick_speed_entry.Size = new Size(100, 23);
            Tick_speed_entry.TabIndex = 2;
            // 
            // Config_submit_button
            // 
            Config_submit_button.Location = new Point(635, 72);
            Config_submit_button.Name = "Config_submit_button";
            Config_submit_button.Size = new Size(75, 23);
            Config_submit_button.TabIndex = 1;
            Config_submit_button.Text = "Cambiar";
            Config_submit_button.UseVisualStyleBackColor = true;
            Config_submit_button.Click += Config_submit_button_Click;
            // 
            // Config_label
            // 
            Config_label.AutoSize = true;
            Config_label.BorderStyle = BorderStyle.FixedSingle;
            Config_label.Location = new Point(0, -1);
            Config_label.Name = "Config_label";
            Config_label.Size = new Size(160, 17);
            Config_label.TabIndex = 0;
            Config_label.Text = "Configuración del simulador";
            // 
            // panel5
            // 
            panel5.Controls.Add(Flights_View);
            panel5.Location = new Point(1067, 25);
            panel5.Name = "panel5";
            panel5.Size = new Size(550, 610);
            panel5.TabIndex = 7;
            // 
            // Flights_View
            // 
            Flights_View.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Flights_View.Location = new Point(3, 3);
            Flights_View.Name = "Flights_View";
            Flights_View.Size = new Size(547, 777);
            Flights_View.TabIndex = 0;
            Flights_View.CellClick += Flights_View_CellClick;
            // 
            // panel6
            // 
            panel6.Controls.Add(label1);
            panel6.Location = new Point(1067, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(550, 16);
            panel6.TabIndex = 8;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(3, -3);
            label1.Name = "label1";
            label1.Size = new Size(547, 26);
            label1.TabIndex = 0;
            label1.Text = "Flights information";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Import_flightplan_button
            // 
            Import_flightplan_button.ImageAlign = ContentAlignment.BottomLeft;
            Import_flightplan_button.Location = new Point(1067, 641);
            Import_flightplan_button.Name = "Import_flightplan_button";
            Import_flightplan_button.Size = new Size(75, 23);
            Import_flightplan_button.TabIndex = 9;
            Import_flightplan_button.Text = "Importar planes";
            Import_flightplan_button.UseVisualStyleBackColor = true;
            Import_flightplan_button.Click += Import_flightplan_button_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1628, 865);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            Name = "Main";
            Text = "Main";
            WindowState = FormWindowState.Minimized;
            Load += Main_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Flights_View).EndInit();
            panel6.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel miPanel;
        private Label posicionLbl;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem nuevoPuntoToolStripMenuItem;
        private Button Automatic_button;
        private System.Windows.Forms.Timer reloj;
        private ToolStripMenuItem NuevoPunto_Stripmenu_button;
        private ToolStripMenuItem ListaPuntos_StripMenu_Button;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel2;
        private Panel panel3;
        private Label Info_label;
        private Label Controles_label;
        private Panel panel4;
        private Label Config_label;
        private Button Config_submit_button;
        private Label Tick_speed_units_label;
        private Label Tick_speed_label;
        private TextBox Tick_speed_entry;
        private Label Safe_distance_units_label;
        private Label Safe_distance_label;
        private TextBox Safe_distance_entry;
        private Label Tick_speed_info_label;
        private Label Safe_distance_info_label;
        private Button button1;
        private Button Restart_button;
        private Label Conflicto_label;
        private Button Presimulacion_conflict_button;
        private Panel panel5;
        private DataGridView Flights_View;
        private Panel panel6;
        private Label label1;
        private Button Import_flightplan_button;
    }
}
