using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Tic_Tac_Toe.Game1;

namespace Tic_Tac_Toe
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class UserInfo : Window
    {
        public UserInfo()
        {
            InitializeComponent();
            foreach (Account acc in Account.accounts)
            {
                ListUsers.Items.Add(acc.UserName);
            }

        }
        private void GetInfoPerUser(object sender, RoutedEventArgs e)
        {
            userInfo.Items.Clear();
            Account account = Account.accounts
                .Find(ac => ac.UserName == (string)ListUsers.SelectedItem);

            userInfo.Items.Add(account.getInfoAccount());
            userInfo.Items.Add("id  -  WinnerName  -  LoserName  -  Time  -  rating");
            foreach (DataGame game in account.ListGamesAccount)
            {
                userInfo.Items.Add(game.getInfo());
            }




        }

    }
}
