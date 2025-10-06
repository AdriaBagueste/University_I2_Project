using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Interface
{
    partial class Mostrar_puntos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            PuntosView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)PuntosView).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(164, 277);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "Cerrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // PuntosView
            // 
            PuntosView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PuntosView.Location = new Point(40, 32);
            PuntosView.Name = "PuntosView";
            PuntosView.RowHeadersWidth = 62;
            PuntosView.Size = new Size(360, 225);
            PuntosView.TabIndex = 1;
            PuntosView.CellContentClick += PuntosView_CellContentClick;
            // 
            // MostrarPuntos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 365);
            Controls.Add(PuntosView);
            Controls.Add(button1);
            Name = "MostrarPuntos";
            Text = "MostrarPuntos";
            Load += MostrarPuntos_Load;
            ((System.ComponentModel.ISupportInitialize)PuntosView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private DataGridView PuntosView;
    }
}