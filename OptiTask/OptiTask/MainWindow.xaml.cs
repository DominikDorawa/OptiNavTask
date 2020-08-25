
using System.Windows;
using System.IO;
using Microsoft.Win32;



namespace OptiTask
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new numbersViewModel();
        }

        public void load_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
                ((numbersViewModel)DataContext).NumbersString = ((numbersViewModel)DataContext).NumbersString + " /// " + File.ReadAllText(openFileDialog.FileName);     
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == true)
                 File.WriteAllText(saveFileDialog.FileName, ((numbersViewModel)DataContext).NumbersString2);

        }
    }
}
