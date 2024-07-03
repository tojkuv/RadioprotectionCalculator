using NodaTime;

namespace RadioprotectionCalculator.Client.Calculators;

public class Isotope
{
	public required string Name { get; set; }
	public required Duration? HalfLife { get; set; }
	public required Units.TimeUnit PreferredHalfLifeUnit { get; set; }

}