using System;
using System.Collections.Generic;
using Facebook.Unity.Canvas;
using Facebook.Unity.Mobile;
using Il2CppDummyDll;

namespace Facebook.Unity.Editor
{
	[Token(Token = "0x2000072")]
	internal class EditorFacebook : FacebookBase, IMobileFacebookImplementation, IMobileFacebook, IFacebook, IMobileFacebookResultHandler, IFacebookResultHandler, ICanvasFacebookImplementation, ICanvasFacebook, IPayFacebook, ICanvasFacebookResultHandler
	{
		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0x28")]
		private IEditorWrapper editorWrapper;

		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816610", Offset = "0x816610")]
		private bool _003CLimitEventUsage_003Ek__BackingField;

		[Token(Token = "0x17000082")]
		public override bool LimitEventUsage
		{
			[Token(Token = "0x600022E")]
			[Address(RVA = "0xCD48B4", Offset = "0xCD48B4", VA = "0xCD48B4", Slot = "27")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8170B0", Offset = "0x8170B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600022F")]
			[Address(RVA = "0xCD48BC", Offset = "0xCD48BC", VA = "0xCD48BC", Slot = "28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8170C0", Offset = "0x8170C0")]
			set
			{
			}
		}

		[Token(Token = "0x17000083")]
		public override string SDKName
		{
			[Token(Token = "0x6000230")]
			[Address(RVA = "0xCD48C8", Offset = "0xCD48C8", VA = "0xCD48C8", Slot = "29")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000084")]
		public override string SDKVersion
		{
			[Token(Token = "0x6000231")]
			[Address(RVA = "0xCD4910", Offset = "0xCD4910", VA = "0xCD4910", Slot = "30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000085")]
		private static IFacebookCallbackHandler EditorGameObject
		{
			[Token(Token = "0x6000232")]
			[Address(RVA = "0xCD483C", Offset = "0xCD483C", VA = "0xCD483C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0xCD4768", Offset = "0xCD4768", VA = "0xCD4768")]
		public EditorFacebook(IEditorWrapper wrapper, CallbackManager callbackManager)
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0xCD47A0", Offset = "0xCD47A0", VA = "0xCD47A0")]
		public EditorFacebook()
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0xCD4958", Offset = "0xCD4958", VA = "0xCD4958", Slot = "32")]
		public override void Init(InitDelegate onInitComplete)
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0xCD4A4C", Offset = "0xCD4A4C", VA = "0xCD4A4C", Slot = "34")]
		public override void LogInWithReadPermissions(IEnumerable<string> permissions, FacebookDelegate<ILoginResult> callback)
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0xCD4A5C", Offset = "0xCD4A5C", VA = "0xCD4A5C", Slot = "33")]
		public override void LogInWithPublishPermissions(IEnumerable<string> permissions, FacebookDelegate<ILoginResult> callback)
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0xCD4BB4", Offset = "0xCD4BB4", VA = "0xCD4BB4", Slot = "36")]
		public override void AppRequest(string message, OGActionType? actionType, string objectId, IEnumerable<string> to, IEnumerable<object> filters, IEnumerable<string> excludeIds, int? maxRecipients, string data, string title, FacebookDelegate<IAppRequestResult> callback)
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0xCD4CEC", Offset = "0xCD4CEC", VA = "0xCD4CEC", Slot = "37")]
		public override void ShareLink(Uri contentURL, string contentTitle, string contentDescription, Uri photoURL, FacebookDelegate<IShareResult> callback)
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0xCD4E34", Offset = "0xCD4E34", VA = "0xCD4E34", Slot = "38")]
		public override void FeedShare(string toId, Uri link, string linkName, string linkCaption, string linkDescription, Uri picture, string mediaSource, FacebookDelegate<IShareResult> callback)
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0xCD4F7C", Offset = "0xCD4F7C", VA = "0xCD4F7C", Slot = "39")]
		public override void ActivateApp(string appId)
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0xCD4FE4", Offset = "0xCD4FE4", VA = "0xCD4FE4", Slot = "40")]
		public override void GetAppLink(FacebookDelegate<IAppLinkResult> callback)
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0xCD511C", Offset = "0xCD511C", VA = "0xCD511C", Slot = "41")]
		public override void AppEventsLogEvent(string logEvent, float? valueToSum, Dictionary<string, object> parameters)
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0xCD5184", Offset = "0xCD5184", VA = "0xCD5184", Slot = "42")]
		public override void AppEventsLogPurchase(float logPurchase, string currency, Dictionary<string, object> parameters)
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0xCD51EC", Offset = "0xCD51EC", VA = "0xCD51EC", Slot = "49")]
		public bool IsImplicitPurchaseLoggingEnabled()
		{
			return default(bool);
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0xCD51F4", Offset = "0xCD51F4", VA = "0xCD51F4", Slot = "46")]
		public override void OnAppRequestsComplete(ResultContainer resultContainer)
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0xCD5274", Offset = "0xCD5274", VA = "0xCD5274", Slot = "45")]
		public override void OnGetAppLinkComplete(ResultContainer resultContainer)
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0xCD52F4", Offset = "0xCD52F4", VA = "0xCD52F4", Slot = "44")]
		public override void OnLoginComplete(ResultContainer resultContainer)
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0xCD5370", Offset = "0xCD5370", VA = "0xCD5370", Slot = "47")]
		public override void OnShareLinkComplete(ResultContainer resultContainer)
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0xCD53F4", Offset = "0xCD53F4", VA = "0xCD53F4", Slot = "65")]
		public void OnFetchDeferredAppLinkComplete(ResultContainer resultContainer)
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0xCD5474", Offset = "0xCD5474", VA = "0xCD5474", Slot = "82")]
		public void OnPayComplete(ResultContainer resultContainer)
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0xCD54F8", Offset = "0xCD54F8", VA = "0xCD54F8", Slot = "66")]
		public void OnRefreshCurrentAccessTokenComplete(ResultContainer resultContainer)
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0xCD5578", Offset = "0xCD5578", VA = "0xCD5578", Slot = "67")]
		public void OnFriendFinderComplete(ResultContainer resultContainer)
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0xCD5604", Offset = "0xCD5604", VA = "0xCD5604", Slot = "68")]
		public void OnUploadImageToMediaLibraryComplete(ResultContainer resultContainer)
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0xCD5760", Offset = "0xCD5760", VA = "0xCD5760", Slot = "69")]
		public void OnUploadVideoToMediaLibraryComplete(ResultContainer resultContainer)
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0xCD57E0", Offset = "0xCD57E0", VA = "0xCD57E0", Slot = "70")]
		public void OnOnIAPReadyComplete(ResultContainer resultContainer)
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0xCD586C", Offset = "0xCD586C", VA = "0xCD586C", Slot = "71")]
		public void OnGetCatalogComplete(ResultContainer resultContainer)
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0xCD58EC", Offset = "0xCD58EC", VA = "0xCD58EC", Slot = "72")]
		public void OnGetPurchasesComplete(ResultContainer resultContainer)
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0xCD5970", Offset = "0xCD5970", VA = "0xCD5970", Slot = "73")]
		public void OnPurchaseComplete(ResultContainer resultContainer)
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0xCD59F4", Offset = "0xCD59F4", VA = "0xCD59F4", Slot = "74")]
		public void OnConsumePurchaseComplete(ResultContainer resultContainer)
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0xCD5A78", Offset = "0xCD5A78", VA = "0xCD5A78", Slot = "75")]
		public void OnInitCloudGameComplete(ResultContainer resultContainer)
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0xCD5B04", Offset = "0xCD5B04", VA = "0xCD5B04", Slot = "76")]
		public void OnScheduleAppToUserNotificationComplete(ResultContainer resultContainer)
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0xCD5B88", Offset = "0xCD5B88", VA = "0xCD5B88", Slot = "77")]
		public void OnLoadInterstitialAdComplete(ResultContainer resultContainer)
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0xCD5C14", Offset = "0xCD5C14", VA = "0xCD5C14", Slot = "78")]
		public void OnShowInterstitialAdComplete(ResultContainer resultContainer)
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0xCD5C98", Offset = "0xCD5C98", VA = "0xCD5C98", Slot = "79")]
		public void OnLoadRewardedVideoComplete(ResultContainer resultContainer)
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0xCD5D1C", Offset = "0xCD5D1C", VA = "0xCD5D1C", Slot = "80")]
		public void OnShowRewardedVideoComplete(ResultContainer resultContainer)
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0xCD5DA0", Offset = "0xCD5DA0", VA = "0xCD5DA0", Slot = "81")]
		public void OnGetPayloadComplete(ResultContainer resultContainer)
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0xCD5E24", Offset = "0xCD5E24", VA = "0xCD5E24", Slot = "50")]
		public void OpenFriendFinderDialog(FacebookDelegate<IGamingServicesFriendFinderResult> callback)
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0xCD5F6C", Offset = "0xCD5F6C", VA = "0xCD5F6C", Slot = "51")]
		public void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, FacebookDelegate<IMediaUploadResult> callback)
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0xCD6098", Offset = "0xCD6098", VA = "0xCD6098", Slot = "52")]
		public void UploadVideoToMediaLibrary(string caption, Uri imageUri, FacebookDelegate<IMediaUploadResult> callback)
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0xCD61C4", Offset = "0xCD61C4", VA = "0xCD61C4", Slot = "53")]
		public void OnIAPReady(FacebookDelegate<IIAPReadyResult> callback)
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0xCD62BC", Offset = "0xCD62BC", VA = "0xCD62BC", Slot = "54")]
		public void GetCatalog(FacebookDelegate<ICatalogResult> callback)
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0xCD63B4", Offset = "0xCD63B4", VA = "0xCD63B4", Slot = "55")]
		public void GetPurchases(FacebookDelegate<IPurchasesResult> callback)
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0xCD64AC", Offset = "0xCD64AC", VA = "0xCD64AC", Slot = "56")]
		public void Purchase(string productID, FacebookDelegate<IPurchaseResult> callback, string developerPayload = "")
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0xCD65A4", Offset = "0xCD65A4", VA = "0xCD65A4", Slot = "57")]
		public void ConsumePurchase(string productID, FacebookDelegate<IConsumePurchaseResult> callback)
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0xCD669C", Offset = "0xCD669C", VA = "0xCD669C", Slot = "58")]
		public void InitCloudGame(FacebookDelegate<IInitCloudGameResult> callback)
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0xCD6794", Offset = "0xCD6794", VA = "0xCD6794", Slot = "59")]
		public void ScheduleAppToUserNotification(string title, string body, Uri media, int timeInterval, string payload, FacebookDelegate<IScheduleAppToUserNotificationResult> callback)
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0xCD688C", Offset = "0xCD688C", VA = "0xCD688C", Slot = "60")]
		public void LoadInterstitialAd(string placementID, FacebookDelegate<IInterstitialAdResult> callback)
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0xCD6984", Offset = "0xCD6984", VA = "0xCD6984", Slot = "61")]
		public void ShowInterstitialAd(string placementID, FacebookDelegate<IInterstitialAdResult> callback)
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0xCD6A7C", Offset = "0xCD6A7C", VA = "0xCD6A7C", Slot = "62")]
		public void LoadRewardedVideo(string placementID, FacebookDelegate<IRewardedVideoResult> callback)
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0xCD6B74", Offset = "0xCD6B74", VA = "0xCD6B74", Slot = "63")]
		public void ShowRewardedVideo(string placementID, FacebookDelegate<IRewardedVideoResult> callback)
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0xCD6C6C", Offset = "0xCD6C6C", VA = "0xCD6C6C", Slot = "64")]
		public void GetPayload(FacebookDelegate<IPayloadResult> callback)
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0xCD6D64", Offset = "0xCD6D64", VA = "0xCD6D64", Slot = "83")]
		public void OnFacebookAuthResponseChange(ResultContainer resultContainer)
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0xCD6DCC", Offset = "0xCD6DCC", VA = "0xCD6DCC", Slot = "84")]
		public void OnUrlResponse(string message)
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0xCD6E34", Offset = "0xCD6E34", VA = "0xCD6E34", Slot = "85")]
		public void OnHideUnity(bool hidden)
		{
		}
	}
}
