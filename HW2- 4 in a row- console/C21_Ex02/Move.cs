using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C21_Ex02
{
    internal class Move
    {
        // $G$ CSS-999 (-2) this members should be readonly.
        private int m_NumOfRow;
        private int m_NumOfCol;


        internal Move(int i_NumRow, int i_NumCol)
        {
            m_NumOfRow = i_NumRow;
            m_NumOfCol = i_NumCol;
        }

        internal int GetNumOfRow()
        {
            return m_NumOfRow;
        }

        internal int GetNumOfCol()
        {
            return m_NumOfCol;
        }

    }
}