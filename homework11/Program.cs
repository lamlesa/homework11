using System;

namespace homework11
{
    enum AccountTypes
    {
        Current,
        Savings
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            account.DumpToScreen();

            Building building = new Building();
            building.Number = 1;
            building.Height = 90.74;
            building.Storeys = 5;
            building.Apartments = 75;
            building.Entrances = 4;
            building.Print();
            building.CalculateTheHeightOfTheStorey(building.Height, building.Storeys);
            try
            {
                building.CalculateTheNumberOfApartmentsInTheEntrance(building.Apartments, building.Entrances);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"( в подъезде ) Ошибка: {ex.Message}");
            }
            try
            {
                building.CalculateTheNumberOfApartmentsPerStorey(building.Apartments, building.Storeys);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"( на этаже ) Ошибка: {ex.Message}");
            }
            building.Print();
        }
    }
}