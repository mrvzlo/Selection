using System;
using System.Collections.Generic;
using System.Linq;
using Selection.Enums;
using StatisticValue = Selection.Enums.StatisticValue;

namespace Selection.Entities
{
    public class Field
    {
        public List<Spot> Spots { get; set; }
        public List<Creature> Creatures { get; set; }

        public void Generate(int spotCount, int creatureCount)
        {
            Spots = new List<Spot>();
            Creatures = new List<Creature>();
            for (var i = 0; i < spotCount; i++)
                Spots.Add(new Spot());

            var aggressionLevels = Enum.GetValues(typeof(AggressionLevel)).Cast<AggressionLevel>().ToList();
            for (var i = 0; i < creatureCount; i++)
            {
                var skip = RandomHelper.Value(aggressionLevels.Count);
                var aggressionLevel = aggressionLevels.Skip(skip).FirstOrDefault();
                Creatures.Add(new Creature(aggressionLevel));
            }
        }

        public void Distribute()
        {
            while (Creatures.Any() && Spots.Any(x => x.Available()))
            {
                var creature = Creatures.First();
                var spot = GetRandomSpot();
                spot.Creatures.Add(creature);
                Creatures.Remove(creature);
            }
        }

        private Spot GetRandomSpot()
        {
            var skip = RandomHelper.Value(Spots.Count(x => x.Available()));
            return Spots.Where(x => x.Available()).Skip(skip).FirstOrDefault();
        }

        public void Concur()
        {
            Creatures = new List<Creature>();
            foreach (var spot in Spots)
            {
                spot.Concur();
                foreach (var creature in spot.Creatures)
                {
                    if (!creature.CanSurvive()) continue;
                    if (creature.CanReplicate())
                        Creatures.Add(new Creature(creature));
                    Creatures.Add(creature.Grow());
                }
                spot.Creatures = new List<Creature>();
            }
        }

        public double GetStatValue(StatisticType type, StatisticValue value)
        {
            IEnumerable<double> query;
            switch (type)
            {
                case StatisticType.Count:
                    return Creatures.Count;
                case StatisticType.Age:
                    query = Creatures.Select(x => (double)x.Age);
                    break;
                case StatisticType.Generation:
                    query = Creatures.Select(x => (double)x.Generation);
                    break;
                case StatisticType.Aggression:
                    query = Creatures.Select(x => x.Aggression);
                    break;
                default:
                    return 0;
            }

            switch (value)
            {
                case StatisticValue.Min:
                    return Math.Round(query.Min(), 2);
                case StatisticValue.Max:
                    return Math.Round(query.Max(), 2);
                case StatisticValue.Average:
                    return Math.Round(query.Average(), 2);
                default:
                    return 0;
            }
        }
    }
}
