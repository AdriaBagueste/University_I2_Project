using System.Drawing.Text;
using Project_libs;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            Flight_ID_entry = new TextBox();
            Flight_Initial_position_x_entry = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox5 = new TextBox();
            label4 = new Label();
            Add_flight_button = new Button();
            label5 = new Label();
            label6 = new Label();
            Flight_Initial_position_y_entry = new TextBox();
            label7 = new Label();
            Flight_final_position_y_entry = new TextBox();
            label8 = new Label();
            Flight_final_position_x_entry = new TextBox();
            SuspendLayout();
            // 
            // Flight_ID_entry
            // 
            Flight_ID_entry.Location = new Point(135, 17);
            Flight_ID_entry.Name = "Flight_ID_entry";
            Flight_ID_entry.Size = new Size(164, 23);
            Flight_ID_entry.TabIndex = 0;
            // 
            // Flight_Initial_position_x_entry
            // 
            Flight_Initial_position_x_entry.Location = new Point(155, 49);
            Flight_Initial_position_x_entry.Name = "Flight_Initial_position_x_entry";
            Flight_Initial_position_x_entry.Size = new Size(56, 23);
            Flight_Initial_position_x_entry.TabIndex = 1;
            Flight_Initial_position_x_entry.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 2;
            label1.Text = "Flight ID";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 49);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 3;
            label2.Text = "Initial position";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 78);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 4;
            label3.Text = "Final position";
            label3.Click += label3_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(135, 104);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(164, 23);
            textBox5.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 107);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 8;
            label4.Text = "label4";
            // 
            // Add_flight_button
            // 
            Add_flight_button.Location = new Point(135, 133);
            Add_flight_button.Name = "Add_flight_button";
            Add_flight_button.Size = new Size(164, 23);
            Add_flight_button.TabIndex = 9;
            Add_flight_button.Text = "Add Flight";
            Add_flight_button.UseVisualStyleBackColor = true;
            Add_flight_button.Click += Add_flight_button_click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(135, 52);
            label5.Name = "label5";
            label5.Size = new Size(14, 15);
            label5.TabIndex = 10;
            label5.Text = "X";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(223, 52);
            label6.Name = "label6";
            label6.Size = new Size(14, 15);
            label6.TabIndex = 12;
            label6.Text = "Y";
            label6.Click += label6_Click;
            // 
            // Flight_Initial_position_y_entry
            // 
            Flight_Initial_position_y_entry.Location = new Point(243, 49);
            Flight_Initial_position_y_entry.Name = "Flight_Initial_position_y_entry";
            Flight_Initial_position_y_entry.Size = new Size(56, 23);
            Flight_Initial_position_y_entry.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(223, 78);
            label7.Name = "label7";
            label7.Size = new Size(14, 15);
            label7.TabIndex = 16;
            label7.Text = "Y";
            // 
            // Flight_final_position_y_entry
            // 
            Flight_final_position_y_entry.Location = new Point(243, 75);
            Flight_final_position_y_entry.Name = "Flight_final_position_y_entry";
            Flight_final_position_y_entry.Size = new Size(56, 23);
            Flight_final_position_y_entry.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(135, 78);
            label8.Name = "label8";
            label8.Size = new Size(14, 15);
            label8.TabIndex = 14;
            label8.Text = "X";
            // 
            // Flight_final_position_x_entry
            // 
            Flight_final_position_x_entry.Location = new Point(155, 75);
            Flight_final_position_x_entry.Name = "Flight_final_position_x_entry";
            Flight_final_position_x_entry.Size = new Size(56, 23);
            Flight_final_position_x_entry.TabIndex = 13;
            // 
            // Form1
            // 
            ClientSize = new Size(369, 174);
            Controls.Add(label7);
            Controls.Add(Flight_final_position_y_entry);
            Controls.Add(label8);
            Controls.Add(Flight_final_position_x_entry);
            Controls.Add(label6);
            Controls.Add(Flight_Initial_position_y_entry);
            Controls.Add(label5);
            Controls.Add(Add_flight_button);
            Controls.Add(label4);
            Controls.Add(textBox5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Flight_Initial_position_x_entry);
            Controls.Add(Flight_ID_entry);
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

        private void Add_flight_button_click(object sender, EventArgs e)
        {
            string flightID = Flight_ID_entry.Text;

            // Declare variables outside so they are accessible later
            float initialX, initialY, finalX, finalY;

            // Try parsing float values safely
            if (float.TryParse(Flight_Initial_position_x_entry.Text, out initialX) &&
                float.TryParse(Flight_Initial_position_y_entry.Text, out initialY) &&
                float.TryParse(Flight_final_position_x_entry.Text, out finalX) &&
                float.TryParse(Flight_final_position_y_entry.Text, out finalY))
            {
                // All inputs are valid floats
                MessageBox.Show($"Flight ID: {flightID}\n" +
                                $"Initial Position: ({initialX}, {initialY})\n" +
                                $"Final Position: ({finalX}, {finalY})");

                // Add flight to file using your library
                Project_libs.Libs.AddFlightToFile(new Flight
                {
                    ID = flightID,
                    Initial_position_x = initialX,
                    Initial_position_y = initialY,
                    Final_position_x = finalX,
                    Final_position_y = finalY
                });
            }
            else
            {
                // If any parsing fails
                MessageBox.Show("Please enter valid numeric values for positions.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }

}

    

