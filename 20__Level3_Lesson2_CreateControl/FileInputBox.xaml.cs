using Microsoft.Win32;
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

namespace _20__Level3_Lesson2_CreateControl
{
    /// <summary>
    /// Логика взаимодействия для FileInputBox.xaml
    /// </summary>
    public partial class FileInputBox : UserControl
    {
        public FileInputBox()
        {
            InitializeComponent();
            //если поменяется текстблок, сработает  моё событие OnTextChanged
            theTextBox.TextChanged += new TextChangedEventHandler(OnTextChanged);
            //TextChanged!!! 
        }




        #region DependencyProperty

        public static readonly DependencyProperty FileNameProperty
            = DependencyProperty.Register("FileName", typeof(string), typeof(FileInputBox));

        //сделали свойство связанное с текстбоксом
        public string FileName
        {
            get => (string)GetValue(FileNameProperty);
            set { SetValue(FileNameProperty, value); }
        }

        #endregion




        #region Обработчики моего юсерконтрола

        //собственное событие (обощенное)
        // при набирании текста, будет срабатывать событие FileNameChanged

        public event EventHandler<EventArgs> FileNameChanged;

        private void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            //throw new NotImplementedException();
            e.Handled = true;//хз как это работает
            if (FileNameChanged != null)
                FileNameChanged(this, EventArgs.Empty);
        }


        //Обработчик кнопки запишет в наше свойство имя выбранного файла с формы
        private void theButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == true)
            {
                this.FileName = ofd.FileName;
            }
        }

        #endregion




        #region Непонятная хрень для защмты контента
        /// <summary>
        /// ЭТО НАДО ДЛЯ ЗАЩИТЫ КОНТЕНТА
        /// При замене контента типа что-то выскакивать должно
        /// </summary>
        /// <param name="oldContent"></param>
        /// <param name="newContent"></param>
        protected override void OnContentChanged(object oldContent, object newContent)
        {
            //base.OnContentChanged(oldContent, newContent);//по умолч
            if (oldContent != null)
            {
                throw new InvalidOperationException("Вы не можете измянять контент!!!!");
            }
        }
        #endregion

    }
}
