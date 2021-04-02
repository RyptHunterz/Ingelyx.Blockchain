namespace Ingelyx.Blockchain.Models
{
    public class Blockchain
    {
        public Block[] blocks { get; set; }

        public Blockchain(Block genesisBlock)
        {
            blocks = new Block[1];
            blocks[0] = genesisBlock;
        }
    }
}
