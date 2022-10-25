using CrudFireStoreWpf.data.firebase.config;
using CrudFireStoreWpf.domain.repository;
using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudFireStoreWpf.domain.service
{
    public class ReadService
    {

        IReadRepository repository;

        public ReadService(IReadRepository repository)
        {
            this.repository = repository;
        }

        public async Task<Dictionary<string, object>> GetAllData_Of_A_Document(String Collection, String Document)
        {
            return await repository.GetAllData_Of_A_Document(Collection, Document);
        }

        public async Task<QuerySnapshot> Get_All_Documents_From_A_Collection(String collection)
        {
            return await repository.Get_All_Documents_From_A_Collection(collection);
        }
    }
}
