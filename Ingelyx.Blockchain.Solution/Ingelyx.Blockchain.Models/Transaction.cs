using Ingelyx.Blockchain.Commons.Enums;

namespace Ingelyx.Blockchain.Models
{
    public class Transaction
    {
        public int idColumn { get; set; }
        public int idLigne { get; set; }
        public MethodAccessEnum methodAccess { get; set; }
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