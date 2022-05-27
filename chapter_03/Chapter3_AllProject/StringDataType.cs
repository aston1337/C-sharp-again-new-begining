using System;
/*
Length      This property returns the length of the current string.
Compare()   This static method compares two strings.
Contains()  This method determines whether a string contains a specific substring.
Equals()    This method tests whether two string objects contain identical character data.
Format()    This static method formats a string using other primitives (e.g., numerical data, other
            strings) and the {0} notation examined earlier in this chapter.
Insert()                This method inserts a string within a given string.
PadLeft() PadRight()    These methods are used to pad a string with some characters.
Remove() Replace()      These methods are used to receive a copy of a string with modifications (characters
                        removed or replaced).
Split()     This method returns a String array containing the substrings in this instance that are
            delimited by elements of a specified char array or string array.
Trim()      This method removes all occurrences of a set of specified characters from the
            beginning and end of the current string.
ToUpper() ToLower()     These methods create a copy of the current string in uppercase or lowercase format, respectively.
 */
namespace Chapter_3 {
    public class StringDataType {
        public static void stringFunctions() {
            basicStringFunctionality();
            concatenation();
            escapeCharacters();
            stringEquality();
            stringsAreImmutable();
        }
        public static void basicStringFunctionality() {
            Console.WriteLine("BasicStringFunctionality -----------------------------");
            string firstName = "Freddy";
            Console.WriteLine($"Name {firstName} has {firstName.Length} characters!");
            Console.WriteLine($"firstName in upperCase: {firstName.ToUpper()}");
            Console.WriteLine($"firstName in lowerCase: {firstName.ToLower()}");
            Console.WriteLine($"firstName has letter y? {firstName.Contains('y')}");
            Console.WriteLine($"replace freddy before: {firstName} and freddy after: {firstName.Replace("dy", "")}");
        }

        public static void concatenation() {
            Console.WriteLine("=> String concatenation:");
            string s1 = "Programming the ";
            string s2 = "PsychoDrill (PTP)";
            string s3 = s1 + s2;
            Console.WriteLine(s3);
            Console.WriteLine();
        }
        /*
\' Inserts a single quote into a string literal.
\" Inserts a double quote into a string literal.
\\ Inserts a backslash into a string literal. This can be quite helpful when defining file or
network paths.
\a Triggers a system alert (beep). For console programs, this can be an audio clue to the user.
\n Inserts a new line (on Windows platforms).
\r Inserts a carriage return.
\t Inserts a horizontal tab into the string literal.
         */
        public static void escapeCharacters() {
            Console.WriteLine("=> Escape characters:\a");
            string strWithTabs = "Model\tColor\tSpeed\tPet Name\a ";
            Console.WriteLine(strWithTabs);
            Console.WriteLine("Everyone loves \"Hello World\"\a ");
            Console.WriteLine("C:\\MyApp\\bin\\Debug\a ");
            // Adds a total of 4 blank lines (then beep again!).
            Console.WriteLine("All finished.\n\n\n\a ");
            Console.WriteLine();
        }

        public static void stringEquality() {
            Console.WriteLine("stringEquality-------------------");
            string s1 = "Hello!";
            string s2 = "Yo!";
            Console.WriteLine($"s1 = {s1}");
            Console.WriteLine($"s2 = {s2}");
            Console.WriteLine();
            // Test these strings for equality.
            Console.WriteLine($"s1 == s2: {s1 == s2}");
            Console.WriteLine($"s1 == Hello!: {s1 == "Hello!"}");
            Console.WriteLine($"s1 != HELLO!: {s1 != "HELLO!"}"); //Case sensitive
            Console.WriteLine($"s1.Equals(s2): {s1.Equals(s2)}");
            Console.WriteLine($"Yo!.Equals(s2): {s2.Equals("Yo!")}");
        }

        public static void stringsAreImmutable() {
            Console.WriteLine("stringsAreImmutable-----------------------");
        }
        
    }
}