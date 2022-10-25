using CrudFireStoreWpf.data.firebase.config;
using Google.Cloud.Firestore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudFireStoreWpf.domain.repository
{
    public interface IUpdateRepository
    {
        Task<bool> Replace_A_Document_Deleting_All_Previous_Fields(String collection, String document, Dictionary<string, object> data);

        Task<bool> Update_Specific_Fields_or_Add_New_Fields(String collection, String document, Dictionary<string, object> data);

        Task<bool> Update_List_Elements_or_Nested_Elements(String collection, String document, Dictionary<string, object> data);

        Task<bool> Update_Array_Elements(String collection, String document, String ArrayName, ArrayList array);

    }
}
