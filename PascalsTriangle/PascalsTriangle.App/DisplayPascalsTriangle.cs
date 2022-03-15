using System;

namespace PascalsTriangle.App
{
    public class DisplayPascalsTriangle : IDisplayPascalsTriangle
    {
        public long[][] Pascal(long depth)
        {
            long[][] arr = new long[depth][];
            
            for (int line = 0; line < depth; line++)
            {
                for (int index = 0; index <= line; index++)
                {
                    if (line == index || index == 0)
                    {
                        arr[line][index] = 1;
                    }

                    else
                    {
                        arr[line] [index] = arr[line - 1][index - 1] +  arr[line - 1][index];
                    }
                }
            }
            return arr;
        }
    }
}
