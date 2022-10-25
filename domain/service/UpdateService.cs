using CrudFireStoreWpf.data.firebase.config;
using CrudFireStoreWpf.domain.repository;
using Google.Cloud.Firestore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudFireStoreWpf.domain.service
{
    public class UpdateService
    {
        IUpdateRepository repository;

        public UpdateService(IUpdateRepository repository)
        {
            this.repository = repository;
        }

        public void Replace_A_Document_Deleting_All_Previous_Fields(String collection, String document, Dictionary<string, object> data)
        {
            this.repository.Replace_A_Document_Deleting_All_Previous_Fields(collection, document, data);
        }

        public void Update_Specific_Fields_or_Add_New_Fields(String collection, String document, Dictionary<string, object> data)
        {
            this.repository.Update_Specific_Fields_or_Add_New_Fields(collection, document, data);
        }

        public void Update_List_Elements_or_Nested_Elements(String collection, String document, Dictionary<string, object> data)
        {
            this.repository.Update_List_Elements_or_Nested_Elements(collection, document, data);    
        }

        public void Update_Array_Elements(String collection, String document, String ArrayName, ArrayList array)
        {
            this.repository.Update_Array_Elements(collection, document, ArrayName, array);
        }

    }
}
