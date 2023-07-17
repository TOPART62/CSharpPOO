using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01Class
{
    internal class WaterTank
    {
        //Attributs d'instances
        private int _completedLevel;
        //Attributs de classe
        private static int _totalCompletedLevels;

        //Properties
        public int UnloadedWeight { get; set; }
        public int MaxCapacity { get; set; }
        public int CompletedLevel
        {
            get => _completedLevel;
            set
            {
                int intTotalLevels = _totalCompletedLevels - CompletedLevel;
                _completedLevel = value;
                _totalCompletedLevels = intTotalLevels + value;
            }
        }
        public static int TotalFillLevels { get; set;  }

        //Constructors
        public WaterTank(int unloadedWeight, int maxCapacity, int completedLevel)
        {
            int intTotalFillLevels = TotalFillLevels;
            UnloadedWeight = unloadedWeight;
            MaxCapacity = maxCapacity;
            CompletedLevel = completedLevel;
            TotalFillLevels = intTotalFillLevels + completedLevel;
        }

        //Methods
        public int TotalWeightCalculation()
        {
            return UnloadedWeight + CompletedLevel;
        }
        public int Fill(int literOfWater)
        {
            if (MaxCapacity > (CompletedLevel + literOfWater))
            {
                CompletedLevel = CompletedLevel + literOfWater;
                return 0;
            }
            else
            {
                int intExcess = (CompletedLevel + literOfWater) - MaxCapacity;
                CompletedLevel = MaxCapacity;
                return intExcess;   
            }
        }
        public int Empty(int literOfWater)
        {
            if (CompletedLevel > literOfWater)
            {
                CompletedLevel = CompletedLevel - literOfWater;
                return 0;
            }
            else
            {
                int intEmpty = literOfWater - CompletedLevel;
                CompletedLevel = 0;
                return intEmpty;
            }
        }
        public void AffichageCiterne()
        {
            string[,] citerneAscii = {
                {"┌──────O─────┐",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "└────────────┘"},
                {"┌──────O─────┐",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│~~~~~~~~~~~~│",
                "└────────────┘"},
                {"┌──────O─────┐",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│~~~~~~~~~~~~│",
                "│            │",
                "└────────────┘"},
                {"┌──────O─────┐",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│~~~~~~~~~~~~│",
                "│            │",
                "│            │",
                "└────────────┘"},
                {"┌──────O─────┐",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│~~~~~~~~~~~~│",
                "│            │",
                "│            │",
                "│            │",
                "└────────────┘"},
                {"┌──────O─────┐",
                "│            │",
                "│            │",
                "│            │",
                "│~~~~~~~~~~~~│",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "└────────────┘"},
                {"┌──────O─────┐",
                "│            │",
                "│            │",
                "│~~~~~~~~~~~~│",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "└────────────┘"},
                {"┌──────O─────┐",
                "│            │",
                "│~~~~~~~~~~~~│",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "└────────────┘"},
                {"┌──────O─────┐",
                "│~~~~~~~~~~~~│",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "└────────────┘"},
            };
            int niveauCiterne = CompletedLevel == 1 ? 1 : (CompletedLevel * 8 / MaxCapacity);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(citerneAscii[niveauCiterne, i]);
            }
        }
    }
}
