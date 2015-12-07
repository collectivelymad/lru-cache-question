using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lru_cache
{
     class Program
     {
          static void Main(string[] args)
          {

               LRUCache cache = new LRUCache(3);

               cache.Set(1, 1);
               cache.Set(2, 2);
               cache.Set(3, 3);
               cache.Set(4, 4);
               cache.Set(5, 5);
               cache.Set(6, 6);
               cache.Delete(2);
               var item = cache.Get(3);

               if (item.HasValue)
                    Console.WriteLine(item.Value);

               cache.Get(5);


               var item2 = cache.Get(5);

               if (item2.HasValue)
                    Console.WriteLine(item2.Value);
               cache.Get(5);
          }
     }
}
