using System;
using System.Linq;
using System.Windows.Forms;
using LiveCharts;
using Selection.Drawing;
using Selection.Entities;
using Selection.Enums;

namespace Selection
{
    public partial class Form1 : Form
    {
        private int SpotCount = 20, SpotRows = 4, CreatureCount = 10, ChartLimit = 40;
        private Field Field { get; set; }
        private Drawer Drawer { get; set; }

        public Form1()
        {
            InitializeComponent();
            Drawer = new Drawer();
            CountChart.DisableAnimations = true;
            AgeChart.DisableAnimations = true;
            AggressionChart.DisableAnimations = true;
            GenerationChart.DisableAnimations = true;
            SpotCounter.Value = SpotCount;
            SpotRowCounter.Value = SpotRows;
            CreatureCounter.Value = CreatureCount;
        }

        #region Actioncs

        private void MakeStep()
        {
            Field.Concur();
            SaveStat();
            Field.Distribute();
            pictureBox1.BackgroundImage = Drawer.DrawSpots(Field, SpotRows);
        }

        private void Start()
        {
            Field = new Field();
            Field.Generate(SpotCount, CreatureCount);
            SetupCharts();
            SaveStat();
            Field.Distribute();
            pictureBox1.BackgroundImage = Drawer.DrawSpots(Field, SpotRows);
            BtnMakeStep.Enabled = true;
            ChBoxAuto.Enabled = true;
        }

        #endregion

        #region Togglers

        private void BtnGenerateCreatures_Click(object sender, EventArgs e) => Start();

        private void BtnMakeStep_Click(object sender, EventArgs e) => MakeStep();

        private void Automatic_Tick(object sender, EventArgs e) => MakeStep();

        private void ChBoxAuto_CheckedChanged(object sender, EventArgs e)
        {
            BtnMakeStep.Enabled = !ChBoxAuto.Checked;
            Automatic.Enabled = ChBoxAuto.Checked;
        }

        private void SpotCounter_ValueChanged(object sender, EventArgs e) => 
            SpotCount = (int)SpotCounter.Value;

        private void SpotRowCounter_ValueChanged(object sender, EventArgs e) => 
            SpotRows = (int)SpotRowCounter.Value;

        private void CreatureCounter_ValueChanged(object sender, EventArgs e) => 
            CreatureCount = (int)CreatureCounter.Value;

        #endregion

        #region Charts

        private void SaveStat()
        {
            CountChart.Series.Single(x => x.Title == "Total count").Values
                .Add((double)Field.Creatures.Count);
            if (!Field.Creatures.Any()) return;
            AgeChart.Series.Single(x => x.Title == "Max age").Values
                .Add(Field.GetStatValue(StatisticType.Age, StatisticValue.Max));
            AgeChart.Series.Single(x => x.Title == "Average age").Values
                .Add(Field.GetStatValue(StatisticType.Age, StatisticValue.Average));
            AggressionChart.Series.Single(x => x.Title == "Max aggression").Values
                .Add(Field.GetStatValue(StatisticType.Aggression, StatisticValue.Max));
            AggressionChart.Series.Single(x => x.Title == "Average aggression").Values
                .Add(Field.GetStatValue(StatisticType.Aggression, StatisticValue.Average));
            GenerationChart.Series.Single(x => x.Title == "Max generation").Values
                .Add(Field.GetStatValue(StatisticType.Generation, StatisticValue.Max));
            GenerationChart.Series.Single(x => x.Title == "Average generation").Values
                .Add(Field.GetStatValue(StatisticType.Generation, StatisticValue.Average));
            // do not show more than 40 values 
            foreach (var series in AggressionChart.Series)
                if (series.Values.Count > ChartLimit)
                    series.Values.RemoveAt(0);
            foreach (var series in AgeChart.Series)
                if (series.Values.Count > ChartLimit)
                    series.Values.RemoveAt(0);
            foreach (var series in GenerationChart.Series)
                if (series.Values.Count > ChartLimit)
                    series.Values.RemoveAt(0);
            foreach (var series in CountChart.Series)
                if (series.Values.Count > ChartLimit)
                    series.Values.RemoveAt(0);
        }

        private void SetupCharts()
        {
            CountChart.Series = new SeriesCollection
            {
                new ChartLine(StatisticType.Count, StatisticValue.Total)
            };
            AgeChart.Series = new SeriesCollection
            {
                new ChartLine(StatisticType.Age, StatisticValue.Max),
                new ChartLine(StatisticType.Age, StatisticValue.Min),
                new ChartLine(StatisticType.Age, StatisticValue.Average)
            };
            GenerationChart.Series = new SeriesCollection
            {
                new ChartLine(StatisticType.Generation, StatisticValue.Max),
                new ChartLine(StatisticType.Generation, StatisticValue.Min),
                new ChartLine(StatisticType.Generation, StatisticValue.Average)
            };
            AggressionChart.Series = new SeriesCollection
            {
                new ChartLine(StatisticType.Aggression, StatisticValue.Max),
                new ChartLine(StatisticType.Aggression, StatisticValue.Min),
                new ChartLine(StatisticType.Aggression, StatisticValue.Average)
            };
        }

        #endregion
    }
}
