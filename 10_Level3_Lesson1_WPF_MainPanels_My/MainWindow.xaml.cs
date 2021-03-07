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

namespace _10_Level3_Lesson1_WPF_MainPanels_My
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


        #region Обработчики Первой вкладки с всплывающими кнопками
        /// <summary>
        /// Открывает окно с планировкой StackPanel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StackButtonWPF_Click(object sender, RoutedEventArgs e)
        {
            Window windowStack = new WinStackPanel();//создаю окно
            windowStack.Show();


        }

        private void WrapButtonWPF_Click(object sender, RoutedEventArgs e)
        {
            Window windowStack = new WinWrapPanel();//создаю окно
            windowStack.Show();
        }

        private void DockButtonWPF_Click(object sender, RoutedEventArgs e)
        {
            Window windowStack = new WinDoxkPanel();//создаю окно
            windowStack.Show();
        }

        private void GridButtonWPF_Click(object sender, RoutedEventArgs e)
        {
            Window windowStack = new WinGrid();//создаю окно
            windowStack.Show();
        }

        private void ExpanderButtonWPF_Click(object sender, RoutedEventArgs e)
        {

        }

        private void GroupBoxButtonWPF_Click(object sender, RoutedEventArgs e)
        {

        }

        private void UniformGridButtonWPF_Click(object sender, RoutedEventArgs e)
        {
            Window windowStack = new WinUniformGrid();//создаю окно
            windowStack.Show();
        }




        #endregion

        private void CanvasButtonWPF_Click(object sender, RoutedEventArgs e)
        {
            Window windowStack = new WinCanvas();//создаю окно
            windowStack.Show();
        }
    }
}
