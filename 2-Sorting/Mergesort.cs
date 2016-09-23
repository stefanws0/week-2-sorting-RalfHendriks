using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALGA
{
    public class Mergesort
    {
        public static void mergesort(ISortList list)
        {
            mergesort(list, 0, list.Count - 1);
        }

        public static void mergesort(ISortList list, int leftIndex, int rightIndex)
        {
            int mediaan;
            if (rightIndex > leftIndex){
                mediaan = (rightIndex + leftIndex) / 2;
                mergesort(list, leftIndex, mediaan);
                mergesort(list, (mediaan + 1), rightIndex);
                DoMerge(list, leftIndex, (mediaan + 1), rightIndex);
            }
        }

        static public void DoMerge(ISortList list, int leftIndex, int mediaan, int rightIndex)
        {
            int[] tempList = new int[list.Count];
            int i;
            int MaxIndexLeft = (mediaan - 1);
            int tmp_pos = leftIndex;
            int num_elements = (rightIndex - leftIndex + 1);

            while ((leftIndex <= MaxIndexLeft) && (mediaan <= rightIndex))
            {
                if (list.compare(leftIndex, mediaan) <= 0)
                    tempList[tmp_pos++] = list[leftIndex++];
                else
                    tempList[tmp_pos++] = list[mediaan++];
            }

            while (leftIndex <= MaxIndexLeft)
                tempList[tmp_pos++] = list[leftIndex++];

            while (mediaan <= rightIndex)
                tempList[tmp_pos++] = list[mediaan++];

            for (i = 0; i < num_elements; i++)
            {
                list[rightIndex] = tempList[rightIndex];
                rightIndex--;
            }
        }
    }
}
