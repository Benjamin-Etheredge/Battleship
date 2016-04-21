using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Battleship
{
    public class Battleship
    {
        public enum Orientation : int { Horizontal = 0, Vertical = 1 };

        // Variables
        public int[,] humanBoard;
        public int[,] computerBoard;
        private Random randomObject = new Random();

        public bool boardsAreSet = false;

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

        public bool humanTurn = true;

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
                    Console.Write(humanBoard[i, j]);// + "\n");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        //public void Play()
        //{

        //    SetupComputerBoard();
        //    boardsAreSet = true;

        //    while (IsWinner() == 0)
        //    {
        //        if (humanTurn)
        //        {
        //            ComputerFIRE();
        //        }
        //        else
        //        {
        //            ComputerFIRE();
        //        }
        //        humanTurn = !humanTurn;

        //        //SimpleDisplay();
        //    }
        //}

        public bool Play_oneTurn(int x, int y)
        {
            bool hit = false;

            if (!boardsAreSet)
            {
                SetupComputerBoard();
                boardsAreSet = true;
            }
            
            if (humanTurn)
            {
                if (FIRE(x, y) > 1)
                {
                    hit = true;
                }
            }
            else
            {
                ComputerFIRE();
            }
            humanTurn = !humanTurn;
            return hit;
        }

        public void ClearBoards()
        {
            for (int i = 0; i < SIZE_OF_BOARD; i++)
            {
                for (int j = 0; j < SIZE_OF_BOARD; j++)
                {
                    humanBoard[i, j] = 1;
                    computerBoard[i, j] = 1;
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
            while (!AttemptToPlaceShip(ref humanBoard, PATROL_BOAT, PATROL_SIZE, (Orientation)randomObject.Next(1), randomObject.Next(SIZE_OF_BOARD - 1), randomObject.Next(SIZE_OF_BOARD - 1))) ;

            // place destroyer
            while (!AttemptToPlaceShip(ref humanBoard, DESTROYER, DESTROYER_SIZE, (Orientation)randomObject.Next(1), randomObject.Next(SIZE_OF_BOARD - 1), randomObject.Next(SIZE_OF_BOARD - 1))) ;

            // place submarine
            while (!AttemptToPlaceShip(ref humanBoard, SUBMARINE, SUBMARINE_SIZE, (Orientation)randomObject.Next(1), randomObject.Next(SIZE_OF_BOARD - 1), randomObject.Next(SIZE_OF_BOARD - 1))) ;

            // place battleship
            while (!AttemptToPlaceShip(ref humanBoard, BATTLESHIP, BATTLESHIP_SIZE, (Orientation)randomObject.Next(1), randomObject.Next(SIZE_OF_BOARD - 1), randomObject.Next(SIZE_OF_BOARD - 1))) ;

            // place carrier
            while (!AttemptToPlaceShip(ref humanBoard, AIRCRAFT_CARRIER, AIRCRAFT_CARRIER_SIZE, (Orientation)randomObject.Next(1), randomObject.Next(SIZE_OF_BOARD - 1), randomObject.Next(SIZE_OF_BOARD - 1))) ;

        }

        public void SetupComputerBoard()
        {
            // place patrol
            while (!AttemptToPlaceShip(ref computerBoard, PATROL_BOAT, PATROL_SIZE, (Orientation)randomObject.Next(1), randomObject.Next(SIZE_OF_BOARD - 1), randomObject.Next(SIZE_OF_BOARD - 1))) ;

            // place destroyer
            while (!AttemptToPlaceShip(ref computerBoard, DESTROYER, DESTROYER_SIZE, (Orientation)randomObject.Next(1), randomObject.Next(SIZE_OF_BOARD - 1), randomObject.Next(SIZE_OF_BOARD - 1))) ;

            // place submarine
            while (!AttemptToPlaceShip(ref computerBoard, SUBMARINE, SUBMARINE_SIZE, (Orientation)randomObject.Next(1), randomObject.Next(SIZE_OF_BOARD - 1), randomObject.Next(SIZE_OF_BOARD - 1))) ;

            // place battleship
            while (!AttemptToPlaceShip(ref computerBoard, BATTLESHIP, BATTLESHIP_SIZE, (Orientation)randomObject.Next(1), randomObject.Next(SIZE_OF_BOARD - 1), randomObject.Next(SIZE_OF_BOARD - 1))) ;

            // place carrier
            while (!AttemptToPlaceShip(ref computerBoard, AIRCRAFT_CARRIER, AIRCRAFT_CARRIER_SIZE, (Orientation)randomObject.Next(1), randomObject.Next(SIZE_OF_BOARD - 1), randomObject.Next(SIZE_OF_BOARD - 1))) ;

            boardsAreSet = true;
        }

        public bool AttemptToPlaceShip(ref int[,] board, int shipCode, Orientation orientation, int x, int y)
        {
            int size = -1;

            switch (shipCode)
            {
                case 2:
                    size = 2;
                    break;
                case 3:
                    size = 3;
                    break;
                case 4:
                    size = 3;
                    break;
                case 5:
                    size = 4;
                    break;
                case 6:
                    size = 5;
                    break;
            }

            bool alreadyPlacedShip = false;

            foreach (int spot in board)
            {
                if (spot.Equals(shipCode))
                {
                    alreadyPlacedShip = true;
                    break;
                }
            }

            if (!alreadyPlacedShip)
            {
                // is spot available
                bool isLocationFree = true;

                int[,] tempBoard = board;
                // Copy(board, tempBoard, SIZE_OF_BOARD);

                for (int i = 0; i < size && isLocationFree; i++)
                {
                    if (orientation == Orientation.Horizontal)
                    {

                        if (x + i >= SIZE_OF_BOARD || board[x + i, y] > 1)
                        {
                            isLocationFree = false;
                        }
                    }
                    else
                    {
                        if (y + i >= SIZE_OF_BOARD || board[x, y + i] > 1)
                        {
                            isLocationFree = false;
                        }
                    }
                }
                //TODO: TEST THIS
                if (isLocationFree)
                {
                    for (int i = 0; i < size && isLocationFree; i++)
                    {
                        if (orientation == Orientation.Horizontal)
                        {
                            tempBoard[x + i, y] = shipCode;
                        }
                        else
                        {
                            tempBoard[x, y + i] = shipCode;
                        }
                    }
                    alreadyPlacedShip = true;
                    board = tempBoard;
                }

                return isLocationFree;
            }
            return alreadyPlacedShip;
        }


        public bool AttemptToPlaceShip(ref int[,] board, int shipCode, int size, Orientation orientation, int x, int y)
        {
            bool alreadyPlacedShip = false;

            foreach(int spot in board)
            {
                if (spot.Equals(shipCode))
                {
                    alreadyPlacedShip = true;
                    break;
                }
            }

            if (!alreadyPlacedShip)
            {
                // is spot available
                bool isLocationFree = true;

                int[,] tempBoard = board;
                // Copy(board, tempBoard, SIZE_OF_BOARD);

                for (int i = 0; i < size && isLocationFree; i++)
                {
                    if (orientation == Orientation.Horizontal)
                    {

                        if (x + i >= SIZE_OF_BOARD || board[x + i, y] > 1)
                        {
                            isLocationFree = false;
                        }
                    }
                    else
                    {
                        if (y + i >= SIZE_OF_BOARD || board[x, y + i] > 1)
                        {
                            isLocationFree = false;
                        }
                    }
                }
                //TODO: TEST THIS
                if (isLocationFree)
                {
                    for(int i = 0; i < size && isLocationFree; i++)
                    {
                        if (orientation == Orientation.Horizontal)
                        {
                            tempBoard[x + i, y] = shipCode;
                        }
                        else
                        {
                            tempBoard[x, y + i] = shipCode;
                        }
                    }
                    alreadyPlacedShip = true;
                    board = tempBoard;
                }

                return isLocationFree;
            }
            return alreadyPlacedShip;
        }

        // fire randomly till valid move is made
        public int[] ComputerFIRE()
        {
            //bool hasFired = false;
            int[] hitValues = new int[3] { 0, 0, 0 };
            int x;
            int y;

            while (hitValues[0].Equals(0))
            {
                x = randomObject.Next(9);
                y = randomObject.Next(9);

                hitValues[0] = FIRE(x, y);
                hitValues[1] = x;
                hitValues[2] = y;
            }
            return hitValues;
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

            if (!humanTurn)
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
