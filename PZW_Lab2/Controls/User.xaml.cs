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

namespace PZW_Lab2.Controls
{
    /// <summary>
    /// Interaction logic for User.xaml
    /// </summary>
    public partial class User : UserControl
    {
        public User()
        {
            InitializeComponent(); 
            this.DeleteImage.MouseDown += DeleteImage_MouseDown;
            this.EditImage.MouseDown += EditImage_MouseDown;
        }

        private void EditImage_MouseDown(object sender, MouseButtonEventArgs e)
        {         
            EditUser.Visibility = Visibility.Visible;
            UserImage.Visibility = Visibility.Collapsed;
            UserName.Visibility = Visibility.Collapsed;
            EditImage.Visibility = Visibility.Collapsed;
            DeleteImage.Visibility = Visibility.Collapsed;
        }

        private ImageSource GetImage(string path)
        {
            return new BitmapImage(new Uri(path, UriKind.Relative));
        }
        private void FinishButton_Click(object sender, RoutedEventArgs e)
        {
            if (EditedUserName.Text == "" || EditImagePath.Text == "")
                MessageBox.Show("Please, fill in new user name and/or profile picture path");
            else
            {
                EditUser.Visibility = Visibility.Collapsed;
                UserName.Content = EditedUserName.Text;
                UserImage.Source = GetImage(EditImagePath.Text);
                UserImage.Visibility = Visibility.Visible;
                UserName.Visibility = Visibility.Visible;
                EditImage.Visibility = Visibility.Visible;
                DeleteImage.Visibility = Visibility.Visible;
            }
        }
        

        void DeleteImage_MouseDown(object sender, MouseButtonEventArgs e)
        {
            RaiseDeleteEvent();
        }        
        
        public String Title
        {
            get { return (String)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        } public static readonly DependencyProperty TitleProperty = DependencyProperty.Register(
                "Title",
                typeof(String),
                typeof(User),
                new UIPropertyMetadata(""));

        public static readonly RoutedEvent DeleteEvent = EventManager.RegisterRoutedEvent
        (
            "Delete", //ime eventa
            RoutingStrategy.Bubble,
            typeof(RoutedEventHandler),
            typeof(User) //tip elementa koji posjeduje event
        );

        public event RoutedEventHandler Delete //za registraciju/deregistraciju 
        {
            add { AddHandler(DeleteEvent, value); }
            remove { RemoveHandler(DeleteEvent, value); }
        }

        void RaiseDeleteEvent()
        {
            RoutedEventArgs newEventArgs = new RoutedEventArgs(User.DeleteEvent);
            RaiseEvent(newEventArgs);
        }

        public void SetStatic()
        {
            DeleteImage.Visibility = Visibility.Collapsed;
            EditImage.Visibility = Visibility.Collapsed;
        }

        public void SetCurrentUser(string sender)
        {
            UserName.Content = sender;
        }
    }
}
