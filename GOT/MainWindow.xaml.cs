using GOT.Serialize;
using GOT.Models;
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

namespace GOT
{
    public partial class MainWindow : Window
    {
        public GameOfThrones[] Result { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            var deserialize = new Deserialize();
            var result = deserialize.Start();
            Result = result;
        }

        public void SearchCharacter(object sender, KeyEventArgs e)
        {
            
            if (e.Key == Key.Enter)
            {
                if (!CheckSymbol(search.Text) || string.IsNullOrEmpty(search.Text))
                {
                    MessageBox.Show("Введите корректно или на латинице");
                    return;
                }
                else
                {
                    var charactersName = Result.Select(r => r.Name);
                    var sortedName = charactersName.Where(chr => chr.ToLower().Contains(search.Text.ToLower()));

                    list.ItemsSource = sortedName;
                    if (sortedName == null)
                    {
                        MessageBox.Show("Персонаж не найден");
                        return;
                    }
                }
            }  
        }

        public bool CheckSymbol(string text)
        {
            foreach (char ch in text)
            {
                if ((int)ch >= 97 && (int)ch <= 122)
                {
                    return true;
                }
            }
            return false;
        }


        private void CharactedInfo(object sender, MouseButtonEventArgs e)
        {
            var sortCharactedInfo = list.SelectedItem.ToString();
            var charactedInfo = Result.FirstOrDefault(c => c.Name == sortCharactedInfo);
            MessageBox.Show($"{charactedInfo.Name}\n{charactedInfo.House}");
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            Close();
        }
        
    }
}
