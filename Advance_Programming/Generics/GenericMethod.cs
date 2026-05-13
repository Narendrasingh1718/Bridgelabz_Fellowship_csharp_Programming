//using System;
//namespace GenericsDemo
//{
//    public class GenericMethod // we solve above problem by using generic method which can accept any data type.
//    {
//        private static void Main()
//        {
//            //bool IsEqual = ClsCalculator.AreEqual<int>(10, 20); // we have to pass the data type when we call that method.
//            //bool IsEqual = ClsCalculator.AreEqual<string>("ABC", "ABC");
//            bool IsEqual = ClsCalculator.AreEqual<double>(10.5, 20.5);
//            if (IsEqual)
//            {
//                Console.WriteLine("Both are Equal");
//            }
//            else
//            {
//                Console.WriteLine("Both are Not Equal");
//            }
//            Console.ReadKey();
//        }
//    }

//    public class ClsCalculator
//    {
//        public static bool AreEqual<T>(T value1, T value2) // T is replace with actual data type at the time of compilation. we can use any name instead of T but by convention we use T for generic type.
//        {
//            return value1.Equals(value2);
//        }
//    }
//}