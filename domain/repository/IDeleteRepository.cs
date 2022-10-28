using CrudFireStoreWpf.data.firebase.config;
using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CrudFireStoreWpf.domain.repository
{
    public interface IDeleteRepository
    {
        void Delete_An_Entired_Document(String collection, String document);

        void Delete_A_Field_Within_A_Document(String collection, String document, String fieldName);

        void Delete_An_Element_Inside_A_List(String collection, String document, String listName, String fieldName);

        void Delete_An_Element_Inside_A_Array(String collection, String document, String ArrayName, dynamic deleteObject);

        void Delete_All_Documents_In_A_Collection(String collection);

        void Delete_All_Documents_In_A_Collection_With_Limitation(String collection, int limit);

    }
}
