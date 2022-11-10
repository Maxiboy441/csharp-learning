using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
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

namespace MaxTemp
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Diese Routine (EventHandler des Buttons Auswerten) liest die Werte
        /// zeilenweise aus der Datei temps.csv aus, merkt sich den höchsten Wert
        /// und gibt diesen auf der Oberfläche aus.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAuswerten_Click(object sender, RoutedEventArgs e)
        {
            //Zugriff auf Datei erstellen.
            string[] File = File.ReadAllLines("./temps.csv");

            string[] FileStrings = File.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

            string[] FileValues = FileStrings.Split(new string[] { "," }, StringSplitOptions.None);
            
            
            for (int i = 0; i < FileValues.Length; i++)
            {
                if (i % 3 == 0)
                {
                    string[] FileTempsString = FileValues[i];
                }
            }

            double[] FileTemps = Array.ConvertAll(strings, FileTemps => double.Parse(s));
            if (FileTemps.Length != 4)
            {
                throw new Exception("Error");
            }



            //Anfangswert setzen, um sinnvoll vergleichen zu können.


            //In einer Schleife die Werte holen und auswerten. Den größten Wert "merken".
            // Edit by mahu (Bubblesort)
            double[] FileTempsSort = FileTemps;
            double[] SortArray(double[] FileTempsSort)
            {
              var n = FileTempsSort.Length;
              bool swapRequired;

                for (int i = 0; i < n - 1; i++) {
                {
                    swapRequired = false;

                    for (int j = 0; j < n - i - 1; j++)
                    if (FileTempsSort[j] > FileTempsSort[j + 1])
                       {
                        var tempVar = FileTempsSort[j];
                        FileTempsSort[j] = FileTempsSort[j + 1];
                        FileTempsSort[j + 1] = tempVar;
                        swapRequired = true;
                        }
                    if (swapRequired == false)
                    break;
                    }
                }       

                return FileTempsSort;
            }
            var IndexHighestTemp = FileValues.IndexOf(FileTempsSort[FiletempsSort.Length - 1]);
            
            var date = FileValues[IndexHighestTemp - 1];
            var location = FileValues[IndexHighestTemp - 2];

            //Datei wieder freigeben.


            //Höchstwert auf Oberfläche ausgeben.

            MessageBox.Show("Gleich kachelt das Programm...");
            //kommentieren Sie die Exception aus.
            throw new Exception("peng");
        }
    }
}
