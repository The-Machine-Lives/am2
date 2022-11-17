using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Facebook.Unity.Mobile.Android
{
	[Token(Token = "0x2000088")]
	internal sealed class AndroidFacebook : MobileFacebook
	{
		[Token(Token = "0x2000089")]
		private class JavaMethodCall<T> : MethodCall<T> where T : IResult
		{
			[Token(Token = "0x40000BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private AndroidFacebook androidImpl;

			[Token(Token = "0x600034F")]
			public JavaMethodCall(AndroidFacebook androidImpl, string methodName)
			{
			}

			[Token(Token = "0x6000350")]
			public override void Call([Optional] MethodArguments args)
			{
			}
		}

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool limitEventUsage;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private IAndroidWrapper androidWrapper;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string userID;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816690", Offset = "0x816690")]
		private string _003CKeyHash_003Ek__BackingField;

		[Token(Token = "0x17000097")]
		private string KeyHash
		{
			[Token(Token = "0x600032C")]
			[Address(RVA = "0xCE1720", Offset = "0xCE1720", VA = "0xCE1720")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8171B0", Offset = "0x8171B0")]
			set
			{
			}
		}

		[Token(Token = "0x17000098")]
		public override bool LimitEventUsage
		{
			[Token(Token = "0x600032D")]
			[Address(RVA = "0xCE1728", Offset = "0xCE1728", VA = "0xCE1728", Slot = "27")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600032E")]
			[Address(RVA = "0xCE1730", Offset = "0xCE1730", VA = "0xCE1730", Slot = "28")]
			set
			{
			}
		}

		[Token(Token = "0x17000099")]
		public override string SDKName
		{
			[Token(Token = "0x600032F")]
			[Address(RVA = "0xCE18E4", Offset = "0xCE18E4", VA = "0xCE18E4", Slot = "29")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009A")]
		public override string SDKVersion
		{
			[Token(Token = "0x6000330")]
			[Address(RVA = "0xCE192C", Offset = "0xCE192C", VA = "0xCE192C", Slot = "30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0xCE152C", Offset = "0xCE152C", VA = "0xCE152C")]
		public AndroidFacebook()
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0xCE16A4", Offset = "0xCE16A4", VA = "0xCE16A4")]
		public AndroidFacebook(IAndroidWrapper androidWrapper, CallbackManager callbackManager)
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0xCDA300", Offset = "0xCDA300", VA = "0xCDA300")]
		public void Init(string appId, HideUnityDelegate hideUnityDelegate, InitDelegate onInitComplete)
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0xCE1A14", Offset = "0xCE1A14", VA = "0xCE1A14", Slot = "34")]
		public override void LogInWithReadPermissions(IEnumerable<string> permissions, FacebookDelegate<ILoginResult> callback)
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0xCE1B2C", Offset = "0xCE1B2C", VA = "0xCE1B2C", Slot = "33")]
		public override void LogInWithPublishPermissions(IEnumerable<string> permissions, FacebookDelegate<ILoginResult> callback)
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0xCE1C44", Offset = "0xCE1C44", VA = "0xCE1C44", Slot = "35")]
		public override void LogOut()
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0xCE1D0C", Offset = "0xCE1D0C", VA = "0xCE1D0C")]
		public void OnLoginStatusRetrieved(ResultContainer resultContainer)
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0xCE1D88", Offset = "0xCE1D88", VA = "0xCE1D88", Slot = "36")]
		public override void AppRequest(string message, OGActionType? actionType, string objectId, IEnumerable<string> to, IEnumerable<object> filters, IEnumerable<string> excludeIds, int? maxRecipients, string data, string title, FacebookDelegate<IAppRequestResult> callback)
		{
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0xCE20DC", Offset = "0xCE20DC", VA = "0xCE20DC", Slot = "37")]
		public override void ShareLink(Uri contentURL, string contentTitle, string contentDescription, Uri photoURL, FacebookDelegate<IShareResult> callback)
		{
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0xCE22BC", Offset = "0xCE22BC", VA = "0xCE22BC", Slot = "38")]
		public override void FeedShare(string toId, Uri link, string linkName, string linkCaption, string linkDescription, Uri picture, string mediaSource, FacebookDelegate<IShareResult> callback)
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0xCE2558", Offset = "0xCE2558", VA = "0xCE2558", Slot = "40")]
		public override void GetAppLink(FacebookDelegate<IAppLinkResult> callback)
		{
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0xCE2630", Offset = "0xCE2630", VA = "0xCE2630", Slot = "41")]
		public override void AppEventsLogEvent(string logEvent, float? valueToSum, Dictionary<string, object> parameters)
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0xCE27F4", Offset = "0xCE27F4", VA = "0xCE27F4", Slot = "42")]
		public override void AppEventsLogPurchase(float logPurchase, string currency, Dictionary<string, object> parameters)
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0xCE2990", Offset = "0xCE2990", VA = "0xCE2990", Slot = "82")]
		public override bool IsImplicitPurchaseLoggingEnabled()
		{
			return default(bool);
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0xCE2A78", Offset = "0xCE2A78", VA = "0xCE2A78", Slot = "39")]
		public override void ActivateApp(string appId)
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0xCE2ACC", Offset = "0xCE2ACC", VA = "0xCE2ACC", Slot = "83")]
		public override void OpenFriendFinderDialog(FacebookDelegate<IGamingServicesFriendFinderResult> callback)
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0xCE2BA4", Offset = "0xCE2BA4", VA = "0xCE2BA4", Slot = "84")]
		public override void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, FacebookDelegate<IMediaUploadResult> callback)
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0xCE2D44", Offset = "0xCE2D44", VA = "0xCE2D44", Slot = "85")]
		public override void UploadVideoToMediaLibrary(string caption, Uri videoUri, FacebookDelegate<IMediaUploadResult> callback)
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0xCE2EA4", Offset = "0xCE2EA4", VA = "0xCE2EA4", Slot = "86")]
		public override void OnIAPReady(FacebookDelegate<IIAPReadyResult> callback)
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0xCE2F7C", Offset = "0xCE2F7C", VA = "0xCE2F7C", Slot = "87")]
		public override void GetCatalog(FacebookDelegate<ICatalogResult> callback)
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0xCE3054", Offset = "0xCE3054", VA = "0xCE3054", Slot = "88")]
		public override void GetPurchases(FacebookDelegate<IPurchasesResult> callback)
		{
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0xCE312C", Offset = "0xCE312C", VA = "0xCE312C", Slot = "89")]
		public override void Purchase(string productID, FacebookDelegate<IPurchaseResult> callback, string developerPayload = "")
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0xCE328C", Offset = "0xCE328C", VA = "0xCE328C", Slot = "90")]
		public override void ConsumePurchase(string purchaseToken, FacebookDelegate<IConsumePurchaseResult> callback)
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0xCE33A4", Offset = "0xCE33A4", VA = "0xCE33A4", Slot = "91")]
		public override void InitCloudGame(FacebookDelegate<IInitCloudGameResult> callback)
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0xCE347C", Offset = "0xCE347C", VA = "0xCE347C", Slot = "92")]
		public override void ScheduleAppToUserNotification(string title, string body, Uri media, int timeInterval, string payload, FacebookDelegate<IScheduleAppToUserNotificationResult> callback)
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0xCE36B0", Offset = "0xCE36B0", VA = "0xCE36B0", Slot = "93")]
		public override void LoadInterstitialAd(string placementID, FacebookDelegate<IInterstitialAdResult> callback)
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0xCE37C8", Offset = "0xCE37C8", VA = "0xCE37C8", Slot = "94")]
		public override void ShowInterstitialAd(string placementID, FacebookDelegate<IInterstitialAdResult> callback)
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0xCE38E0", Offset = "0xCE38E0", VA = "0xCE38E0", Slot = "95")]
		public override void LoadRewardedVideo(string placementID, FacebookDelegate<IRewardedVideoResult> callback)
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0xCE39F8", Offset = "0xCE39F8", VA = "0xCE39F8", Slot = "96")]
		public override void ShowRewardedVideo(string placementID, FacebookDelegate<IRewardedVideoResult> callback)
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0xCE3B10", Offset = "0xCE3B10", VA = "0xCE3B10", Slot = "97")]
		public override void GetPayload(FacebookDelegate<IPayloadResult> callback)
		{
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0xCE15A4", Offset = "0xCE15A4", VA = "0xCE15A4")]
		private static IAndroidWrapper GetAndroidWrapper()
		{
			return null;
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0xCE17A8", Offset = "0xCE17A8", VA = "0xCE17A8")]
		private void CallFB(string method, string args)
		{
		}
	}
}
