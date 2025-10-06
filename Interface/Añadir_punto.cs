using FlightLib;
using System.Drawing.Text;

namespace GUI
{
    public partial class Añadir_punto : Form
    {
        FlightPlan f;
        public Añadir_punto()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            Flight_ID_entry = new TextBox();
            Company_entry = new TextBox();
            Flight_Initial_position_x_entry = new TextBox();
            Flight_Initial_position_y_entry = new TextBox();
            Flight_final_position_x_entry = new TextBox();
            Flight_final_position_y_entry = new TextBox();
            Speed_entry = new TextBox();
            Flight_ID_Label = new Label();
            Initial_position_Label = new Label();
            Final_position_Label = new Label();
            Speed_Label = new Label();
            Add_flight_button = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            Company_Label = new Label();
            pageSetupDialog1 = new PageSetupDialog();
            panel1 = new Panel();
            ManagerFlight_AddFlight_Label = new Label();
            this.Cancel_Button = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Flight_ID_entry
            // 
            Flight_ID_entry.Location = new Point(134, 9);
            Flight_ID_entry.Name = "Flight_ID_entry";
            Flight_ID_entry.Size = new Size(164, 23);
            Flight_ID_entry.TabIndex = 0;
            // 
            // Company_entry
            // 
            Company_entry.Location = new Point(134, 38);
            Company_entry.Name = "Company_entry";
            Company_entry.Size = new Size(164, 23);
            Company_entry.TabIndex = 1;
            // 
            // Flight_Initial_position_x_entry
            // 
            Flight_Initial_position_x_entry.Location = new Point(157, 95);
            Flight_Initial_position_x_entry.Name = "Flight_Initial_position_x_entry";
            Flight_Initial_position_x_entry.Size = new Size(56, 23);
            Flight_Initial_position_x_entry.TabIndex = 2;
            // 
            // Flight_Initial_position_y_entry
            // 
            Flight_Initial_position_y_entry.Location = new Point(245, 95);
            Flight_Initial_position_y_entry.Name = "Flight_Initial_position_y_entry";
            Flight_Initial_position_y_entry.Size = new Size(56, 23);
            Flight_Initial_position_y_entry.TabIndex = 3;
            // 
            // Flight_final_position_x_entry
            // 
            Flight_final_position_x_entry.Location = new Point(157, 121);
            Flight_final_position_x_entry.Name = "Flight_final_position_x_entry";
            Flight_final_position_x_entry.Size = new Size(56, 23);
            Flight_final_position_x_entry.TabIndex = 4;
            // 
            // Flight_final_position_y_entry
            // 
            Flight_final_position_y_entry.Location = new Point(245, 121);
            Flight_final_position_y_entry.Name = "Flight_final_position_y_entry";
            Flight_final_position_y_entry.Size = new Size(56, 23);
            Flight_final_position_y_entry.TabIndex = 5;
            // 
            // Speed_entry
            // 
            Speed_entry.Location = new Point(137, 150);
            Speed_entry.Name = "Speed_entry";
            Speed_entry.Size = new Size(164, 23);
            Speed_entry.TabIndex = 6;
            // 
            // Flight_ID_Label
            // 
            Flight_ID_Label.AutoSize = true;
            Flight_ID_Label.Location = new Point(11, 12);
            Flight_ID_Label.Name = "Flight_ID_Label";
            Flight_ID_Label.Size = new Size(51, 15);
            Flight_ID_Label.TabIndex = 6;
            Flight_ID_Label.Text = "Flight ID";
            // 
            // Initial_position_Label
            // 
            Initial_position_Label.AutoSize = true;
            Initial_position_Label.Location = new Point(14, 95);
            Initial_position_Label.Name = "Initial_position_Label";
            Initial_position_Label.Size = new Size(82, 15);
            Initial_position_Label.TabIndex = 3;
            Initial_position_Label.Text = "Initial position";
            // 
            // Final_position_Label
            // 
            Final_position_Label.AutoSize = true;
            Final_position_Label.Location = new Point(14, 124);
            Final_position_Label.Name = "Final_position_Label";
            Final_position_Label.Size = new Size(78, 15);
            Final_position_Label.TabIndex = 4;
            Final_position_Label.Text = "Final position";

            // 
            // Speed_Label
            // 
            Speed_Label.AutoSize = true;
            Speed_Label.Location = new Point(14, 153);
            Speed_Label.Name = "Speed_Label";
            Speed_Label.Size = new Size(39, 15);
            Speed_Label.TabIndex = 8;
            Speed_Label.Text = "Speed";
            // 
            // Add_flight_button
            // 
            Add_flight_button.Location = new Point(137, 179);
            Add_flight_button.Name = "Add_flight_button";
            Add_flight_button.Size = new Size(164, 23);
            Add_flight_button.TabIndex = 9;
            Add_flight_button.Text = "Add Flight";
            Add_flight_button.UseVisualStyleBackColor = true;
            Add_flight_button.Click += Add_flight_button_click;
            // 
            // Cancel_Button
            // 
            Cancel_Button.Location = new Point(14, 179);
            Cancel_Button.Name = "Cancel_Button";
            Cancel_Button.Size = new Size(121, 23);
            Cancel_Button.TabIndex = 21;
            Cancel_Button.Text = "Cancel";
            Cancel_Button.UseVisualStyleBackColor = true;
            Cancel_Button.Click += Cancel_Button_click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(137, 98);
            label5.Name = "label5";
            label5.Size = new Size(14, 15);
            label5.TabIndex = 10;
            label5.Text = "X";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(225, 98);
            label6.Name = "label6";
            label6.Size = new Size(14, 15);
            label6.TabIndex = 12;
            label6.Text = "Y";
     
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(225, 124);
            label7.Name = "label7";
            label7.Size = new Size(14, 15);
            label7.TabIndex = 16;
            label7.Text = "Y";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(137, 124);
            label8.Name = "label8";
            label8.Size = new Size(14, 15);
            label8.TabIndex = 14;
            label8.Text = "X";

            // 
            // Company_Label
            // 
            Company_Label.AutoSize = true;
            Company_Label.Location = new Point(11, 41);
            Company_Label.Name = "Company_Label";
            Company_Label.Size = new Size(59, 15);
            Company_Label.TabIndex = 18;
            Company_Label.Text = "Company";
            // 
            // panel1
            // 
            panel1.Controls.Add(this.Cancel_Button);
            panel1.Controls.Add(Flight_final_position_x_entry);
            panel1.Controls.Add(Company_Label);
            panel1.Controls.Add(Flight_ID_entry);
            panel1.Controls.Add(Company_entry);
            panel1.Controls.Add(Flight_Initial_position_x_entry);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(Flight_ID_Label);
            panel1.Controls.Add(Flight_final_position_y_entry);
            panel1.Controls.Add(Initial_position_Label);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(Final_position_Label);
            panel1.Controls.Add(Speed_entry);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(Speed_Label);
            panel1.Controls.Add(Flight_Initial_position_y_entry);
            panel1.Controls.Add(Add_flight_button);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(0, 18);
            panel1.Name = "panel1";
            panel1.Size = new Size(319, 209);
            panel1.TabIndex = 19;
            // 
            // ManagerFlight_AddFlight_Label
            // 
            ManagerFlight_AddFlight_Label.AutoSize = true;
            ManagerFlight_AddFlight_Label.Location = new Point(0, 0);
            ManagerFlight_AddFlight_Label.Name = "ManagerFlight_AddFlight_Label";
            ManagerFlight_AddFlight_Label.Size = new Size(153, 15);
            ManagerFlight_AddFlight_Label.TabIndex = 20;
            ManagerFlight_AddFlight_Label.Text = "Flight Manager - Add Flight";
            // 
            // Form1
            // 
            ClientSize = new Size(308, 227);
            Controls.Add(ManagerFlight_AddFlight_Label);
            Controls.Add(panel1);
            Name = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        public FlightPlan DamePlan()
        {
            return this.f;
        }

        private void Cancel_Button_click(object sender, EventArgs e)
        {
            this.Close();
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
                f = new FlightPlan(flightID, initialX, initialY, finalX, finalY, speed);

                this.Close();
            }
            else
            {
                // If any parsing fails
                MessageBox.Show("Please enter valid numeric values for positions.");
            }
        }
    }

}

    

