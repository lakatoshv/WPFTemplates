namespace MaterialDashboard
{
    /// <summary>
    /// Consumption.
    /// </summary>
    public class Consumption
    {
        /// <summary>
        /// Gets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        public string Title { get; }

        /// <summary>
        /// Gets the percentage.
        /// </summary>
        /// <value>
        /// The percentage.
        /// </value>
        public int Percentage { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Consumption"/> class.
        /// </summary>
        public Consumption()
        {
            Title = "Поточне використання";
            Percentage = CalculatePercentage();
        }

        /// <summary>
        /// Calculates the percentage.
        /// </summary>
        /// <returns></returns>
        private static int CalculatePercentage()
        {
            return 47;
        }
    }
}