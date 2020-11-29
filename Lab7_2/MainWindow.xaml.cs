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

namespace Lab7_2
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MyMatrix matrix = new MyMatrix();
            string matrices = matrix.CreateMatrices(Convert.ToInt32(Rows.Text), Convert.ToInt32(Columns.Text));
            string[] allMatrices = matrices.Split(',');
            BaseMatrix.Text = allMatrices[0];
            DerivedMatrix1.Text = allMatrices[1];
            DerivedMatrix2.Text = allMatrices[2];
            DerivedMatrix3.Text = allMatrices[3];
            BaseSize.Text = $"Размер матрицы: {Rows.Text}x{Columns.Text}";
            DerivedSize1.Text = $"Размер матрицы: {Rows.Text}x10";
            DerivedSize2.Text = $"Размер матрицы: 20x{Rows.Text}";
            DerivedSize3.Text = $"Размер матрицы: {Rows.Text}x15";
        }
    }
}
