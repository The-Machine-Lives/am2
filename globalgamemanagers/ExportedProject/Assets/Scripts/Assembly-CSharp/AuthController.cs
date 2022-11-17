using System;
using Il2CppDummyDll;
using Uken.Library.Authentication;
using Uken.Library.Network;

[Token(Token = "0x20001FD")]
public class AuthController
{
	[Token(Token = "0x200065D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820588", Offset = "0x820588")]
	private sealed class _003C_003Ec__DisplayClass38_0
	{
		[Token(Token = "0x4001F7C")]
		[FieldOffset(Offset = "0x10")]
		public AuthController _003C_003E4__this;

		[Token(Token = "0x4001F7D")]
		[FieldOffset(Offset = "0x18")]
		public Action<AuthenticationStatus> onComplete;

		[Token(Token = "0x6002D99")]
		[Address(RVA = "0xA379C8", Offset = "0xA379C8", VA = "0xA379C8")]
		public _003C_003Ec__DisplayClass38_0()
		{
		}

		[Token(Token = "0x6002D9A")]
		[Address(RVA = "0xA3988C", Offset = "0xA3988C", VA = "0xA3988C")]
		internal void _003CLogin_003Eb__0(AuthenticationStatus loginResult)
		{
		}
	}

	[Token(Token = "0x200065E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820598", Offset = "0x820598")]
	private sealed class _003C_003Ec__DisplayClass38_1
	{
		[Token(Token = "0x4001F7E")]
		[FieldOffset(Offset = "0x10")]
		public AuthenticationStatus loginResult;

		[Token(Token = "0x4001F7F")]
		[FieldOffset(Offset = "0x18")]
		public _003C_003Ec__DisplayClass38_0 CS_0024_003C_003E8__locals1;

		[Token(Token = "0x6002D9B")]
		[Address(RVA = "0xA39A78", Offset = "0xA39A78", VA = "0xA39A78")]
		public _003C_003Ec__DisplayClass38_1()
		{
		}

		[Token(Token = "0x6002D9C")]
		[Address(RVA = "0xA39A80", Offset = "0xA39A80", VA = "0xA39A80")]
		internal void _003CLogin_003Eb__1(AuthenticationStatus linkStatus, LinkResult linkResult)
		{
		}
	}

	[Token(Token = "0x200065F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8205A8", Offset = "0x8205A8")]
	private sealed class _003C_003Ec__DisplayClass39_0
	{
		[Token(Token = "0x4001F80")]
		[FieldOffset(Offset = "0x10")]
		public AuthController _003C_003E4__this;

		[Token(Token = "0x4001F81")]
		[FieldOffset(Offset = "0x18")]
		public Action<AuthenticationStatus> onComplete;

		[Token(Token = "0x6002D9D")]
		[Address(RVA = "0xA37B04", Offset = "0xA37B04", VA = "0xA37B04")]
		public _003C_003Ec__DisplayClass39_0()
		{
		}

		[Token(Token = "0x6002D9E")]
		[Address(RVA = "0xA39B50", Offset = "0xA39B50", VA = "0xA39B50")]
		internal void _003CLoginViaGuest_003Eb__0(string response)
		{
		}

		[Token(Token = "0x6002D9F")]
		[Address(RVA = "0xA39BF8", Offset = "0xA39BF8", VA = "0xA39BF8")]
		internal void _003CLoginViaGuest_003Eb__1(long statusCode, string response)
		{
		}
	}

	[Token(Token = "0x2000660")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8205B8", Offset = "0x8205B8")]
	private sealed class _003C_003Ec__DisplayClass44_0
	{
		[Token(Token = "0x4001F82")]
		[FieldOffset(Offset = "0x10")]
		public Action<bool> onComplete;

		[Token(Token = "0x6002DA0")]
		[Address(RVA = "0xA3808C", Offset = "0xA3808C", VA = "0xA3808C")]
		public _003C_003Ec__DisplayClass44_0()
		{
		}

		[Token(Token = "0x6002DA1")]
		[Address(RVA = "0xA39CA0", Offset = "0xA39CA0", VA = "0xA39CA0")]
		internal void _003CUnlinkGuest_003Eb__0(string response)
		{
		}

		[Token(Token = "0x6002DA2")]
		[Address(RVA = "0xA39D38", Offset = "0xA39D38", VA = "0xA39D38")]
		internal void _003CUnlinkGuest_003Eb__1(long statusCode, string response)
		{
		}
	}

	[Token(Token = "0x2000661")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8205C8", Offset = "0x8205C8")]
	private sealed class _003C_003Ec__DisplayClass45_0
	{
		[Token(Token = "0x4001F83")]
		[FieldOffset(Offset = "0x10")]
		public AuthController _003C_003E4__this;

		[Token(Token = "0x4001F84")]
		[FieldOffset(Offset = "0x18")]
		public Action<AuthenticationStatus, LinkResult> onComplete;

		[Token(Token = "0x6002DA3")]
		[Address(RVA = "0xA381A8", Offset = "0xA381A8", VA = "0xA381A8")]
		public _003C_003Ec__DisplayClass45_0()
		{
		}

		[Token(Token = "0x6002DA4")]
		[Address(RVA = "0xA39DD0", Offset = "0xA39DD0", VA = "0xA39DD0")]
		internal void _003CLinkGuestAuth_003Eb__0(string response)
		{
		}

		[Token(Token = "0x6002DA5")]
		[Address(RVA = "0xA39E7C", Offset = "0xA39E7C", VA = "0xA39E7C")]
		internal void _003CLinkGuestAuth_003Eb__1(long statusCode, string response)
		{
		}
	}

	[Token(Token = "0x2000662")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8205D8", Offset = "0x8205D8")]
	private sealed class _003C_003Ec__DisplayClass46_0
	{
		[Token(Token = "0x4001F85")]
		[FieldOffset(Offset = "0x10")]
		public AuthController _003C_003E4__this;

		[Token(Token = "0x4001F86")]
		[FieldOffset(Offset = "0x18")]
		public Action<UnlinkResult> onComplete;

		[Token(Token = "0x6002DA6")]
		[Address(RVA = "0xA38300", Offset = "0xA38300", VA = "0xA38300")]
		public _003C_003Ec__DisplayClass46_0()
		{
		}

		[Token(Token = "0x6002DA7")]
		[Address(RVA = "0xA39F28", Offset = "0xA39F28", VA = "0xA39F28")]
		internal void _003CUnlinkAll_003Eb__0(string response)
		{
		}

		[Token(Token = "0x6002DA8")]
		[Address(RVA = "0xA39FDC", Offset = "0xA39FDC", VA = "0xA39FDC")]
		internal void _003CUnlinkAll_003Eb__1(long statusCode, string response)
		{
		}
	}

	[Token(Token = "0x2000663")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8205E8", Offset = "0x8205E8")]
	private sealed class _003C_003Ec__DisplayClass60_0
	{
		[Token(Token = "0x4001F87")]
		[FieldOffset(Offset = "0x10")]
		public Action<string, Action<string>, Action<long, string>> hothLogin;

		[Token(Token = "0x4001F88")]
		[FieldOffset(Offset = "0x18")]
		public AuthController _003C_003E4__this;

		[Token(Token = "0x4001F89")]
		[FieldOffset(Offset = "0x20")]
		public Action<AuthenticationStatus> onComplete;

		[Token(Token = "0x4001F8A")]
		[FieldOffset(Offset = "0x28")]
		public Action<string> _003C_003E9__1;

		[Token(Token = "0x4001F8B")]
		[FieldOffset(Offset = "0x30")]
		public Action<long, string> _003C_003E9__2;

		[Token(Token = "0x6002DA9")]
		[Address(RVA = "0xA394C4", Offset = "0xA394C4", VA = "0xA394C4")]
		public _003C_003Ec__DisplayClass60_0()
		{
		}

		[Token(Token = "0x6002DAA")]
		[Address(RVA = "0xA3A070", Offset = "0xA3A070", VA = "0xA3A070")]
		internal void _003CLoginViaNativeAuthProvider_003Eb__0(bool success, string authCode)
		{
		}

		[Token(Token = "0x6002DAB")]
		[Address(RVA = "0xA3A244", Offset = "0xA3A244", VA = "0xA3A244")]
		internal void _003CLoginViaNativeAuthProvider_003Eb__1(string response)
		{
		}

		[Token(Token = "0x6002DAC")]
		[Address(RVA = "0xA3A2EC", Offset = "0xA3A2EC", VA = "0xA3A2EC")]
		internal void _003CLoginViaNativeAuthProvider_003Eb__2(long statusCode, string response)
		{
		}
	}

	[Token(Token = "0x2000664")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8205F8", Offset = "0x8205F8")]
	private sealed class _003C_003Ec__DisplayClass61_0
	{
		[Token(Token = "0x4001F8C")]
		[FieldOffset(Offset = "0x10")]
		public Action<string, bool, Action<string>, Action<long, string>> hothLink;

		[Token(Token = "0x4001F8D")]
		[FieldOffset(Offset = "0x18")]
		public bool forced;

		[Token(Token = "0x4001F8E")]
		[FieldOffset(Offset = "0x20")]
		public AuthController _003C_003E4__this;

		[Token(Token = "0x4001F8F")]
		[FieldOffset(Offset = "0x28")]
		public Action<AuthenticationStatus, LinkResult> onComplete;

		[Token(Token = "0x4001F90")]
		[FieldOffset(Offset = "0x30")]
		public NativeAuthProvider authProvider;

		[Token(Token = "0x4001F91")]
		[FieldOffset(Offset = "0x38")]
		public Action<string> _003C_003E9__1;

		[Token(Token = "0x4001F92")]
		[FieldOffset(Offset = "0x40")]
		public Action<long, string> _003C_003E9__2;

		[Token(Token = "0x6002DAD")]
		[Address(RVA = "0xA39614", Offset = "0xA39614", VA = "0xA39614")]
		public _003C_003Ec__DisplayClass61_0()
		{
		}

		[Token(Token = "0x6002DAE")]
		[Address(RVA = "0xA3A394", Offset = "0xA3A394", VA = "0xA3A394")]
		internal void _003CLinkNativeAuth_003Eb__0(bool success, string authCode)
		{
		}

		[Token(Token = "0x6002DAF")]
		[Address(RVA = "0xA3A4F8", Offset = "0xA3A4F8", VA = "0xA3A4F8")]
		internal void _003CLinkNativeAuth_003Eb__1(string response)
		{
		}

		[Token(Token = "0x6002DB0")]
		[Address(RVA = "0xA3A590", Offset = "0xA3A590", VA = "0xA3A590")]
		internal void _003CLinkNativeAuth_003Eb__2(long statusCode, string response)
		{
		}
	}

	[Token(Token = "0x2000665")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820608", Offset = "0x820608")]
	private sealed class _003C_003Ec__DisplayClass66_0
	{
		[Token(Token = "0x4001F93")]
		[FieldOffset(Offset = "0x10")]
		public AuthController _003C_003E4__this;

		[Token(Token = "0x4001F94")]
		[FieldOffset(Offset = "0x18")]
		public Action<UnlinkResult> onComplete;

		[Token(Token = "0x4001F95")]
		[FieldOffset(Offset = "0x20")]
		public Action<string> _003C_003E9__1;

		[Token(Token = "0x4001F96")]
		[FieldOffset(Offset = "0x28")]
		public Action<long, string> _003C_003E9__2;

		[Token(Token = "0x6002DB1")]
		[Address(RVA = "0xA39840", Offset = "0xA39840", VA = "0xA39840")]
		public _003C_003Ec__DisplayClass66_0()
		{
		}

		[Token(Token = "0x6002DB2")]
		[Address(RVA = "0xA3A640", Offset = "0xA3A640", VA = "0xA3A640")]
		internal void _003CUnlinkGooglePlayAuth_003Eb__0(bool success, string authCode)
		{
		}

		[Token(Token = "0x6002DB3")]
		[Address(RVA = "0xA3A77C", Offset = "0xA3A77C", VA = "0xA3A77C")]
		internal void _003CUnlinkGooglePlayAuth_003Eb__1(string response)
		{
		}

		[Token(Token = "0x6002DB4")]
		[Address(RVA = "0xA3A830", Offset = "0xA3A830", VA = "0xA3A830")]
		internal void _003CUnlinkGooglePlayAuth_003Eb__2(long statusCode, string response)
		{
		}
	}

	[Token(Token = "0x4000B52")]
	protected const float c_minTimeInSecondsToSendAfterNetworkReconnect = 1.5f;

	[Token(Token = "0x4000B53")]
	public const bool c_debugNoAuth = false;

	[Token(Token = "0x4000B54")]
	[FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x825FEC", Offset = "0x825FEC")]
	private AuthenticationStatus _003CauthenticationStatus_003Ek__BackingField;

	[Token(Token = "0x4000B55")]
	[FieldOffset(Offset = "0x14")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x825FFC", Offset = "0x825FFC")]
	private AuthTokenRefreshStatus _003CauthRefreshStatus_003Ek__BackingField;

	[Token(Token = "0x4000B56")]
	[FieldOffset(Offset = "0x18")]
	private UkenAuthCredential m_authenticationCredential;

	[Token(Token = "0x4000B57")]
	[FieldOffset(Offset = "0x20")]
	private AuthApiClient m_apiClient;

	[Token(Token = "0x4000B58")]
	[FieldOffset(Offset = "0x28")]
	private AuthApiConfig m_apiConfig;

	[Token(Token = "0x4000B59")]
	[FieldOffset(Offset = "0x30")]
	private INetworkStatus m_networkStatus;

	[Token(Token = "0x4000B5A")]
	[FieldOffset(Offset = "0x38")]
	private bool m_refreshTokenValid;

	[Token(Token = "0x4000B5B")]
	[FieldOffset(Offset = "0x3C")]
	private float m_timeUntilTokenRefresh;

	[Token(Token = "0x4000B5C")]
	[FieldOffset(Offset = "0x40")]
	private float m_timeUntilAuthRetry;

	[Token(Token = "0x4000B5D")]
	private const float m_refreshBufferThrottle = 0.9f;

	[Token(Token = "0x4000B5E")]
	private const float m_reauthenticateBackoffBase = 0.1f;

	[Token(Token = "0x4000B5F")]
	private const float m_maxReauthenticateBackoff = 10f;

	[Token(Token = "0x4000B60")]
	private const float m_reauthenticateBackoffRate = 2f;

	[Token(Token = "0x4000B61")]
	[FieldOffset(Offset = "0x44")]
	private float m_reauthenticateBackoffMultiplier;

	[Token(Token = "0x4000B62")]
	[FieldOffset(Offset = "0x48")]
	private DateTime? m_pauseTime;

	[Token(Token = "0x4000B63")]
	[FieldOffset(Offset = "0x58")]
	private GooglePlayAuthProvider m_googlePlayAuthProvider;

	[Token(Token = "0x170001A2")]
	public AuthenticationStatus authenticationStatus
	{
		[Token(Token = "0x6000D4F")]
		[Address(RVA = "0xA371C8", Offset = "0xA371C8", VA = "0xA371C8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8350A0", Offset = "0x8350A0")]
		get
		{
			return default(AuthenticationStatus);
		}
		[Token(Token = "0x6000D50")]
		[Address(RVA = "0xA371D0", Offset = "0xA371D0", VA = "0xA371D0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8350B0", Offset = "0x8350B0")]
		private set
		{
		}
	}

	[Token(Token = "0x170001A3")]
	public AuthTokenRefreshStatus authRefreshStatus
	{
		[Token(Token = "0x6000D51")]
		[Address(RVA = "0xA371D8", Offset = "0xA371D8", VA = "0xA371D8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8350C0", Offset = "0x8350C0")]
		get
		{
			return default(AuthTokenRefreshStatus);
		}
		[Token(Token = "0x6000D52")]
		[Address(RVA = "0xA371E0", Offset = "0xA371E0", VA = "0xA371E0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8350D0", Offset = "0x8350D0")]
		private set
		{
		}
	}

	[Token(Token = "0x170001A4")]
	public bool isGuestCredentialValid
	{
		[Token(Token = "0x6000D53")]
		[Address(RVA = "0xA371E8", Offset = "0xA371E8", VA = "0xA371E8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170001A5")]
	public bool isNativeAuthAccount
	{
		[Token(Token = "0x6000D54")]
		[Address(RVA = "0xA37214", Offset = "0xA37214", VA = "0xA37214")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000D55")]
	[Address(RVA = "0xA37240", Offset = "0xA37240", VA = "0xA37240")]
	public AuthController(string baseAuthUrl, string credentialFilePath, INetworkStatus networkStatus)
	{
	}

	[Token(Token = "0x6000D56")]
	[Address(RVA = "0xA37350", Offset = "0xA37350", VA = "0xA37350")]
	public bool SupportsNativeAuth()
	{
		return default(bool);
	}

	[Token(Token = "0x6000D57")]
	[Address(RVA = "0xA37358", Offset = "0xA37358", VA = "0xA37358")]
	public bool GuestAuthenticated()
	{
		return default(bool);
	}

	[Token(Token = "0x6000D58")]
	[Address(RVA = "0xA37394", Offset = "0xA37394", VA = "0xA37394")]
	public long GetLoginTime()
	{
		return default(long);
	}

	[Token(Token = "0x6000D59")]
	[Address(RVA = "0xA37430", Offset = "0xA37430", VA = "0xA37430")]
	public int GetUserCreationTime()
	{
		return default(int);
	}

	[Token(Token = "0x6000D5A")]
	[Address(RVA = "0xA37448", Offset = "0xA37448", VA = "0xA37448")]
	public string GetUserID()
	{
		return null;
	}

	[Token(Token = "0x6000D5B")]
	[Address(RVA = "0xA37474", Offset = "0xA37474", VA = "0xA37474")]
	public string GetAccessToken()
	{
		return null;
	}

	[Token(Token = "0x6000D5C")]
	[Address(RVA = "0xA37510", Offset = "0xA37510", VA = "0xA37510")]
	public bool IsAuthenticated(double currentTime)
	{
		return default(bool);
	}

	[Token(Token = "0x6000D5D")]
	[Address(RVA = "0xA37588", Offset = "0xA37588", VA = "0xA37588")]
	public bool IsSignedIn()
	{
		return default(bool);
	}

	[Token(Token = "0x6000D5E")]
	[Address(RVA = "0xA375C4", Offset = "0xA375C4", VA = "0xA375C4")]
	public bool IsConnectedToNativeAuth()
	{
		return default(bool);
	}

	[Token(Token = "0x6000D5F")]
	[Address(RVA = "0xA37668", Offset = "0xA37668", VA = "0xA37668")]
	public void SetAuthStatusFailed()
	{
	}

	[Token(Token = "0x6000D60")]
	[Address(RVA = "0xA37674", Offset = "0xA37674", VA = "0xA37674")]
	public void Login(Action<AuthenticationStatus> onComplete, LoginMethod loginMethod)
	{
	}

	[Token(Token = "0x6000D61")]
	[Address(RVA = "0xA379D0", Offset = "0xA379D0", VA = "0xA379D0")]
	private void LoginViaGuest(Action<AuthenticationStatus> onComplete)
	{
	}

	[Token(Token = "0x6000D62")]
	[Address(RVA = "0xA37B00", Offset = "0xA37B00", VA = "0xA37B00")]
	private void LoginViaNativeAuth(Action<AuthenticationStatus> onComplete)
	{
	}

	[Token(Token = "0x6000D63")]
	[Address(RVA = "0xA37BAC", Offset = "0xA37BAC", VA = "0xA37BAC")]
	private void ParseGuestLinkResponse(string response)
	{
	}

	[Token(Token = "0x6000D64")]
	[Address(RVA = "0xA37D1C", Offset = "0xA37D1C", VA = "0xA37D1C")]
	private void ParseLoginResponse(string jsonText, bool success, bool isNativeAuthLogin)
	{
	}

	[Token(Token = "0x6000D65")]
	[Address(RVA = "0xA37E70", Offset = "0xA37E70", VA = "0xA37E70")]
	public void Logout(Action<LogoutResult> onComplete)
	{
	}

	[Token(Token = "0x6000D66")]
	[Address(RVA = "0xA37EFC", Offset = "0xA37EFC", VA = "0xA37EFC")]
	public void UnlinkGuest(Action<bool> onComplete)
	{
	}

	[Token(Token = "0x6000D67")]
	[Address(RVA = "0xA38094", Offset = "0xA38094", VA = "0xA38094")]
	public void LinkGuestAuth(Action<AuthenticationStatus, LinkResult> onComplete)
	{
	}

	[Token(Token = "0x6000D68")]
	[Address(RVA = "0xA381B0", Offset = "0xA381B0", VA = "0xA381B0")]
	public void UnlinkAll(Action<UnlinkResult> onComplete)
	{
	}

	[Token(Token = "0x6000D69")]
	[Address(RVA = "0xA38308", Offset = "0xA38308", VA = "0xA38308")]
	private void OnHothLoginSuccess(string response, bool isNativeAuthLogin)
	{
	}

	[Token(Token = "0x6000D6A")]
	[Address(RVA = "0xA38468", Offset = "0xA38468", VA = "0xA38468")]
	private void OnHothLoginFailure(long statusCode, string response)
	{
	}

	[Token(Token = "0x6000D6B")]
	[Address(RVA = "0xA3866C", Offset = "0xA3866C", VA = "0xA3866C")]
	private void OnHothLinkFailure(long statusCode, string response)
	{
	}

	[Token(Token = "0x6000D6C")]
	[Address(RVA = "0xA38870", Offset = "0xA38870", VA = "0xA38870")]
	private void OnHothLinkSuccess(string response, bool isNativeAuthLogin)
	{
	}

	[Token(Token = "0x6000D6D")]
	[Address(RVA = "0xA389B8", Offset = "0xA389B8", VA = "0xA389B8")]
	private void OnHothUnlinkSuccess(string response, bool isNativeAuthLogin)
	{
	}

	[Token(Token = "0x6000D6E")]
	[Address(RVA = "0xA38AEC", Offset = "0xA38AEC", VA = "0xA38AEC")]
	private void OnHothUnlinkFailure(long statusCode, string response)
	{
	}

	[Token(Token = "0x6000D6F")]
	[Address(RVA = "0xA38430", Offset = "0xA38430", VA = "0xA38430")]
	private void RefreshAPIConfig()
	{
	}

	[Token(Token = "0x6000D70")]
	[Address(RVA = "0xA38CF0", Offset = "0xA38CF0", VA = "0xA38CF0")]
	public void Update(float deltaTime)
	{
	}

	[Token(Token = "0x6000D71")]
	[Address(RVA = "0xA38CF4", Offset = "0xA38CF4", VA = "0xA38CF4")]
	public void RefreshAuthIfNeeded(float deltaTime)
	{
	}

	[Token(Token = "0x6000D72")]
	[Address(RVA = "0xA38FF8", Offset = "0xA38FF8", VA = "0xA38FF8")]
	public void OnApplicationPause(bool paused)
	{
	}

	[Token(Token = "0x6000D73")]
	[Address(RVA = "0xA38E64", Offset = "0xA38E64", VA = "0xA38E64")]
	private void RefreshAuthToken()
	{
	}

	[Token(Token = "0x6000D74")]
	[Address(RVA = "0xA39130", Offset = "0xA39130", VA = "0xA39130")]
	private void OnRefreshComplete(bool success, string responseText)
	{
	}

	[Token(Token = "0x6000D75")]
	[Address(RVA = "0xA38F78", Offset = "0xA38F78", VA = "0xA38F78")]
	private void Reauthenticate()
	{
	}

	[Token(Token = "0x6000D76")]
	[Address(RVA = "0xA39358", Offset = "0xA39358", VA = "0xA39358")]
	private void LoginViaNativeAuthProvider(NativeAuthProvider authProvider, Action<string, Action<string>, Action<long, string>> hothLogin, Action<AuthenticationStatus> onComplete)
	{
	}

	[Token(Token = "0x6000D77")]
	[Address(RVA = "0xA394CC", Offset = "0xA394CC", VA = "0xA394CC")]
	private void LinkNativeAuth(NativeAuthProvider authProvider, Action<string, bool, Action<string>, Action<long, string>> hothLink, Action<AuthenticationStatus, LinkResult> onComplete, bool forced)
	{
	}

	[Token(Token = "0x6000D78")]
	[Address(RVA = "0xA3961C", Offset = "0xA3961C", VA = "0xA3961C")]
	public void InitializeGooglePlayAuthProvider()
	{
	}

	[Token(Token = "0x6000D79")]
	[Address(RVA = "0xA37B0C", Offset = "0xA37B0C", VA = "0xA37B0C")]
	private void LoginViaGooglePlay(Action<AuthenticationStatus> onComplete)
	{
	}

	[Token(Token = "0x6000D7A")]
	[Address(RVA = "0xA3967C", Offset = "0xA3967C", VA = "0xA3967C")]
	public void LinkGooglePlayAuth(Action<AuthenticationStatus, LinkResult> onComplete, bool forced)
	{
	}

	[Token(Token = "0x6000D7B")]
	[Address(RVA = "0xA39724", Offset = "0xA39724", VA = "0xA39724")]
	public void UnlinkGooglePlayAuth(Action<UnlinkResult> onComplete)
	{
	}

	[Token(Token = "0x6000D7C")]
	[Address(RVA = "0xA39848", Offset = "0xA39848", VA = "0xA39848")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8350E0", Offset = "0x8350E0")]
	private void _003CRefreshAuthToken_003Eb__57_0(string responseText)
	{
	}

	[Token(Token = "0x6000D7D")]
	[Address(RVA = "0xA39858", Offset = "0xA39858", VA = "0xA39858")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8350F0", Offset = "0x8350F0")]
	private void _003CRefreshAuthToken_003Eb__57_1(long statusCode, string responseText)
	{
	}

	[Token(Token = "0x6000D7E")]
	[Address(RVA = "0xA39860", Offset = "0xA39860", VA = "0xA39860")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x835100", Offset = "0x835100")]
	private void _003CReauthenticate_003Eb__59_0(AuthenticationStatus status)
	{
	}
}
