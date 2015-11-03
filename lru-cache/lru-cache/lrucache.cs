using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lru_cache
{
     public class LRUcache
     {
          private IndexedLinkedList cacheOrder;
          public Dictionary<int, int> cacheValues { private set; get;}

          private const int max_size = 20;

           
          public LRUcache()
          {
               this.cacheOrder = new IndexedLinkedList();
               this.cacheValues = new Dictionary<int, int>();
          }
      
          public void set(int key, int value)
          {
               if (cacheValues.ContainsKey(key))
               {
                    cacheOrder.reset(key);
               }
               else
               {
                    if (isFull()) 
                    {
                         cacheOrder.remove();
                         cacheValues.Remove(cacheValues.First().Key);
                    }

                    cacheValues[key] = value;
                    cacheOrder.add(key);
               }
          }

          public void delete(int key)
          {
               cacheOrder.remove(key);
               cacheValues.Remove(key);
          }


          private Boolean isFull()
          {
               return cacheValues.Count == max_size;
          }

          public int get(int key)
          {
               var result = cacheValues[key];

               cacheOrder.reset(key);

               return result;
          }
     }
}