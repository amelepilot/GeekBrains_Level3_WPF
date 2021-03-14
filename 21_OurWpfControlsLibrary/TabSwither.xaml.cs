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


        #region ВСЁ ДЛЯ КНОПКИ НАЗАД

            /// <summary>
            /// Свойсто Имени кнопки НАЗАД - butnPrev
            /// </summary>
            public string PrevTextDP
            {
                get { return (string)GetValue(PrevTextDPProperty); }
                set { SetValue(PrevTextDPProperty, value); }
            }


            public static readonly DependencyProperty PrevTextDPProperty =
                DependencyProperty.Register("PrevTextDP", 
                                            typeof(string), typeof(TabSwither),
                                            new PropertyMetadata("11"));

        
            /// <summary>
            /// Обработчик унопки НАЗАД
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void butnPrev_Click(object sender, RoutedEventArgs e)
            {
                e.Handled = true;//союытие закончилось тут
                RoutedEventArgs args = new RoutedEventArgs(butnPrevClickEvent);
                RaiseEvent(args);
            }

            //дальше ниже интересно!!!
            public static readonly RoutedEvent butnPrevClickEvent =
                                                                    EventManager.RegisterRoutedEvent("butnPrev_Click",
                                                                    RoutingStrategy.Bubble,
                                                                    typeof(RoutedEventHandler),
                                                                    typeof(TabSwither));
        
            public event RoutedEventHandler butnPrevClick
            {
                add { AddHandler(butnPrevClickEvent, value); }
                remove { RemoveHandler(butnPrevClickEvent,value); }
            }

        #endregion



        #region ВСЁ ДЛЯ КНОПКИ ВПЕРЕД

            /// <summary>
            /// Свойсто Имени кнопки НАЗАД - butnPrev
            /// </summary>
            public string NextTextDP
            {
                get { return (string)GetValue(NextTextDPProperty); }
                set { SetValue(NextTextDPProperty, value); }
            }


            public static readonly DependencyProperty NextTextDPProperty =
                DependencyProperty.Register("NextTextDP",
                                            typeof(string), typeof(TabSwither),
                                            new PropertyMetadata("22"));


            /// <summary>
            /// Обработчик кнопки вперед
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void butnNext_Click(object sender, RoutedEventArgs e)
            {
                e.Handled = true;//союытие закончилось тут
                RoutedEventArgs args = new RoutedEventArgs(butnNextClickEvent);
                RaiseEvent(args);
            }

            //дальше ниже интересно!!! что-то типа DP но с событиями!!!!
            public static readonly RoutedEvent butnNextClickEvent =
                                                                   EventManager.RegisterRoutedEvent("butnNext_Click",
                                                                   RoutingStrategy.Bubble,
                                                                   typeof(RoutedEventHandler),
                                                                   typeof(TabSwither));


            public event RoutedEventHandler butnNextClick
            {
                add { AddHandler(butnNextClickEvent, value); }
                remove { RemoveHandler(butnNextClickEvent, value); }
            }


        #endregion






        /// <summary>
        ///  Фигня, чтоб не сломать контент
        /// </summary>
        /// <param name="oldContent"></param>
        /// <param name="newContent"></param>
        protected override void OnContentChanged(object oldContent, object newContent)
        {
            //base.OnContentChanged(oldContent, newContent);//поумолчаеию
            if (oldContent != null)
            {
                throw new InvalidOperationException("Защита измениния контента!!!!!");
            }
        }


       
    }
}
