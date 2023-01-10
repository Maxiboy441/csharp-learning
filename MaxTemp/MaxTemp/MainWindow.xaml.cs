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

       string dateiPfad;
       string dateiInhalt;

       private void btnAuswerten_Click(object sender, RoutedEventArgs e)
       {
         Microsoft.Win32.OpenFileDialog openFileDlg = new Microsoft.Win32.OpenFileDialog();

            Nullable<bool> result = openFileDlg.ShowDialog();

           if (result == true)
           {
               dateiPfad=openFileDlg.FileName;
               FileNameTextBox.Text = openFileDlg.FileName;
               FileStream fs = new FileStream(dateiPfad, FileMode.Open);
               StreamReader sr = new StreamReader(fs);
               dateiInhalt=sr.ReadToEnd();
               txtInhalt.Text = dateiInhalt;
           }

           //Zugriff auf Datei erstellen.

           //Anfangswert setzen, um sinnvoll vergleichen zu können.


           //In einer Schleife die Werte holen und auswerten. Den größten Wert "merken".
           /* Edit by mahu (Bubblesort)
           double[] FileTempsSort = FileTemps;
           public double[] SortArray(FileTempsSort)
           {
             var n = FileTempsSort.Length;
             bool swapRequired;

               for (int i = 0; i < n - 1; i++) 
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

               return FileTempsSort;
           }
           */

           //Datei wieder freigeben.


           //Höchstwert auf Oberfläche ausgeben.



           //Zugriff auf Datei erstellen.


           //kommentieren Sie die Exception aus.
       }

       private void btnMax_Click(object sender, RoutedEventArgs e)
       {

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



           txtMax.Text = temp.ToString();
           if (temp > 40)
           {
               MessageBox.Show("ALARM!!!");
           }
       }

       private void btnMin_Click(object sender, RoutedEventArgs e)
       {
           string[] file = File.ReadAllLines("./temps.csv");
           string[] values;
           double temp = 100;
           int index = 0;


           for (int i = 0; i < file.Length; i++)
           {
               values = file[i].Split(new string[] { "," }, StringSplitOptions.None);
               double value = Double.Parse(values[2], CultureInfo.InvariantCulture);

               if (value < temp)
               {
                   temp = Convert.ToDouble(values[2], CultureInfo.InvariantCulture);
                   index = i + 1;
               }
           }
           txtMin.Text = temp.ToString();
       }
   }
}
