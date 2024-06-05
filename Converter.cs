using System;

namespace CurrencyConverterGUI {
	public class Converter
	{
		public Converter()
		{
		}

		public static double USDtoNIS(double USD)
		{
			return USD * 3.68
	
	}

		public static double USDtoCAD(double USD)
		{
			return USD * 1.36;
		}

		public static double USDtoEUr(double USD)
		{
			return USD * .96;
		}
	}
}