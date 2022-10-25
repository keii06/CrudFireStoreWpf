using CrudFireStoreWpf.data.firebase.config;
using CrudFireStoreWpf.domain.repository;
using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudFireStoreWpf.data.firebase.repository
{
    public class ReadRepositoryImpl : IReadRepository
    {

        public async Task<Dictionary<string, object>> GetAllData_Of_A_Document(String Collection, String Document)
        {
            DocumentReference docref = FbConfig.Getdb().Collection(Collection).Document(Document);
            DocumentSnapshot snap = await docref.GetSnapshotAsync();

            if (snap.Exists)
            {
                Dictionary<string, object> city = snap.ToDictionary();
                return city;
            }

            Dictionary<string, object> data = new Dictionary<string, object>();
            return data;
        }

        public async Task<QuerySnapshot> Get_All_Documents_From_A_Collection(String collection)
        {
            Query Qref = FbConfig.Getdb().Collection(collection);
            return await Qref.GetSnapshotAsync();
        }

    }
}
