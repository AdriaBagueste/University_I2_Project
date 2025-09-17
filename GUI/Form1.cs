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
            Flight_ID_Label = new Label();
            Initial_position_Label = new Label();
            Final_position_Label = new Label();
            Speed_entry = new TextBox();
            Speed_Label = new Label();
            Add_flight_button = new Button();
            label5 = new Label();
            label6 = new Label();
            Flight_Initial_position_y_entry = new TextBox();
            label7 = new Label();
            Flight_final_position_y_entry = new TextBox();
            label8 = new Label();
            Flight_final_position_x_entry = new TextBox();
            Company_Label = new Label();
            Company_entry = new TextBox();
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
            Flight_Initial_position_x_entry.Location = new Point(158, 103);
            Flight_Initial_position_x_entry.Name = "Flight_Initial_position_x_entry";
            Flight_Initial_position_x_entry.Size = new Size(56, 23);
            Flight_Initial_position_x_entry.TabIndex = 1;
            Flight_Initial_position_x_entry.TextChanged += textBox2_TextChanged;
            // 
            // Flight_ID_Label
            // 
            Flight_ID_Label.AutoSize = true;
            Flight_ID_Label.Location = new Point(12, 20);
            Flight_ID_Label.Name = "Flight_ID_Label";
            Flight_ID_Label.Size = new Size(51, 15);
            Flight_ID_Label.TabIndex = 2;
            Flight_ID_Label.Text = "Flight ID";
            Flight_ID_Label.Click += label1_Click;
            // 
            // Initial_position_Label
            // 
            Initial_position_Label.AutoSize = true;
            Initial_position_Label.Location = new Point(15, 103);
            Initial_position_Label.Name = "Initial_position_Label";
            Initial_position_Label.Size = new Size(82, 15);
            Initial_position_Label.TabIndex = 3;
            Initial_position_Label.Text = "Initial position";
            Initial_position_Label.Click += label2_Click;
            // 
            // Final_position_Label
            // 
            Final_position_Label.AutoSize = true;
            Final_position_Label.Location = new Point(15, 132);
            Final_position_Label.Name = "Final_position_Label";
            Final_position_Label.Size = new Size(78, 15);
            Final_position_Label.TabIndex = 4;
            Final_position_Label.Text = "Final position";
            Final_position_Label.Click += label3_Click;
            // 
            // Speed_entry
            // 
            Speed_entry.Location = new Point(138, 158);
            Speed_entry.Name = "Speed_entry";
            Speed_entry.Size = new Size(164, 23);
            Speed_entry.TabIndex = 7;
            // 
            // Speed_Label
            // 
            Speed_Label.AutoSize = true;
            Speed_Label.Location = new Point(15, 161);
            Speed_Label.Name = "Speed_Label";
            Speed_Label.Size = new Size(39, 15);
            Speed_Label.TabIndex = 8;
            Speed_Label.Text = "Speed";
            // 
            // Add_flight_button
            // 
            Add_flight_button.Location = new Point(138, 187);
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
            label5.Location = new Point(138, 106);
            label5.Name = "label5";
            label5.Size = new Size(14, 15);
            label5.TabIndex = 10;
            label5.Text = "X";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(226, 106);
            label6.Name = "label6";
            label6.Size = new Size(14, 15);
            label6.TabIndex = 12;
            label6.Text = "Y";
            label6.Click += label6_Click;
            // 
            // Flight_Initial_position_y_entry
            // 
            Flight_Initial_position_y_entry.Location = new Point(246, 103);
            Flight_Initial_position_y_entry.Name = "Flight_Initial_position_y_entry";
            Flight_Initial_position_y_entry.Size = new Size(56, 23);
            Flight_Initial_position_y_entry.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(226, 132);
            label7.Name = "label7";
            label7.Size = new Size(14, 15);
            label7.TabIndex = 16;
            label7.Text = "Y";
            // 
            // Flight_final_position_y_entry
            // 
            Flight_final_position_y_entry.Location = new Point(246, 129);
            Flight_final_position_y_entry.Name = "Flight_final_position_y_entry";
            Flight_final_position_y_entry.Size = new Size(56, 23);
            Flight_final_position_y_entry.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(138, 132);
            label8.Name = "label8";
            label8.Size = new Size(14, 15);
            label8.TabIndex = 14;
            label8.Text = "X";
            // 
            // Flight_final_position_x_entry
            // 
            Flight_final_position_x_entry.Location = new Point(158, 129);
            Flight_final_position_x_entry.Name = "Flight_final_position_x_entry";
            Flight_final_position_x_entry.Size = new Size(56, 23);
            Flight_final_position_x_entry.TabIndex = 13;
            // 
            // Company_Label
            // 
            Company_Label.AutoSize = true;
            Company_Label.Location = new Point(12, 49);
            Company_Label.Name = "Company_Label";
            Company_Label.Size = new Size(59, 15);
            Company_Label.TabIndex = 18;
            Company_Label.Text = "Company";
            Company_Label.Click += label9_Click;
            // 
            // Company_entry
            // 
            Company_entry.Location = new Point(135, 46);
            Company_entry.Name = "Company_entry";
            Company_entry.Size = new Size(164, 23);
            Company_entry.TabIndex = 17;
            // 
            // Form1
            // 
            ClientSize = new Size(369, 262);
            Controls.Add(Company_Label);
            Controls.Add(Company_entry);
            Controls.Add(label7);
            Controls.Add(Flight_final_position_y_entry);
            Controls.Add(label8);
            Controls.Add(Flight_final_position_x_entry);
            Controls.Add(label6);
            Controls.Add(Flight_Initial_position_y_entry);
            Controls.Add(label5);
            Controls.Add(Add_flight_button);
            Controls.Add(Speed_Label);
            Controls.Add(Speed_entry);
            Controls.Add(Final_position_Label);
            Controls.Add(Initial_position_Label);
            Controls.Add(Flight_ID_Label);
            Controls.Add(Flight_Initial_position_x_entry);
            Controls.Add(Flight_ID_entry);
            Name = "Form1";
            Load += Form1_Load;
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
            string Company = Company_entry.Text;

            // Declare variables outside so they are accessible later
            float initialX, initialY, finalX, finalY, speed;

            // Try parsing float values safely
            if (float.TryParse(Flight_Initial_position_x_entry.Text, out initialX) &&
                float.TryParse(Flight_Initial_position_y_entry.Text, out initialY) &&
                float.TryParse(Flight_final_position_x_entry.Text, out finalX) &&
                float.TryParse(Flight_final_position_y_entry.Text, out finalY) &&
                float.TryParse(Speed_entry.Text, out speed))
            {
                // All inputs are valid floats
                MessageBox.Show($"Flight ID: {flightID} " + $"Company: {Company}\n" +
                                $"Initial Position: ({initialX}, {initialY})\n" +
                                $"Final Position: ({finalX}, {finalY})\n" +
                                $"Speed: {speed}");

                // Add flight to file using your library
                Project_libs.Libs.AddFlightToFile(new Flight
                {
                    ID = flightID,
                    Company = Company,
                    Initial_position_x = initialX,
                    Initial_position_y = initialY,
                    Final_position_x = finalX,
                    Final_position_y = finalY,
                    speed = speed
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }

}

    

