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

namespace _21_OurWpfControlsLibrary
{
    /// <summary>
    /// Логика взаимодействия для TabSwither.xaml
    /// </summary>
    public partial class TabSwither : UserControl
    {
        public TabSwither()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Свойсто Имени кнопки НАЗАД - butnPrev
        /// </summary>
        public string PrevTextDP
        {
            get { return (string)GetValue(PrevTextDPProperty); }
            set { SetValue(PrevTextDPProperty, value); }
        }

       
        public static readonly DependencyProperty PrevTextDPProperty =
            DependencyProperty.Register("PrevTextDP", typeof(string), typeof(TabSwither), new PropertyMetadata(0));






        /// <summary>
        ///  Фигня, чтоб не сломать контент
        /// </summary>
        /// <param name="oldContent"></param>
        /// <param name="newContent"></param>
        protected override void OnContentChanged(object oldContent, object newContent)
        {
            //base.OnContentChanged(oldContent, newContent);//поумолчаеию
            if (oldContent !=null)
            {
                throw new InvalidOperationException("Защита измениния контента!!!!!");
            }
        }
    }
}
