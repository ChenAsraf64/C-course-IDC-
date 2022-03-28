using System;
using System.Windows.Forms;

namespace _4InARowGame
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //If checBox was marked so enabled player 2 text box 
            if (checkBox1.Checked)
            {
                textBox2.Enabled = true;
                textBox2.Text = "";
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Game startGameForm = new Game();
            //Changing the names on labels for 2 players
            if(checkBox1.Checked)
            {
                startGameForm.LabelTextForPlayer2 = textBox2.Text + ":"; 
            }
            if(!String.IsNullOrEmpty(textBox1.Text))
            {
                startGameForm.LabelTextForPlayer1 = textBox1.Text + ":"; 
            }
            startGameForm.SetColumnsAndRows((int)numericUpDown1.Value, (int)numericUpDown2.Value);
            startGameForm.ShowDialog();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
      
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
