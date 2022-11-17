using Il2CppDummyDll;

namespace Facebook.Unity.Mobile
{
	[Token(Token = "0x2000080")]
	internal interface IMobileFacebookResultHandler : IFacebookResultHandler
	{
		[Token(Token = "0x60002AD")]
		void OnFetchDeferredAppLinkComplete(ResultContainer resultContainer);

		[Token(Token = "0x60002AE")]
		void OnRefreshCurrentAccessTokenComplete(ResultContainer resultContainer);

		[Token(Token = "0x60002AF")]
		void OnFriendFinderComplete(ResultContainer resultContainer);

		[Token(Token = "0x60002B0")]
		void OnUploadImageToMediaLibraryComplete(ResultContainer resultContainer);

		[Token(Token = "0x60002B1")]
		void OnUploadVideoToMediaLibraryComplete(ResultContainer resultContainer);

		[Token(Token = "0x60002B2")]
		void OnOnIAPReadyComplete(ResultContainer resultContainer);

		[Token(Token = "0x60002B3")]
		void OnGetCatalogComplete(ResultContainer resultContainer);

		[Token(Token = "0x60002B4")]
		void OnGetPurchasesComplete(ResultContainer resultContainer);

		[Token(Token = "0x60002B5")]
		void OnPurchaseComplete(ResultContainer resultContainer);

		[Token(Token = "0x60002B6")]
		void OnConsumePurchaseComplete(ResultContainer resultContainer);

		[Token(Token = "0x60002B7")]
		void OnInitCloudGameComplete(ResultContainer resultContainer);

		[Token(Token = "0x60002B8")]
		void OnScheduleAppToUserNotificationComplete(ResultContainer resultContainer);

		[Token(Token = "0x60002B9")]
		void OnLoadInterstitialAdComplete(ResultContainer resultContainer);

		[Token(Token = "0x60002BA")]
		void OnShowInterstitialAdComplete(ResultContainer resultContainer);

		[Token(Token = "0x60002BB")]
		void OnLoadRewardedVideoComplete(ResultContainer resultContainer);

		[Token(Token = "0x60002BC")]
		void OnShowRewardedVideoComplete(ResultContainer resultContainer);

		[Token(Token = "0x60002BD")]
		void OnGetPayloadComplete(ResultContainer resultContainer);
	}
}
