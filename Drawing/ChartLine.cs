using LiveCharts;
using LiveCharts.Wpf;
using Selection.Enums;

namespace Selection.Drawing
{
    public class ChartLine : LineSeries
    {
        public StatisticType Statistic { get; set; }
        public StatisticValue Value { get; set; }

        public ChartLine(StatisticType statisticType, StatisticValue valueType)
        {
            MinHeight = 0;
            Title = $"{valueType.ToString()} {statisticType.ToString().ToLower()}";
            Values = new ChartValues<double>();
            Statistic = statisticType;
            Value = valueType;
        }
    }
}
