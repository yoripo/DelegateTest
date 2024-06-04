using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DelegateTes
{
    // デリゲートの定義
    public delegate void MyDelegate(string message);

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            // デリゲートのインスタンス化
            MyDelegate delg = new MyDelegate(SayHello);

            // デリゲートを使ってメソッドを呼び出す
            delg("Hello, World!"+ input.Text);

            // マルチキャストデリゲートの例
            delg += SayGoodbye;
            delg("Everyoneマルチキャストデリゲート分");
        }
        public static void SayHello(string message)
        {
            MessageBox.Show("こんにちは: " + message);
        }

        public static void SayGoodbye(string message)
        {
            MessageBox.Show("さよなら: " + message);
        }
    }
}