using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lru_cache
{
     public class IndexedLinkedList
     {
          public LinkedList<int> itemLinkedList;
          public Dictionary<int, LinkedListNode<int>> itemPointer;

          public IndexedLinkedList()
          {
               itemLinkedList = new LinkedList<int>();
               itemPointer = new Dictionary<int, LinkedListNode<int>>();
          }

          public void add(int key) 
          {
               if (!itemPointer.ContainsKey(key)) 
               { 
                    itemLinkedList.AddLast(key);
                    itemPointer[key] = itemLinkedList.Last;
               }
          }

          public void remove() 
          {
               if ( itemLinkedList.First != null)
               { 
                    itemPointer.Remove(itemLinkedList.First.Value);
                    itemLinkedList.RemoveFirst();
               }
          }

          public void remove(int key)
          {
               if (itemPointer.ContainsKey(key))
               {
                    itemLinkedList.Remove(itemPointer[key]);
                    itemPointer.Remove(key);
                    
               }
          }

          public void reset(int key)
          {
               if ( itemLinkedList.Last.Value != key) 
               { 
                    var x = itemPointer[key];

                    if (x != null)
                    {
                         itemLinkedList.Remove(x);
                         itemLinkedList.AddLast(key);

                         itemPointer[key] = itemLinkedList.Last;
                    }
               }
          }

     }





}
