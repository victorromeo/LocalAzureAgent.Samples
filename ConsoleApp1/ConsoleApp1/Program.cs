using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Load secret from environment variable (best practice for both Linux and Windows)
            string secret = Environment.GetEnvironmentVariable("MY_SECRET");
            if (string.IsNullOrEmpty(secret))
            {
                Console.WriteLine("[INFO] No secret found in environment variable MY_SECRET.");
            }
            else
            {
                // Use the secret in your application logic here
                Console.WriteLine("[INFO] Secret loaded successfully.");
                // Never print the secret value itself
            }
        }
    }
}
