using GameCharacters.Data;
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

namespace GameCharacters.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Goblin _goblin1 = new Goblin();
        Troll _goblin1 = new Troll();
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MoveUp(object sender, RoutedEventArgs e)
        {
            _goblin1.Move(MoveDirectionEnum.Up);
            Canvas.SetLeft(chGoblin,_goblin1.PostionX);
            Canvas.SetTop(chGoblin, _goblin1.PostionY);

        }
        private void MoveDown(object sender, RoutedEventArgs e)
        {
            _goblin1.Move(MoveDirectionEnum.Down);
            Canvas.SetLeft(chGoblin, _goblin1.PostionX);
            Canvas.SetTop(chGoblin, _goblin1.PostionY);
        }
        private void MoveLeft(object sender, RoutedEventArgs e)
        {
            _goblin1.Move(MoveDirectionEnum.Left);
            Canvas.SetLeft(chGoblin, _goblin1.PostionX);
            Canvas.SetTop(chGoblin, _goblin1.PostionY);
        }
        private void MoveRight(object sender, RoutedEventArgs e)
        {
            _goblin1.Move(MoveDirectionEnum.Right);
            Canvas.SetLeft(chGoblin, _goblin1.PostionX);
            Canvas.SetTop(chGoblin, _goblin1.PostionY);
        }
    }
}
