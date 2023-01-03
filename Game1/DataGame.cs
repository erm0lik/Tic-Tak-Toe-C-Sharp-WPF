using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tic_Tac_Toe.Game1;

namespace Tic_Tac_Toe
{
    internal class DataGame
    {
        private int id;
        public string WinnerName { get; private set; }
        private string LoserName;
        private string date;
        private TYPE_ACCOUNT typeWinner;
        private TYPE_ACCOUNT typeLoser;
        private double rating;
        public double Rating { get { return rating; } set { rating = value; } }
        public static List<DataGame> list = new List<DataGame>();

        public string getInfo()
        {
            return id.ToString() + " - " + WinnerName + " - " + LoserName + " - " + date + " - " + rating;
        }

        public DataGame(int id, string winnerName, TYPE_ACCOUNT typeWinner, string loserName, TYPE_ACCOUNT typeLoser, double rating, string date)
        {
            this.id = id;
            WinnerName = winnerName;
            LoserName = loserName;
            this.date = date;
            this.typeWinner = typeWinner;
            this.typeLoser = typeLoser;
            this.rating = rating;
        }
    }
}
