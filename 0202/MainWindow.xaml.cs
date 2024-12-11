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
using Word = Microsoft.Office.Interop.Word;
using System.IO;


namespace _0202
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
            if(text.Text == "")
            {
                MessageBox.Show("Введите количество минут!");
                return;
            }
            int result;
            
            if(int.TryParse(text.Text, out result) == false)
            {
                MessageBox.Show("Можно вводить только числа!");
                return;
            }

            int minuts = int.Parse(text.Text);
            int overminuts = 0;
            double final = 0;
            double overfinal = 0;


            if (tar1.IsChecked == true)
            {
                ClassLibrary1.Class1 s = new ClassLibrary1.Class1();
                final = s.calc1(minuts);
            }
            else
            {
                if (minuts > 100)
                {
                    overminuts = minuts - 100;
                    minuts = 100;
                    overfinal = overminuts * 1.6;
                    final = minuts * 0.3 + overfinal;
                }
                else
                {
                    final = minuts * 0.3;
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            string amount = "100.50";
            
            Word.Application wordApp = new Word.Application();
            Word.Document wordDoc = wordApp.Documents.Open("C:\\Users\\pc\\source\\repos\\0202\\0202\\bin\\Debug" + "/obraz.docx");
            
            Word.Bookmark bookmark = wordDoc.Bookmarks["mark"];


            bookmark.Range.Text = amount;
            string fileName = "C:\\Users\\pc\\source\\repos\\0202\\0202\\bin\\Debug" + $"/Квитанция_{DateTime.Now:dd.MM.yyyy}.docx";
            wordDoc.SaveAs2(fileName);
            wordDoc.Close();
            wordApp.Quit();
            MessageBox.Show($"Квитанция сохранена как {fileName}");
        }
    }
}
