using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C21_Ex02
{
    internal class Board
    {
        private int m_NumRow;
        private int m_NumCol;
        private char[,] m_BoardChar;

        internal Board(int i_NumRow, int i_NumCol)
        {
            m_NumRow = i_NumRow;
            m_NumCol = i_NumCol;
            m_BoardChar = new char[m_NumRow, m_NumCol];
        }

        internal void SetValInCharArr(int i_NumRow, int i_NumCol, char i_val)
        {
            m_BoardChar[i_NumRow, i_NumCol] = i_val;
        }

        internal int GetRowNum()
        {
            return m_NumRow;
        }


        internal int GetColNum()
        {
            return m_NumCol;
        }

        internal bool BoxIsFree(int i_NumRow, int i_NumCol)
        {
            char SignPlayer1 = 'X';
            char SignPlayer2 = 'O';
            while (i_NumRow < GetRowNum() && i_NumCol < GetColNum() && i_NumRow > -1 && i_NumRow > -1)
            {
                if (m_BoardChar[i_NumRow, i_NumCol].Equals(SignPlayer1) || m_BoardChar[i_NumRow, i_NumCol].Equals(SignPlayer2))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            return true;
        }

        internal bool ColdIsNotFull(int i_NumCol)
        {
            for (int i = 0; i < GetRowNum(); i++)
            {
                if (BoxIsFree(i, i_NumCol))
                {
                    return true;
                }
            }

            return false;
        }

        internal bool BoardIsNotFull()
        {
            bool FullOrNot = false;
            for (int i = 0; i < GetRowNum(); i++)
            {
                for (int j = 0; j < GetColNum(); j++)
                {
                    if (BoxIsFree(i, j))
                    {
                        return true;
                    }
                    else
                    {
                        FullOrNot = false;
                    }
                }

            }
            return FullOrNot;
        }


        internal char GetValueOfTheBox(int i_NumRow, int i_NumCol)
        {
            return m_BoardChar[i_NumRow, i_NumCol];
        }



        // $G$ DSN-999 (-3) You should override ToString.
        internal StringBuilder PrintBoard()
        {
            int n_row = GetRowNum();
            int n_col = GetColNum();

            StringBuilder Board = new StringBuilder();
            StringBuilder Board_val = new StringBuilder();
            StringBuilder Board_pattern = new StringBuilder();

            for (int i = -1; i < n_row; i++)
            {
                for (int j = -1; j < n_col; j++)
                {
                    if (i == -1)
                    {
                        if (j == -1)
                        {
                            Board_pattern.Append("  =");
                            Board_val.Append("  ");
                        }
                        else
                        {
                            Board_pattern.Append("====");
                            Board_val.Append("   ");
                            Board_val.Append((char)('1' + j));
                        }
                    }
                    else
                    {
                        if (j == -1)
                        {
                            Board_val.Append("  | ");
                        }
                        else
                        {
                            if (!(BoxIsFree(i, j)))
                            {
                                Board_val.Append(m_BoardChar[i, j]);
                                Board_val.Append(" | ");
                            }
                            else
                            {
                                Board_val.Append("  | ");
                            }
                        }
                    }

                }

                Board.Append(Board_val);
                Board_val = Board_val.Clear();
                if (i != -1)
                {
                    Board.Append(Environment.NewLine);
                    Board.Append(Board_pattern);
                }

                Board.Append(Environment.NewLine);
            }

            return Board;

        }


    }
}
