using System;

namespace DZ11.Building
{
    internal class Buildingarray
    {
        private Building[] buildings;
        public Buildingarray()
        {
            Building[] buildings = new Building[10];
        }

        public Building this[int index]
        {
            get
            {
                if (index < 0 || index > 10)
                {
                    throw new ArgumentOutOfRangeException("Такого номера нет");
                }
                else
                {
                    return buildings[index];
                }
            }
        }

    }

}
