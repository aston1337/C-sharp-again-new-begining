using System;

namespace chapter_04 {
    public class MultiDimensionalArrays {
        public static void callArrays() {
            rectangularArray();
            JaggedMultidimensionalArray();
        }

        public static void rectangularArray() {
            Console.WriteLine("Rectangular multidimensional Array-------------------");
            int[,] matrix = new int[3,4];
            for (int i = 0; i < 3; i++) {           //i = row, j = column
                for (int j = 0; j < 4; j++) {
                    matrix[i, j] = i * j;         //item at index i,j will be the result of "i * j" 
                }
            }

            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 4; j++) {
                    Console.Write(matrix[i,j] + "\t");
                }
                Console.WriteLine();
            }   
        }

        public static void JaggedMultidimensionalArray() {
            Console.WriteLine("JaggedMultidimensionalArray-------------------------");
            int[][] mdArray = new int[5][];

            for (int i = 0; i < mdArray.Length; i++) {
                mdArray[i] = new int[i + 7];
            }

            for (int i = 0; i < 5; i++) {
                for (int j = 0; j < mdArray[i].Length; j++) {
                    Console.Write(mdArray[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}