using System;
using System.Numerics;

namespace Chapter_3 {
    public class DataTypes {
        public static void voidNumericalDataTypes() {
            charTypeFunctionality();
            parseValues();
            tryParseFromStringData();
            dateTimeAndTimeSpan();
            separators();
        }

        public static void charTypeFunctionality() {
            Console.WriteLine("Char type Functionality -------------------------");
            char myChar = 'a';
            Console.WriteLine($"char.isDigit('a'): {char.IsDigit(myChar)}");
            Console.WriteLine($"char.isLetter('a'): {char.IsLetter(myChar)}");
            Console.WriteLine($"char.isWhiteSpace(\"Hello there\", 5): {char.IsWhiteSpace("Hello there!", 5)}");
            Console.WriteLine($"char.isWhiteSpace(\"Hello there\", 6): {char.IsWhiteSpace("Hello there!", 6)}");
            Console.WriteLine($"char.isPunctuation('?'): {char.IsPunctuation('?')}");
            
        }
        //if cant parse exeption will be thrown
        public static void parseValues() {
            Console.WriteLine("Parsing values-------------------------");
            bool b = bool.Parse("True");
            int i = Int32.Parse("99");
            double d = Double.Parse("92,34512");
            char c = Char.Parse("w");
            Console.WriteLine($"Parsed values: {b}, {i}, {d}, {c}");
        }
        
        public static void tryParseFromStringData() {
            Console.WriteLine("Try parse -------------------------");
            if (bool.TryParse("qwrue", out bool b)) {
                Console.WriteLine($"Value of b: {b}");
            } else {
                Console.WriteLine($"Default value of b: {b}");
            }

            string value = "21";
            if (double.TryParse(value, out double d)) {
                Console.WriteLine($"Value of d: {d}");
            } else {
                Console.WriteLine($"Failed to convert the input ({value}) to a double and the variable was assigned the default value {d}");
            }
        }

        public static void dateTimeAndTimeSpan() {
            Console.WriteLine("dates and times----------------------");
            DateTime dt = new DateTime(2015, 10, 17);
            Console.WriteLine($"The year is {dt.Year} and day id {dt.Day} of {dt.Month}");
            dt = dt.AddMonths(2);
            Console.WriteLine($"{dt.IsDaylightSavingTime()}");

            TimeSpan t = new TimeSpan(4, 30, 23);
            Console.WriteLine(t);

            Console.WriteLine(t.Subtract(new TimeSpan(0, 15, 0)));
        }

        public static void separators() {
            Console.WriteLine("=> Use Digit Separators:");
            Console.Write("Integer:");
            Console.WriteLine(123_456);
            Console.Write("Long:");
            Console.WriteLine(123_456_789L);
            Console.Write("Float:");
            Console.WriteLine(123_456.1234F);
            Console.Write("Double:");
            Console.WriteLine(123_456.12);
            Console.Write("Decimal:");
            Console.WriteLine(123_456.12M);
                //Updated in 7.2, Hex can begin with _
            Console.Write("Hex:");
            Console.WriteLine(0x_00_00_FF);
        }
    }
}