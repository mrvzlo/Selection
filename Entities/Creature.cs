using Selection.Enums;

namespace Selection.Entities
{
    public class Creature
    {
        public double Food { get; set; }
        public int Age { get; set; }
        public int Generation { get; set; }
        public double Aggression { get; set; }
        public double FoodToSurvive { get; set; }
        public double FoodToReplicate { get; set; }

        public double FoodMax() => FoodToSurvive + FoodToReplicate;
        public bool CanSurvive() => RandomHelper.Chance(Food / FoodToSurvive);
        public bool CanReplicate() => RandomHelper.Chance((Food - FoodToSurvive) / FoodToReplicate);

        public Creature(AggressionLevel aggressionLevel)
        {
            Aggression = (int)aggressionLevel / 100.0;
            FoodToSurvive = 1;
            FoodToReplicate = FoodToSurvive;
        }

        public Creature(Creature parent)
        {
            Aggression = parent.Aggression;
            Generation = parent.Generation + 1;
            FoodToSurvive = 1;
            FoodToReplicate = FoodToSurvive;
        }

        public Creature Grow()
        {
            Aggression += (FoodToSurvive - Food) / FoodToSurvive;
            if (Aggression < 0) Aggression = 0;
            if (Aggression > 1) Aggression = 1;
            Food = 0;
            Age++;
            return this;
        }
    }
}
