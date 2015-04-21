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
    /// Interaction logic for Post.xaml
    /// </summary>
    public partial class Post : UserControl
    {
        public Post()
        {
            InitializeComponent();
            CurrentUser.SetStatic();
        }

        public string user
        {
            get { return (string)GetValue(userProperty); }
            set { SetValue(userProperty, value); }
        }
        public static readonly DependencyProperty userProperty =
            DependencyProperty.Register("user", typeof(string), typeof(Post), new PropertyMetadata(""));

        public string post
        {
            get { return (string)GetValue(postProperty); }
            set { SetValue(postProperty, value); }
        }
        public static readonly DependencyProperty postProperty =
            DependencyProperty.Register("post", typeof(string), typeof(Post), new PropertyMetadata(""));       
    }
}
