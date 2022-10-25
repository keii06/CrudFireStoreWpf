using CrudFireStoreWpf.data.firebase.config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Google.Cloud.Firestore;
using CrudFireStoreWpf.data.firebase.repository;
using CrudFireStoreWpf.domain.service;
using System.Collections;
using System.Xml.Linq;

namespace CrudFireStoreWpf.presentation.update
{
    /// <summary>
    /// Lógica de interacción para update.xaml
    /// </summary>
    public partial class update : Window
    {
        UpdateRepositoryImpl repository = new UpdateRepositoryImpl();

        public update()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

        private void btnupdate1_Click(object sender, RoutedEventArgs e)
        {
            String collection = "Update1";
            String document = "docs1";

            Dictionary<string, object> data = new Dictionary<string, object>()
            {
                {"name","TACV"},
                {"web","youtube.com"}
            };

            UpdateService service = new UpdateService(repository);
            service.Replace_A_Document_Deleting_All_Previous_Fields(collection, document, data);

        }

        private void btnupdate2_Click(object sender, RoutedEventArgs e)
        {
            String collection = "Update1";
            String document = "docs1";

            Dictionary<string, object> data = new Dictionary<string, object>()
            {
                {"name","TACV - The Amazing Code_Verse"},
                //Add new field
                {"newField",123 },
            };

            UpdateService service = new UpdateService(repository);
            service.Update_Specific_Fields_or_Add_New_Fields(collection,document,data);
        }

        private void btnupdate3_Click(object sender, RoutedEventArgs e)
        {
            String collection = "WithMultipleSets";
            String document = "ubBqvTiQCo4LQ48AYFRh";

            Dictionary<string, object> data = new Dictionary<string, object>()
            {
                {"MyList.FirstName","TACV - The amazing Code-Verse"},
                //Add new field
                {"MyList.newField",123 },

            };

            UpdateService service = new UpdateService(repository);
            service.Update_List_Elements_or_Nested_Elements(collection,document,data);
        }

        private void btnupdate4_Click(object sender, RoutedEventArgs e)
        {
            String collection = "WithMultipleSets";
            String document = "ubBqvTiQCo4LQ48AYFRh";
            String ArrayName = "MyArray";

            ArrayList array = new ArrayList
                {
                    456,
                    "hola",
                    true,
                };

            UpdateService service = new UpdateService(repository);
            service.Update_Array_Elements(collection, document, ArrayName, array);
        }
    }
}
