using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;
using Tic_Tac_Toe.Game1;

namespace Tic_Tac_Toe
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Games game = new TrainingGame();
        int id = 0;
        RegistrationWindow registrationWindow = new RegistrationWindow();
        Account accountX = null;
        Account accountO = null;
        public static MainWindow main;
        UserInfo userInfo;

        public MainWindow()
        {

            InitializeComponent();
            main = this;


        }
        private void B_MouseEnter(object sender, RoutedEventArgs e)
        {

            Button b = sender as Button;
            if (b.IsEnabled == true)
                b.Content = game.Value;



        }
        private void B_MouseLeave(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            if (b.IsEnabled == true)
                b.Content = null;

        }
        private void B_Click(object sender, RoutedEventArgs e)
        {
            if (playerO.SelectedItem == null || playerX.SelectedItem == null)
            {
                MessageBox.Show("Виберіть гравців для гри ", "", MessageBoxButton.OK);
                return;
            }
            Button button = sender as Button;
            button.Content = game.Value;
            game.addToMatrix(button.Name, game.Value);
            button.IsEnabled = false;
            game.replacement();


            if (game.thereIsAWinner())
            {

                DataGame dataGame;

                if (game.Value == "X")
                {
                    dataGame = new DataGame(id++, accountO.UserName, accountO.type, accountX.UserName, accountX.type, game.rating, DateTime.UtcNow.ToString());
                }

                else
                {
                    dataGame = new DataGame(id++, accountX.UserName, accountX.type, accountO.UserName, accountO.type, game.rating, DateTime.UtcNow.ToString());
                }
                DataGame.list.Add(dataGame);
                accountX.AddGame(dataGame);
                accountO.AddGame(dataGame);
                MessageBoxResult messageBoxResult =
                    MessageBox.Show("Виграв " + dataGame.WinnerName + "!!! бажаєте запустити гру ще раз ?", " ", MessageBoxButton.YesNoCancel);

                switch (messageBoxResult)
                {
                    case MessageBoxResult.Yes:
                        FieldClearance();
                        break;
                    case MessageBoxResult.No:
                        Close();
                        break;
                    case MessageBoxResult.Cancel:
                        break;

                }

            }
            if (game.count == 9 && game.thereIsAWinner() == false)
            {
                MessageBox.Show("Нічия !!! Переграйте гру", " ", (MessageBoxButton.OK));
                FieldClearance();
            }
        }
        private void RestartGame(object sender, RoutedEventArgs e)
        {
            FieldClearance();
        }
        private void AddUserr(object sender, RoutedEventArgs e)
        {
            registrationWindow.UserName.Text = null;
            registrationWindow.TypeAccount.Text = null;
            registrationWindow.ShowDialog();
        }
        private void GetUser(object sender, RoutedEventArgs e)
        {
            userInfo = new UserInfo();
            userInfo.ShowDialog();
        }

        private void FieldClearance()
        {
            B00.IsEnabled = true;
            B00.Content = null;
            B01.IsEnabled = true;
            B01.Content = null;
            B02.IsEnabled = true;
            B02.Content = null;
            B10.IsEnabled = true;
            B10.Content = null;
            B11.IsEnabled = true;
            B11.Content = null;
            B12.IsEnabled = true;
            B12.Content = null;
            B20.IsEnabled = true;
            B20.Content = null;
            B21.IsEnabled = true;
            B21.Content = null;
            B22.IsEnabled = true;
            B22.Content = null;
            if (Radio.IsChecked == true)
                game = new DefoltGame();
            else game = new TrainingGame();
        }

        private void PlayerXChange(object sender, SelectionChangedEventArgs e)
        {
            accountX = Account.accounts.Find(name => name.UserName == playerX.SelectedItem);
        }

        private void PlayerOChange(object sender, SelectionChangedEventArgs e)
        {
            accountO = Account.accounts.Find(name => name.UserName == playerO.SelectedItem);
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            FieldClearance();
        }
            private void RadioButton_UnChecked(object sender, RoutedEventArgs e)
        {
            FieldClearance();
        }
    }
}
