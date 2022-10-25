using CrudFireStoreWpf.data.firebase.repository;
using CrudFireStoreWpf.domain.service;
using System;
using System.Collections;
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

namespace CrudFireStoreWpf.presentation.create
{
    /// <summary>
    /// Lógica de interacción para create.xaml
    /// </summary>
    public partial class create : Window
    {
        public create()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

        private void btnAutoId_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                validarVacio();

                CreateRepositoryImpl repository = new CreateRepositoryImpl();
                CreateService service = new CreateService(repository);

                Dictionary<string, object> data = new Dictionary<string, object>()
                {
                    {"Nombre", txtname.Text},
                    {"Apellido", txtlastname.Text},
                    {"Dirección", txtaddress.Text},
                    {"FechaNac", datefecnac.Text},
                };

                String collection = "WithAutoID";

                service.Add_Document_With_AutoID(data, collection);
                MessageBox.Show("Agregado Exitosamente");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnCustomId_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                validarVacio();

                CreateRepositoryImpl repository = new CreateRepositoryImpl();
                CreateService service = new CreateService(repository);

                Dictionary<string, object> data = new Dictionary<string, object>()
                {
                    {"Nombre", txtname.Text},
                    {"Apellido", txtlastname.Text},
                    {"Dirección", txtaddress.Text},
                    {"FechaNac", datefecnac.Text},
                };

                String collection = "WithCustomID";
                String document = "CustomID";

                service.Add_Document_With_CustomID(data,collection,document);
                MessageBox.Show("Agregado Exitosamente");

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnArray_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                validarVacio();

                CreateRepositoryImpl repository = new CreateRepositoryImpl();
                CreateService service = new CreateService(repository);

                ArrayList array = new ArrayList
                {
                    txtname.Text,
                    txtlastname.Text,
                    txtaddress.Text,
                    datefecnac.Text
                };

                String collection = "WithArrayList";
                String document = "list";

                service.Add_Array(array, collection, document);
                MessageBox.Show("Agregado Exitosamente");

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        void validarVacio()
        {
            if (txtname.Text == "")
            {
                throw new Exception("El nombre está vacío");
            }
            if (txtlastname.Text == "")
            {
                throw new Exception("El apellido está vacío");
            }
            if (txtaddress.Text == "")
            {
                throw new Exception("La dirección está vacía");
            }
            if (datefecnac.Text == "")
            {
                throw new Exception("La fecha está vacía");
            }
        }
    }
}
