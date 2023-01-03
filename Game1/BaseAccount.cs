using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe.Game1
{
    internal class BaseAccount : Account
    {
        public BaseAccount(TYPE_ACCOUNT type, string userName) : base(type, userName)
        {
        }

        public override void AddGame(DataGame dataGame)
        {
            DataGame data = dataGame;
            if (data.WinnerName == UserName)
                Rating += data.Rating;
            else Rating -= data.Rating;
            ListGamesAccount.Add(data);
        }
    }
}
