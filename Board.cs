using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Source
{
    public class Board
    {
        readonly int rows;
        readonly int columns;
        bool isFallingBlock = false;
        char cube;
        char [,] board;
        public Board(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
            board = new char[rows, columns]; 
        }
        public bool IsFallingBlock()
        {
            if(isFallingBlock == true)
            {
                return true; 
            }
            else return false;
        }
        public void Drop(Block block) 
        {
            block = new Block(cube);
            isFallingBlock = true; 
        }
        public void Tick()
        {

        }
        // I NEED YOUUUU !!!
        public override String ToString()
        {
            String s = "";
            cube = 'X'; 
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                   
                    s += ".";
                   
                }
                s += "\n";
            }

            return s;
        }
    }
}
