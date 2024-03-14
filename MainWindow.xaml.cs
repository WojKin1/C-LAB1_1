using System;
using System.Windows;


namespace WpfApp1
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
      

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            try
            {
            double a = double.Parse(danaa.Text);
            double b = double.Parse(danab.Text);
            double c = double.Parse(danac.Text);


            if(!double.TryParse(danaa.Text, out a) && !double.TryParse(danab.Text, out b) && !double.TryParse(danac.Text, out c))
            {
                MessageBox.Show("Wprowadź poprawne wartości dla a, b i c !");
                return;
            }
           
            
                double delta = (b * b) - (4 * a * c);   
            
            if(delta < 0)
            {
                wynik.Text = "Delta mniejsza od 0!";
            }
            else if(delta == 0)
            {
                double x0 = -b / 2 * a;
                wynik.Text = $"X0 = { x0}";
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta) / (2 * a));
                double x2 = (-b - Math.Sqrt(delta) / (2 * a));

                wynik.Text = $"X1 = {x1} X2 = {x2}";


            }

        }
            catch (FormatException)
            {
                MessageBox.Show("Wprowadź dane!");
            }
            
            catch(Exception ex) //obsluga bledow dodatkowych nie zwiazanych z zadaniem
            {
                MessageBox.Show($"Wystapil blad: {ex.Message}");
            }


    }
  }
}
