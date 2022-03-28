using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C21_Ex02
{
    internal class Player
    {
        private char m_SignOfPlayer;
        private int m_PointOfPlayer;
        private int m_NumOfPlayer;

        internal Player(char i_Sign, int i_NumPlayer, int i_NumOfThePlayer)
        {
            m_SignOfPlayer = i_Sign;
            m_NumOfPlayer = i_NumPlayer;
            m_NumOfPlayer = i_NumOfThePlayer;
        }
        internal char SignOfPlayer()
        {
            return m_SignOfPlayer;
        }


        internal int PointsOfPlayer()
        {
            return m_NumOfPlayer; 

        }

        internal void AddPointToPlayer()
        {
            m_PointOfPlayer++;
        }
    }
}
