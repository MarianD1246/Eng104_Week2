using System;
using System.Collections.Generic;


namespace MoreTypes_Lib
{
    public class ArraysExercises
    {
        // returns a 1D array containing the contents of a given List
        public static string[] Make1DArray(List<string> contents)
        {
            string[] strArray = new string[contents.Count];
            for (int i = 0; i < contents.Count; i++)
            {
                strArray[i] = contents[i];
            }
            return strArray;
        }

        // returns a 3D array containing the contents of a given List
        public static string[,,] Make3DArray(int length1, int length2, int length3, List<string> contents)
        {
            {
                if (length1 < 0 || length2 < 0 || length3 < 0)
                {
                    throw new ArgumentException(String.Format("Please enter a positive value for the lengths."));
                }
                if (length1 == 0 || length2 == 0 || length3 == 0)
                {
                    throw new ArgumentException(String.Format("Try using a 2d or 1d array instead!"));
                }

                if (length1 * length2 * length3 > contents.Count)
                {
                    throw new ArgumentException(String.Format("Number of elements in list must match array size"));
                }
            }//Throw Exceptions

            int count = 0;
            string[,,] strArray = new string[length1, length2, length3];
            //[x,y,z] //1d word //2d words on a page //3d many pages in a book //4d many books in a shelf //5many shelfs on a 
            for (int x = 0; x < length1; x++)
            {
                for (int y = 0; y < length2; y++)
                {
                    for (int z = 0; z < length3; z++)
                    {
                        strArray[x, y, z] = contents[count];
                        count++;
                    }
                }
            }

            return strArray;
            
        }

        // returns a jagged array containing the contents of a given List
        public static string[][] MakeJagged2DArray(int countRow1, int countRow2, List<string> contents)
        {
            {
                if (countRow1 < 0 || countRow2 < 0)
                {
                    throw new ArgumentException(String.Format("One or more row input value is negative."));
                }
                if (countRow1 == 0 || countRow2 == 0)
                {
                    throw new ArgumentException(String.Format("Try using a 1d array instead!"));
                }
                if (countRow1 + countRow2 > contents.Count)
                {
                    throw new ArgumentException(String.Format("Number of elements in list must match array size"));
                }
            }//Throw Exceptions

            //cR1 = 2 || cR2 = 4
            string[][] jaggedArray = new string[countRow1][]; 
            int[] jagRows = new int[] { countRow1, countRow2 };
            int index = 0;
            for (int x = 0; x < countRow1; x++)
            {
                jaggedArray[x] = new string[jagRows[x]];
                for (int y = 0; y < jagRows[x]; y++)
                {
                    jaggedArray[x][y] = contents[index];
                    index++;
                }
            }
            return jaggedArray;

            //int index = 0;
            //string[][] jaggedArray = new string[countRow1][];

            //for (int x = 0; x < countRow1; x++)
            //{
            //    string[] jaggedRow = new string[countRow2];
            //    for (int y = 0; y < countRow2; y++)
            //    {
            //        jaggedRow[y] = contents[index];
            //        index++;
            //    }
            //    jaggedArray[x] = jaggedRow;
            //}

            //throw new NotImplementedException();
        }
    }
}
