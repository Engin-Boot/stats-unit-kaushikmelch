using System;
using System.Collections.Generic;

namespace Statistics
{
    public class StatsComputer
    {
        public double average;
        public double min;
        public double max;

        public Stats CalculateStatistics(List<float> numbers)
        {
            Stats Values = new Stats();
            if (numbers.Count == 0)
            {
                Values.average = Double.NaN;
                Values.min = Double.NaN;
                Values.max = Double.NaN;
                return Values;
            }
            this.average = 0.0;
            this.min = Double.MaxValue;
            this.max = 0.0;
            for (int i = 0; i < numbers.Count; i++)
            {
                this.average += numbers[i];
                this.max = Math.Max(this.max, numbers[i]);
                this.min = Math.Min(this.min, numbers[i]);
            }
            this.average = this.average / numbers.Count;
            Values.average = this.average;
            Values.max = this.max;
            Values.min = this.min;
            return Values;
        }

    }
}
