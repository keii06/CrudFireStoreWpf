using CrudFireStoreWpf.data.firebase.config;
using CrudFireStoreWpf.data.firebase.repository;
using Google.Cloud.Firestore;
using Google.Cloud.Firestore.V1;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Data;
using CrudFireStoreWpf.domain.service;

namespace CrudFireStoreWpf.presentation.read
{
    /// <summary>
    /// Lógica de interacción para read.xaml
    /// </summary>
    public partial class read : Window
    {

        DataTable dt = new DataTable();
        ReadRepositoryImpl repository = new ReadRepositoryImpl();

        public read()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, RoutedEventArgs e)
        {

            this.Hide();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
             dt.Columns.AddRange(new DataColumn[4]
                {
                new DataColumn("Document", typeof(string)),
                new DataColumn("IsCapital", typeof(bool)),
                new DataColumn("Population", typeof(int)),
                new DataColumn("Province", typeof(string)),
                });
        }

        private async void btnMostrarXDocumento_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                validarRef();

                ReadService service = new ReadService(repository);
                Dictionary<string, object> data = await service.GetAllData_Of_A_Document(txtCollection.Text, txtDocument.Text);
                dgdatos.ItemsSource = data;

                txtiscapital.Text = data["IsCapital"].ToString();
                txtpopulation.Text = data["Population"].ToString();
                txtprovince.Text = data["Province"].ToString();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private async void btnMostrarXColeccion_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txtCollection.Text == "")
                {
                    throw new Exception("No ha ingresado una colección a la referencia");
                }

                ReadService service = new ReadService(repository);
                QuerySnapshot snap = await service.Get_All_Documents_From_A_Collection(txtCollection.Text);

                dt.Clear();
                limpiar();

                foreach (DocumentSnapshot docSnap in snap.Documents)
                {
                    Dictionary<string, object> city = docSnap.ToDictionary();
                    dt.Rows.Add(docSnap.Id, city["IsCapital"], city["Population"], city["Province"]);
                }

                dgdatos.ItemsSource = dt.DefaultView;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        void validarRef()
        {
            if (txtCollection.Text == "")
            {
                throw new Exception("No ha ingresado una colección a la referencia");
            }
            if (txtDocument.Text == "")
            {
                throw new Exception("No ha ingresado un documento a la referencia");
            }
        }

        void limpiar()
        {
            txtiscapital.Text = "";
            txtpopulation.Text = "";
            txtprovince.Text = "";
        }


    }
}
