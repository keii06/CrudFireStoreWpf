using CrudFireStoreWpf.data.firebase.config;
using CrudFireStoreWpf.domain.repository;
using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CrudFireStoreWpf.data.firebase.repository
{
    public class DeleteRepositoryImpl : IDeleteRepository
    {

        public void Delete_An_Entired_Document(String collection, String document)
        {
            DocumentReference docref = FbConfig.Getdb().Collection(collection).Document(document);
            docref.DeleteAsync();
            MessageBox.Show("EliminadoCorrectamente");
        }

        public void Delete_A_Field_Within_A_Document(String collection, String document, String fieldName)
        {
            DocumentReference docref = FbConfig.Getdb().Collection(collection).Document(document);
            Dictionary<String, object> data = new Dictionary<String, object>()
            {
                {fieldName,FieldValue.Delete },
            };

            docref.UpdateAsync(data);
            MessageBox.Show("EliminadoCorrectamente");
        }

        public void Delete_An_Element_Inside_A_List(String collection, String document, String listName, String fieldName)
        {
            DocumentReference docref = FbConfig.Getdb().Collection(collection).Document(document);
            String nameField = listName + fieldName;
            Dictionary<String, object> data = new Dictionary<String, object>()
            {
                {nameField,FieldValue.Delete },
            };

            docref.UpdateAsync(data);
            MessageBox.Show("EliminadoCorrectamente");
        }

        public void Delete_An_Element_Inside_A_Array(String collection, String document, String ArrayName, dynamic deleteObject)
        {
            DocumentReference docref = FbConfig.Getdb().Collection(collection).Document(document);
            Dictionary<String, object> data = new Dictionary<String, object>()
            {
                {ArrayName,FieldValue.ArrayRemove(deleteObject) },
            };

            docref.UpdateAsync(data);
            MessageBox.Show("EliminadoCorrectamente");
        }

        public async void Delete_All_Documents_In_A_Collection(String collection,)
        {
            CollectionReference collref = FbConfig.Getdb().Collection(collection);
            QuerySnapshot snap = await collref.GetSnapshotAsync();

            foreach (DocumentSnapshot doc in snap.Documents)
            {
                await doc.Reference.DeleteAsync();
            }
        }

        public async void Delete_All_Documents_In_A_Collection_With_Limitation(String collection, int limit)
        {
            CollectionReference collref = FbConfig.Getdb().Collection(collection);
            QuerySnapshot snap = await collref.Limit(limit).GetSnapshotAsync();
            IReadOnlyList<DocumentSnapshot> docs = snap.Documents;

            while (docs.Count > 0)
            {
                foreach (DocumentSnapshot doc in docs)
                {
                    await doc.Reference.DeleteAsync();
                }
                snap = await collref.Limit(3).GetSnapshotAsync();
                docs = snap.Documents;
            }


        }




















        public async void Delete_All_Documents_In_A_Collection(string collection)
        {
            CollectionReference collref = FbConfig.Getdb().Collection(collection);
            QuerySnapshot snap = await collref.GetSnapshotAsync();

            foreach (DocumentSnapshot doc in snap.Documents)
            {
                await doc.Reference.DeleteAsync();
            }
        }

        public async void Delete_All_Documents_In_A_Collection_With_Limitation(string collection, int limit)
        {
            CollectionReference collref = FbConfig.Getdb().Collection(collection);
            QuerySnapshot snap = await collref.Limit(limit).GetSnapshotAsync();
            IReadOnlyList<DocumentSnapshot> docs = snap.Documents;

            while (docs.Count > 0)
            {
                foreach (DocumentSnapshot doc in docs)
                {
                    await doc.Reference.DeleteAsync();
                }
                snap = await collref.Limit(3).GetSnapshotAsync();
                docs = snap.Documents;
            }
        }

        public void Delete_An_Element_Inside_A_Array(string collection, string document, string ArrayName, dynamic deleteObject)
        {
            DocumentReference docref = FbConfig.Getdb().Collection(collection).Document(document);
            Dictionary<String, object> data = new Dictionary<String, object>()
            {
                {ArrayName,FieldValue.ArrayRemove(deleteObject) },
            };

            docref.UpdateAsync(data);
            MessageBox.Show("EliminadoCorrectamente");
        }

        public void Delete_An_Element_Inside_A_List(string collection, string document, string listName, string fieldName)
        {
            DocumentReference docref = FbConfig.Getdb().Collection(collection).Document(document);
            String nameField = listName + fieldName;
            Dictionary<String, object> data = new Dictionary<String, object>()
            {
                {nameField,FieldValue.Delete },
            };

            docref.UpdateAsync(data);
            MessageBox.Show("EliminadoCorrectamente");
        }

        public void Delete_An_Entired_Document(string collection, string document)
        {
            DocumentReference docref = FbConfig.Getdb().Collection(collection).Document(document);
            docref.DeleteAsync();
            MessageBox.Show("EliminadoCorrectamente");
        }

        public void Delete_A_Field_Within_A_Document(string collection, string document, string fieldName)
        {
            DocumentReference docref = FbConfig.Getdb().Collection(collection).Document(document);
            Dictionary<String, object> data = new Dictionary<String, object>()
            {
                {fieldName,FieldValue.Delete },
            };

            docref.UpdateAsync(data);
            MessageBox.Show("EliminadoCorrectamente");
        }
    }
}
