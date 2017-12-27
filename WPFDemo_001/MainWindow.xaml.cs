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
using WPFDemo_001.Models;

namespace WPFDemo_001
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
        }

        MyDataContext dataContext = new MyDataContext();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dataContext = new MyDataContext();
            dt1.ItemsSource = dataContext.Personels.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Personel p = new Personel
            {
                Adi = txt1.Text,
                Soyadi = txt2.Text,
                TCKN = txt3.Text
                
            };
                dataContext.Personels.Add(p);
            dataContext.SaveChanges();
                dt1.ItemsSource =  dataContext.Personels.ToList();
            
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";

        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var silinecek = txt1.Text;
            var silinecekPersonel = dataContext.Personels.Where(x => x.TCKN == silinecek).FirstOrDefault();
            dataContext.Personels.Remove(silinecekPersonel);
            dataContext.SaveChanges();
            dt1.ItemsSource = dataContext.Personels.ToList();
            txt3.Text = "";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var guncellenecek = txt3.Text;
            var guncellenecekPersonel = dataContext.Personels.Where(x => x.TCKN == guncellenecek).FirstOrDefault();
            guncellenecekPersonel.Adi = txt1.Text;
            guncellenecekPersonel.Soyadi = txt2.Text;
            dataContext.SaveChanges();
            dt1.ItemsSource = dataContext.Personels.ToList();
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
        }
    }
}
