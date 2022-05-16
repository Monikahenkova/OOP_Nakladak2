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

namespace OOP_Nakladak
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Nakladak Volvo;
        Nakladak Fiat;
       
       
        public MainWindow()
        {
            InitializeComponent();

            
            Volvo = new Nakladak(10000, 1300 , 30);
            Volvo.Znacka = "Volvo";
            
            Fiat = new Nakladak(10000, 1100, 32);
            Fiat.Znacka = "Fiat";

            Vypis();

        }
        public void Vypis()
        {
            Nakladak1.Text = Volvo.Znacka + "\n";
            Nakladak1.Text += "Nosnost" + " " + Volvo.Nosnost + "\n";
            Nakladak1.Text += "Naložení" + " " + Volvo.Nalozeno + "\n";
            Nakladak1.Text += "Spotreba" + " " + Volvo.Spotreba + "\n";
            Nakladak1.Text += "ObjemNadrze" + " " + Volvo.ObjemNadrz + "\n";
            Nakladak1.Text += "Palivo" + " " + Volvo.Palivo + "\n";
            Nakladak1.Text += "Vzdálenost" + " " + Volvo.Vzdalenost + "\n";

            Nakladak2.Text = Fiat.Znacka + "\n";
            Nakladak2.Text += "Nosnost" + " " + Fiat.Nosnost + "\n";
            Nakladak2.Text += "Naložení" + " " + Fiat.Nalozeno + "\n";
            Nakladak2.Text += "Spotreba" + " " + Fiat.Spotreba + "\n";
            Nakladak2.Text += "ObjemNadrze" + " " + Fiat.ObjemNadrz + "\n";
            Nakladak2.Text += "Palivo" + " " + Fiat.Palivo + "\n";
            Nakladak2.Text += "Vzdálenost" + " " + Fiat.Vzdalenost + "\n";
        }



        private void Nacepovat_Click(object sender, RoutedEventArgs e)
        {
            Volvo.Tankovat(int.Parse(input1.Text)); 
            Vypis();
        }
        private void Nacepovat2_Click(object sender, RoutedEventArgs e)
        {
            Fiat.Tankovat(int.Parse(input2.Text));
            Vypis();
        }


        private void Jet_Click(object sender, RoutedEventArgs e)
        {
            Volvo.Jet(int.Parse(input1.Text));
            Volvo.Jezdit(int.Parse(input1.Text));
            Vypis();
        }

        private void Nalozit_Click(object sender, RoutedEventArgs e)
        {
            Volvo.Naloz(int.Parse(input1.Text));
            Vypis();
        }

        private void Vylozit2_Click(object sender, RoutedEventArgs e)
        {
            Fiat.Vyloz(int.Parse(input2.Text));
            Vypis();
        }

        private void Vylozit_Click(object sender, RoutedEventArgs e)
        {
            Volvo.Vyloz(int.Parse(input1.Text));
            Vypis();
        }

        private void Nalozit2_Click(object sender, RoutedEventArgs e)
        {
            Fiat.Naloz(int.Parse(input2.Text));
            Vypis();
        }

        private void Jet2_Click(object sender, RoutedEventArgs e)
        {
            Volvo.Jet(int.Parse(input2.Text));
            Fiat.Jezdit(int.Parse(input2.Text));
            Vypis();
        }
    }
}
