using System;
using Il2CppDummyDll;

namespace Facebook.Unity.Mobile
{
	[Token(Token = "0x200007D")]
	internal interface IMobileFacebook : IFacebook
	{
		[Token(Token = "0x600029D")]
		bool IsImplicitPurchaseLoggingEnabled();

		[Token(Token = "0x600029E")]
		void OpenFriendFinderDialog(FacebookDelegate<IGamingServicesFriendFinderResult> callback);

		[Token(Token = "0x600029F")]
		void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, FacebookDelegate<IMediaUploadResult> callback);

		[Token(Token = "0x60002A0")]
		void UploadVideoToMediaLibrary(string caption, Uri videoUri, FacebookDelegate<IMediaUploadResult> callback);

		[Token(Token = "0x60002A1")]
		void OnIAPReady(FacebookDelegate<IIAPReadyResult> callback);

		[Token(Token = "0x60002A2")]
		void GetCatalog(FacebookDelegate<ICatalogResult> callback);

		[Token(Token = "0x60002A3")]
		void GetPurchases(FacebookDelegate<IPurchasesResult> callback);

		[Token(Token = "0x60002A4")]
		void Purchase(string productID, FacebookDelegate<IPurchaseResult> callback, string developPayload);

		[Token(Token = "0x60002A5")]
		void ConsumePurchase(string productToken, FacebookDelegate<IConsumePurchaseResult> callback);

		[Token(Token = "0x60002A6")]
		void InitCloudGame(FacebookDelegate<IInitCloudGameResult> callback);

		[Token(Token = "0x60002A7")]
		void ScheduleAppToUserNotification(string title, string body, Uri media, int timeInterval, string payload, FacebookDelegate<IScheduleAppToUserNotificationResult> callback);

		[Token(Token = "0x60002A8")]
		void LoadInterstitialAd(string placementID, FacebookDelegate<IInterstitialAdResult> callback);

		[Token(Token = "0x60002A9")]
		void ShowInterstitialAd(string placementID, FacebookDelegate<IInterstitialAdResult> callback);

		[Token(Token = "0x60002AA")]
		void LoadRewardedVideo(string placementID, FacebookDelegate<IRewardedVideoResult> callback);

		[Token(Token = "0x60002AB")]
		void ShowRewardedVideo(string placementID, FacebookDelegate<IRewardedVideoResult> callback);

		[Token(Token = "0x60002AC")]
		void GetPayload(FacebookDelegate<IPayloadResult> callback);
	}
}
