using System.Collections;

namespace DAY_1
{
    internal class Program
    {

        static List<int> nums = new List<int>() {1,2,3,4,5 };
        static void Main(string[] args)
        {
        
        }

        #region Pure Vs. Impure Function
        static void Add_1 (int x)
        {
            nums.Add(x);
        }

        static void Add_2()
        {
            nums.Add(new Random().Next());
        }

        static List<int> Add_3(List<int> numbers,int x)
        {
            var res = new List<int>(numbers);
            res.Add(x);
            return res;
        }

        #endregion


        #region IEnumerable _ IEnumerator


        public class MyCOllection : IEnumerable
        {

            private int[] Ints = new int[] {1,2,3,4,5,6,7,8,9};

            public IEnumerator GetEnumerator()
            {
                return new MyCollectionIEnumerator(Ints);
            }

        }

        public class MyCollectionIEnumerator : IEnumerator
        {

            private int pos = -1;
            private int[] list;

            public MyCollectionIEnumerator(int[] items)
            {
                list = items;
            }
            public object Current => throw new NotImplementedException();

            public bool MoveNext()
            {
                pos++;
                return (pos < list.Length);
            }

            public void Reset()
            {
                pos = -1;
            }
        }



        #endregion

    }


}
