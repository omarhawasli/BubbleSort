using System.Collections.Generic;

namespace Bublesort
{
    public static class MyFunction
    {
        public static void MyFunc(this List<int> list)
        {
            int swap;
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (list[i] < list[j])
                    {
                        swap = list[i];
                        list[i] = list[j];
                        list[j] = swap;
                    }
                }
            }

        }
    }
}