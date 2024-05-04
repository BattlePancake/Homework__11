using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework__11
{
    //---------------------------- Task 1 -------------------------------

    public class GenericClass<T>
    {
        public List<T> TestList { get; set; }

        public GenericClass(List<T> testList)
        {
            TestList = testList;
        }
        public void GetMyList()
        {
            foreach (T el in TestList)
            {
                Console.Write($"{el} ");
            }
        }
        public void AddElement(T element)
        {
            TestList.Add(element);
        }
        public void AddCoupleElements(T[] elements)
        {
            TestList.AddRange(elements);
        }
        public void DeleteElement(T removeElement)
        {
            TestList.Remove(removeElement);
        }
        public void DeleteElementByIndex(int removeElementIndex)
        {
            TestList.RemoveAt(removeElementIndex);
        }
        public T GetElementByIndex(int getElementIndex)
        {
            return TestList[getElementIndex];
        }
        public void GetGenericListLength()
        {
            Console.WriteLine(TestList.Count);
        }
    }
}
