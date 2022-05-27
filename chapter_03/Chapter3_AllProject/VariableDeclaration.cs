using System;
using System.Numerics;
using System.Threading.Channels;

namespace Chapter_3 {
    public class VariableDeclaration {
        public static void LocalVarDeclaration() {
            int myInt = 32;
            float myFloat = 3.553f;
            double MyDouble = 3.12343423;
            string myString = "Hello!";
            char myChar = 'a';
            bool b1 = true, b2 = true, b3 = false; //single line declaration

            Console.WriteLine( $"myInt: {myInt}" );
            Console.WriteLine( $"MyFloat: {myFloat}" );
            Console.WriteLine( $"MyDouble: {MyDouble}" );
            Console.WriteLine( $"myString: {myString}" );
            Console.WriteLine( $"myChar: {myChar}" );
            Console.WriteLine( $"My boolean values: {b1}, {b2}, {b3}" );
        }
        
    }
}