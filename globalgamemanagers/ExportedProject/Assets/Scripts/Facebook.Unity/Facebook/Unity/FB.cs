using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Facebook.Unity.Mobile;
using Il2CppDummyDll;
using UnityEngine;

namespace Facebook.Unity
{
	[Token(Token = "0x200000B")]
	public sealed class FB : ScriptableObject
	{
		[Token(Token = "0x200000C")]
		private delegate void OnDLLLoaded();

		[Token(Token = "0x200000D")]
		public sealed class Mobile
		{
			[Token(Token = "0x1700001F")]
			private static IMobileFacebook MobileFacebookImpl
			{
				[Token(Token = "0x6000065")]
				[Address(RVA = "0xCDAC0C", Offset = "0xCDAC0C", VA = "0xCDAC0C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000066")]
			[Address(RVA = "0xCD1108", Offset = "0xCD1108", VA = "0xCD1108")]
			public static bool IsImplicitPurchaseLoggingEnabled()
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200000E")]
		internal abstract class CompiledFacebookLoader : MonoBehaviour
		{
			[Token(Token = "0x17000020")]
			protected abstract FacebookGameObject FBGameObject
			{
				[Token(Token = "0x6000067")]
				get;
			}

			[Token(Token = "0x6000068")]
			[Address(RVA = "0xCDA734", Offset = "0xCDA734", VA = "0xCDA734")]
			public void Start()
			{
			}

			[Token(Token = "0x6000069")]
			[Address(RVA = "0xCCE5D4", Offset = "0xCCE5D4", VA = "0xCCE5D4")]
			protected CompiledFacebookLoader()
			{
			}
		}

		[Token(Token = "0x200000F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8160B0", Offset = "0x8160B0")]
		private sealed class _003C_003Ec__DisplayClass36_0
		{
			[Token(Token = "0x4000028")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public InitDelegate onInitComplete;

			[Token(Token = "0x4000029")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string appId;

			[Token(Token = "0x400002A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool cookie;

			[Token(Token = "0x400002B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
			public bool logging;

			[Token(Token = "0x400002C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
			public bool status;

			[Token(Token = "0x400002D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
			public bool xfbml;

			[Token(Token = "0x400002E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string authResponse;

			[Token(Token = "0x400002F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool frictionlessRequests;

			[Token(Token = "0x4000030")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string javascriptSDKLocale;

			[Token(Token = "0x4000031")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public HideUnityDelegate onHideUnity;

			[Token(Token = "0x600006A")]
			[Address(RVA = "0xCD8994", Offset = "0xCD8994", VA = "0xCD8994")]
			public _003C_003Ec__DisplayClass36_0()
			{
			}

			[Token(Token = "0x600006B")]
			[Address(RVA = "0xCD9AC0", Offset = "0xCD9AC0", VA = "0xCD9AC0")]
			internal void _003CInit_003Eb__0()
			{
			}

			[Token(Token = "0x600006C")]
			[Address(RVA = "0xCD9C3C", Offset = "0xCD9C3C", VA = "0xCD9C3C")]
			internal void _003CInit_003Eb__1()
			{
			}

			[Token(Token = "0x600006D")]
			[Address(RVA = "0xCD9E5C", Offset = "0xCD9E5C", VA = "0xCD9E5C")]
			internal void _003CInit_003Eb__2()
			{
			}

			[Token(Token = "0x600006E")]
			[Address(RVA = "0xCDA1A8", Offset = "0xCDA1A8", VA = "0xCDA1A8")]
			internal void _003CInit_003Eb__3()
			{
			}

			[Token(Token = "0x600006F")]
			[Address(RVA = "0xCDA4D4", Offset = "0xCDA4D4", VA = "0xCDA4D4")]
			internal void _003CInit_003Eb__4()
			{
			}
		}

		[Token(Token = "0x400001F")]
		private const string DefaultJSSDKLocale = "en_US";

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static IFacebook facebook;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static bool isInitCalled;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static string facebookDomain;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static string gamingDomain;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static string graphApiVersion;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8161E0", Offset = "0x8161E0")]
		private static string _003CAppId_003Ek__BackingField;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8161F0", Offset = "0x8161F0")]
		private static string _003CClientToken_003Ek__BackingField;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816200", Offset = "0x816200")]
		private static OnDLLLoaded _003COnDLLLoadedDelegate_003Ek__BackingField;

		[Token(Token = "0x17000016")]
		public static string AppId
		{
			[Token(Token = "0x600003C")]
			[Address(RVA = "0xCD3118", Offset = "0xCD3118", VA = "0xCD3118")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816790", Offset = "0x816790")]
			get
			{
				return null;
			}
			[Token(Token = "0x600003D")]
			[Address(RVA = "0xCD7C94", Offset = "0xCD7C94", VA = "0xCD7C94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8167A0", Offset = "0x8167A0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public static string ClientToken
		{
			[Token(Token = "0x600003E")]
			[Address(RVA = "0xCD7D00", Offset = "0xCD7D00", VA = "0xCD7D00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8167B0", Offset = "0x8167B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600003F")]
			[Address(RVA = "0xCD7D68", Offset = "0xCD7D68", VA = "0xCD7D68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8167C0", Offset = "0x8167C0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000018")]
		public static string GraphApiVersion
		{
			[Token(Token = "0x6000040")]
			[Address(RVA = "0xCCAD34", Offset = "0xCCAD34", VA = "0xCCAD34")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000041")]
			[Address(RVA = "0xCD7DD4", Offset = "0xCD7DD4", VA = "0xCD7DD4")]
			set
			{
			}
		}

		[Token(Token = "0x17000019")]
		public static bool IsLoggedIn
		{
			[Token(Token = "0x6000042")]
			[Address(RVA = "0xCD43F4", Offset = "0xCD43F4", VA = "0xCD43F4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001A")]
		public static bool IsInitialized
		{
			[Token(Token = "0x6000043")]
			[Address(RVA = "0xCD7E40", Offset = "0xCD7E40", VA = "0xCD7E40")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001B")]
		public static bool LimitAppEventUsage
		{
			[Token(Token = "0x6000044")]
			[Address(RVA = "0xCD7F58", Offset = "0xCD7F58", VA = "0xCD7F58")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000045")]
			[Address(RVA = "0xCD8070", Offset = "0xCD8070", VA = "0xCD8070")]
			set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		internal static IFacebook FacebookImpl
		{
			[Token(Token = "0x6000046")]
			[Address(RVA = "0xCD29DC", Offset = "0xCD29DC", VA = "0xCD29DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000047")]
			[Address(RVA = "0xCD8198", Offset = "0xCD8198", VA = "0xCD8198")]
			set
			{
			}
		}

		[Token(Token = "0x1700001D")]
		internal static string FacebookDomain
		{
			[Token(Token = "0x6000048")]
			[Address(RVA = "0xCD28D0", Offset = "0xCD28D0", VA = "0xCD28D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000049")]
			[Address(RVA = "0xCD8204", Offset = "0xCD8204", VA = "0xCD8204")]
			set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		private static OnDLLLoaded OnDLLLoadedDelegate
		{
			[Token(Token = "0x600004A")]
			[Address(RVA = "0xCD8270", Offset = "0xCD8270", VA = "0xCD8270")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8167D0", Offset = "0x8167D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600004B")]
			[Address(RVA = "0xCD82D8", Offset = "0xCD82D8", VA = "0xCD82D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8167E0", Offset = "0x8167E0")]
			set
			{
			}
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0xCD8344", Offset = "0xCD8344", VA = "0xCD8344")]
		public static void Init([Optional] InitDelegate onInitComplete, [Optional] HideUnityDelegate onHideUnity, [Optional] string authResponse)
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0xCD8484", Offset = "0xCD8484", VA = "0xCD8484")]
		public static void Init(string appId, [Optional] string clientToken, bool cookie = true, bool logging = true, bool status = true, bool xfbml = false, bool frictionlessRequests = true, [Optional] string authResponse, string javascriptSDKLocale = "en_US", [Optional] HideUnityDelegate onHideUnity, [Optional] InitDelegate onInitComplete)
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0xCD89AC", Offset = "0xCD89AC", VA = "0xCD89AC")]
		public static void LogInWithPublishPermissions([Optional] IEnumerable<string> permissions, [Optional] FacebookDelegate<ILoginResult> callback)
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0xCD8A98", Offset = "0xCD8A98", VA = "0xCD8A98")]
		public static void LogInWithReadPermissions([Optional] IEnumerable<string> permissions, [Optional] FacebookDelegate<ILoginResult> callback)
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0xCD8B84", Offset = "0xCD8B84", VA = "0xCD8B84")]
		public static void LogOut()
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0xCD8C58", Offset = "0xCD8C58", VA = "0xCD8C58")]
		public static void AppRequest(string message, OGActionType actionType, string objectId, IEnumerable<string> to, string data = "", string title = "", [Optional] FacebookDelegate<IAppRequestResult> callback)
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0xCD8DB4", Offset = "0xCD8DB4", VA = "0xCD8DB4")]
		public static void AppRequest(string message, OGActionType actionType, string objectId, [Optional] IEnumerable<object> filters, [Optional] IEnumerable<string> excludeIds, [Optional] int? maxRecipients, string data = "", string title = "", [Optional] FacebookDelegate<IAppRequestResult> callback)
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0xCD8F20", Offset = "0xCD8F20", VA = "0xCD8F20")]
		public static void AppRequest(string message, [Optional] IEnumerable<string> to, [Optional] IEnumerable<object> filters, [Optional] IEnumerable<string> excludeIds, [Optional] int? maxRecipients, string data = "", string title = "", [Optional] FacebookDelegate<IAppRequestResult> callback)
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0xCD9064", Offset = "0xCD9064", VA = "0xCD9064")]
		public static void ShareLink([Optional] Uri contentURL, string contentTitle = "", string contentDescription = "", [Optional] Uri photoURL, [Optional] FacebookDelegate<IShareResult> callback)
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0xCD9170", Offset = "0xCD9170", VA = "0xCD9170")]
		public static void FeedShare(string toId = "", [Optional] Uri link, string linkName = "", string linkCaption = "", string linkDescription = "", [Optional] Uri picture, string mediaSource = "", [Optional] FacebookDelegate<IShareResult> callback)
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0xCCD44C", Offset = "0xCCD44C", VA = "0xCCD44C")]
		public static void API(string query, HttpMethod method, [Optional] FacebookDelegate<IGraphResult> callback, [Optional] IDictionary<string, string> formData)
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0xCD92B0", Offset = "0xCD92B0", VA = "0xCD92B0")]
		public static void API(string query, HttpMethod method, FacebookDelegate<IGraphResult> callback, WWWForm formData)
		{
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0xCD9414", Offset = "0xCD9414", VA = "0xCD9414")]
		public static void ActivateApp()
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0xCD94F8", Offset = "0xCD94F8", VA = "0xCD94F8")]
		public static void GetAppLink(FacebookDelegate<IAppLinkResult> callback)
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0xCD95E4", Offset = "0xCD95E4", VA = "0xCD95E4")]
		public static void ClearAppLink()
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0xCD1238", Offset = "0xCD1238", VA = "0xCD1238")]
		public static void LogAppEvent(string logEvent, [Optional] float? valueToSum, [Optional] Dictionary<string, object> parameters)
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0xCD95E8", Offset = "0xCD95E8", VA = "0xCD95E8")]
		public static void LogPurchase(decimal logPurchase, [Optional] string currency, [Optional] Dictionary<string, object> parameters)
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0xCD9690", Offset = "0xCD9690", VA = "0xCD9690")]
		public static void LogPurchase(float logPurchase, [Optional] string currency, [Optional] Dictionary<string, object> parameters)
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0xCD97B0", Offset = "0xCD97B0", VA = "0xCD97B0")]
		private static void LogVersion()
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0xCD9A2C", Offset = "0xCD9A2C", VA = "0xCD9A2C")]
		public FB()
		{
		}
	}
}
