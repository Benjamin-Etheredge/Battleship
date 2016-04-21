using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Battleship
{
    static class Program
    {
        
            //Battleship batShip = new Battleship();
            //batShip.Play();
            /// <summary>
            /// The main entry point for the application.
            /// </summary>
            [STAThread]
            static void Main()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
    
    }

    public class Battleship
    {
        public enum Orientation:int { Horizontal = 0, Vertical = 1 };

        // Variables
        private int[,] humanBoard;
        private int[,] computerBoard;
        private Random randomObject = new Random();

        // Constants
        private const int SIZE_OF_BOARD = 10;

        private const int ATTACKED = 0;
        private const int EMPTY_SEA = 1;

        private const int PATROL_BOAT = 2;
        private const int PATROL_SIZE = 2;

        private const int DESTROYER = 3;
        private const int DESTROYER_SIZE = 3;

        private const int SUBMARINE = 4;
        private const int SUBMARINE_SIZE = 3;

        private const int BATTLESHIP = 5;
        private const int BATTLESHIP_SIZE = 4;

        private const int AIRCRAFT_CARRIER = 6;
        private const int AIRCRAFT_CARRIER_SIZE = 5;

        private bool humanTurn = true;

        public Battleship()
        {
            humanBoard = new int[SIZE_OF_BOARD, SIZE_OF_BOARD];
            computerBoard = new int[SIZE_OF_BOARD, SIZE_OF_BOARD];
            ClearBoards();
            
        }

        public void SimpleDisplay()
        {
            for (int i = 0; i < SIZE_OF_BOARD; i++)
            {
                for (int j = 0; j < SIZE_OF_BOARD; j++)
                {
                    Console.Write(humanBoard[i, j] + "\n");
                }
                Console.WriteLine();
            }
        }

        public void Play()
        {

            SetupComputerBoard();
            SetupHumanBoard(); //TODO: remove this for gui

            while (IsWinner() == 0)
            {
                if (humanTurn)
                {
                    ComputerFIRE();
                }
                else
                {
                    ComputerFIRE();
                }
                humanTurn = !humanTurn;
            }
        }

        public void ClearBoards()
        {
            for (int i = 0; i < SIZE_OF_BOARD; i++)
            {
                for (int j = 0; j < SIZE_OF_BOARD; j++)
                {
                    humanBoard[i, j] = 0;
                    computerBoard[i, j] = 0;
                }
            }
        }

        // hand off to gui. gui shouldn't use this function.
        public void SetupHumanBoard()
        {
            //bool isPlaced = false;

            //// place patrol
            //while (!isPlaced)
            //{

            //}

            //isPlaced = false;

            // place patrol
            while (AttemptToPlaceShip(ref humanBoard, PATROL_BOAT, PATROL_SIZE, (Orientation)randomObject.Next(1), randomObject.Next(SIZE_OF_BOARD - 1), randomObject.Next(SIZE_OF_BOARD - 1))) ;

            // place destroyer
            while (AttemptToPlaceShip(ref humanBoard, DESTROYER, DESTROYER_SIZE, (Orientation)randomObject.Next(1), randomObject.Next(SIZE_OF_BOARD - 1), randomObject.Next(SIZE_OF_BOARD - 1))) ;

            // place submarine
            while (AttemptToPlaceShip(ref humanBoard, SUBMARINE, SUBMARINE_SIZE, (Orientation)randomObject.Next(1), randomObject.Next(SIZE_OF_BOARD - 1), randomObject.Next(SIZE_OF_BOARD - 1))) ;

            // place battleship
            while (AttemptToPlaceShip(ref humanBoard, BATTLESHIP, BATTLESHIP_SIZE, (Orientation)randomObject.Next(1), randomObject.Next(SIZE_OF_BOARD - 1), randomObject.Next(SIZE_OF_BOARD - 1))) ;

            // place carrier
            while (AttemptToPlaceShip(ref humanBoard, AIRCRAFT_CARRIER, AIRCRAFT_CARRIER_SIZE, (Orientation)randomObject.Next(1), randomObject.Next(SIZE_OF_BOARD - 1), randomObject.Next(SIZE_OF_BOARD - 1))) ;

        }

        public void SetupComputerBoard()
        {            
            // place patrol
            while (AttemptToPlaceShip(ref computerBoard, PATROL_BOAT, PATROL_SIZE, (Orientation)randomObject.Next(1), randomObject.Next(SIZE_OF_BOARD - 1), randomObject.Next(SIZE_OF_BOARD - 1)));

            // place destroyer
            while (AttemptToPlaceShip(ref computerBoard, DESTROYER, DESTROYER_SIZE, (Orientation)randomObject.Next(1), randomObject.Next(SIZE_OF_BOARD - 1), randomObject.Next(SIZE_OF_BOARD - 1))) ;

            // place submarine
            while (AttemptToPlaceShip(ref computerBoard, SUBMARINE, SUBMARINE_SIZE, (Orientation)randomObject.Next(1), randomObject.Next(SIZE_OF_BOARD - 1), randomObject.Next(SIZE_OF_BOARD - 1))) ;

            // place battleship
            while (AttemptToPlaceShip(ref computerBoard, BATTLESHIP, BATTLESHIP_SIZE, (Orientation)randomObject.Next(1), randomObject.Next(SIZE_OF_BOARD - 1), randomObject.Next(SIZE_OF_BOARD - 1))) ;

            // place carrier
            while (AttemptToPlaceShip(ref computerBoard, AIRCRAFT_CARRIER, AIRCRAFT_CARRIER_SIZE, (Orientation)randomObject.Next(1), randomObject.Next(SIZE_OF_BOARD - 1), randomObject.Next(SIZE_OF_BOARD - 1))) ;
        }

        public bool AttemptToPlaceShip(ref int[,] board, int shipCode, int size, Orientation orientation, int x, int y)
        {
            // is spot available
            bool isLocationFree = true;

            int[,] tempBoard = board;
            // Copy(board, tempBoard, SIZE_OF_BOARD);

            for (int i = 0; i < size && isLocationFree; i++)
            {
                if (orientation == Orientation.Horizontal)
                {

                    if (x + i >= SIZE_OF_BOARD || board[x + i, y] > 0)
                    {
                        isLocationFree = false;
                    }
                    else
                    {
                        tempBoard[x + i, y] = shipCode;
                    }
                }
                else
                {
                    if (y + i >= SIZE_OF_BOARD || board[x, y + i] > 0)
                    {
                        isLocationFree = false;
                    }
                    else
                    {
                        tempBoard[x, y + i] = shipCode;
                    }
                }
            }
             //TODO: TEST THIS
            if (isLocationFree)
            {
                board = tempBoard;
            }

            return isLocationFree;

        }

        // fire randomly till valid move is made
        public void ComputerFIRE()
        {
            bool hasFired = false;
            while (!hasFired)
            {
                int x = randomObject.Next(9);
                int y = randomObject.Next(9);
                if (FIRE(x, y) != 0)
                {
                    hasFired = true;
                }
            }
        }

        const int HUMAN_WIN = 1;
        const int COMPUTER_WIN = 2;
        //TODO: write
        // assumes theres a winner till proven there is not due to that being easier
        // 0 == no winner; 1 == human win; 2 == computer win; 
        public int IsWinner()
        {
            int winner = 0;
            bool didComputerWin = true;
            bool didHumanWin = true;
            
            for (int i = 0; i < SIZE_OF_BOARD && (didComputerWin || didHumanWin); i++)
            {
                for (int j = 0; j < SIZE_OF_BOARD && (didComputerWin || didHumanWin); j++)
                {
                    // will run check everytime but oh well
                    if (didComputerWin && humanBoard[i, j] > 0)
                    {
                        didComputerWin = false;
                    }
                    if (didHumanWin && computerBoard[i, j] > 0)
                    {
                        didHumanWin = false;
                    }
                }
            }

            // if both are still marked as winners, an error has occured since check is done after every move
            if (didHumanWin && didComputerWin)
            {
                throw new Exception("ERROR: Two winners");
            }

            // which person if any won
            else if (didHumanWin) 
            {
                winner = 1;
            }
            else if (didComputerWin)
            {
                winner = 2;
            }

            return winner;

        }

        public int FIRE(int x, int y)
        {
            // using a ref would be easier but can't in c#
            int valueOfTargetedLocation = 0;
            
            if(humanTurn)
            {
                if (humanBoard[x, y] > 0)
                {
                    valueOfTargetedLocation = humanBoard[x, y];
                    humanBoard[x, y] = ATTACKED;
                }
            }
            else
            {
                if (computerBoard[x, y] > 0)
                {
                    valueOfTargetedLocation = computerBoard[x, y];
                    computerBoard[x, y] = ATTACKED;
                }
            }

            return valueOfTargetedLocation;
        }



    }

}
