using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Assignment_02
{
    internal class Cache<TKey, TValue> where TKey : notnull where TValue : notnull
    {

        /*• Create a generic class Cache<TKey, TValue> that implements a simple caching mechanism.
        • Implement methods to add, retrieve, and remove items from the cache.
        • Ensure that the cache has a maximum size and evicts the least recently used item when it exceeds the limit.
        */


        #region Fields
        /// private uint size;
        ///private TKey[] keys;
        ///private TValue[] values; 

        private Dictionary<TKey, TValue> cacheDictionary;
        private LinkedList<TKey> reArrangedList;
        #endregion

        #region Properties
        public uint Size { get; private set; }

        #endregion

        #region Indexer
        //public TKey this[uint index]
        //{
        //    get
        //    {
        //        return keys[index];
        //    }
        //    set
        //    {
        //        keys[index] = value;
        //    }
        //}

        //public TValue this[TKey key]
        //{
        //    get
        //    {
        //        return values[key];
        //    }
        //    set
        //    {
        //        values[key] = value;
        //    }
        //}
        #endregion

        #region Constructors
        public Cache()
        {
            Size = 10;
           cacheDictionary= new Dictionary<TKey,TValue>();
            reArrangedList= new LinkedList<TKey>();

        }
        public Cache(uint size)
        {
            Size = size;
            cacheDictionary = new Dictionary<TKey, TValue>();
            reArrangedList = new LinkedList<TKey>();
        }
        #endregion

        #region Methods


        //=========== Add ==============
        public void AddItem(/*uint position ,*/TKey k, TValue v)
        {
            if (cacheDictionary.ContainsKey(k))
                reArrangedList.Remove(k);
            else if (cacheDictionary.Count > Size)
                RemoveLeastRecentItem();
        }

        //============ Remove Least Recent Item ==========
        private void RemoveLeastRecentItem()
        {
          TKey l=  reArrangedList.First();
            RemoveItem(l);
            reArrangedList.Remove(l);

        }

        //============ Remove  ===========
        public void RemoveItem(TKey k) 
        {
            cacheDictionary.Remove(k);
        }


        //============= Retrieve Item =============
        public TValue RetrieveItem(TKey k)         
        {
            if (!cacheDictionary.ContainsKey(k))
                throw new Exception();
            reArrangedList.Remove(k);
            reArrangedList.AddLast(k);

          return  cacheDictionary[k];
        }

        #endregion

    }
}
