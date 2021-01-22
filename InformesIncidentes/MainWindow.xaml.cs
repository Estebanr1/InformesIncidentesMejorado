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

namespace InformesIncidentes
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

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void botonGenerar_Click(object sender, RoutedEventArgs e)
        {



        }

        private void botonSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void botonGenerar_Click_1(object sender, RoutedEventArgs e)
        {

            
                string rutaDir = $"c:\\Informes";
            string rutaArchivo = $"{rutaDir}\\prueba.txt";

            if (!Directory.Exists(rutaDir))
            { Directory.CreateDirectory(rutaDir); }
            



            using (StreamWriter sw = new StreamWriter(rutaArchivo, false))
            {
                
              
                sw.WriteLine($"Fecha: {datePickerFecha}");
                sw.WriteLine($"\nProblema: \n\t{texboxProblema.Text}\n");
                sw.WriteLine($"\nSolucion Inmediata: \n\t{texBoxSolucionInmediata.Text}\n");
                sw.WriteLine($"\nSolucion Definitiva: \n\t{textBoxSolucionDefinitiva.Text}\n");
                sw.WriteLine($"\nNombre: \n\t{textBoxNombre.Text}\n");
            }

            
           
            MessageBox.Show("Archivo Generado en C:\\Informes", "Mensaje");

        }
        
        
    }
}
