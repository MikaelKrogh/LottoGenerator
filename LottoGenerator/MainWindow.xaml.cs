using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;
using System.Windows;

namespace LottoGenerator {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            this.DataContext = this;
            tilfoej();     
        }
        ObservableCollection<Kupon> enKupon { get; set; } = new ObservableCollection<Kupon>();
        //evt get set ved fejl

        private void LavKuponKnap_Click(object sender, RoutedEventArgs e) {
            Kupon kupon = new Kupon(false);
            Kupon kupon1 = new Kupon(true);
            Kupon kupon2= new Kupon(true);
            Kupon kupon3 = new Kupon(false);
            enKupon.Add(kupon);
            enKupon.Add(kupon1);
            enKupon.Add(kupon2);
            enKupon.Add(kupon3);

            for (int i = 0; i < enKupon.Count; i++)
            {
                StringBuilder tekstTilFil = TekstBehandler.Linjebehandling(enKupon[i]);
                File.WriteAllText($@"C:\Lottotekst\lottoKupon{i.ToString()}.txt", tekstTilFil.ToString());
                TilfoejTilBoks(tekstTilFil);

            }
            
        }
        private void tilfoej() {
            Kupon kupon = new Kupon(false);
            Kupon kupon1 = new Kupon(true);
            Kupon kupon2 = new Kupon(true);
            Kupon kupon3 = new Kupon(false);
            enKupon.Add(kupon);
            enKupon.Add(kupon1);
            enKupon.Add(kupon2);
            enKupon.Add(kupon3);
           

        }

        private void TilfoejTilBoks(StringBuilder builder) {
            ResultBx.Text += builder.ToString();
        }
    }
}
