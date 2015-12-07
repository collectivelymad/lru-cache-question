using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lru_cache
{
     public class indexedLinkedList<T>
     {
          public LinkedList<T> itemLinkedList;
          public Dictionary<T, LinkedListNode<T>> itemPointer;

          public indexedLinkedList()
          {
               itemLinkedList = new LinkedList<T>();
               itemPointer = new Dictionary<T, LinkedListNode<T>>();
          }

          public void Add(T key) 
          {
               if (!itemPointer.ContainsKey(key)) 
               { 
                    itemLinkedList.AddLast(key);
                    itemPointer[key] = itemLinkedList.Last;
               }
          }

          public int Count
          {    
               get {
                    return itemPointer.Count;
               }      
          }

          public bool ContainsKey(T key)
          {
               return itemPointer.ContainsKey(key);
          }

          public void Remove() 
          {
               if ( itemLinkedList.First != null)
               { 
                    itemPointer.Remove(itemLinkedList.First.Value);
                    itemLinkedList.RemoveFirst();
               }
          }

          public void Remove(T key)
          {
               if (itemPointer.ContainsKey(key))
               {
                    itemLinkedList.Remove(itemPointer[key]);
                    itemPointer.Remove(key);
                    
               }
          }

          public T Item(T key)
          {
               if (itemPointer.ContainsKey(key))
               {
                    return itemPointer[key].Value;
               } else
               {
                    return default(T);
               }
          }

          public void Reset(T key)
          {
               if ( !itemLinkedList.Last.Value.Equals(key)) 
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
