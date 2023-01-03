using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Tic_Tac_Toe
{
    public class Games
    {
        private string value = "X";
        public int count { get; private set; } = 0;
        public double rating { get; private set; } = new Random().NextDouble();
        public string Value
        {
            get { return value; }
            set { this.value = value; }
        }


        private string[,] matrix = new String[3, 3] {{ "1", "2", "3" },
                                                     { "4", "5", "6" },
                                                     { "7", "8", "9" } };

        public Games()
        {
        }
        public void replacement()
        {
            if (value == "X") value = "O";

            else value = "X";
            count++;
        }
        public void addToMatrix(string indexs, string value)
        {
            matrix[Int32.Parse(indexs[1].ToString())
                , Int32.Parse(indexs[2].ToString())] = value;

        }
        public bool thereIsAWinner()
        {
            if (matrix[0, 0] == matrix[0, 1] && matrix[0, 0] == matrix[0, 2]) //first row 
                return true;
            else if (matrix[1, 0] == matrix[1, 1] && matrix[1, 0] == matrix[1, 2]) // second row
                return true;
            else if (matrix[2, 0] == matrix[2, 1] && matrix[2, 0] == matrix[2, 2]) // third row 
                return true;
            else if (matrix[0, 0] == matrix[1, 0] && matrix[0, 0] == matrix[2, 0]) //first column 
                return true;
            else if (matrix[0, 1] == matrix[1, 1] && matrix[0, 1] == matrix[2, 1])// second column
                return true;
            else if (matrix[0, 2] == matrix[1, 2] && matrix[0, 2] == matrix[2, 2])// third column
                return true;
            else if (matrix[0, 0] == matrix[1, 1] && matrix[0, 0] == matrix[2, 2]) //first diagonal top down
                return true;
            else if (matrix[0, 2] == matrix[1, 1] && matrix[0, 2] == matrix[2, 0])// second diagonal down up 
                return true;
            else return false;
        }

    }
}
