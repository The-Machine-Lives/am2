using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Facebook.Unity.Mobile.IOS
{
	[Token(Token = "0x2000084")]
	internal class IOSFacebook : MobileFacebook
	{
		[Token(Token = "0x2000085")]
		private class NativeDict
		{
			[Token(Token = "0x40000B7")]
			[FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816660", Offset = "0x816660")]
			private int _003CNumEntries_003Ek__BackingField;

			[Token(Token = "0x40000B8")]
			[FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816670", Offset = "0x816670")]
			private string[] _003CKeys_003Ek__BackingField;

			[Token(Token = "0x40000B9")]
			[FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816680", Offset = "0x816680")]
			private string[] _003CValues_003Ek__BackingField;

			[Token(Token = "0x17000093")]
			public int NumEntries
			{
				[Token(Token = "0x6000321")]
				[Address(RVA = "0x17BD168", Offset = "0x17BD168", VA = "0x17BD168")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x817150", Offset = "0x817150")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6000322")]
				[Address(RVA = "0x17BD150", Offset = "0x17BD150", VA = "0x17BD150")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x817160", Offset = "0x817160")]
				set
				{
				}
			}

			[Token(Token = "0x17000094")]
			public string[] Keys
			{
				[Token(Token = "0x6000323")]
				[Address(RVA = "0x17BD170", Offset = "0x17BD170", VA = "0x17BD170")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x817170", Offset = "0x817170")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000324")]
				[Address(RVA = "0x17BD158", Offset = "0x17BD158", VA = "0x17BD158")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x817180", Offset = "0x817180")]
				set
				{
				}
			}

			[Token(Token = "0x17000095")]
			public string[] Values
			{
				[Token(Token = "0x6000325")]
				[Address(RVA = "0x17BD178", Offset = "0x17BD178", VA = "0x17BD178")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x817190", Offset = "0x817190")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000326")]
				[Address(RVA = "0x17BD160", Offset = "0x17BD160", VA = "0x17BD160")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8171A0", Offset = "0x8171A0")]
				set
				{
				}
			}

			[Token(Token = "0x6000320")]
			[Address(RVA = "0x17BD124", Offset = "0x17BD124", VA = "0x17BD124")]
			public NativeDict()
			{
			}
		}

		[Token(Token = "0x40000B4")]
		[FieldOffset(Offset = "0x28")]
		private bool limitEventUsage;

		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0x30")]
		private IIOSWrapper iosWrapper;

		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0x38")]
		private string userID;

		[Token(Token = "0x17000090")]
		public override bool LimitEventUsage
		{
			[Token(Token = "0x600030A")]
			[Address(RVA = "0xCE4078", Offset = "0xCE4078", VA = "0xCE4078", Slot = "27")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600030B")]
			[Address(RVA = "0xCE4080", Offset = "0xCE4080", VA = "0xCE4080", Slot = "28")]
			set
			{
			}
		}

		[Token(Token = "0x17000091")]
		public override string SDKName
		{
			[Token(Token = "0x600030C")]
			[Address(RVA = "0xCE4150", Offset = "0xCE4150", VA = "0xCE4150", Slot = "29")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000092")]
		public override string SDKVersion
		{
			[Token(Token = "0x600030D")]
			[Address(RVA = "0xCE4198", Offset = "0xCE4198", VA = "0xCE4198", Slot = "30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0xCE3EC8", Offset = "0xCE3EC8", VA = "0xCE3EC8")]
		public IOSFacebook()
		{
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0xCE4048", Offset = "0xCE4048", VA = "0xCE4048")]
		public IOSFacebook(IIOSWrapper iosWrapper, CallbackManager callbackManager)
		{
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0xCDA034", Offset = "0xCDA034", VA = "0xCDA034")]
		public void Init(string appId, bool frictionlessRequests, string iosURLSuffix, HideUnityDelegate hideUnityDelegate, InitDelegate onInitComplete)
		{
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0xCE4250", Offset = "0xCE4250", VA = "0xCE4250", Slot = "34")]
		public override void LogInWithReadPermissions(IEnumerable<string> permissions, FacebookDelegate<ILoginResult> callback)
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0xCE434C", Offset = "0xCE434C", VA = "0xCE434C", Slot = "33")]
		public override void LogInWithPublishPermissions(IEnumerable<string> permissions, FacebookDelegate<ILoginResult> callback)
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0xCE4448", Offset = "0xCE4448", VA = "0xCE4448", Slot = "35")]
		public override void LogOut()
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0xCE4538", Offset = "0xCE4538", VA = "0xCE4538", Slot = "36")]
		public override void AppRequest(string message, OGActionType? actionType, string objectId, IEnumerable<string> to, IEnumerable<object> filters, IEnumerable<string> excludeIds, int? maxRecipients, string data, string title, FacebookDelegate<IAppRequestResult> callback)
		{
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0xCE4844", Offset = "0xCE4844", VA = "0xCE4844", Slot = "37")]
		public override void ShareLink(Uri contentURL, string contentTitle, string contentDescription, Uri photoURL, FacebookDelegate<IShareResult> callback)
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0xCE4978", Offset = "0xCE4978", VA = "0xCE4978", Slot = "38")]
		public override void FeedShare(string toId, Uri link, string linkName, string linkCaption, string linkDescription, Uri picture, string mediaSource, FacebookDelegate<IShareResult> callback)
		{
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0xCE4B7C", Offset = "0xCE4B7C", VA = "0xCE4B7C", Slot = "41")]
		public override void AppEventsLogEvent(string logEvent, float? valueToSum, Dictionary<string, object> parameters)
		{
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0xCE5208", Offset = "0xCE5208", VA = "0xCE5208", Slot = "42")]
		public override void AppEventsLogPurchase(float logPurchase, string currency, Dictionary<string, object> parameters)
		{
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0xCE5374", Offset = "0xCE5374", VA = "0xCE5374", Slot = "82")]
		public override bool IsImplicitPurchaseLoggingEnabled()
		{
			return default(bool);
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0xCE537C", Offset = "0xCE537C", VA = "0xCE537C", Slot = "39")]
		public override void ActivateApp(string appId)
		{
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0xCE5434", Offset = "0xCE5434", VA = "0xCE5434", Slot = "40")]
		public override void GetAppLink(FacebookDelegate<IAppLinkResult> callback)
		{
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0xCE555C", Offset = "0xCE555C", VA = "0xCE555C", Slot = "83")]
		public override void OpenFriendFinderDialog(FacebookDelegate<IGamingServicesFriendFinderResult> callback)
		{
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0xCE5684", Offset = "0xCE5684", VA = "0xCE5684", Slot = "84")]
		public override void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, FacebookDelegate<IMediaUploadResult> callback)
		{
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0xCE5804", Offset = "0xCE5804", VA = "0xCE5804", Slot = "85")]
		public override void UploadVideoToMediaLibrary(string caption, Uri videoUri, FacebookDelegate<IMediaUploadResult> callback)
		{
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0xCE3F48", Offset = "0xCE3F48", VA = "0xCE3F48")]
		private static IIOSWrapper GetIOSWrapper()
		{
			return null;
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0xCE4E18", Offset = "0xCE4E18", VA = "0xCE4E18")]
		private static NativeDict MarshallDict(Dictionary<string, object> dict)
		{
			return null;
		}

		[Token(Token = "0x600031F")]
		private int AddCallback<T>(FacebookDelegate<T> callback) where T : IResult
		{
			return default(int);
		}
	}
}
