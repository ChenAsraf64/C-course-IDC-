using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

// $G$ RUL-001 (-10) Email - Wrong subject format.
// $G$ RUL-004 (-10) Wrong zip name format / folder name format.
// $G$ RUL-007 (-80) Late submission (2 points per day).
// $G$ RUL-999 (-10) Wrong solution name format.

// $G$ SFN-001 (-5) The program does not compile
// $G$ SFN-010 (-5) The program does not recognize the state of completion or retirement from the game as required. Not exit the game.
// $G$ SFN-011 (-5) The program does not allow another new game, after finishing one. In case of two players.

namespace C21_Ex02
{
    class Program
    {
        public static void Main()
        {
            new Play().Start();
            Thread.Sleep(5000);
        }
    }
}
