using System;
using System.Collections.Generic;
using System.Text;
using Ingelyx.Blockchain.Commons.Helper;

namespace Ingelyx.Blockchain.Models
{
    public class Block
    {
        public Guid Index { get; set; }
        public string PreviousHash { get; set; }
        public DateTime Timestamp { get; set; }
        public List<Transaction> Data { get; set; }
        public string Hash { get; set; }

        public Block(Guid index, string previousHash, DateTime timestamp, List<Transaction> data, string hash)
        {
            this.Index = index;
            this.PreviousHash = previousHash;
            this.Timestamp = timestamp;
            this.Data = data;
            this.Hash = hash;
        }

        public string calculateHash(Guid index, string previousHash, DateTime timestamp, List<Transaction> transactionList)
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach(var item in transactionList)
            {
                stringBuilder.Append(item);
            }

            return SHA256Helper.Sha256Hash(index + previousHash + timestamp + stringBuilder);
        }
    }
}