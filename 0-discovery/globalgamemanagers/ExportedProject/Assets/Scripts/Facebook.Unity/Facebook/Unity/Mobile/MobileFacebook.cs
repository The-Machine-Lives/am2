using System;
using Il2CppDummyDll;

namespace Facebook.Unity.Mobile
{
	[Token(Token = "0x2000081")]
	internal abstract class MobileFacebook : FacebookBase, IMobileFacebookImplementation, IMobileFacebook, IFacebook, IMobileFacebookResultHandler, IFacebookResultHandler
	{
		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x17BD240", Offset = "0x17BD240", VA = "0x17BD240")]
		protected MobileFacebook(CallbackManager callbackManager)
		{
		}

		[Token(Token = "0x60002BF")]
		public abstract bool IsImplicitPurchaseLoggingEnabled();

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x17BD248", Offset = "0x17BD248", VA = "0x17BD248", Slot = "44")]
		public override void OnLoginComplete(ResultContainer resultContainer)
		{
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x17BD2C8", Offset = "0x17BD2C8", VA = "0x17BD2C8", Slot = "45")]
		public override void OnGetAppLinkComplete(ResultContainer resultContainer)
		{
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x17BD358", Offset = "0x17BD358", VA = "0x17BD358", Slot = "46")]
		public override void OnAppRequestsComplete(ResultContainer resultContainer)
		{
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x17BD3E8", Offset = "0x17BD3E8", VA = "0x17BD3E8", Slot = "65")]
		public void OnFetchDeferredAppLinkComplete(ResultContainer resultContainer)
		{
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x17BD478", Offset = "0x17BD478", VA = "0x17BD478", Slot = "47")]
		public override void OnShareLinkComplete(ResultContainer resultContainer)
		{
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x17BD5E0", Offset = "0x17BD5E0", VA = "0x17BD5E0", Slot = "66")]
		public void OnRefreshCurrentAccessTokenComplete(ResultContainer resultContainer)
		{
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x17BD6AC", Offset = "0x17BD6AC", VA = "0x17BD6AC", Slot = "83")]
		public virtual void OpenFriendFinderDialog(FacebookDelegate<IGamingServicesFriendFinderResult> callback)
		{
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x17BD714", Offset = "0x17BD714", VA = "0x17BD714", Slot = "67")]
		public void OnFriendFinderComplete(ResultContainer resultContainer)
		{
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x17BD7A4", Offset = "0x17BD7A4", VA = "0x17BD7A4", Slot = "68")]
		public void OnUploadImageToMediaLibraryComplete(ResultContainer resultContainer)
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x17BD834", Offset = "0x17BD834", VA = "0x17BD834", Slot = "69")]
		public void OnUploadVideoToMediaLibraryComplete(ResultContainer resultContainer)
		{
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x17BD8C4", Offset = "0x17BD8C4", VA = "0x17BD8C4", Slot = "70")]
		public void OnOnIAPReadyComplete(ResultContainer resultContainer)
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x17BD954", Offset = "0x17BD954", VA = "0x17BD954", Slot = "71")]
		public void OnGetCatalogComplete(ResultContainer resultContainer)
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x17BD9E4", Offset = "0x17BD9E4", VA = "0x17BD9E4", Slot = "72")]
		public void OnGetPurchasesComplete(ResultContainer resultContainer)
		{
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x17BDB90", Offset = "0x17BDB90", VA = "0x17BDB90", Slot = "73")]
		public void OnPurchaseComplete(ResultContainer resultContainer)
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x17BDD3C", Offset = "0x17BDD3C", VA = "0x17BDD3C", Slot = "74")]
		public void OnConsumePurchaseComplete(ResultContainer resultContainer)
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x17BDDCC", Offset = "0x17BDDCC", VA = "0x17BDDCC", Slot = "75")]
		public void OnInitCloudGameComplete(ResultContainer resultContainer)
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x17BDE5C", Offset = "0x17BDE5C", VA = "0x17BDE5C", Slot = "76")]
		public void OnScheduleAppToUserNotificationComplete(ResultContainer resultContainer)
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x17BDEEC", Offset = "0x17BDEEC", VA = "0x17BDEEC", Slot = "77")]
		public void OnLoadInterstitialAdComplete(ResultContainer resultContainer)
		{
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x17BDF7C", Offset = "0x17BDF7C", VA = "0x17BDF7C", Slot = "78")]
		public void OnShowInterstitialAdComplete(ResultContainer resultContainer)
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x17BE00C", Offset = "0x17BE00C", VA = "0x17BE00C", Slot = "79")]
		public void OnLoadRewardedVideoComplete(ResultContainer resultContainer)
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x17BE09C", Offset = "0x17BE09C", VA = "0x17BE09C", Slot = "80")]
		public void OnShowRewardedVideoComplete(ResultContainer resultContainer)
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x17BE128", Offset = "0x17BE128", VA = "0x17BE128", Slot = "81")]
		public void OnGetPayloadComplete(ResultContainer resultContainer)
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x17BE2D4", Offset = "0x17BE2D4", VA = "0x17BE2D4", Slot = "84")]
		public virtual void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, FacebookDelegate<IMediaUploadResult> callback)
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x17BE33C", Offset = "0x17BE33C", VA = "0x17BE33C", Slot = "85")]
		public virtual void UploadVideoToMediaLibrary(string caption, Uri videoUri, FacebookDelegate<IMediaUploadResult> callback)
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x17BE3A4", Offset = "0x17BE3A4", VA = "0x17BE3A4", Slot = "86")]
		public virtual void OnIAPReady(FacebookDelegate<IIAPReadyResult> callback)
		{
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x17BE40C", Offset = "0x17BE40C", VA = "0x17BE40C", Slot = "87")]
		public virtual void GetCatalog(FacebookDelegate<ICatalogResult> callback)
		{
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x17BE474", Offset = "0x17BE474", VA = "0x17BE474", Slot = "88")]
		public virtual void GetPurchases(FacebookDelegate<IPurchasesResult> callback)
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x17BE4DC", Offset = "0x17BE4DC", VA = "0x17BE4DC", Slot = "89")]
		public virtual void Purchase(string productID, FacebookDelegate<IPurchaseResult> callback, string developerPayload)
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x17BE544", Offset = "0x17BE544", VA = "0x17BE544", Slot = "90")]
		public virtual void ConsumePurchase(string purchaseToken, FacebookDelegate<IConsumePurchaseResult> callback)
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x17BE5AC", Offset = "0x17BE5AC", VA = "0x17BE5AC", Slot = "91")]
		public virtual void InitCloudGame(FacebookDelegate<IInitCloudGameResult> callback)
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x17BE614", Offset = "0x17BE614", VA = "0x17BE614", Slot = "92")]
		public virtual void ScheduleAppToUserNotification(string title, string body, Uri media, int timeInterval, string payload, FacebookDelegate<IScheduleAppToUserNotificationResult> callback)
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x17BE67C", Offset = "0x17BE67C", VA = "0x17BE67C", Slot = "93")]
		public virtual void LoadInterstitialAd(string placementID, FacebookDelegate<IInterstitialAdResult> callback)
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x17BE6E4", Offset = "0x17BE6E4", VA = "0x17BE6E4", Slot = "94")]
		public virtual void ShowInterstitialAd(string placementID, FacebookDelegate<IInterstitialAdResult> callback)
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x17BE74C", Offset = "0x17BE74C", VA = "0x17BE74C", Slot = "95")]
		public virtual void LoadRewardedVideo(string placementID, FacebookDelegate<IRewardedVideoResult> callback)
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x17BE7B4", Offset = "0x17BE7B4", VA = "0x17BE7B4", Slot = "96")]
		public virtual void ShowRewardedVideo(string placementID, FacebookDelegate<IRewardedVideoResult> callback)
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x17BE81C", Offset = "0x17BE81C", VA = "0x17BE81C", Slot = "97")]
		public virtual void GetPayload(FacebookDelegate<IPayloadResult> callback)
		{
		}
	}
}
