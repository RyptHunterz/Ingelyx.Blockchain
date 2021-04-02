using Ingelyx.Blockchain.Commons.Enums;
using Ingelyx.Blockchain.Models;
using System;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Transaction[] transactions = new Transaction[] { new Transaction() { idLigne = 0, idColumn = 0, methodAccess = MethodAccessEnum.POST, data = "HelloWorld" } };

            var genesisBlock = new Block(new Guid(), "genesisblock", DateTime.Now, transactions);
            var Blockchain = new Blockchain(genesisBlock);
        }
    }
}
