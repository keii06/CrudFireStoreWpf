using CrudFireStoreWpf.presentation.create;
using CrudFireStoreWpf.presentation.delete;
using CrudFireStoreWpf.presentation.read;
using CrudFireStoreWpf.presentation.update;
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

namespace CrudFireStoreWpf
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            create create = new create();
            create.ShowDialog();
        }

        private void btnRead_Click(object sender, RoutedEventArgs e)
        {
            read read = new read();
            read.ShowDialog();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            update update = new update();
            update.ShowDialog();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            delete delete = new delete();
            delete.ShowDialog();
        }
    }
}
