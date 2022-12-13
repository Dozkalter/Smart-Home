using MySql.Data.MySqlClient;
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
using System.Windows.Shapes;

namespace SmartHome
{
    /// <summary>
    /// Interaction logic for profilPage.xaml
    /// </summary>
    public partial class profilPage : Window
    {
        int id;
        public profilPage(int id)
        {
            InitializeComponent();
            this.id = id;
        }

       

      

        private void btxExit1_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();

        }

        private void BtnModify_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("server=localhost;user id=root;database=library");
                connection.Open();
                MySqlCommand command = new MySqlCommand("update user set nom = '"+ TxtNom.Text + "' , prenom ='"+ TxtPrenom.Text + "', email ='"+ TxtEmail.Text+"' where id ="+id, connection);
                  command.ExecuteNonQuery();
                    connection.Close();
                MessageBox.Show("Data was update successfully!", "Update Successfull",MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}
