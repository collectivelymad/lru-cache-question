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

               LRUcache cache = new LRUcache();

               cache.set(1, 1);
               cache.set(2, 2);
               cache.set(3, 3);
               cache.set(4, 4);
               cache.set(5, 5);
               cache.set(6, 6);
               cache.delete(2);
               cache.get(3);

               cache.get(5);
               cache.get(5);
          }
     }
}
