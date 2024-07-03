using System.Reflection;

namespace RadioprotectionCalculator.Client.Models
{
	public class IsotopeDecay
	{
		public string ElementName { get; set; } = Isotopes.Keys.First().ToString();
		public List<Isotope> ElementIsotopes { get; set; } = Isotopes.Values.First();
		public Isotope Isotope { get; set; } = Isotopes.Values.First().First();
		public Units.ActivityUnit ActivityUnit { get; set; } = Units.ActivityUnit.Bq;
		public Units.TimeUnit TimeSpanUnit { get; set; } = Isotopes.Values.First().First().PreferredHalfLifeUnit;
		public TimeSpan? HalfLife { get; set; } = Isotopes.Values.First().First().HalfLife;
		public Activity OriginalActivity { get; set; } = new();
		public Activity CalculatedActivity { get; set; } = new();
		public DateTime? OriginalDate { get; set; }
		public TimeSpan? OriginalTime { get; set; }
		public DateTime? CalculationDate { get; set; }
		public TimeSpan? CalculationTime { get; set; }
		public static Dictionary<string, List<Isotope>> Isotopes { get; set; } = new Dictionary<string, List<Isotope>>
			{
				{ "Fluorine (F)", new List<Isotope> { new Isotope { Name = "F-18", HalfLife = TimeSpan.FromMinutes(119), PreferredHalfLifeUnit = Units.TimeUnit.Minutes }, new Isotope { Name = "F-19", HalfLife = TimeSpan.FromMinutes(119), PreferredHalfLifeUnit = Units.TimeUnit.Minutes } } },
				{ "Cesium (Cs)", new List<Isotope> { new Isotope { Name = "Cs-133", HalfLife = TimeSpan.FromSeconds(5), PreferredHalfLifeUnit = Units.TimeUnit.Seconds }, new Isotope { Name = "Cs-134", HalfLife = TimeSpan.FromHours(6), PreferredHalfLifeUnit = Units.TimeUnit.Hours }, new Isotope { Name = "Cs-137", HalfLife = TimeSpan.FromDays(7 * 365.25), PreferredHalfLifeUnit = Units.TimeUnit.Years } } }
			};
	}
}
