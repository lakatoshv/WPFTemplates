using System.Collections.Generic;

namespace MaterialDashboard
{
    /// <summary>
    /// Chart data.
    /// </summary>
    public class ChartData
    {
        /// <summary>
        /// Gets the consumption.
        /// </summary>
        /// <value>
        /// The consumption.
        /// </value>
        public List<Consumption> Consumption { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartData"/> class.
        /// </summary>
        /// <param name="consumption">The consumption.</param>
        public ChartData(Consumption consumption)
        {
            Consumption = new List<Consumption>();
            Consumption.Add(consumption);
        }
    }
}