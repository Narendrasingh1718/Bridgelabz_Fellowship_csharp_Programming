//using System;
//namespace GenericsDemo
//{
//    public class Method // accepting any data type by using method overloading but it is not a good practice because we have to create multiple methods for different data types and it is not type safe
//    {
//        private static void Main()
//        {
//            // bool IsEqual = ClsCalculator.AreEqual(10, 20);
//            // bool IsEqual = ClsCalculator.AreEqual("ABC", "ABC");
//            bool IsEqual = ClsCalculator.AreEqual(10.5, 20.5);

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
//        public static bool AreEqual(int value1, int value2)
//        {
//            return value1 == value2;
//        }

//        public static bool AreEqual(string value1, string value2)
//        {
//            return value1 == value2;
//        }

//        public static bool AreEqual(double value1, double value2)
//        {
//            return value1 == value2;
//        }
//    }
//}