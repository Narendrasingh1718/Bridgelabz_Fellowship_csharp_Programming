//using System;
//namespace GenericsDemo
//{
//    public class ClsMain // by using object data type we can accept any data type but it is not a good practice because we have to do type casting and it is not type safe
//    {
//        private static void Main()
//        {
//            // bool IsEqual = ClsCalculator.AreEqual(10, 20);
//            bool IsEqual = ClsCalculator.AreEqual("ABC", "ABC");
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
//        //Now this method can accept any data type
//        public static bool AreEqual(object value1, object value2)
//        {
//            return value1 == value2;
//        }
//    }
//}