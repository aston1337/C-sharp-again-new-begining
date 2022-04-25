using System;

namespace Chapter_3 {
    class MainStructures {
        public static void Main(string[] args) {
            Console.WriteLine("*******My First C# programm*******");
            Console.WriteLine();
            //if we have args we can loop them
            for (int i = 0; i < args.Length; i++) {
                Console.WriteLine(args[i]);
            }
            string[] theArgs = Environment.GetCommandLineArgs();
            Console.WriteLine(theArgs[1]);
            //call 
            //EnvironmentData.getEnvironmentData();
            //ConsoleClass.getUserData();
            //VariableDeclaration.LocalVarDeclaration();
            //DefaultLiteral.defaultDeclarations();
            //DataTypes.voidNumericalDataTypes();
            //StringDataType.stringFunctions();
            //NarrowingAndWidening.checkedUnchecked();
            //Loops.iterationsAndDecisions();
            //IfElse.ifElseStatment();
        }
        /*//variations of main
        // int return type, array of strings as the parameter.
        static int Main(string[ ] args) {
            return 0;
        }
        // No return type, no parameters.
        static void Main() {
        }
        // int return type, no parameters.
        static int Main() {
            return 0;
        }
        
        //asynchronous Main method
        static Task Main()
        static Task<int> Main()
        static Task Main(string[])
        static Task<int> Main(string[])*/
    }
}