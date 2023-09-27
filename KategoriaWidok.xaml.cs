using System.Windows;
using System.Windows.Controls;
using System.Xml;

namespace NET_Zadanie_2
{
    public partial class KategoriaWidok : Window
    {
        public KategoriaWidok(XmlElement selectedCategory)
        {
            InitializeComponent();

            string categoryName = selectedCategory.GetAttribute("Nazwa");
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(filename: "C:\\Users\\YVKVZV\\source\\repos\\NET Zadanie 3\\NET Zadanie 3\\Bronie.xml");
            XmlNodeList weapons = xmlDoc.SelectNodes($"//Kategoria[@Nazwa='{categoryName}']/Podkategoria/Bron");

            // Przypisz dane do kontrolki, która ma wyświetlać broń (na przykład DataGrid)
            MyDataGrid.ItemsSource = weapons;
        }
    }
}
