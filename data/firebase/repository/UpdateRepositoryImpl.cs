using CrudFireStoreWpf.data.firebase.config;
using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudFireStoreWpf.data.firebase.repository
{
    public class UpdateRepositoryImpl
    {

        public void Replace_Document_Deleting_All_Previous_Fields()
        {
            DocumentReference docref = FbConfig.Getdb().Collection("Update1").Document("docs1");
            Dictionary<string, object> data = new Dictionary<string, object>();

        }

    }
}
