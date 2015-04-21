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
using PZW_Lab2.Controls;

namespace PZW_Lab2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void OnWindowLoaded(object sender, RoutedEventArgs e)
        {
            RegisterFriendDelete();
        }

        private void RegisterFriendDelete()
        {
            foreach (var child in this.FriendContainer.Children)
            {
                if (!(child is User)) { continue; }

                var Friend = child as User;
                Friend.Delete += OnFriendDelete;
            }
        }
        private void OnFriendDelete(object sender, RoutedEventArgs e)
        {
            if (!(sender is User)) { return; }

            var Friend = sender as User;

            this.FriendContainer.Children.Remove(Friend);
        }     
    }
}
