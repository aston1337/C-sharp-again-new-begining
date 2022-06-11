using System;

namespace chapter_04 {
/*
 (None)     If a value type parameter is not marked with a modifier, it is assumed to be passed
            by value, meaning the called method receives a copy of the original data. Reference
            types without a modifier are passed in by reference.
out         Output parameters must be assigned by the method being called and, therefore, are
            passed by reference. If the called method fails to assign output parameters, you are
            issued a compiler error.
ref         The value is initially assigned by the caller and may be optionally modified by
            the called method (as the data is also passed by reference). No compiler error is
            generated if the called method fails to assign a ref parameter.
            in New in C# 7.2, the in modifier indicates that a ref parameter is read-only by the
            called method.
params      This parameter modifier allows you to send in a variable number of arguments as
            a single logical parameter. A method can have only a single params modifier, and it
            must be the final parameter of the method. You might not need to use the params
            modifier all too often; however, be aware that numerous methods within the base
            class libraries do make use of this C# language feature
 */
    class Methods {
        public static void runMethods() {
            addWrapper( 3, 4 );
            AddByValueTypes( 8, 6 );
            AddUsingOutParam(90, 90, out int sum);
        }

        static int addWrapper( int x, int y ) {
            return Add();

            int Add() { //nested func
                return x + y;
            }
        }

        static int addWrapperWithSideEffect( int x, int y ) {
            return Add();

            int Add() {
                x += 1; // here the parametr changes outside
                return x + y;
            }
        }

        static int addWrapperWithStatic( int x, int y ) {
            return Add( x, y );

            static int Add( int x, int y ) {
                return x + y;
            }
        }

        static int AddByValueTypes(int x, int y) {  // x y - copy of original data
            //default behavier for value types
            int ans = x = y;
            // Caller will not see these changes
            // as you are modifying a copy of the
            // original data.
            x = 10000;
            y = 888888;
            return ans; //
        }

        static void AddUsingOutParam(int x, int y, out int sum) {
            sum = x + y;
        }
    }

}
