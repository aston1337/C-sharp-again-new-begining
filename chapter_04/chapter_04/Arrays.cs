using System;

namespace chapter_04 {
    public class Arrays {
        public static void funWithArrays() {
            simpleArrays();
            initializationSyntax();
            implicitlyTypedArrays();
            arrayOfObjects();
        }

        static void simpleArrays() {
            Console.WriteLine("Simple Array creation---------------");
            int[] arr = new int[5]; // 5 - number of elements, indices 0-4
            arr[0] = 100;
            arr[1] = 200;
            arr[2] = 300;
            foreach (int el in arr) {
                Console.Write($"{el} ");
            }
            Console.WriteLine();
        }

        static void initializationSyntax() {
            Console.WriteLine("Array Init----------------");
            string[] stringArray = new string[] { "one", "two", "three" };
            Console.WriteLine($"String array has {stringArray.Length} elements");
            
            bool[] arr = { true, false, false, true };  //Without using NEW keyword
            int[] arrInt = new int[4] { 2, 4, 5, 7 };
            //int[] arrInt = new int[4] { 2, 4, 5, 7, 6 }; // Compile error if number of elems do not match with arrSize
        }

        public static void implicitlyTypedArrays() {
            Console.WriteLine("implicitlyTypedArrays-----------------");
            var i = new[] { 1, 4, 5 };
            Console.WriteLine($"i is: {i.ToString()}");
            var b = new[] { 2.3, 4.23 };
            Console.WriteLine($"b is: {b.ToString()}");
            var c = new[] { "Hello", "Im", "Aston" };
            Console.WriteLine($"c is: {c.ToString()}");
        }

        public static void arrayOfObjects() { // System.Object base class to every prototype
            Console.WriteLine("arrayOfObjects---------------------");
            object[] obj = new Object[5];
            obj[0] = "Hello";
            obj[1] = true;
            obj[2] = 3.45;
            obj[3] = 45;
            obj[4] = new DateTime(1989, 05, 09 );

            foreach (object elem in obj) {
                Console.WriteLine($"Type: {elem.GetType()}, element: {elem}");
            }
        }
        
        
    }
}