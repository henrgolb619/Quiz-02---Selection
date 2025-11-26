namespace Quiz_02___Selection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void q04InstructionButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The user will enter the temperature in the first text box and answer if they brought a jacket in the second text box.  The output will be:\r\n\r\n“You should be comfortable” if If they brought a jacket and the temperature is below 15 , or they did not bring a jacket and the temperature is above 15\r\n\r\nIf they brought a jacket and the temperature is above 15 “You will be too hot”\r\n\r\nIf they did not bring a jacket and the temperature is below 15 “You are going to be cold”\r\n\r\nMake sure you add a try catch so there are no runtime errors.\r\n  For full marks use exactly three if statements ");
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void bonusButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Change the text in this message box to answer the question:  Provide an example to explain why you would choose 'if..else if' instead of repeated 'if' statements");
        }

        private void q1TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void q1Button_Click(object sender, EventArgs e)
        {
            if (q1TextBox.Text == "Banana")
            {
                q1OutputLabel.Text = "Secret Unlocked!";
            }
            else
            {
                q1OutputLabel.Text = "Wrong Password! Try Again!";
            }
        }

        private void q2Button_Click(object sender, EventArgs e)
        {
            if (q2TextBox.Text == "r")
            {
                q2OutputLabel.Text = "Rock On!";
            }
            else if (q2TextBox.Text == "c")
            {
                q2OutputLabel.Text = "Giddy-Up!";
            }
            else
            {
                q2OutputLabel.Text = "Please enter a valid response.";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void q3Button_Click(object sender, EventArgs e)
        {
            try
            {
                int grade = Convert.ToInt32(q3TextBox.Text);

                if (grade < 50)
                {
                    q3OutputLabel.Text = "You Failed..";
                }
                if (grade >= 50)
                {
                    q3OutputLabel.Text = "You Passed!";
                }
                if (grade > 80)
                {
                    q3OutputLabel.Text = "Excellent Effort!";
                }


            }
            catch
            {
                q3OutputLabel.Text = "Please enter an appropriate integer.";
            }
        }

        private void q4Button_Click(object sender, EventArgs e)
        {
            try
            {
                bool coat;
                int temperature;

                if (q4CoatTextBox.Text == "y")
                {
                    coat = true;
                }
                else
                {
                    coat = false;
                }

                temperature = int.Parse(q4TempTextBox.Text);

                
                if (coat)
                {
                    
                    if (temperature > 15)
                    {
                        q4OutputLabel.Text = "You will be too hot.";
                    }
                    else
                    {
                        q4OutputLabel.Text = "You will be comfortable.";
                    }
                }
                else
                {
                    if (temperature > 15)
                    {
                        q4OutputLabel.Text = "You will be comfortable.";
                    }
                    else
                    {
                        q4OutputLabel.Text = "You will be too cold.";
                    }
                }
            }
            catch
            {
                q4OutputLabel.Text = "Invalid input.";
            }
            /*
                 *                                                     ________
                 *                                                    /        \
                 *                                                   |  o    o  |    
                 *                                                   |     >    | 
                 *                                                   |          |
                 *                                                   |  \____/  |
                 *                                                    \________/
                 *                                                 
                 */
        }
    }
}
