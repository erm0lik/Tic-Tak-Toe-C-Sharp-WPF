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
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            switch (TypeAccount.Text)
            {
                case "Преміум аккаунт":
                    Account.accounts.Add(new PremiumAccount(TYPE_ACCOUNT.PREMIUM, UserName.Text));
                    break;
                case "Базовий аккаунт":
                    Account.accounts.Add(new BaseAccount(TYPE_ACCOUNT.BASE, UserName.Text));
                    break;
                case "Безпрограшний аккаунт":
                    Account.accounts.Add(new ZeroLoseAccount (TYPE_ACCOUNT.ZEROLOSE, UserName.Text));
                    break;
                default:
                    MessageBox.Show("У вас не заповнено ім'я , або тип аккаунту ");
                    return;
                    
            }
            MainWindow.main.playerX.Items.Add(UserName.Text);
            MainWindow.main.playerO.Items.Add(UserName.Text);
            Hide();

        }


    }
}
