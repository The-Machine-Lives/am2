using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Facebook.Unity.Gameroom
{
	[Token(Token = "0x2000069")]
	internal sealed class GameroomFacebook : FacebookBase, IGameroomFacebookImplementation, IGameroomFacebook, IPayFacebook, IFacebook, IGameroomFacebookResultHandler, IFacebookResultHandler
	{
		[Token(Token = "0x200006A")]
		public delegate void OnComplete(ResultContainer resultContainer);

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string appId;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private IGameroomWrapper gameroomWrapper;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816600", Offset = "0x816600")]
		private bool _003CLimitEventUsage_003Ek__BackingField;

		[Token(Token = "0x1700007A")]
		public override bool LimitEventUsage
		{
			[Token(Token = "0x60001FD")]
			[Address(RVA = "0xCDE9B8", Offset = "0xCDE9B8", VA = "0xCDE9B8", Slot = "27")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x817040", Offset = "0x817040")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001FE")]
			[Address(RVA = "0xCDE9C0", Offset = "0xCDE9C0", VA = "0xCDE9C0", Slot = "28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x817050", Offset = "0x817050")]
			set
			{
			}
		}

		[Token(Token = "0x1700007B")]
		public override string SDKName
		{
			[Token(Token = "0x60001FF")]
			[Address(RVA = "0xCDE9CC", Offset = "0xCDE9CC", VA = "0xCDE9CC", Slot = "29")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007C")]
		public override string SDKVersion
		{
			[Token(Token = "0x6000200")]
			[Address(RVA = "0xCDEA14", Offset = "0xCDEA14", VA = "0xCDEA14", Slot = "30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0xCDE7FC", Offset = "0xCDE7FC", VA = "0xCDE7FC")]
		public GameroomFacebook()
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0xCDE97C", Offset = "0xCDE97C", VA = "0xCDE97C")]
		public GameroomFacebook(IGameroomWrapper gameroomWrapper, CallbackManager callbackManager)
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0xCDA62C", Offset = "0xCDA62C", VA = "0xCDA62C")]
		public void Init(string appId, HideUnityDelegate hideUnityDelegate, InitDelegate onInitComplete)
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0xCDEA6C", Offset = "0xCDEA6C", VA = "0xCDEA6C", Slot = "39")]
		public override void ActivateApp([Optional] string appId)
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0xCDEAF4", Offset = "0xCDEAF4", VA = "0xCDEAF4", Slot = "41")]
		public override void AppEventsLogEvent(string logEvent, float? valueToSum, Dictionary<string, object> parameters)
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0xCDEDD4", Offset = "0xCDEDD4", VA = "0xCDEDD4", Slot = "42")]
		public override void AppEventsLogPurchase(float logPurchase, string currency, Dictionary<string, object> parameters)
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0xCDEECC", Offset = "0xCDEECC", VA = "0xCDEECC", Slot = "36")]
		public override void AppRequest(string message, OGActionType? actionType, string objectId, IEnumerable<string> to, IEnumerable<object> filters, IEnumerable<string> excludeIds, int? maxRecipients, string data, string title, FacebookDelegate<IAppRequestResult> callback)
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0xCDF340", Offset = "0xCDF340", VA = "0xCDF340", Slot = "38")]
		public override void FeedShare(string toId, Uri link, string linkName, string linkCaption, string linkDescription, Uri picture, string mediaSource, FacebookDelegate<IShareResult> callback)
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0xCDF560", Offset = "0xCDF560", VA = "0xCDF560", Slot = "37")]
		public override void ShareLink(Uri contentURL, string contentTitle, string contentDescription, Uri photoURL, FacebookDelegate<IShareResult> callback)
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0xCDF5B8", Offset = "0xCDF5B8", VA = "0xCDF5B8", Slot = "40")]
		public override void GetAppLink(FacebookDelegate<IAppLinkResult> callback)
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0xCDF620", Offset = "0xCDF620", VA = "0xCDF620", Slot = "33")]
		public override void LogInWithPublishPermissions(IEnumerable<string> scope, FacebookDelegate<ILoginResult> callback)
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0xCDF76C", Offset = "0xCDF76C", VA = "0xCDF76C", Slot = "34")]
		public override void LogInWithReadPermissions(IEnumerable<string> scope, FacebookDelegate<ILoginResult> callback)
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0xCDF770", Offset = "0xCDF770", VA = "0xCDF770", Slot = "46")]
		public override void OnAppRequestsComplete(ResultContainer resultContainer)
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0xCDF7F0", Offset = "0xCDF7F0", VA = "0xCDF7F0", Slot = "45")]
		public override void OnGetAppLinkComplete(ResultContainer resultContainer)
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0xCDF858", Offset = "0xCDF858", VA = "0xCDF858", Slot = "44")]
		public override void OnLoginComplete(ResultContainer resultContainer)
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0xCDF8D4", Offset = "0xCDF8D4", VA = "0xCDF8D4", Slot = "47")]
		public override void OnShareLinkComplete(ResultContainer resultContainer)
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0xCDF958", Offset = "0xCDF958", VA = "0xCDF958", Slot = "49")]
		public bool HaveReceivedPipeResponse()
		{
			return default(bool);
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0xCDFA18", Offset = "0xCDFA18", VA = "0xCDFA18", Slot = "50")]
		public string GetPipeResponse(string callbackId)
		{
			return null;
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0xCDE87C", Offset = "0xCDE87C", VA = "0xCDE87C")]
		private static IGameroomWrapper GetGameroomWrapper()
		{
			return null;
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0xCDF624", Offset = "0xCDF624", VA = "0xCDF624")]
		private void LoginWithPermissions(IEnumerable<string> scope, FacebookDelegate<ILoginResult> callback)
		{
		}
	}
}
