using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudFireStoreWpf.data.firebase.config
{
    public static class FbConfig
    {
        public static FirestoreDb Getdb()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"\practicasflutter.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            //MessageBox.Show("Successful");
            return FirestoreDb.Create("practicasflutter-keii06");
        }
    }
}
