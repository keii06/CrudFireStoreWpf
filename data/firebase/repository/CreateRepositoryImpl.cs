using CrudFireStoreWpf.data.firebase.config;
using CrudFireStoreWpf.domain.repository;
using Google.Cloud.Firestore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudFireStoreWpf.data.firebase.repository
{
    public class CreateRepositoryImpl : ICreateRepository
    {
        public bool Add_Array(ArrayList users, string collection, string document)
        {
            DocumentReference docref = FbConfig.Getdb().Collection(collection).Document(document);
            Dictionary<string, object> data = new Dictionary<string, object>
            {
                { "My user array", users }
            };
            docref.SetAsync(data);
            return true;
        }

        public bool Add_Document_With_AutoID(Dictionary<string, object> user, string collection)
        {
            CollectionReference collref = FbConfig.Getdb().Collection(collection);
            collref.AddAsync(user);
            return true;
        }

        public bool Add_Document_With_CustomID(Dictionary<string, object> user, string collection, string document)
        {
            DocumentReference docref = FbConfig.Getdb().Collection(collection).Document(document);
            docref.SetAsync(user);
            return true;
        }

        public bool Add_ListOfObjects(Dictionary<string, object> List, String collection, String document)
        {
            DocumentReference doc = FbConfig.Getdb().Collection(collection).Document(document);
            Dictionary<string, object> MainData = new Dictionary<string, object>
            {
                { "MyList", List }
            };
            doc.SetAsync(MainData);
            return true;
        }

        public bool Add_Multiple_SetsOfData(String Collection, Dictionary<string, object> data)
        {
            CollectionReference coll = FbConfig.Getdb().Collection(Collection);
            coll.AddAsync(data);
            return true;
        }
    }
}
