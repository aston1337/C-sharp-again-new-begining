using System;

namespace Chapter_3 {
    public class IfElse {
        public static void ifElseStatment() {
            string str = "Hello";
            if (str.Length > 0) {
                Console.WriteLine("String is not empty");
            } else {
                Console.WriteLine("String is empty");
            }
        }
    }
}
/*
==       if(age == 30)          Returns true only if each expression is the same
!=       if("Foo" != myStr)     Returns true only if each expression is different
<        if(bonus < 2000)       Returns true if expression A (bonus) is less than expression B (2000)
>        if(bonus > 2000)       Returns true if expression A (bonus) is greater than expression B (2000)
<=       if(bonus <= 2000)      Returns true if expression A (bonus) is less than or equal to expression B (2000)
>=       if(bonus >= 2000)      Returns true if expression A (bonus) is greater than or equal to expression B (2000)
*/