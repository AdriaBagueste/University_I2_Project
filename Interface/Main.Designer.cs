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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            posicionLbl = new Label();
            menuStrip1 = new MenuStrip();
            nuevoPuntoToolStripMenuItem = new ToolStripMenuItem();
            NuevoPunto_Stripmenu_button = new ToolStripMenuItem();
            ListaPuntos_StripMenu_Button = new ToolStripMenuItem();
            Mover_button = new Button();
            Automatico_button = new Button();
            reloj = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // miPanel
            // 
            miPanel.BackColor = SystemColors.AppWorkspace;
            miPanel.Font = new System.Drawing.Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            miPanel.Location = new Point(227, 59);
            miPanel.Margin = new Padding(2);
            miPanel.Name = "miPanel";
            miPanel.Size = new Size(560, 420);
            miPanel.TabIndex = 0;
            miPanel.MouseLeave += miPanel_MouseLeave;
            miPanel.MouseMove += miPanel_MouseMove;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 16F);
            label1.Location = new Point(197, 59);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(25, 30);
            label1.TabIndex = 1;
            label1.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 16F);
            label2.Location = new Point(173, 452);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(49, 30);
            label2.TabIndex = 2;
            label2.Text = "699";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 16F);
            label3.Location = new Point(227, 30);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(25, 30);
            label3.TabIndex = 3;
            label3.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 16F);
            label4.Location = new Point(737, 30);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(49, 30);
            label4.TabIndex = 4;
            label4.Text = "799";
            // 
            // posicionLbl
            // 
            posicionLbl.BorderStyle = BorderStyle.FixedSingle;
            posicionLbl.Location = new Point(400, 30);
            posicionLbl.Margin = new Padding(2, 0, 2, 0);
            posicionLbl.Name = "posicionLbl";
            posicionLbl.Size = new Size(224, 24);
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
            menuStrip1.Size = new Size(799, 24);
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
            NuevoPunto_Stripmenu_button.Size = new Size(180, 22);
            NuevoPunto_Stripmenu_button.Text = "Nuevo Punto";
            NuevoPunto_Stripmenu_button.Click += NuevoPunto_Stripmenu_button_Click;
            // 
            // ListaPuntos_StripMenu_Button
            // 
            ListaPuntos_StripMenu_Button.Name = "ListaPuntos_StripMenu_Button";
            ListaPuntos_StripMenu_Button.Size = new Size(180, 22);
            ListaPuntos_StripMenu_Button.Text = "Listar Puntos";
            ListaPuntos_StripMenu_Button.Click += listarPuntosToolStripMenuItem_Click;
            // 
            // Mover_button
            // 
            Mover_button.Location = new Point(69, 159);
            Mover_button.Margin = new Padding(2);
            Mover_button.Name = "Mover_button";
            Mover_button.Size = new Size(78, 20);
            Mover_button.TabIndex = 7;
            Mover_button.Text = "Mover";
            Mover_button.UseVisualStyleBackColor = true;
            // 
            // Automatico_button
            // 
            Automatico_button.Location = new Point(57, 217);
            Automatico_button.Margin = new Padding(2);
            Automatico_button.Name = "Automatico_button";
            Automatico_button.Size = new Size(101, 25);
            Automatico_button.TabIndex = 8;
            Automatico_button.Text = "Automatico";
            Automatico_button.UseVisualStyleBackColor = true;
            Automatico_button.Click += button2_Click;
            // 
            // reloj
            // 
            reloj.Tick += reloj_Tick;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 486);
            Controls.Add(Automatico_button);
            Controls.Add(Mover_button);
            Controls.Add(posicionLbl);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(miPanel);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            Name = "Main";
            Text = "Principal";
            Load += Principal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel miPanel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label posicionLbl;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem nuevoPuntoToolStripMenuItem;
        private Button Mover_button;
        private Button Automatico_button;
        private System.Windows.Forms.Timer reloj;
        private ToolStripMenuItem NuevoPunto_Stripmenu_button;
        private ToolStripMenuItem ListaPuntos_StripMenu_Button;
    }
}
