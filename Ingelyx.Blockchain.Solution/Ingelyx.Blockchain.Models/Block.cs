using System;
using System.Text;

namespace Ingelyx.Blockchain.Models
{
    using Ingelyx.Blockchain.Commons.Helpers;

    public class Block
    {
        public Guid Index { get; set; }
        public string PreviousHash { get; set; }
        public DateTime Timestamp { get; set; }
        public Transaction[] Data { get; set; }
        public string Hash { get; set; }

        public Block(Guid index, string previousHash, DateTime timestamp, Transaction[] data)
        {
            this.Index = index;
            this.PreviousHash = previousHash;
            this.Timestamp = timestamp;
            this.Data = data;
            this.Hash = calculateHash(index, previousHash, timestamp, data);
        }

        public string calculateHash(Guid index, string previousHash, DateTime timestamp, Transaction[] data)
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach(var item in data)
            {
                stringBuilder.Append(item);
            }

            return SHA256Helper.Sha256Hash(index + previousHash + timestamp + stringBuilder);
        }
    }
}