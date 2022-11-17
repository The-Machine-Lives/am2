using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Facebook.Unity.Canvas
{
	[Token(Token = "0x200008D")]
	internal sealed class CanvasFacebook : FacebookBase, ICanvasFacebookImplementation, ICanvasFacebook, IPayFacebook, IFacebook, ICanvasFacebookResultHandler, IFacebookResultHandler
	{
		[Token(Token = "0x200008E")]
		private class CanvasUIMethodCall<T> : MethodCall<T> where T : IResult
		{
			[Token(Token = "0x40000C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private CanvasFacebook canvasImpl;

			[Token(Token = "0x40000C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private string callbackMethod;

			[Token(Token = "0x6000379")]
			public CanvasUIMethodCall(CanvasFacebook canvasImpl, string methodName, string callbackMethod)
			{
			}

			[Token(Token = "0x600037A")]
			public override void Call(MethodArguments args)
			{
			}

			[Token(Token = "0x600037B")]
			private void UI(string method, MethodArguments args, [Optional] FacebookDelegate<T> callback)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200008F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816150", Offset = "0x816150")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x40000C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x40000C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Utilities.Callback<ResultContainer> _003C_003E9__40_0;

			[Token(Token = "0x600037D")]
			[Address(RVA = "0xCCD7E0", Offset = "0xCCD7E0", VA = "0xCCD7E0")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x600037E")]
			[Address(RVA = "0xCCD7E8", Offset = "0xCCD7E8", VA = "0xCCD7E8")]
			internal void _003COnFacebookAuthResponseChange_003Eb__40_0(ResultContainer formattedResponse)
			{
			}
		}

		[Token(Token = "0x2000090")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816160", Offset = "0x816160")]
		private sealed class _003C_003Ec__DisplayClass47_0
		{
			[Token(Token = "0x40000C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ResultContainer result;

			[Token(Token = "0x40000C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Utilities.Callback<ResultContainer> callback;

			[Token(Token = "0x600037F")]
			[Address(RVA = "0xCCD444", Offset = "0xCCD444", VA = "0xCCD444")]
			public _003C_003Ec__DisplayClass47_0()
			{
			}

			[Token(Token = "0x6000380")]
			[Address(RVA = "0xCCD89C", Offset = "0xCCD89C", VA = "0xCCD89C")]
			internal void _003CFormatAuthResponse_003Eb__0(IGraphResult r)
			{
			}
		}

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string appId;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string appLinkUrl;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ICanvasJSWrapper canvasJSWrapper;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private HideUnityDelegate onHideUnityDelegate;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8166A0", Offset = "0x8166A0")]
		private bool _003CLimitEventUsage_003Ek__BackingField;

		[Token(Token = "0x1700009C")]
		public override bool LimitEventUsage
		{
			[Token(Token = "0x600035F")]
			[Address(RVA = "0xCCA1DC", Offset = "0xCCA1DC", VA = "0xCCA1DC", Slot = "27")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8171C0", Offset = "0x8171C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000360")]
			[Address(RVA = "0xCCA1E4", Offset = "0xCCA1E4", VA = "0xCCA1E4", Slot = "28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8171D0", Offset = "0x8171D0")]
			set
			{
			}
		}

		[Token(Token = "0x1700009D")]
		public override string SDKName
		{
			[Token(Token = "0x6000361")]
			[Address(RVA = "0xCCA1F0", Offset = "0xCCA1F0", VA = "0xCCA1F0", Slot = "29")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009E")]
		public override string SDKVersion
		{
			[Token(Token = "0x6000362")]
			[Address(RVA = "0xCCA238", Offset = "0xCCA238", VA = "0xCCA238", Slot = "30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009F")]
		public override string SDKUserAgent
		{
			[Token(Token = "0x6000363")]
			[Address(RVA = "0xCCA2EC", Offset = "0xCCA2EC", VA = "0xCCA2EC", Slot = "31")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0xCC9FF4", Offset = "0xCC9FF4", VA = "0xCC9FF4")]
		public CanvasFacebook()
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0xCCA174", Offset = "0xCCA174", VA = "0xCCA174")]
		public CanvasFacebook(ICanvasJSWrapper canvasJSWrapper, CallbackManager callbackManager)
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0xCCA074", Offset = "0xCCA074", VA = "0xCCA074")]
		private static ICanvasJSWrapper GetCanvasJSWrapper()
		{
			return null;
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0xCCA798", Offset = "0xCCA798", VA = "0xCCA798")]
		public void Init(string appId, bool cookie, bool logging, bool status, bool xfbml, string channelUrl, string authResponse, bool frictionlessRequests, string javascriptSDKLocale, bool loadDebugJSSDK, HideUnityDelegate hideUnityDelegate, InitDelegate onInitComplete)
		{
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0xCCAE04", Offset = "0xCCAE04", VA = "0xCCAE04", Slot = "33")]
		public override void LogInWithPublishPermissions(IEnumerable<string> permissions, FacebookDelegate<ILoginResult> callback)
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0xCCAF84", Offset = "0xCCAF84", VA = "0xCCAF84", Slot = "34")]
		public override void LogInWithReadPermissions(IEnumerable<string> permissions, FacebookDelegate<ILoginResult> callback)
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0xCCB0FC", Offset = "0xCCB0FC", VA = "0xCCB0FC", Slot = "35")]
		public override void LogOut()
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0xCCB23C", Offset = "0xCCB23C", VA = "0xCCB23C", Slot = "36")]
		public override void AppRequest(string message, OGActionType? actionType, string objectId, IEnumerable<string> to, IEnumerable<object> filters, IEnumerable<string> excludeIds, int? maxRecipients, string data, string title, FacebookDelegate<IAppRequestResult> callback)
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0xCCB960", Offset = "0xCCB960", VA = "0xCCB960", Slot = "39")]
		public override void ActivateApp(string appId)
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0xCCBA18", Offset = "0xCCBA18", VA = "0xCCBA18", Slot = "37")]
		public override void ShareLink(Uri contentURL, string contentTitle, string contentDescription, Uri photoURL, FacebookDelegate<IShareResult> callback)
		{
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0xCCBD5C", Offset = "0xCCBD5C", VA = "0xCCBD5C", Slot = "38")]
		public override void FeedShare(string toId, Uri link, string linkName, string linkCaption, string linkDescription, Uri picture, string mediaSource, FacebookDelegate<IShareResult> callback)
		{
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0xCCC004", Offset = "0xCCC004", VA = "0xCCC004", Slot = "40")]
		public override void GetAppLink(FacebookDelegate<IAppLinkResult> callback)
		{
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0xCCC120", Offset = "0xCCC120", VA = "0xCCC120", Slot = "41")]
		public override void AppEventsLogEvent(string logEvent, float? valueToSum, Dictionary<string, object> parameters)
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0xCCC22C", Offset = "0xCCC22C", VA = "0xCCC22C", Slot = "42")]
		public override void AppEventsLogPurchase(float purchaseAmount, string currency, Dictionary<string, object> parameters)
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0xCCC338", Offset = "0xCCC338", VA = "0xCCC338", Slot = "44")]
		public override void OnLoginComplete(ResultContainer result)
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0xCCCD18", Offset = "0xCCCD18", VA = "0xCCCD18", Slot = "45")]
		public override void OnGetAppLinkComplete(ResultContainer message)
		{
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0xCCCD80", Offset = "0xCCCD80", VA = "0xCCCD80", Slot = "50")]
		public void OnFacebookAuthResponseChange(ResultContainer resultContainer)
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0xCCCE60", Offset = "0xCCCE60", VA = "0xCCCE60", Slot = "49")]
		public void OnPayComplete(ResultContainer resultContainer)
		{
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0xCCCEE4", Offset = "0xCCCEE4", VA = "0xCCCEE4", Slot = "46")]
		public override void OnAppRequestsComplete(ResultContainer resultContainer)
		{
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0xCCCF64", Offset = "0xCCCF64", VA = "0xCCCF64", Slot = "47")]
		public override void OnShareLinkComplete(ResultContainer resultContainer)
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0xCCCFE8", Offset = "0xCCCFE8", VA = "0xCCCFE8", Slot = "51")]
		public void OnUrlResponse(string url)
		{
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0xCCCFF0", Offset = "0xCCCFF0", VA = "0xCCCFF0", Slot = "52")]
		public void OnHideUnity(bool isGameShown)
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0xCCC3C0", Offset = "0xCCC3C0", VA = "0xCCC3C0")]
		private static void FormatAuthResponse(ResultContainer result, Utilities.Callback<ResultContainer> callback)
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0xCCD5B0", Offset = "0xCCD5B0", VA = "0xCCD5B0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8171E0", Offset = "0x8171E0")]
		private void _003COnLoginComplete_003Eb__37_0(ResultContainer formattedResponse)
		{
		}
	}
}
