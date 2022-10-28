using CrudFireStoreWpf.data.firebase.repository;
using CrudFireStoreWpf.domain.repository;
using CrudFireStoreWpf.domain.service;
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

namespace CrudFireStoreWpf.presentation.delete
{
    /// <summary>
    /// Lógica de interacción para delete.xaml
    /// </summary>
    public partial class delete : Window
    {
        DeleteRepositoryImpl repository = new DeleteRepositoryImpl();

        public delete()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

        private void Delete_An_Entired_Document_Click(object sender, RoutedEventArgs e)
        {
            DeleteService service = new DeleteService(repository);
            string collection = "";
            string document = "";
            service.Delete_An_Entired_Document(collection, document);
        }

        private void Delete_A_Field_Within_A_Document_Click(object sender, RoutedEventArgs e)
        {
            DeleteService service = new DeleteService(repository);
            string collection = "";
            string document = "";
            string fieldName = "";
            service.Delete_A_Field_Within_A_Document(collection, document, fieldName);
        }

        private void Delete_An_Element_Inside_A_List_Click(object sender, RoutedEventArgs e)
        {
            DeleteService service = new DeleteService(repository);
            string collection = "";
            string document = "";
            string listName = "";
            string fieldName = "";
            service.Delete_An_Element_Inside_A_List(collection, document, listName, fieldName);
        }

        private void Delete_An_Element_Inside_A_Array_Click(object sender, RoutedEventArgs e)
        {
            DeleteService service = new DeleteService(repository);
            string collection = "";
            string document = "";
            string ArrayName = "";
            service.Delete_An_Element_Inside_A_Array(collection,document,ArrayName,456);
        }

        private void Delete_All_Documents_In_A_Collection_Click(object sender, RoutedEventArgs e)
        {
            DeleteService service = new DeleteService(repository);
            string collection = "";
            service.Delete_All_Documents_In_A_Collection(collection);
        }

        private void Delete_All_Documents_In_A_Collection_With_Limitation_Click(object sender, RoutedEventArgs e)
        {
            DeleteService service = new DeleteService(repository);
            string collection = "";
            int limit = 3;
            service.Delete_All_Documents_In_A_Collection_With_Limitation(collection, limit);
        }
    }
}
