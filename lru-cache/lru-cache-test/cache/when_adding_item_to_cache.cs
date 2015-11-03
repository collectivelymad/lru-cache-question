using lru_cache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;


namespace lru_cache_test.cache.when_adding_item_to_cache
{
     public class when_adding_item_to_cache
     {
     
          [Fact]
          public void item_exists_order_is_updated() 
          {
               var key = 3;
               var value = 0;
               var expectedValue = 0;

               var sut = new LRUcache();

               sut.set(key, value);
               sut.set(1, 1);
               sut.set(2, 2);
              

               var cacheItem = sut.get(key);

               Assert.Equal(sut.cacheValues.Last().Value, expectedValue); 

          }


          [Fact]
          public void item_exists_and_cache_is_full_order_is_updated() 
          { 
          } 

          [Fact]
          public void item_does_not_exists_item_is_added_at_end() 
          {
          }

          [Fact]
          public void item_does_not_exists_and_cache_is_full_item_is_added_at_end_and_lru_is_removed()
          {

          }


     }

    
}
