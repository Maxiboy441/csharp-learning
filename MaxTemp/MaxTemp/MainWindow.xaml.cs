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
            string[] file = File.ReadAllLines("./temps.csv");
            string[] values;
            double temp = 0;
            int index = 0;


            for (int i = 0; i < file.Length; i++)
            {
                values = file[i].Split(new string[] { "," }, StringSplitOptions.None);
                double value = Double.Parse(values[2], CultureInfo.InvariantCulture);

                if (value > temp)
                {
                    temp = Convert.ToDouble(values[2], CultureInfo.InvariantCulture);
                    index = i + 1;
                }
            }


            //Anfangswert setzen, um sinnvoll vergleichen zu können.


            //In einer Schleife die Werte holen und auswerten. Den größten Wert "merken".
            // Edit by mahu (Bubblesort)

            //Datei wieder freigeben.


            //Höchstwert auf Oberfläche ausgeben.
            lblAusgabe.Content = temp.ToString();
            MessageBox.Show("Gleich kachelt das Programm...");
            //kommentieren Sie die Exception aus.

        }
    }
}
