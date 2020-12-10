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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab7
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public Counting counting { get; set; }

        int number1 = 0;
        int number2 = 0;
        int number3 = 0;
        int number4 = 0;
        int number5 = 0;
        int number6 = 0;
        int number7 = 0;
        int number8 = 0;
        int number9 = 0;

        #region TextChanged

        private void Box1_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Box1.Text != ""&&Box1.Text!="0")
                {
                    number1 = int.Parse(Box1.Text);
                    Indicators(number1, number2, number3, number4, number5, number6, number7, number8, number9);
                }
            }
            catch
            {
                Box1.Text = "";
                MessageBox.Show("Нужно вводить числа!");
            }
        }

        private void Box4_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Box4.Text != "" && Box1.Text != "0")
                {
                    number4 = int.Parse(Box4.Text);
                    Indicators(number1, number2, number3, number4, number5, number6, number7, number8, number9);
                }
            }
            catch
            {
                Box4.Text = "";
                MessageBox.Show("Нужно вводить числа!");
            }
        }

        private void Box7_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Box7.Text != "" && Box1.Text != "0")
                {
                    number7 = int.Parse(Box7.Text);
                    Indicators(number1, number2, number3, number4, number5, number6, number7, number8, number9);
                }
            }
            catch
            {
                Box7.Text = "";
                MessageBox.Show("Нужно вводить числа!");
            }
        }

        private void Box2_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Box2.Text != "" && Box1.Text != "0")
                {
                    number2 = int.Parse(Box2.Text);
                    Indicators(number1, number2, number3, number4, number5, number6, number7, number8, number9);
                }
            }
            catch
            {
                Box2.Text = "";
                MessageBox.Show("Нужно вводить числа!");
            }
        }

        private void Box5_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Box5.Text != "" && Box1.Text != "0")
                {
                    number5 = int.Parse(Box5.Text);
                    Indicators(number1, number2, number3, number4, number5, number6, number7, number8, number9);
                }
            }
            catch
            {
                Box5.Text = "";
                MessageBox.Show("Нужно вводить числа!");
            }
        }

        private void Box8_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Box8.Text != "" && Box1.Text != "0")
                {
                    number8 = int.Parse(Box8.Text);
                    Indicators(number1, number2, number3, number4, number5, number6, number7, number8, number9);
                }
            }
            catch
            {
                Box8.Text = "";
                MessageBox.Show("Нужно вводить числа!");
            }
        }

        private void Box3_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Box3.Text != "" && Box1.Text != "0")
                {
                    number3 = int.Parse(Box3.Text);
                    Indicators(number1, number2, number3, number4, number5, number6, number7, number8, number9);
                }
            }
            catch
            {
                Box3.Text = "";
                MessageBox.Show("Нужно вводить числа!");
            }
        }

        private void Box6_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Box6.Text != "" && Box1.Text != "0")
                {
                    number6 = int.Parse(Box6.Text);
                    Indicators(number1, number2, number3, number4, number5, number6, number7, number8, number9);
                }
            }
            catch
            {
                Box6.Text = "";
                MessageBox.Show("Нужно вводить числа!");
            }
        }

        private void Box9_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Box9.Text != "" && Box1.Text != "0")
                {
                    number9 = int.Parse(Box9.Text);
                    Indicators(number1, number2, number3, number4, number5, number6, number7, number8, number9);
                }
            }
            catch
            {
                Box9.Text = "";
                MessageBox.Show("Нужно вводить числа!");
            }
        }

        #endregion


        #region Focus


        private void FocusOn1(object sender, RoutedEventArgs e)
        {
            Box1.Text = "";
        }

        private void FocusOn2(object sender, RoutedEventArgs e)
        {
            Box2.Text = "";
        }

        private void FocusOn3(object sender, RoutedEventArgs e)
        {
            Box3.Text = "";
        }

        private void FocusOn4(object sender, RoutedEventArgs e)
        {
            Box4.Text = "";
        }
        private void FocusOn5(object sender, RoutedEventArgs e)
        {
            Box5.Text = "";
        }
        private void FocusOn6(object sender, RoutedEventArgs e)
        {
            Box6.Text = "";
        }
        private void FocusOn7(object sender, RoutedEventArgs e)
        {
            Box7.Text = "";
        }
        private void FocusOn8(object sender, RoutedEventArgs e)
        {
            Box8.Text = "";
        }
        private void FocusOn9(object sender, RoutedEventArgs e)
        {
            Box9.Text = "";
        }

        private void FocusOff1(object sender, RoutedEventArgs e)
        {
            if (Box1.Text == "" || Box1.Text == "Введите число!")
            {
                Box1.Foreground = Brushes.Black;
                Box1.FontSize = 30;
                Box1.Text = "0";
            }
        }
        private void FocusOff2(object sender, RoutedEventArgs e)
        {
            if (Box2.Text == "" || Box1.Text == "Введите число!")
            {
                Box2.Text = "0";
            }

        }
        private void FocusOff3(object sender, RoutedEventArgs e)
        {
            if (Box3.Text == "" || Box1.Text == "Введите число!")
            {
                Box3.Text = "0";
            }
        }
        private void FocusOff4(object sender, RoutedEventArgs e)
        {
            if (Box4.Text == "" || Box1.Text == "Введите число!")
            {
                Box4.Text = "0";
            }
        }
        private void FocusOff5(object sender, RoutedEventArgs e)
        {
            if (Box5.Text == "" || Box1.Text == "Введите число!")
            {
                Box5.Text = "0";
            }
        }
        private void FocusOff6(object sender, RoutedEventArgs e)
        {
            if (Box6.Text == "" || Box1.Text == "Введите число!")
            {
                Box6.Text = "0";
            }

        }
        private void FocusOff7(object sender, RoutedEventArgs e)
        {
            if (Box7.Text == "" || Box1.Text == "Введите число!")
            {
                Box7.Text = "0";
            }
        }
        private void FocusOff8(object sender, RoutedEventArgs e)
        {
            if (Box8.Text == "" || Box1.Text == "Введите число!")
            {
                Box8.Text = "0";
            }
        }
        private void FocusOff9(object sender, RoutedEventArgs e)
        {
            if (Box9.Text == "" || Box1.Text == "Введите число!")
            {
                Box9.Text = "0";
            }
        }

        #endregion

        #region Methods

        public void Indicators(int num1, int num2, int num3, int num4, int num5, int num6, int num7, int num8, int num9)
        {
            List<int> numList = new List<int>();
            numList.Add(num1);
            numList.Add(num2);
            numList.Add(num3);
            numList.Add(num4);
            numList.Add(num5);
            numList.Add(num6);
            numList.Add(num7);
            numList.Add(num8);
            numList.Add(num9);

            string average = Math.Round(numList.Average(), 2).ToString();
            string max = numList.Max().ToString();
            string min = numList.Min().ToString();
            string summ = numList.Sum().ToString();
            string odd = "";
            foreach (var i in numList)
            {
                if (i % 2 != 0)
                {
                    odd += $"{i.ToString()} ";
                }
            }

            MaxCount.Text = max;
            MinCount.Text = min;
            Summ.Text = summ;
            Avr.Text = average;
            Odd.Text = odd;

        }

        #endregion

    }
}
