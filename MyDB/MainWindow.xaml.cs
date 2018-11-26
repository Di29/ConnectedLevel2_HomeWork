using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace MyDB
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            SqlConnection sqlConnection = new SqlConnection();
            SqlConnectionStringBuilder connectionStringBuilder = new SqlConnectionStringBuilder();

            connectionStringBuilder.UserID = "sa";
            connectionStringBuilder.Password = "1234@";
            connectionStringBuilder.InitialCatalog = "MyDB";
            connectionStringBuilder.DataSource = "localhost";
            connectionStringBuilder.ConnectTimeout = 30;
            sqlConnection.ConnectionString = connectionStringBuilder.ConnectionString;
        }
    }
}
