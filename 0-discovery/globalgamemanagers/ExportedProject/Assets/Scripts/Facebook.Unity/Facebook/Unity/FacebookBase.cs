using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Facebook.Unity
{
	[Token(Token = "0x2000011")]
	internal abstract class FacebookBase : IFacebookImplementation, IFacebook, IFacebookResultHandler
	{
		[Serializable]
		[Token(Token = "0x2000012")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8160C0", Offset = "0x8160C0")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4000035")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4000036")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<string, bool> _003C_003E9__41_0;

			[Token(Token = "0x60000A5")]
			[Address(RVA = "0xCDDC70", Offset = "0xCDDC70", VA = "0xCDDC70")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x60000A6")]
			[Address(RVA = "0xCDDC78", Offset = "0xCDDC78", VA = "0xCDDC78")]
			internal bool _003CValidateAppRequestArgs_003Eb__41_0(string toWhom)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private InitDelegate onInitCompleteDelegate;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816210", Offset = "0x816210")]
		private bool _003CInitialized_003Ek__BackingField;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816220", Offset = "0x816220")]
		private CallbackManager _003CCallbackManager_003Ek__BackingField;

		[Token(Token = "0x17000022")]
		public abstract bool LimitEventUsage
		{
			[Token(Token = "0x6000082")]
			get;
			[Token(Token = "0x6000083")]
			set;
		}

		[Token(Token = "0x17000023")]
		public abstract string SDKName
		{
			[Token(Token = "0x6000084")]
			get;
		}

		[Token(Token = "0x17000024")]
		public abstract string SDKVersion
		{
			[Token(Token = "0x6000085")]
			get;
		}

		[Token(Token = "0x17000025")]
		public virtual string SDKUserAgent
		{
			[Token(Token = "0x6000086")]
			[Address(RVA = "0xCCA700", Offset = "0xCCA700", VA = "0xCCA700", Slot = "31")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000026")]
		public bool LoggedIn
		{
			[Token(Token = "0x6000087")]
			[Address(RVA = "0xCDCB90", Offset = "0xCDCB90", VA = "0xCDCB90", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000027")]
		public bool Initialized
		{
			[Token(Token = "0x6000088")]
			[Address(RVA = "0xCDCC50", Offset = "0xCDCC50", VA = "0xCDCC50", Slot = "8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8167F0", Offset = "0x8167F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000089")]
			[Address(RVA = "0xCDCC58", Offset = "0xCDCC58", VA = "0xCDCC58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816800", Offset = "0x816800")]
			private set
			{
			}
		}

		[Token(Token = "0x17000028")]
		protected CallbackManager CallbackManager
		{
			[Token(Token = "0x600008A")]
			[Address(RVA = "0xCCAF7C", Offset = "0xCCAF7C", VA = "0xCCAF7C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816810", Offset = "0x816810")]
			get
			{
				return null;
			}
			[Token(Token = "0x600008B")]
			[Address(RVA = "0xCDCB88", Offset = "0xCDCB88", VA = "0xCDCB88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816820", Offset = "0x816820")]
			private set
			{
			}
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0xCCA1B0", Offset = "0xCCA1B0", VA = "0xCCA1B0")]
		protected FacebookBase(CallbackManager callbackManager)
		{
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0xCCABD0", Offset = "0xCCABD0", VA = "0xCCABD0", Slot = "32")]
		public virtual void Init(InitDelegate onInitComplete)
		{
		}

		[Token(Token = "0x600008D")]
		public abstract void LogInWithPublishPermissions(IEnumerable<string> scope, FacebookDelegate<ILoginResult> callback);

		[Token(Token = "0x600008E")]
		public abstract void LogInWithReadPermissions(IEnumerable<string> scope, FacebookDelegate<ILoginResult> callback);

		[Token(Token = "0x600008F")]
		[Address(RVA = "0xCCB1EC", Offset = "0xCCB1EC", VA = "0xCCB1EC", Slot = "35")]
		public virtual void LogOut()
		{
		}

		[Token(Token = "0x6000090")]
		public abstract void AppRequest(string message, OGActionType? actionType, string objectId, IEnumerable<string> to, IEnumerable<object> filters, IEnumerable<string> excludeIds, int? maxRecipients, string data, string title, FacebookDelegate<IAppRequestResult> callback);

		[Token(Token = "0x6000091")]
		public abstract void ShareLink(Uri contentURL, string contentTitle, string contentDescription, Uri photoURL, FacebookDelegate<IShareResult> callback);

		[Token(Token = "0x6000092")]
		public abstract void FeedShare(string toId, Uri link, string linkName, string linkCaption, string linkDescription, Uri picture, string mediaSource, FacebookDelegate<IShareResult> callback);

		[Token(Token = "0x6000093")]
		[Address(RVA = "0xCDCC64", Offset = "0xCDCC64", VA = "0xCDCC64", Slot = "15")]
		public void API(string query, HttpMethod method, IDictionary<string, string> formData, FacebookDelegate<IGraphResult> callback)
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0xCDD418", Offset = "0xCDD418", VA = "0xCDD418", Slot = "16")]
		public void API(string query, HttpMethod method, WWWForm formData, FacebookDelegate<IGraphResult> callback)
		{
		}

		[Token(Token = "0x6000095")]
		public abstract void ActivateApp([Optional] string appId);

		[Token(Token = "0x6000096")]
		public abstract void GetAppLink(FacebookDelegate<IAppLinkResult> callback);

		[Token(Token = "0x6000097")]
		public abstract void AppEventsLogEvent(string logEvent, float? valueToSum, Dictionary<string, object> parameters);

		[Token(Token = "0x6000098")]
		public abstract void AppEventsLogPurchase(float logPurchase, string currency, Dictionary<string, object> parameters);

		[Token(Token = "0x6000099")]
		[Address(RVA = "0xCDD5A8", Offset = "0xCDD5A8", VA = "0xCDD5A8", Slot = "43")]
		public virtual void OnInitComplete(ResultContainer resultContainer)
		{
		}

		[Token(Token = "0x600009A")]
		public abstract void OnLoginComplete(ResultContainer resultContainer);

		[Token(Token = "0x600009B")]
		[Address(RVA = "0xCDD720", Offset = "0xCDD720", VA = "0xCDD720", Slot = "23")]
		public void OnLogoutComplete(ResultContainer resultContainer)
		{
		}

		[Token(Token = "0x600009C")]
		public abstract void OnGetAppLinkComplete(ResultContainer resultContainer);

		[Token(Token = "0x600009D")]
		public abstract void OnAppRequestsComplete(ResultContainer resultContainer);

		[Token(Token = "0x600009E")]
		public abstract void OnShareLinkComplete(ResultContainer resultContainer);

		[Token(Token = "0x600009F")]
		[Address(RVA = "0xCCB5E4", Offset = "0xCCB5E4", VA = "0xCCB5E4")]
		protected void ValidateAppRequestArgs(string message, OGActionType? actionType, string objectId, [Optional] IEnumerable<string> to, [Optional] IEnumerable<object> filters, [Optional] IEnumerable<string> excludeIds, [Optional] int? maxRecipients, string data = "", string title = "", [Optional] FacebookDelegate<IAppRequestResult> callback)
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0xCDD770", Offset = "0xCDD770", VA = "0xCDD770", Slot = "48")]
		protected virtual void OnAuthResponse(LoginResult result)
		{
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0xCDCF54", Offset = "0xCDCF54", VA = "0xCDCF54")]
		private IDictionary<string, string> CopyByValue(IDictionary<string, string> data)
		{
			return null;
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0xCDD344", Offset = "0xCDD344", VA = "0xCDD344")]
		private Uri GetGraphUrl(string query)
		{
			return null;
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0xCDD7FC", Offset = "0xCDD7FC", VA = "0xCDD7FC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816830", Offset = "0x816830")]
		private void _003COnInitComplete_003Eb__35_0(ILoginResult result)
		{
		}
	}
}
