using Avalonia;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using WalletWasabi.CoinJoin;

namespace WalletWasabi.Gui.Converters
{
	public class PhaseColorConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (!Enum.TryParse(typeof(Phase), parameter.ToString(), false, out var p))
			{
				throw new ArgumentException($"Unknown '{parameter}' value");
			}
			var global = Application.Current.Resources[Global.GlobalResourceKey] as Global;
			var phaseError = global.ChaumianClient.State.IsInErrorState;

			return (Phase)p <= (Phase)value
				? phaseError
					? Brushes.IndianRed
					: Brushes.Green
				: Brushes.Gray;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new InvalidOperationException();
		}
	}
}
