using System;
using System.Text;

namespace csharp_projects_assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stringbuilder
            StringBuilder sb = new StringBuilder("Information of a student currently studying in IPD19 are as follow: ", 100);
            sb.Append("\nFirst Name : Payal ");
            sb.Append("\nLast Name  : Patel ");
            sb.Append("\nEmail      : 6151825@johnabbottcollge.net");

            Console.WriteLine(sb);

            //Partial Class
            PartialClass1 pc1 = new PartialClass1();
            pc1.partialMethod();

            PartialClass2 pc2 = new PartialClass2();
            pc2.partialMethod();

            //Static Class
            MyStaticClass.radius = 3;
            MyStaticClass.calculateArea();

            //2DJagged Array
            Console.WriteLine("\n2D jagged Array Example");
            int[,] jagged2d = new int[4, 3]
            {
               {11,22,33}, 
               {5,15,25}, 
               {20,40,60},
               {10,30,50}
            };
            for (int i = 0; i < jagged2d.GetLength(0); i++)
            {
                for (int j = 0; j < jagged2d.GetLength(1); j++)
                {
                    Console.Write($"[{i},{j}]=[{jagged2d[i,j]}]\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Element at position [2][1] is {0}", jagged2d[2,1]);
            Console.WriteLine("Element at position [1][2] is {0}", jagged2d[1,2]);

            //3DJagged Array
            Console.WriteLine("\n3D jagged Array Example");
            int[][][] jagged3d = new int[][][]
            {
                new int[][] { new int[] { 10, 12 }, new int[] { 14, 16, 18 } },
                new int[][] { new int[] { 20 } },
                new int[][] { new int[] { 30, 11 }, new int[] { 22, 33, 44, 55} }
            };
            for (int x = 0; x < jagged3d.Length; x++)
            {
                for (int y = 0; y < jagged3d[x].Length; y++)
                {
                    for (int z = 0; z < jagged3d[x][y].Length; z++)
                    {
                        Console.Write($"[{x}][{y}][{z}]= {jagged3d[x][y][z]}\t");
                    }
                }
                Console.WriteLine("");
            }
            Console.WriteLine("Element at position [0][1][2] is {0}", jagged3d[0][1][2]);
            Console.WriteLine("Element at position [2][1][0] is {0}", jagged3d[2][1][0]);

            //Using Index
            IndexerClass ic = new IndexerClass();
            ic[0] = "CSHARP";
            ic[1] = "object-oriented";
            ic[2] = "programming";
            Console.Write("\nUsing indexer for Printing values stored in objects used as arrays\n");
            Console.WriteLine("{0} is {1} {2} language", ic[0], ic[1], ic[2]);

            //Using Tuple
            var book = Tuple.Create(1, "How to be Happy", 11011,2010);
            TupleClass tp = new TupleClass();

            // call to a method that takes tuple as an input and returns tuple as the output
            var moreInfo =tp.displayAndCreate(book);

            Console.WriteLine($"Author Id : {moreInfo.Item1}");
            Console.WriteLine($"Author Name : {moreInfo.Item2}");
            Console.WriteLine($"Book sold : {moreInfo.Item3}");
        }
    }
}
