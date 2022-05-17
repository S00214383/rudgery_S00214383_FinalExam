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

namespace rudgery_S00214383_FinalExam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public List<RentalProperty> allProperties;
        public MainWindow()
        {
            InitializeComponent();
        }

    

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Loading data to its start

            RentalData db = new RentalData();

            var query = from h in db.AllRentals
                        orderby h.Price 

                        select h;

            allProperties = query.ToList();
            lbxHouses.ItemsSource = allProperties;

        }

        //displaying selected house from listbox
        private void lbxHouses_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            RentalProperty selected = lbxHouses.SelectedItem as RentalProperty;

            //check either null or not
            if (selected != null)
            {
                //update display
                tblxHousesDetails.Text = selected.GetDetails();

            }

        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            //creating second windown
            RentalData secondWindow = new RentalData();

            //stablish connection / link
            //secondWindow.owner = this;

            //secondWindow.ShowDialog();
                
            }
    }
}
