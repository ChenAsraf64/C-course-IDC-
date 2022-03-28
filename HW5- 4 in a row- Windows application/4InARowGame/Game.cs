using System;
using System.Drawing;
using System.Windows.Forms;

namespace _4InARowGame
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }

        int columns = 0;
        int rows = 0;
        int count = 0;
        bool playermove = true ; //true = first player, false = second Player
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Game_Load(object sender, EventArgs e)
        {
            var m_RowCount = rows;
            var m_ColumnCount = columns;

            tableLayoutPanel1.ColumnCount = m_ColumnCount;
            tableLayoutPanel1.RowCount = m_RowCount;
            tableLayoutPanel2.ColumnCount = m_ColumnCount;
            tableLayoutPanel2.RowCount = 1;

            tableLayoutPanel1.ColumnStyles.Clear();
            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel2.ColumnStyles.Clear();
            tableLayoutPanel2.RowStyles.Clear();

            for (int i = 0; i < m_ColumnCount; i++)
            {
                tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100 / m_ColumnCount));
                tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100 / m_ColumnCount));
            }
            for (int i = 0; i < m_RowCount; i++)
            {
                tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100 / m_RowCount));
            }

            for (int i = 0; i < m_ColumnCount; i++)
            {
                var m_Button2 = new Button();
                m_Button2.Text = string.Format("{0}", i + 1);
                m_Button2.Name = string.Format("{0}", i + 1);
                m_Button2.Tag = i + 1; 
                m_Button2.Dock = DockStyle.Fill;
                m_Button2.Click += new EventHandler(ButtonClickOneEvent);
                tableLayoutPanel2.Controls.Add(m_Button2, i, 1);
                

                for (int j = 0; j < m_RowCount; j++)
                {

                    var m_Button = new Button();
                    //button.Text = string.Format("{0}{1}", j + 1, i + 1);
                    m_Button.Name = string.Format("button_{0}{1}", j + 1, i + 1);
                    m_Button.Enabled = false;
                    m_Button.Dock = DockStyle.Fill;
                    tableLayoutPanel1.Controls.Add(m_Button, i, j);
                }
            }
          
        }

        private void ButtonClickOneEvent(object sender, EventArgs e)
        {
            Button m_CurrentButton = (Button)sender;
            int buttonNumber = (int)m_CurrentButton.Tag;
            if(playermove)
            {
                AddItemAtColumn(buttonNumber, Color.Pink);
                if(CheckingIfTheGameIsAgainstComputer()) 
                {
                    count++; 
                    GameAgainstComputer();
                    playermove = !playermove;
                }
            }
            else//!playermove --> player2
            {
                AddItemAtColumn(buttonNumber, Color.LightBlue);
            }
            
            if(CheckIfWin(Color.Pink))
            {
                int m_Player1Points = Int32.Parse(label3.Text) + 1;
                label3.Text = m_Player1Points.ToString(); ;
                DialogResult m_PlayerChoice; 
                if (CheckIfTie())
                {
                    m_PlayerChoice = MessageBox.Show("Tie! \nAnother Round?", "A Tie!", MessageBoxButtons.YesNo);
                }
                else
                {
                    m_PlayerChoice = MessageBox.Show(string.Format("Player {0} Won!! \nAnother Round?", label1.Text), "A Win!", MessageBoxButtons.YesNo);
                }
                
                if (m_PlayerChoice == DialogResult.No)
                {
                    Application.Exit(); 
                }
            }

            if (CheckIfWin(Color.LightBlue))
            {
                int m_Player2Points = Int32.Parse(label4.Text) + 1;
                label4.Text = m_Player2Points.ToString();
                DialogResult m_PlayerChoice;
                if (CheckIfTie())
                {
                    m_PlayerChoice = MessageBox.Show("Tie! \nAnother Round?", "A Tie!", MessageBoxButtons.YesNo);
                }
                else
                {
                    m_PlayerChoice = MessageBox.Show(string.Format("Player {0} Won!! \nAnother Round?", label2.Text), "A Win!", MessageBoxButtons.YesNo);
                }
                if (m_PlayerChoice == DialogResult.No)
                {
                    Application.Exit();
                }
            }

            if (tableLayoutPanel1.GetControlFromPosition(buttonNumber - 1, 0).BackColor != Color.Cornsilk)
            {
                m_CurrentButton.Enabled = false;
            }
            playermove = !playermove;
            count++;
            if(count == rows * columns || CheckIfWin(Color.Pink) || CheckIfWin(Color.LightBlue))
            {
                count = 0; 
                //MessageBox.Show("End Game");
                for(int i = 1; i<=rows; i++)
                {
                    for(int j = 1; j <= columns; j++)
                    {
                        tableLayoutPanel1.GetControlFromPosition(j - 1, i - 1).BackColor = Color.Cornsilk;
                        EnabledPanelContents(tableLayoutPanel2, true);
                        playermove = true;

                    }
                }
            }
        }

        private void EnabledPanelContents(TableLayoutPanel i_Panel, bool io_Enabled)
        {
            foreach (Control ctrl in i_Panel.Controls)
            {
                ctrl.Enabled = io_Enabled;
            }
        }
        public void AddItemAtColumn(int i_Column, Color io_ColorCell)
        {
            for (int i = rows  ; i >= 1; i--)
            {
                if(this.tableLayoutPanel1.GetControlFromPosition(i_Column - 1, i - 1).BackColor == Color.Cornsilk)
                {
                    this.tableLayoutPanel1.GetControlFromPosition(i_Column - 1, i - 1).BackColor = io_ColorCell;
                    return; 
                }
            }
        }

        public bool AddItemAtRandomColumn(int i_Column, Color io_ColorCell)
        {
            for (int i = rows; i >= 1; i--)
            {
                if (this.tableLayoutPanel1.GetControlFromPosition(i_Column - 1, i - 1).BackColor == Color.Cornsilk)
                {
                    this.tableLayoutPanel1.GetControlFromPosition(i_Column - 1, i - 1).BackColor = io_ColorCell;
                    return true;
                }
            }
            return false; 
        }

        private bool CheckIfTie()
        {
            if(label3.Text == label4.Text && label3.Text != "0" && label4.Text != "0")
            {
                return true; 
            }
            return false; 
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public string LabelTextForPlayer2
        {
            set
            {
                label2.Text = value; 
            }
        }


        public string LabelTextForPlayer1
        {
            set
            {
                label1.Text = value;
            }
        }


        public void SetColumnsAndRows(int i_Columns, int i_Rows)
        {
            columns = i_Columns;
            rows = i_Rows; 
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Game_AutoSizeChanged(object sender, EventArgs e)
        {

        }

        private bool CheckIfWin(Color i_PlayerColor)
        {
            for (int j = 1; j <= columns - 3; j++)
            {
                for (int i = 1; i <= rows; i++)
                {
                    if(tableLayoutPanel1.GetControlFromPosition(i - 1, j - 1).BackColor == i_PlayerColor &&
                        tableLayoutPanel1.GetControlFromPosition(i - 1, j).BackColor == i_PlayerColor &&
                        tableLayoutPanel1.GetControlFromPosition(i - 1, j + 1).BackColor == i_PlayerColor &&
                        tableLayoutPanel1.GetControlFromPosition(i - 1, j + 2).BackColor == i_PlayerColor )
                    {
                        return true;
                    }
                }
            }
            //Checking id there is 4 in a row
            for (int i = 1; i <= columns - 3; i++)
            {
                for (int j = 1; j <= rows; j++)
                {
                    if (tableLayoutPanel1.GetControlFromPosition(i - 1, j - 1).BackColor == i_PlayerColor &&
                        tableLayoutPanel1.GetControlFromPosition(i, j - 1).BackColor == i_PlayerColor &&
                        tableLayoutPanel1.GetControlFromPosition(i + 1, j - 1).BackColor == i_PlayerColor &&
                        tableLayoutPanel1.GetControlFromPosition(i + 2, j - 1).BackColor == i_PlayerColor)
                    {
                        return true;
                    }
                }
            }

            //Checking 4 in a diagonal line
            for (int i = 4; i <= columns; i++)
            {
                for (int j = 1; j <= rows-3; j++)
                {
                    if (tableLayoutPanel1.GetControlFromPosition(i - 1, j - 1).BackColor == i_PlayerColor &&
                        tableLayoutPanel1.GetControlFromPosition(i - 2, j).BackColor == i_PlayerColor &&
                        tableLayoutPanel1.GetControlFromPosition(i - 3, j + 1).BackColor == i_PlayerColor &&
                        tableLayoutPanel1.GetControlFromPosition(i - 4, j + 2).BackColor == i_PlayerColor)
                    {
                        return true;
                    }
                }
            }

            for (int i = 4; i <= columns; i++)
            {
                for (int j = 4; j <= rows; j++)
                {
                    if (tableLayoutPanel1.GetControlFromPosition(i - 1, j - 1).BackColor == i_PlayerColor &&
                        tableLayoutPanel1.GetControlFromPosition(i - 2, j - 2).BackColor == i_PlayerColor &&
                        tableLayoutPanel1.GetControlFromPosition(i - 3, j - 3).BackColor == i_PlayerColor &&
                        tableLayoutPanel1.GetControlFromPosition(i - 4, j - 4).BackColor == i_PlayerColor)
                    {
                        return true;
                    }
                }
            }

            return false; 
        }

        private bool CheckingIfTheGameIsAgainstComputer()
        {
            if(label2.Text != "Computer:")
            {
                return false; 
            }
            return true; 
        }

        private void GameAgainstComputer()
        {
            Random m_Number = new Random();
            int randomNumber = m_Number.Next(1, columns+1);
            while (!AddItemAtRandomColumn(randomNumber, Color.LightBlue))
            {
                randomNumber = m_Number.Next(1, columns+1);
                int m_Random2 = randomNumber; 
            } 
        }
   
    }
}
