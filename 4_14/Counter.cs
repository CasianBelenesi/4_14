using System;

namespace _4_14
{
    public class Counter
    {
        #region fields
        protected string id;
        protected int count;
        #endregion

        #region Constructor
        public int Count => count;
        
        public Counter() : this("")
        {

        }
        #endregion

        #region Properties
        public Counter ( string id )
        {
            this.id = id;
            count = 0;
        }
        #endregion

        #region Methods
         public virtual void Increment()
        {
            count++;
        }
        #endregion

        #region Override
        public override string ToString()
        {
            return $"[Counter <{id}>: {count}]";
        }
        #endregion
    }
}