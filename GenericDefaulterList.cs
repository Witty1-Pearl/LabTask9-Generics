using System;
using System.Collections.Generic;
namespace IntergenicResearchLibray
{
     public class GenericDefaulterList<T> where T : IDefaulterList
    {
        private T[] studentDefaulters;      // StudentDefaulters is declared but not initialized    
        private const int DEFAULTSIZE = 10;
        private int numElements = 0;
        
        
        public GenericDefaulterList()
        {
            studentDefaulters = new T[DEFAULTSIZE]; //Here studentDefaulters have been initialized via a constructor
            
        }

       
        public GenericDefaulterList(int size) //overloaded constructor
        {
            studentDefaulters = new T[size];
           
        }

        public void Add(T item) // When this method is called items are added to the queue.
        {
            if(numElements < studentDefaulters.Length)
            {
                studentDefaulters[numElements] = item;
                numElements++;
            }else{
                throw new ArgumentOutOfRangeException("Student defaulters list is full.....");
            }
        }

    

        public T[] GetDefaulter()
        {
            if(numElements > 0)
            {
                return studentDefaulters;
            }else{
                throw new ArgumentOutOfRangeException("Student defaulters list is empty.....");
            }
        }

    }
}