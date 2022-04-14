using System.Text;
namespace _4_14
{
    internal class MultiCounter
    {
        int size;
        ChainedModulusCounter[] cmc;
        public string value
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                for(int i = size; i >= 0; i--)
                {

                }
            }
        }
        public MultiCounter( int size, int modulus)
        {
            this.size = size;
            cmc = new ChainedModulusCounter[size];
            cmc[size - 1] = new ChainedModulusCounter(modulus, "", null);
            for(int i = size-2; i >=0 ; i--)
            {
                cmc[i] = new ChainedModulusCounter(modulus, "", cmc[i + 1]);
            }
        }
        public void Increment()
        {
            cmc[0]
        }
    }

}