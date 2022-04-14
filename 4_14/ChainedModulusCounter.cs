namespace _4_14
{
    internal class ChainedModulusCounter
    {
        ChainedModulusCounter next;
        public ChainedModulusCounter(int modulus, string id, ChainedModulusCounter nextCounter) : base(modulus, id)
        {
            this.next = nextCounter;
        }

        public override void Increment()
        {
            base Increment();
            if(Counter == 0)
            {
                next.Increment();
            }
        }
        
    }
}