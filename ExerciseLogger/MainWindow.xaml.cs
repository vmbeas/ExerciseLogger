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
using System.IO;

namespace ExerciseLogger
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

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            string output = string.Format(DateTime.Today.ToString("d") + "\r\nExercise Name:{0}\r\nWeight:{1}\r\n" +
                                            "Reps:{2}\r\nRest Time:{3}\r\nNotes:{4}\r\n", 
                                            nameTxt.Text, weightTxt.Text, repTxt.Text, restTxt.Text, notesTxt.Text);
            StreamWriter file = new StreamWriter("log.txt", true);
            file.WriteLine(output);
            file.Close();
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            nameTxt.Clear();
            weightTxt.Clear();
            repTxt.Clear();
            restTxt.Clear();
            notesTxt.Clear();
        }


    }
}
