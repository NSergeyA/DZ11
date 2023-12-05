using System;

namespace DZ11.Building
{
    internal class Building
    {
        private static uint IDcount = 0;
        public uint ID;
        public int floors;
        public int flats;
        public double height;

        public Building(int floors = 5, int flats = 50, double height = 10)
        {
            ID = IDcount++;
            this.floors = floors;
            this.flats = flats;
            this.height = height;
        }
        public void Print()
        {
            Console.WriteLine($"Номер здания: {ID}\nКол-во этажей: {floors}\nКол-во квартир: {flats}");
        }

    }
}
