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
    public interface ICreateRepository
    {
        bool Add_Document_With_AutoID(Dictionary<string, object> user, String collection);
        bool Add_Document_With_CustomID(Dictionary<string, object> user, String collection, String document);
        bool Add_Array(ArrayList users, String collection, String document);
        bool Add_ListOfObjects(Dictionary<string, object> List, String collection, String document);
        bool Add_Multiple_SetsOfData(String Collection, Dictionary<string, object> dats);

    }
}
