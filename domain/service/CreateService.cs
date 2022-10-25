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
    public class CreateService
    {
        ICreateRepository repository;

        public CreateService(ICreateRepository repository)
        {
            this.repository = repository;
        }

        public void Add_Document_With_AutoID(Dictionary<string, object> user, String collection)
        {
            this.repository.Add_Document_With_AutoID(user, collection);
        }

        public void Add_Document_With_CustomID(Dictionary<string, object> user, String collection, String document)
        {
            this.repository.Add_Document_With_CustomID(user, collection, document);
        }

        public void Add_Array(ArrayList users, String collection, String document)
        {
            this.repository.Add_Array(users, collection, document);
        }

        public void Add_ListOfObjects(Dictionary<string, object> List, String collection, String document)
        {
            this.repository.Add_ListOfObjects(List, collection, document);
        }

        public void Add_Multiple_SetsOfData(String Collection, Dictionary<string, object> dats)
        {
            this.repository.Add_Multiple_SetsOfData(Collection, dats);
        }
    }
}
