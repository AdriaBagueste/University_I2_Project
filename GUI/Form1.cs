using System.Drawing.Text;
using Project_libs;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Project_libs.Flight
        }

        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            this.label3 = new Label();
            this.textBox3 = new TextBox();
            this.textBox5 = new TextBox();
            this.label4 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(135, 17);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(135, 46);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 49);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new Size(38, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // textBox3
            // 
            this.textBox3.Location = new Point(135, 75);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new Size(100, 23);
            this.textBox3.TabIndex = 5;
            // 
            // textBox5
            // 
            this.textBox5.Location = new Point(135, 104);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new Size(100, 23);
            this.textBox5.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new Point(12, 107);
            this.label4.Name = "label4";
            this.label4.Size = new Size(38, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "label4";
            // 
            // Form1
            // 
            ClientSize = new Size(799, 541);
            Controls.Add(this.label4);
            Controls.Add(this.textBox5);
            Controls.Add(this.textBox3);
            Controls.Add(this.label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }

}

    

