using CrudFireStoreWpf.data.firebase.config;
using CrudFireStoreWpf.domain.repository;
using Google.Cloud.Firestore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CrudFireStoreWpf.data.firebase.repository
{
    public class UpdateRepositoryImpl : IUpdateRepository
    {

        public async Task<bool> Replace_A_Document_Deleting_All_Previous_Fields(String collection, String document, Dictionary<string, object> data)
        {
            DocumentReference docref = FbConfig.Getdb().Collection(collection).Document(document);
            DocumentSnapshot snap = await docref.GetSnapshotAsync();
            if (snap.Exists)
            {
                await docref.SetAsync(data);
                return true;
            }
            return false;
        }

        public async Task<bool> Update_Specific_Fields_or_Add_New_Fields(String collection, String document, Dictionary<string, object> data)
        {
            DocumentReference docref = FbConfig.Getdb().Collection(collection).Document(document);
            DocumentSnapshot snap = await docref.GetSnapshotAsync();
            if (snap.Exists)
            {
                await docref.UpdateAsync(data);
                return true;
            }
            return false ;
        }

        public async Task<bool> Update_List_Elements_or_Nested_Elements(String collection, String document, Dictionary<string, object> data)
        {
            DocumentReference docref = FbConfig.Getdb().Collection(collection).Document(document);
            DocumentSnapshot snap = await docref.GetSnapshotAsync();
            if (snap.Exists)
            {
                await docref.UpdateAsync(data);
                return true;
            }
            return false;
        }

        public async Task<bool> Update_Array_Elements(String collection, String document, String ArrayName, ArrayList array)
        {
            DocumentReference docref = FbConfig.Getdb().Collection(collection).Document(document);
            DocumentSnapshot snap = await docref.GetSnapshotAsync();
            if (snap.Exists)
            {
                foreach (var element in array)
                {
                    await docref.UpdateAsync(ArrayName, FieldValue.ArrayUnion(element));
                }
                return true;
            }
            return false;
        }

    }
}
