using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing; // Нужен для работы с PrintPageEventArgs
using System.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents.DocumentStructures;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Diagnostics;

namespace the_program_for_printing
{
    /// <summary>
    /// Логика взаимодействия для one.xaml
    /// </summary>
    public partial class one : Page
    {
        public one()
        {
            InitializeComponent();
        }

        private string text = "";//переменная которая содержит текст для печати
        private void prints_Click(object sender, RoutedEventArgs e)
        {
            text = txt_surname.Text;//текст который печатаем
            text = txt_name.Text;//текст который печатаем
            text = txt_lname.Text;//текст который печатаем

            PrintDocument printa = new PrintDocument();
            printa.PrintPage += PrintPageHandler;

           
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == true)
            {
                printDialog.PrintVisual(print, "Печать");
            }
        }

   
        void PrintPageHandler(object sender, PrintPageEventArgs e) //обработчик события печати
        {
            e.Graphics.DrawString(text, new System.Drawing.Font("Arial", 14), System.Drawing.Brushes.Black, 0,0);
        }   
    }
}
