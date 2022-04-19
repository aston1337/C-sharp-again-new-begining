using System;

namespace Chapter_3 {
    public class NarrowingAndWidening {
        public static void typeConversion() {
            short num1 = 12, num2 = 2;
            Console.WriteLine(Add(num1, num2)); // widening short = 32_767, int = 2_147_483_647 no loss of data while convert to int parametrs
        }

        public static void errorConvertion() {
            short num1 = 30000, num2 = 30000;
           // short answ = Add(num1, num2); //Cannot implicitly convert type 'int' to 'short'. result int try to assigne to short. Overflow
            short answ2 = (short) Add(num1, num2); // explicit cast to short (allow loss of data)
           // Console.WriteLine(answ, answ2);
        }

        static int Add(int x, int y) {
            // this func needs int paramertrs
            return x + y;
        }

        //If we need to track loss of data
        public static void checkedUnchecked() {
            procwssBytes();
        }

        static void procwssBytes() {
            byte b1 = 100;
            byte b2 = 250;
            checked { // gives oportunity to throw error. If unchecked = не проверять
                byte sum = (byte) Add(b1, b2); // => 94  
                Console.WriteLine($"sum: {sum}");
            }
        }
    }
}