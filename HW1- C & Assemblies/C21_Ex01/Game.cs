using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C21_Ex02
{
    internal class Game
    {
        private Player m_Player1;
        private Player m_Player2;
        private Board m_BoardGame;
        private bool m_IsTheComputerIsAPlayer2;


        internal Game(Player i_player1, Player i_player2, Board i_game_board)
        {
            m_Player1 = i_player1;
            m_Player2 = i_player2;
            m_BoardGame = i_game_board;
        }

        internal Board BoardOfTheGame()
        {
            return m_BoardGame;
        }

        internal bool OkMove(int i_NumRow, int i_NumCol)
        {
            if (i_NumCol < 0 || i_NumCol > m_BoardGame.GetColNum())
            {
                return false;
            }
            else if (i_NumRow < 0 || i_NumRow > m_BoardGame.GetRowNum())
            {
                return false;
            }
            else if (m_BoardGame.BoxIsFree(i_NumRow, i_NumCol) == false)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        internal void SetAllValToNull()
        {
            for (int i = 0; i < m_BoardGame.GetRowNum(); i++)
            {
                for (int j = 0; j < m_BoardGame.GetColNum(); j++)
                {
                    BoardOfTheGame().SetValInCharArr(i, j, ' ');
                }
            }
        }


        internal int RandamColForComuterMove()
        {
            Random n_randam = new Random();
            int randamNumCol = n_randam.Next(0, this.m_BoardGame.GetRowNum());

            while (m_BoardGame.ColdIsNotFull(randamNumCol) == false)
            {
                randamNumCol = n_randam.Next(0, this.m_BoardGame.GetRowNum());
            }
            return randamNumCol;
        }


        internal int GetNumRowForComputer(int i_NumCol)
        {
            if (m_BoardGame.ColdIsNotFull(i_NumCol))
            {
                for (int i = m_BoardGame.GetRowNum() - 1; -1 < i; i--)
                {
                    if (m_BoardGame.BoxIsFree(i, i_NumCol) && OkMove(i, i_NumCol))
                    {
                        return i;
                    }
                }
            }

            return -1;

        }



        internal bool GameBoxItFree(int i_NumRow, int i_NumCol)
        {
            return m_BoardGame.BoxIsFree(i_NumRow, i_NumCol);
        }


        internal bool GameBoardIsNotFull()
        {
            return m_BoardGame.BoardIsNotFull();
        }


    }
}
