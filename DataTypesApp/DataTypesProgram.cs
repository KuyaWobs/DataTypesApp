namespace DataTypesApp
{
    internal class DataTypesProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the pieces of apples: ");
            int pieces = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter total price of " +  pieces + " apple(s): ");
            double TotalPrice = Convert.ToDouble(Console.ReadLine());   

            Console.WriteLine("The total price of 6 apple(s) is " + TotalPrice);
            Console.WriteLine("The value of original price is " + TotalPrice);
            int ConvertedValue = (int)TotalPrice;
            Console.WriteLine("The value of converted price is " + ConvertedValue);
        }
    }
}