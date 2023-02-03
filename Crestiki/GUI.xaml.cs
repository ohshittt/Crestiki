using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
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

namespace Crestiki
{
    /// <summary>
    /// Логика взаимодействия для GUI.xaml
    /// </summary>
    public partial class GUI : Window
    {
        string hod = "X";
       

        public GUI()
        {
            InitializeComponent();
            enabled();
            
        }
        private void enabled()
        {
            b1.IsEnabled = false;
            b2.IsEnabled = false;
            b3.IsEnabled = false;
            b4.IsEnabled = false;
            b5.IsEnabled = false;
            b6.IsEnabled = false;
            b7.IsEnabled = false;
            b8.IsEnabled = false; 
            b9.IsEnabled = false;
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
           
            Button b = (Button)sender;
            if (hod == "X")
            {
                b.Content = "X";
                b.IsEnabled = false;
            }
            if (b1.Content != null && b2.Content != null && b3.Content != null && b4.Content != null && b5.Content != null && b6.Content != null && b7.Content != null && b8.Content != null && b9.Content != null)
            {
                checkwinner(); // если все кнопки не пустые, то мы вызываем кнопку для проверки кто выиграл
            }
            else
            {
                AITurn();
            }
            checkwinner();
        }

        private void checkwinner()
        {
            bool pob = false;
            if (b1.Content == "X" && b2.Content == "X" && b3.Content == "X")
            {
                MessageBox.Show($"The winner is X");
                Exit.IsEnabled = false;
                enabled();

                pob = true;
            }
            if (b4.Content == "X" && b5.Content == "X" && b6.Content == "X")
            {
                MessageBox.Show($"The winner is X");
                Exit.IsEnabled = false;
                enabled();
                pob = true;
            }
            if (b7.Content == "X" && b8.Content == "X" && b9.Content == "X")
            {
                MessageBox.Show($"The winner is X");
                Exit.IsEnabled = false;
                enabled();
                pob = true;
            }
            if (b1.Content == "X" && b4.Content == "X" && b7.Content == "X")
            {
                MessageBox.Show($"The winner is X");
                Exit.IsEnabled = false;
                enabled();
                pob = true;
            }
            if (b2.Content == "X" && b5.Content == "X" && b8.Content == "X")
            {
                MessageBox.Show($"The winner is X");
                Exit.IsEnabled = false;
                enabled();
                pob = true;
            }
            if (b3.Content == "X" && b6.Content == "X" && b9.Content == "X")
            {
                MessageBox.Show($"The winner is X");
                Exit.IsEnabled = false;
                enabled();
                pob = true;
            }
            if (b1.Content == "X" && b5.Content == "X" && b9.Content == "X")
            {
                MessageBox.Show($"The winner is X");
                Exit.IsEnabled = false;
                enabled();
                pob = true;
            }
            if (b3.Content == "X" && b5.Content == "X" && b7.Content == "X")
            {
                MessageBox.Show($"The winner is X");
                Exit.IsEnabled = false;
                enabled();
                pob = true;
            }

            if (b1.Content == "O" && b2.Content == "O" && b3.Content == "O")
            {
                MessageBox.Show($"The winner is O");
                Exit.IsEnabled = false;
                enabled();
                pob = true;
            }
            if (b4.Content == "O" && b5.Content == "O" && b6.Content == "O")
            {
                MessageBox.Show($"The winner is O");
                Exit.IsEnabled = false;
                enabled();
                pob = true;
            }
            if (b7.Content == "O" && b8.Content == "O" && b9.Content == "O")
            {
                MessageBox.Show($"The winner is O");
                Exit.IsEnabled = false;
                enabled();
                pob = true;
            }
            if (b1.Content == "O" && b4.Content == "O" && b7.Content == "O")
            {
                MessageBox.Show($"The winner is O");
                Exit.IsEnabled = false;
                enabled();
                pob = true;
            }
            if (b2.Content == "O" && b5.Content == "O" && b8.Content == "O")
            {
                MessageBox.Show($"The winner is O");
                Exit.IsEnabled = false;
                enabled();
                pob = true;
            }
            if (b3.Content == "O" && b6.Content == "O" && b9.Content == "O")
            {
                MessageBox.Show($"The winner is O");
                Exit.IsEnabled = false;
                enabled();
                pob = true;
            }
            if (b1.Content == "O" && b5.Content == "O" && b9.Content == "O")
            {
                MessageBox.Show($"The winner is O");
                Exit.IsEnabled = false;
                enabled();
                pob = true;
            }
            if (b3.Content == "O" && b5.Content == "O" && b7.Content == "O")
            {
                MessageBox.Show($"The winner is O");
                Exit.IsEnabled = false;
                enabled();
                pob = true;
            }
            if (pob == false && b1.Content != null && b2.Content != null && b3.Content != null && b4.Content != null && b5.Content != null && b6.Content != null && b7.Content != null && b8.Content != null && b9.Content != null)
            {

                MessageBox.Show("NO Winner");
                Exit.IsEnabled = false;
                enabled();
            }
        }

        public void AITurn() //заполнение нолика
        {
            Button[] BArr = new Button[9];  //создаем массив
            BArr[0] = b1;
            BArr[1] = b2;
            BArr[2] = b3;
            BArr[3] = b4;
            BArr[4] = b5;
            BArr[5] = b6;
            BArr[6] = b7;
            BArr[7] = b8;
            BArr[8] = b9;
            bool ok = false;
            do
            {
                Random rand = new Random();
                int randed = rand.Next(0, 9);
                if (BArr[randed].Content == null && BArr[randed].IsEnabled) //если какое то место от 0 до 9 пусто, то туда мы пишем свой нолик
                {
                    BArr[randed].Content = "O";
                    BArr[randed].IsEnabled = false;
                    ok = true;
                }
            }
            while (ok == false);
        }

        private void restart_Click(object sender, RoutedEventArgs e) // сброс
        {
            b1.Content = null; b1.IsEnabled = false;
            b2.Content = null; ; b2.IsEnabled = false;
            b3.Content = null; b3.IsEnabled = false;
            b4.Content = null; b4.IsEnabled = false;
            b5.Content = null; b5.IsEnabled = false;
            b6.Content = null; b6.IsEnabled = false;
            b7.Content = null; b7.IsEnabled = false;
            b8.Content = null; b8.IsEnabled = false;
            b9.Content = null; b9.IsEnabled = false;
            Exit.IsEnabled = true;

        }

        private void Exit_Click(object sender, RoutedEventArgs e) //выход, закрытие окна
        {
            
            b1.IsEnabled = true;
            b2.IsEnabled = true;
            b3.IsEnabled = true;
            b4.IsEnabled = true;
            b5.IsEnabled = true;
            b6.IsEnabled = true;
            b7.IsEnabled = true;
            b8.IsEnabled = true;
            b9.IsEnabled = true;
            Exit.IsEnabled = false;
        }

    }
}


