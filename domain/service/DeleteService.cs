using CrudFireStoreWpf.data.firebase.config;
using CrudFireStoreWpf.domain.repository;
using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CrudFireStoreWpf.domain.service
{
    public class DeleteService
    {

        IDeleteRepository repository;

        public DeleteService(IDeleteRepository repository)
        {
            this.repository = repository;
        }

        public void Delete_An_Entired_Document(String collection, String document)
        {
            repository.Delete_An_Entired_Document(collection, document);
        }

        public void Delete_A_Field_Within_A_Document(String collection, String document, String fieldName)
        {
            repository.Delete_A_Field_Within_A_Document(collection, document, fieldName);
        }

        public void Delete_An_Element_Inside_A_List(String collection, String document, String listName, String fieldName)
        {
            repository.Delete_An_Element_Inside_A_List(collection, document, listName, fieldName);  
        }

        public void Delete_An_Element_Inside_A_Array(String collection, String document, String ArrayName, dynamic deleteObject)
        {
            repository.Delete_An_Element_Inside_A_Array(collection, document, ArrayName, deleteObject); 
        }

        public void Delete_All_Documents_In_A_Collection(String collection)
        {
            repository.Delete_All_Documents_In_A_Collection(collection);
        }

        public void Delete_All_Documents_In_A_Collection_With_Limitation(String collection, int limit)
        {
            repository.Delete_All_Documents_In_A_Collection_With_Limitation(collection, limit);
        }
    }
}
