using System;

namespace Chapter_3 {
    class ConsoleProgramm {
        public static void Main(string[] args) {
            Console.WriteLine("*******My First C# programm*******");
            Console.WriteLine();
        }
        //variations of main
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
        static Task<int> Main(string[])
    }
}