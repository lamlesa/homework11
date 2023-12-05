using System;

namespace homework11
{
    internal class Building
    {
        private ushort number;
        private double height;
        private byte storeys;
        private uint apartments;
        private byte entrances;
        public ushort Number { get { return number; } set { if (value > 0) { number = value; } else { throw new ArgumentException("( отрицательное число )"); } } }
        public double Height { get { return height; } set { if (value > 0) { height= value; } else { throw new ArgumentException("( отрицательное число )"); } } }
        public byte Storeys { get { return storeys; } set { if (value > 0) { storeys = value; } else { throw new ArgumentException("( отрицательное число )"); } } }
        public uint Apartments { get { return apartments; } set { if (value > 0) { apartments = value; } else { throw new ArgumentException("( отрицательное число )"); } } }
        public byte Entrances { get { return entrances; } set { if (value > 0) { entrances = value; } else { throw new ArgumentException("( отрицательное число )"); } } }
        public void CalculateTheHeightOfTheStorey(double height, byte storeys)
        {
            double storey_height = height / Convert.ToDouble(storeys);
            Console.WriteLine($"Высота одного этажа: {storey_height}");
        }
        public void CalculateTheNumberOfApartmentsInTheEntrance(uint apartments, byte entrances)
        {
            double entrance_volume = Convert.ToDouble(apartments) / Convert.ToDouble(entrances);
            if (entrance_volume % 1 == 0)
            {
                Console.WriteLine($"Квартир в одном подъезде: {entrance_volume}");
            }
            else
            {
                throw new ArgumentException("Что-то не так с входными данными.");
            }
        }
        public void CalculateTheNumberOfApartmentsPerStorey(uint apartments, byte storeys)
        {
            double storey_volume = Convert.ToDouble(apartments) / Convert.ToDouble(storeys);
            if (storey_volume % 1 == 0)
            {
                Console.WriteLine($"Квартир на одном этаже: {storey_volume}");
            }
            else
            {
                throw new ArgumentException("Что-то не так с входными данными.");
            }
        }
        public void Print()
        {
            Console.WriteLine($"Номер здания: {number}\nВысота: {height}\nКоличество квартир: {apartments}\nПодъездов: {entrances}\nЭтажей: {storeys}");
        }
    }
}