using System;
using Il2CppDummyDll;

namespace Com.Uken.Adlib
{
	[Token(Token = "0x2000010")]
	public interface IProvider
	{
		[Token(Token = "0x6000034")]
		string GetName();

		[Token(Token = "0x6000035")]
		string GetVersionNumber();

		[Token(Token = "0x6000036")]
		void Initialize(AdPlacement[] allAdPlacements);

		[Token(Token = "0x6000037")]
		bool IsAdReady(AdPlacement adPlacement);

		[Token(Token = "0x6000038")]
		void FetchAd(AdPlacement adPlacement, Action<string, bool> onLoaded);

		[Token(Token = "0x6000039")]
		bool ShowAd(AdPlacement adPlacement, bool forceInvokeOnAdShown, Action<AdPlacementShowResult> onAdShown, Action<MoPub.ImpressionData> onImpressionTracked);

		[Token(Token = "0x600003A")]
		bool CanBeFetched(AdPlacement adPlacement);

		[Token(Token = "0x600003B")]
		void HideBanner(BannerAdPlacement adPlacement);

		[Token(Token = "0x600003C")]
		void BlockLegitimateInterest(bool blockLegitimateInterest);
	}
}
