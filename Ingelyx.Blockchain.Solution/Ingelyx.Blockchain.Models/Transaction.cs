using System;
namespace Ingelyx.Blockchain.Models
{
    public class Transaction
    {
        public string idColumn { get; set; }
        public string idLigne { get; set; }
        public string methodAccess { get; set; } // PUT / DELETE / POST
        public string data { get; set; }

        public string rawData
        { 
            get
            {
                return string.Format("/{0};{1};{2};{3}", idColumn, idLigne, methodAccess, data);
            }
        }
    }
}