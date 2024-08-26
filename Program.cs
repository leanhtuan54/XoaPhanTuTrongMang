using System;

namespace ChuyenDoiNhietDo
{
    class Program
    {
       
        public static double CelsiusToFahrenheit(double celsius)
        {
            double fahrenheit = (9.0 / 5) * celsius + 32;
            return fahrenheit;
        }

        // Phương thức chuyển đổi từ Fahrenheit sang Celsius
        public static double FahrenheitToCelsius(double fahrenheit)
        {
            double celsius = (5.0 / 9) * (fahrenheit - 32);
            return celsius;
        }

        // Phương thức Main thực thi ứng dụng
        public static void Main(string[] args)
        {
            double fahrenheit;
            double celsius;
            int choice;

            do
            {
                // Hiển thị menu lựa chọn
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Fahrenheit to Celsius");
                Console.WriteLine("2. Celsius to Fahrenheit");
                Console.WriteLine("0. Exit");
                Console.WriteLine("Enter your choice: ");
                choice = Int32.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        // Chuyển đổi Fahrenheit sang Celsius
                        Console.WriteLine("Enter Fahrenheit: ");
                        fahrenheit = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Fahrenheit to Celsius: " + FahrenheitToCelsius(fahrenheit));
                        break;

                    case 2:
                        // Chuyển đổi Celsius sang Fahrenheit
                        Console.WriteLine("Enter Celsius: ");
                        celsius = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Celsius to Fahrenheit: " + CelsiusToFahrenheit(celsius));
                        break;

                    case 0:
                        // Thoát chương trình
                        Environment.Exit(0);
                        break;

                    default:
                        // Trường hợp nhập lựa chọn không hợp lệ
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            } while (choice != 0); // Vòng lặp tiếp tục cho đến khi người dùng chọn thoát
    }
}
}