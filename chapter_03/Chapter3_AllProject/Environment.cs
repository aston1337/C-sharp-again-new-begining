using System;

namespace Chapter_3 {
    class EnvironmentData {
        public static void getEnvironmentData() {
            foreach (string drive in Environment.GetLogicalDrives()) {
                Console.WriteLine($"Logical drive: {drive}");
            }

            Console.WriteLine($"Number of Logic CPU: {Environment.ProcessorCount}");
            Console.WriteLine($"OS version: {Environment.OSVersion}");
        }
    }
}