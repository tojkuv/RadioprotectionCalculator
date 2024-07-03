	 namespace RadioprotectionCalculator.Client.Calculators;

	 public class Activity
	 {
		 private double? _value;

		 public Activity() { }

		 public Activity(double value, Units.ActivityUnit unit = Units.ActivityUnit.GBq) { SetValue(value, unit); }

		 public void SetValue(double? val, Units.ActivityUnit unit = Units.ActivityUnit.Bq) {
			 this._value = ConvertToBq(val, unit);
		 }

		 public double? GetValue(Units.ActivityUnit unit = Units.ActivityUnit.Bq) {
			 return ConvertFromBq(unit);
		 }
		 public bool IsValueInitialized()
		 {
			 return _value.HasValue;
		 }

		 private double? ConvertToBq(double? val, Units.ActivityUnit unit)
		 {
			 return unit switch
			 {
				 Units.ActivityUnit.pCi => val * 27.027027027027,
				 Units.ActivityUnit.nCi => val * 2.7027027027027E+2,
				 Units.ActivityUnit.uCi => val * 2.7027027027027E+5,
				 Units.ActivityUnit.mCi => val * 2.7027027027027E+8,
				 Units.ActivityUnit.Ci => val * 2.7027027027027E+11,
				 Units.ActivityUnit.Bq => val,
				 Units.ActivityUnit.kBq => val * 1E3,
				 Units.ActivityUnit.MBq => val * 1E6,
				 Units.ActivityUnit.GBq => val * 1E9,
				 Units.ActivityUnit.TBq => val * 1E12,
				 Units.ActivityUnit.dpm => val * 60,
				 _ => throw new ArgumentException($"Conversion from {unit} to Bq is not supported.")
			 };
		 }

		 private double? ConvertFromBq(Units.ActivityUnit unit)
		 {
			 return unit switch
			 {
				 Units.ActivityUnit.pCi => _value / 27.027027027027,
				 Units.ActivityUnit.nCi => _value / 2.7027027027027E+2,
				 Units.ActivityUnit.uCi => _value / 2.7027027027027E+5,
				 Units.ActivityUnit.mCi => _value / 2.7027027027027E+8,
				 Units.ActivityUnit.Ci => _value / 2.7027027027027E+11,
				 Units.ActivityUnit.Bq => _value,
				 Units.ActivityUnit.kBq => _value / 1E+3,
				 Units.ActivityUnit.MBq => _value / 1E+6,
				 Units.ActivityUnit.GBq => _value / 1E+9,
				 Units.ActivityUnit.TBq => _value / 1E+12,
				 Units.ActivityUnit.dpm => _value / 60,
				 _ => throw new ArgumentException($"Conversion Bq to {unit} is not supported.")
			 };
		 }
	 }