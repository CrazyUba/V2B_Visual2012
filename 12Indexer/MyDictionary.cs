using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12Indexer
{
    class MyDictionary
    {
        string[] key = new string[10];
        int[] value = new int[10];

        public int this[string requestedKey]
        {
            set
            {
                for (int i = 0; i < this.key.Length; i++)
                {
                    if (string.Compare(this.key[i], requestedKey) == 0)
                    {
                        this.key[i] = requestedKey;
                        this.value[i] = value;
                        return;
                    }
                    if (this.key[i] == null)
                    {
                        this.key[i] = requestedKey;
                        this.value[i] = value;
                        return;
                    }
                }
                throw new Exception("Key not found");
            }


            get {
                for (int i = 0; i < this.key.Length; i++)
                {
                    if (string.Compare(this.key[i], requestedKey) == 0) {
                        return this.value[i];
                    }
                }
                throw new Exception("Key not found");
            }
            
        }
    }
}
