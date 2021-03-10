using System;
using System.Collections.Generic;
using System.Diagnostics;
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

            private void CanvasButtonWPF_Click(object sender, RoutedEventArgs e)
            {
                Window windowStack = new WinCanvas();//создаю окно
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
           
        /// <summary>
            /// Браузер в приложении!!!
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void PrikolWEBWPF_Click(object sender, RoutedEventArgs e)
            {
            Window windowStack = new WinWebPrikol();//создаю окно
            MessageBox.Show("Надо больше отдыхать...");
            windowStack.Show();
            }

        #endregion



        #region Обработчики Вкладки с прикольными кнопками

            private void testbuttonWPF1_Click(object sender, RoutedEventArgs e)
            {
                Debug.WriteLine("Нажимается при наведении", "Обработчик");
            }

            private void testbuttonWPF3_Click(object sender, RoutedEventArgs e)
            {
                Debug.WriteLine("Кнопка по умолчанию.", "Обработчик");
            }

            private void testbuttonWPF4_Click(object sender, RoutedEventArgs e)
            {
                Debug.WriteLine("Кнопка Repeat нажата", "Обработчик");
                //Window.Show("Кнопка Repeat", "Обработчик");
            }


            private void ToggleButton_Click(object sender, RoutedEventArgs e)
            {
                Debug.WriteLine("Кнопка ToggleButton нажата", "Обработчик");
            }

        #endregion

       
    }
}
