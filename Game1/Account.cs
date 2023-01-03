using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe.Game1
{
    abstract class Account
    {
        public TYPE_ACCOUNT type { get; private set; }
        public string UserName { get; private set; }
        private List<DataGame> listGamesAccount = new List<DataGame>();
        public List<DataGame> ListGamesAccount { get { return listGamesAccount; } }
        private double rating = 0;
        public static List<Account> accounts = new List<Account>();
        public double Rating { get { return rating; } set { rating = value; } }

        protected Account(TYPE_ACCOUNT type, string userName)
        {
            this.type = type;
            UserName = userName;
        }

        public abstract void AddGame(DataGame dataGame);

        public string getInfoAccount()
        {
            string typeStr ;
            if (TYPE_ACCOUNT.PREMIUM == type)
            {
                typeStr = "Преміум акаунт";
            }
            else if (TYPE_ACCOUNT.BASE == type)
            {
                typeStr = "Базовий акаунт"; 
            }
            else typeStr = "Без програшний акаунт";
            return UserName+" - ("+typeStr+") - кількість ігр:" +listGamesAccount.Count()+" - рейтинг:" +rating;
        }
    }
    public enum TYPE_ACCOUNT
    {
        PREMIUM,
        BASE , 
        ZEROLOSE
    }
}
