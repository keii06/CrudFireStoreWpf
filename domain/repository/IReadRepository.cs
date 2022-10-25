using CrudFireStoreWpf.data.firebase.config;
using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudFireStoreWpf.domain.repository
{
    public interface IReadRepository
    {
        Task<Dictionary<string, object>> GetAllData_Of_A_Document(String Collection, String Document);

        Task<QuerySnapshot> Get_All_Documents_From_A_Collection(String collection);
    }
}
