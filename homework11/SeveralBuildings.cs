using System;

namespace homework11
{
    internal class SeveralBuildings
    {
        private Building[] buildings = new Building[10];
        public SeveralBuildings()
        {
            for (byte i = 0; i < 10; i++)
            {
                buildings[i] = new Building();
            }
        }
        public Building this[int index]
        {
            get
            {
                byte k = 20;
                for (byte i = 0; i < 10; i++)
                {
                    if (buildings[i].Number == index)
                    {
                        k = i;
                        break;
                    }
                }
                if (k != 20)
                {
                    return buildings[k];
                }
                else
                {
                    return null;
                }
            }
        }
    }
}