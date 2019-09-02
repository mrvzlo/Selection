using System.Collections.Generic;
using System.Linq;

namespace Selection.Entities
{
    public class Spot
    {
        public List<Creature> Creatures { get; set; }

        public bool Available() => Creatures.Count < 2;

        public Spot()
        {
            Creatures = new List<Creature>();
        }

        public void Concur()
        {
            if (!Creatures.Any()) return;

            if (Creatures.Count == 1)
            {
                var creature = Creatures.Single();
                creature.Food = creature.FoodMax();
                return;
            }

            foreach (var creature in Creatures)
            {
                var opponent = Creatures.First(x => x != creature);
                var damage = Fight(opponent.Aggression, creature.Aggression);
                creature.Food = creature.FoodMax() / 2 - damage;
            }
        }

        private double Fight(double aggressor, double defender) => aggressor / 2 + aggressor * defender - defender / 2;
    }
}
