using Chaincase.Common;
using Chaincase.UI.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using QRCoder;

namespace Chaincase.UI.Services
{
	public static class Extensions
	{
		public static IServiceCollection AddUIServices(this IServiceCollection services)
		{
			services.AddSingleton<UIStateService>();

			services.AddSingleton<Global>();

			services.AddScoped<ThemeSwitcher>();
			services.AddSingleton<QRCodeGenerator>();
			services.AddSingleton<IndexViewModel>();
			services.AddSingleton<ReceiveViewModel>();
			services.AddSingleton<SendViewModel>();
			services.AddSingleton<StatusViewModel>();
			services.AddTransient<LoadWalletViewModel>();
			services.AddTransient<WalletInfoViewModel>();
			services.AddTransient<NewPasswordViewModel>();
			services.AddTransient<CoinJoinViewModel>();
			services.AddTransient<ToastViewModel>();

			return services;
		}
	}
}
