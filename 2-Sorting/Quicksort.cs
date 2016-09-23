﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALGA
{
    public class Quicksort
    {
        public static void quicksort(ISortList list)
        {
            quicksort(list, 0, list.Count - 1);
        }

        private static void quicksort(ISortList list, int leftIndex, int rightIndex)
        {
            if(leftIndex < rightIndex)
            {
                int mediaan = (leftIndex + ((leftIndex + rightIndex) / 2) + rightIndex) / 3;
                int listPivot = partition(list, mediaan, leftIndex, rightIndex);

                if (listPivot > 1)
                    quicksort(list, leftIndex, listPivot - 1);

                if (listPivot + 1 < rightIndex)
                    quicksort(list, listPivot + 1, rightIndex);
            }
        }

        /**
         * Partition the list according to the value at the pivot index
         * This method should only partition the part of the array that is between startIndex and endIndex
         * All values lower than the pivot value should be to the left of the pivot value
         * and all values higher than the pivot value should be to the right of the pivot value
         * 
         * This method should return the position of the pivot value after partitioning is complete
         * 
         * For example: partition([4, 9, 0, 5, 2], 3, 0, 4)
         * should partition the values between indices 0...4 (inclusive) using the value 5 as the pivot
         * A possible partitioning would be: [2, 0, 5, 9, 4], this method should return 2 as that is where
         * the pivot value 5 has ended up.
         * This method may assume there are no equal values
         */
        public static int partition(ISortList list, int pivotIndex, int leftIndex, int rightIndex)
        {
            while (leftIndex < rightIndex)
            {
                while (list.compare(leftIndex,pivotIndex) < 0)
                    leftIndex++;

                while (list.compare(rightIndex,pivotIndex) > 0)
                    rightIndex--;

                if (leftIndex == pivotIndex)
                    pivotIndex = rightIndex;
                else if (rightIndex == pivotIndex)
                    pivotIndex = leftIndex;

                list.swap(leftIndex, rightIndex);
            }
            return pivotIndex;
        }
    }
}
