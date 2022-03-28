using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading; 

namespace C21_Ex02
{
    internal class Play
    {
        private Player m_Player1;
        private Player m_Player2;
        private bool m_TheComputerIsPlay = false;
        private bool m_PlayAgain = true;
        private int m_NumOfPlayerToPlay = 1;
        private bool m_Tie = true;
        private int m_PlayerWin = 0;

        internal void Start()
        {
            Console.Write("WELCOME TO THE GAME :)\n");
            Console.Write("you can leave in any point by write Q\n");
            Thread.Sleep(2500);
            Ex02.ConsoleUtils.Screen.Clear();
            m_Player1 = setPlayer1();
            m_Player2 = setPlayer2();
            int n_row = getNBoardRow();
            int n_col = getNBoardCol();
            Board board = new Board(n_row, n_col);
            Game game = new Game(m_Player1, m_Player2, board);

            Ex02.ConsoleUtils.Screen.Clear();
            Console.WriteLine(printBoard(game));

            while (m_PlayAgain == true)
            {
                while (game.GameBoardIsNotFull())
                {
                    if (m_PlayerWin == 0)
                    {
                        if (m_NumOfPlayerToPlay == 1)
                        {
                            Console.WriteLine("turn of player 1 to play");
                            Move move = getMovePlayer1(game);
                            setMovePlayer1(game, move);
                            Thread.Sleep(50);
                            Ex02.ConsoleUtils.Screen.Clear();
                            Console.WriteLine(printBoard(game));
                        }
                        else if (m_NumOfPlayerToPlay == 2)
                        {
                            setMovePlayer2(game);
                            Thread.Sleep(50);
                            Ex02.ConsoleUtils.Screen.Clear();
                            Console.WriteLine(printBoard(game));
                        }
                        else
                        {
                            m_NumOfPlayerToPlay = 1;
                        }
                    }

                    else if (m_PlayerWin == 1 || m_PlayerWin == 2)
                    {
                        Ex02.ConsoleUtils.Screen.Clear();
                        win(game);
                        Ex02.ConsoleUtils.Screen.Clear();
                        game.SetAllValToNull();
                        doYouWantToPlayAgain(game);
                    }


                }
            }
        }


        private int getNBoardRow()
        {
            Console.WriteLine("Please enter the number of row, a number between 4-8");
            string row = Console.ReadLine();
            while (!(row.Equals("8") || row.Equals("7") || row.Equals("6") || row.Equals("5") || row.Equals("4")) || row.Equals("Q"))
            {
                if (row.Equals("Q"))
                {
                    exitPlay();
                    break;
                }
                Console.WriteLine("please try again, a number between 4-8! ");
                row = Console.ReadLine();
            }

            int n_row;
            int.TryParse(row, out n_row);
            return n_row;
        }


        private int getNBoardCol()
         {
             Console.WriteLine("Please enter the number of colum, a number between 4-8");
             string col = Console.ReadLine();
             while (!(col.Equals("8") || col.Equals("7") || col.Equals("6") || col.Equals("5") || col.Equals("4")) || col.Equals("Q"))
             {
                 if (col.Equals("Q"))
                 {
                     exitPlay();
                     break;
                 }
                 Console.WriteLine("please try again, a number between 4-8!");
                 col = Console.ReadLine();
             }

             int n_col;
             int.TryParse(col, out n_col);

             return n_col;
         }


        private void doYouWantToPlayAgain(Game i_game)
        {
            Console.WriteLine("do you want to play again? if yes write 1 else write 2");
            string player_answer = Console.ReadLine();
            while (!(player_answer.Equals("1") || player_answer.Equals("2")) || player_answer.Equals("Q"))
            {
                if (player_answer.Equals("Q"))
                {
                    exitPlay();
                    break;
                }
                Console.WriteLine("please try again, write 1 or 2 ! ");
                player_answer = Console.ReadLine();
            }
            if (player_answer.Equals("1"))
            {
                m_PlayerWin = 0;
                m_PlayAgain = true;
                i_game.SetAllValToNull();
            }
            else
            {
                m_PlayAgain = false;
            }
        }

        private static Player setPlayer1()
         {
             Player player1 = new Player('X', 0, 1);
             return player1;

         }

        private Player setPlayer2()
         {
             Console.WriteLine("Hey player 1, " +
                 "if you want to play with a friend write 1,\n "
                     + "if you want to play with the computer write 2.");
             string input_of_player = Console.ReadLine();

             while (!(input_of_player.Equals("1")) && !(input_of_player.Equals("2")) || input_of_player.Equals("Q"))
             {
                 if (input_of_player.Equals("Q"))
                 {
                     exitPlay();
                     break;
                 }
                 Console.WriteLine("please try again, write 1 or 2 ! ");
                 input_of_player = Console.ReadLine();

             }

             if (input_of_player.Equals("1") == true)
             {
                 m_TheComputerIsPlay = false;
                 Player player2 = new Player('O', 0, 2);
                 return player2;
             }

             else
             {
                 m_TheComputerIsPlay = true;
                 Player player2 = new Player('O', 0, 2);
                 return player2;
             }

         }
        private int inputMoveCol(Game i_game)
         {
             Console.WriteLine("please choose the number of colum, a number between 1-" + i_game.BoardOfTheGame().GetColNum());
             string n_col = Console.ReadLine();
             int num_col;

             while (n_col.Equals("Q") || !(int.TryParse(n_col, out num_col)) || num_col < 1 || num_col > i_game.BoardOfTheGame().GetColNum())
             {
                 if (n_col.Equals("Q"))
                 {
                     exitPlay();
                     break;
                 }

                 Console.WriteLine("please write number between 1-" + i_game.BoardOfTheGame().GetColNum() + "!");
                 n_col = Console.ReadLine();
             }

             int.TryParse(n_col, out num_col);
             return num_col - 1;
         }



        private int getRowWithCol(Game i_game, int i_num)
         {
             for (int i = i_game.BoardOfTheGame().GetRowNum() - 1; -1 < i; i--)
             {
                 if (i_game.OkMove(i, i_num) || i_game.GameBoxItFree(i, i_num)) 
                 {
                     return i;
                 }
             }
             return -1;
         }


        private bool numOk(Game i_game, int i_num)
         {
             if (i_num > 0 || i_game.BoardOfTheGame().GetColNum() >= i_num)
             {
                 return true;
             }
             else
             {
                 return false;
             }
         }

        private bool stringOk(String i_num)
         {
             int num = 0;
             if (int.TryParse(i_num, out num))
             {
                 return true;
             }
             else
             {
                 return false;
             }
         }


        private Move getMovePlayer1(Game i_game)
         {
             int n_col = inputMoveCol(i_game);
             int n_row = getRowWithCol(i_game, n_col);

             while (n_row == -1 || n_col == -1)
             {
                 n_col = inputMoveCol(i_game);
                 n_row = getRowWithCol(i_game, n_col);
             }

             Move move = new Move(n_row, n_col);
             return move;

         }

        private void setMovePlayer1(Game i_game, Move i_move)
         {
             int n_row = i_move.GetNumOfRow();
             int n_col = i_move.GetNumOfCol();

             i_game.BoardOfTheGame().SetValInCharArr(n_row, n_col, 'X');
             Ex02.ConsoleUtils.Screen.Clear();
             Console.WriteLine(printBoard(i_game));

             if (cheakWinnigmove(i_game, m_Player1, i_move))
             {
                 m_Player1.AddPointToPlayer();
                 m_PlayerWin = 1;
                 win(i_game);
             }
             else if (!i_game.GameBoardIsNotFull())
             {
                 m_NumOfPlayerToPlay = 2;
                 m_Tie = true;
                 tieInTheGame(i_game);
             }
             else
             {
                 m_NumOfPlayerToPlay = 2;
             }
         }

        private bool setMoveIsOk(Game i_game, Move i_move)
         {
             while (!(i_game.GameBoardIsNotFull() || i_game.OkMove(i_move.GetNumOfRow(), i_move.GetNumOfCol())))
             {
                 return false;
             }

             return true;
         }

        private Move getMove2Comp(Game i_game)
         {
             int n_col = i_game.RandamColForComuterMove();
             int n_row = i_game.GetNumRowForComputer(n_col);

             while (!(i_game.BoardOfTheGame().BoardIsNotFull() || i_game.OkMove(n_row, n_col) || 0 <= n_row))
             {
                 n_col = i_game.RandamColForComuterMove();
                 n_row = i_game.GetNumRowForComputer(n_col);
             }


             Move move = new Move(n_row, n_col);
             return move;
         }


        private void setMovePlayer2(Game i_game)
         {
             if (!m_TheComputerIsPlay)
             {
                 Console.WriteLine("player 2 it is our turn to play");

                 int n_col = inputMoveCol(i_game);
                 int n_row = getRowWithCol(i_game, n_col);

                 while (n_row == -1 || n_col == -1)
                 {
                     n_col = inputMoveCol(i_game);
                     n_row = getRowWithCol(i_game, n_col);
                 }

                 Move move = new Move(n_row, n_col);

                 i_game.BoardOfTheGame().SetValInCharArr(n_row, n_col, 'O');
                 Ex02.ConsoleUtils.Screen.Clear();
                 Console.WriteLine(printBoard(i_game));


                 if (cheakWinnigmove(i_game, m_Player2, move))
                 {
                     m_Player2.AddPointToPlayer();
                     m_PlayerWin = 2;
                     win(i_game);
                 }
                 else if (!i_game.GameBoardIsNotFull())
                 {
                     m_NumOfPlayerToPlay = 1;
                     m_Tie = true;
                     tieInTheGame(i_game);
                 }
                 else
                 {
                     m_NumOfPlayerToPlay = 1;
                 }
             }
             else
             {
                 Console.WriteLine("the computer move");
                 Thread.Sleep(2000);
                 Move move_computer = getMove2Comp(i_game);

                 while (!(setMoveIsOk(i_game, move_computer)))
                 {
                     move_computer = getMove2Comp(i_game);
                 }

                 i_game.BoardOfTheGame().SetValInCharArr(move_computer.GetNumOfRow(), move_computer.GetNumOfCol(),  'O');

                 Ex02.ConsoleUtils.Screen.Clear();
                 Console.WriteLine(printBoard(i_game));
                 Thread.Sleep(500);

                 if (cheakWinnigmove(i_game, m_Player2, move_computer))
                 {
                     m_Player2.AddPointToPlayer();
                     m_PlayerWin = 2;
                     win(i_game);
                 }
                 else if (!i_game.GameBoardIsNotFull())
                 {
                     m_NumOfPlayerToPlay = 1;
                     m_Tie = true;
                     tieInTheGame(i_game);
                 }
                 else
                 {
                     m_NumOfPlayerToPlay = 1;
                 }
             }
         }



        private void tieInTheGame(Game i_game)
         {
             while (m_Tie)
             {
                 m_Player1.AddPointToPlayer();
                 m_Player2.AddPointToPlayer();
                 Console.WriteLine(printPoints(i_game));
                 doYouWantToPlayAgain(i_game);

             }
         }
        private bool cheakWinnigmoveByRow(Game i_game, Player i_player, Move i_move)
         {
             int n_row = i_move.GetNumOfRow();
             int count = 0;
             bool remp = false;
             for (int i = 0; i < i_game.BoardOfTheGame().GetColNum(); i++)
             {
                 if (i_game.BoardOfTheGame().GetValueOfTheBox(n_row, i) == i_player.SignOfPlayer())
                 {
                     count++;
                     if (count == 4)
                     {
                         remp = true;
                         break;
                     }
                 }
                 else
                 {
                     count = 0;
                 }
             }
                
             return remp;
         }


        private bool cheakWinnigMoveByCol(Game i_game, Player i_player, Move i_move)
         {
             int n_col = i_move.GetNumOfCol();
             int count = 0;
             bool remp = false;
             for (int i = 0; i < i_game.BoardOfTheGame().GetRowNum(); i++)
             {
                 if (i_game.BoardOfTheGame().GetValueOfTheBox(i, n_col) == i_player.SignOfPlayer())
                 {
                     count++;
                     if (count == 4)
                     {
                         remp = true;
                         break;
                     }
                 }
                 else
                 {
                     count = 0;
                 }
             }

             return remp;
         }



        private bool cheakWinnigMoveByA1(Game i_game, Player i_player, Move i_move)
         {
             int n_row = i_move.GetNumOfRow();
             int n_col = i_move.GetNumOfCol();
             int count = 0;
             while (n_col < i_game.BoardOfTheGame().GetColNum() && 0 <= n_col && n_row < i_game.BoardOfTheGame().GetRowNum() && 0 <= n_row)
             {
                 if (i_game.BoardOfTheGame().GetValueOfTheBox(n_row, n_col) == i_player.SignOfPlayer())
                 {
                     count++;
                     if (count == 4)
                     {
                         return true;
                     }
                 }
                 else
                 {
                     count = 0;
                 }
                 n_row++;
                 n_col--;
             }

             return false;
         }

        private bool cheakWinnigMoveByA2(Game i_game, Player i_player, Move i_move)
         {
             int n_row = i_move.GetNumOfRow();
             int n_col = i_move.GetNumOfCol();
             int count = 0;
             while (n_col < i_game.BoardOfTheGame().GetColNum() && 0 <= n_col && n_row < i_game.BoardOfTheGame().GetRowNum() && 0 <= n_row)
             {
                 if (i_game.BoardOfTheGame().GetValueOfTheBox(n_row, n_col) == i_player.SignOfPlayer())
                     {
                         count++;
                         if (count == 4)
                         {
                             return true;
                         }
                     }
                     else
                     {
                         count = 0;
                     }
                     n_row++;
                     n_col++;
             }

             return false;
         }


        private bool cheakWinnigmove(Game i_game, Player i_player, Move i_move)
         {
             return (cheakWinnigMoveByCol(i_game, i_player, i_move) || cheakWinnigMoveByCol(i_game, i_player, i_move) ||
                 cheakWinnigMoveByA1(i_game, i_player, i_move) || cheakWinnigMoveByA2(i_game, i_player, i_move));
         }


        private void win(Game i_game)
         {
             Ex02.ConsoleUtils.Screen.Clear();
             Console.WriteLine("playe " + m_PlayerWin + " YOU WON!!!");
             Console.WriteLine(printPoints(i_game));
             doYouWantToPlayAgain(i_game);
         }


        private StringBuilder printBoard(Game i_game)
         {
             StringBuilder board_to_print = new StringBuilder();
             board_to_print.Append(Environment.NewLine);
             board_to_print.Append(i_game.BoardOfTheGame().PrintBoard());
             board_to_print.Append(Environment.NewLine);


             return board_to_print;
         }


        private StringBuilder printPoints(Game i_game)
         {
             StringBuilder print_points = new StringBuilder();
             string point_player1 = "player 1 have " + m_Player1.PointsOfPlayer() + " points\n";
             string point_player2 = "player 2 have " + m_Player2.PointsOfPlayer() + " points\n";
             print_points.Append(point_player1);
             print_points.Append(point_player2);
             return print_points;
         }

        private void exitPlay()
         {
             Console.WriteLine("hope that you have fun! goodbye");
             Thread.Sleep(50000);
             
         }

    }
}
