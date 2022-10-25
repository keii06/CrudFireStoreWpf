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


namespace CrudFireStoreWpf.presentation.update
{
    /// <summary>
    /// Lógica de interacción para update.xaml
    /// </summary>
    public partial class update : Window
    {
        public update()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

        private async void btnupdate1_Click(object sender, RoutedEventArgs e)
        {
            DocumentReference docref = FbConfig.Getdb().Collection("Update1").Document("docs1");
            Dictionary<string, object> data = new Dictionary<string, object>()
            {
                {"name","TACV"},
                {"web","youtube.com"}
            };
            DocumentSnapshot snap = await docref.GetSnapshotAsync();
            if (snap.Exists)
            {
                await docref.SetAsync(data);
            }

        }

        private async void btnupdate2_Click(object sender, RoutedEventArgs e)
        {
            DocumentReference docref = FbConfig.Getdb().Collection("Update1").Document("docs1");
            Dictionary<string, object> data = new Dictionary<string, object>()
            {
                {"name","TACV - The Amazing Code_Verse"},
                //Add new field
                {"newField",123 },
            };
            DocumentSnapshot snap = await docref.GetSnapshotAsync();
            if (snap.Exists)
            {
                await docref.UpdateAsync(data);
            }
        }

        private async void btnupdate3_Click(object sender, RoutedEventArgs e)
        {
            String collection = "WithMultipleSets";
            String document = "ubBqvTiQCo4LQ48AYFRh";

            DocumentReference docref = FbConfig.Getdb().Collection(collection).Document(document);

            Dictionary<string, object> data = new Dictionary<string, object>()
            {
                {"MyList.FirstName","TACV - The amazing Code-Verse"},
                //Add new field
                {"MyList.newField",123 },

            };

            DocumentSnapshot snap = await docref.GetSnapshotAsync();
            if (snap.Exists)
            {
                await docref.UpdateAsync(data);
            }
        }

        private async void btnupdate4_Click(object sender, RoutedEventArgs e)
        {
            String collection = "WithMultipleSets";
            String document = "ubBqvTiQCo4LQ48AYFRh";

            DocumentReference docref = FbConfig.Getdb().Collection(collection).Document(document);
            DocumentSnapshot snap = await docref.GetSnapshotAsync();
            if (snap.Exists)
            {
                await docref.UpdateAsync("MyArray",FieldValue.ArrayUnion(123,"abcd",456));
            }
        }
    }
}
