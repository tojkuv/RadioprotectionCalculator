

using static RadioprotectionCalculator.Client.Models.Units;

namespace RadioprotectionCalculator.Client.Models
{
	public class Activity
	{
		private double? value;

		public Activity() { }

		public Activity(double value, Units.ActivityUnit unit = Units.ActivityUnit.GBq) { SetValue(value, unit); }

		public void SetValue(double value, Units.ActivityUnit unit = Units.ActivityUnit.Bq) {
			this.value = ConvertToBq(value, unit);
		}

		public double GetValue(Units.ActivityUnit unit = Units.ActivityUnit.Bq) { 
			if (value == null)
			{
				throw new InvalidOperationException("Value is not set.");
			}
			return ConvertFromBq((double)value, unit);
		}
		public bool IsValueInitialized()
		{
			return value.HasValue;
		}

		private double ConvertToBq(double value, Units.ActivityUnit unit)
		{
			switch (unit)
			{
				case ActivityUnit.pCi:
					return value / 27.027027027027;
				case ActivityUnit.nCi:
					return value / 2.7027027027027E-2;
				case ActivityUnit.uCi:
					return value / 2.7027027027027E-5;
				case ActivityUnit.mCi:
					return value / 2.7027027027027E-8;
				case ActivityUnit.Ci:
					return value / 2.7027027027027E-11;
				case ActivityUnit.Bq:
					return value;
				case ActivityUnit.kBq:
					return value / 1E3;
				case ActivityUnit.MBq:
					return value / 1E6;
				case ActivityUnit.GBq:
					return value / 1E9;
				case ActivityUnit.TBq:
					return value / 1E12;
				case ActivityUnit.dpm:
					return value / 60;
				default:
					throw new ArgumentException($"Conversion from {unit} to Bq is not supported.");
			}
		}

		private double ConvertFromBq(double value, Units.ActivityUnit unit)
		{
			switch (unit)
			{
				case ActivityUnit.pCi:
					return value * 27.027027027027;
				case ActivityUnit.nCi:
					return value * 2.7027027027027E-2;
				case ActivityUnit.uCi:
					return value * 2.7027027027027E-5;
				case ActivityUnit.mCi:
					return value * 2.7027027027027E-8;
				case ActivityUnit.Ci:
					return value * 2.7027027027027E-11;
				case ActivityUnit.Bq:
					return value;
				case ActivityUnit.kBq:
					return value * 1E-3;
				case ActivityUnit.MBq:
					return value * 1E-6;
				case ActivityUnit.GBq:
					return value * 1E-9;
				case ActivityUnit.TBq:
					return value * 1E-12;
				case ActivityUnit.dpm:
					return value * 60;
				default:
					throw new ArgumentException($"Conversion Bq to {unit} is not supported.");
			}
		}
	}
}
