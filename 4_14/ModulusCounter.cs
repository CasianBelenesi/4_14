namespace _4_14
{
    public class ModulusCounter : Counter
    {

        int modulus;
        public ModulusCounter(int modulus , string id): base(id)
        {
            this.modulus = modulus;
        }
        public override void Increment()
        {
            count = (count + 1) % modulus;
        }
        public override string ToString()
        {
            return $"[Counter <{id}>: Value = {count} , Modulus = {modulus}]";
        }
    }
}