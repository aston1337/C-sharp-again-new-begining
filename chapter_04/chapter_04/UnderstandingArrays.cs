using System.Diagnostics.CodeAnalysis;

namespace chapter_04;

public class UnderstandingArrays {
    public static void arrMethods() {
        SimpleArrays();
        SimpleArraysCreation();
        ArrayInitialization();
        arrayOfObjects();
        rectMultidimensionalArray();
        jaggedMultidimensionalArray();
        printArray();
    }

    public static void SimpleArrays() {
        Console.WriteLine( "Fun with arrays---------------------------" );
        int[] myInts = new int[3];
        int[] bookOnDotNet = new int[100];
        Console.WriteLine( bookOnDotNet );
    }

    public static void SimpleArraysCreation() {
        Console.WriteLine( "SimpleArraysCreation---------------------------" );
        int[] myInts = new int[3]; //if elements not defined they will be assigned default value
        myInts[0] = 100;
        myInts[1] = 200;
        myInts[2] = 300;
        foreach ( int x in myInts ) {
            Console.WriteLine( x );
        }
        Console.WriteLine();
    }

    [SuppressMessage( "ReSharper", "RedundantExplicitArraySize" )]
    public static void ArrayInitialization() {
        Console.WriteLine( "ArrayInitialization-----------------------------" );
        string[] stringArr = new string[] { "one", "two", "three" };
        Console.WriteLine( $"stringArr has {stringArr.Length} elements" );

        bool[] boolArr = { false, true, false };
        Console.WriteLine( $"boolArr has {boolArr.Length} elements" );

        int[] intArr = new int[4] { 20, 40, 50, 10 };
        Console.WriteLine( $"intArr has {intArr.Length} elements" );
        // if size and number of elements are different - compile error!!!
    }

    public static void arrayOfObjects() {
        Console.WriteLine( "ArrayOfObjects---------------------" );
        object[] myObjs = new object[4];
        myObjs[0] = 10;
        myObjs[1] = false;
        myObjs[2] = new DateTime(1900, 5, 9);
        myObjs[3] = "form and void";

        foreach ( object el in myObjs ) {
            Console.WriteLine( $"Type: {el.GetType()}, Value: {el}" );
        }

        Console.WriteLine(  );
    }

    public static void rectMultidimensionalArray() {
        Console.WriteLine( "RectMultidimensionalArray-------------------------" );
        int[,] myMatrix = new int[3, 4];
        //populate 3*4
        for ( int i = 0; i < 3; i++ ) {
            for ( int j = 0; j < 4; j++ ) {
                myMatrix[i, j] = i * j;
            }
        }
        //print 
        for ( int i = 0; i < 3; i++ ) {
            for ( int j = 0; j < 4; j++ ) {
                Console.Write( myMatrix[i,j] + "\t" );
            }

            Console.WriteLine(  );
        }
        Console.WriteLine(  );
    }

    public static void jaggedMultidimensionalArray() {
        Console.WriteLine( "jaggedMultidimensionalArray--------------------" );
        // Array of arrays
        int[][] myJagArr = new int[5][];
        
        //create
        for ( int i = 0; i < myJagArr.Length; i++ ) {
            myJagArr[i] = new int[i + 7];
        }
        //print
        for ( int i = 0; i < myJagArr.Length; i++ ) {
            for ( int j = 0; j < myJagArr[i].Length; j++ ) {
                Console.Write( myJagArr[i][j] + " " );
            }
            Console.WriteLine(  );
        }
    }
    //array as argument
    public static void printArray(int[] myInts) {
        for ( int i = 0; i < myInts.Length; i++ ) {
            Console.WriteLine( $"Item {i} is {myInts[i]}" );
        }
    }

    public static string[] getStringArr() {
        string[] theStrings = { "Hello", "from", "Belarus" };
        return theStrings;
    }
}
