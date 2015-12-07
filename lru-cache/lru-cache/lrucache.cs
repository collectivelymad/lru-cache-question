using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lru_cache
{
     public class LRUCache
     {
          private indexedLinkedList<int> cacheItems;
       
          private int max_size;
           
          public LRUCache(int size)
          {
               max_size = size;
               this.cacheItems = new indexedLinkedList<int>();
          }
      
          public void Set(int key, int value)
          {
               if (cacheItems.ContainsKey(key))
               {
                    cacheItems.Reset(key);
               }
               else
               {
                    if (isFull()) 
                    {
                         cacheItems.Remove();
                    }
                     
                    cacheItems.Add(key);
               }
          }

          public void Delete(int key)
          {
               cacheItems.Remove(key);
          }
 
          public int? Get(int key)
          {
               var result = cacheItems.ContainsKey(key);

               //used Default(T) for an item that was not found.
               if (result)
                    cacheItems.Reset(key);
               else
                    return null;

               return cacheItems.Item(key);
          }
  
          private Boolean isFull()
          {
               return cacheItems.Count == max_size;
          }
     }
}