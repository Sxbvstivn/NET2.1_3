using System;
using System.Windows;
using System.Windows.Controls;
using System.Xml;

namespace NET_Zadanie_2
{
    public partial class MainWindow : Window
    {
        ListBox lista;

        public MainWindow()
        {
            InitializeComponent();
            lista = (ListBox)FindName("Kategorie");
        }

        private void WidokWybranejKategorii(object sender, RoutedEventArgs e)
        {
            // Pobieramy wybraną kategorię jako XmlElement
            XmlElement wybrana = (XmlElement)lista.SelectedItem;

            // Tworzymy nową instancję KategoriaWidok i przekazujemy wybraną kategorię
            KategoriaWidok kategoriaWidok = new KategoriaWidok(wybrana);

            // Wyświetlamy nowe okno
            kategoriaWidok.Show();
        }
    }
}
