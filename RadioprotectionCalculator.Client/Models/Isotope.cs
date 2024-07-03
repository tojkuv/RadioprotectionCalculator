namespace RadioprotectionCalculator.Client.Models
{
	public class Isotope
	{
		public required string Name { get; set; }
		public required TimeSpan? HalfLife { get; set; }
		public required Units.TimeUnit PreferredHalfLifeUnit { get; set; }

	}
}
