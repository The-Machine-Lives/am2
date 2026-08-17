using System;
using Il2CppDummyDll;
using Uken.Core;
using Uken.Library.Network;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x20004A4")]
	public class UkenAuth : UkenController
	{
		[Token(Token = "0x200081D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821318", Offset = "0x821318")]
		private sealed class _003C_003Ec__DisplayClass27_0
		{
			[Token(Token = "0x4002355")]
			[FieldOffset(Offset = "0x10")]
			public UkenAuth _003C_003E4__this;

			[Token(Token = "0x4002356")]
			[FieldOffset(Offset = "0x18")]
			public Action<AuthenticationStatus> onComplete;

			[Token(Token = "0x60032F2")]
			[Address(RVA = "0xA9C064", Offset = "0xA9C064", VA = "0xA9C064")]
			public _003C_003Ec__DisplayClass27_0()
			{
			}

			[Token(Token = "0x60032F3")]
			[Address(RVA = "0xA9C76C", Offset = "0xA9C76C", VA = "0xA9C76C")]
			internal void _003CInitialGooglePlayLogin_003Eb__0(AuthenticationStatus authStatus)
			{
			}
		}

		[Token(Token = "0x400155C")]
		private const string c_hasSeenAppleSignIn = "seen_apple_sign_in";

		[Token(Token = "0x400155D")]
		private const string c_hasLaunchedVersion1Key = "has_launched_1.0";

		[Token(Token = "0x400155E")]
		[FieldOffset(Offset = "0x18")]
		private AuthController m_authController;

		[Token(Token = "0x400155F")]
		[FieldOffset(Offset = "0x20")]
		private PIIScrubberController m_piiScrubberController;

		[Token(Token = "0x4001560")]
		[FieldOffset(Offset = "0x28")]
		private GooglePlayFileController m_googlePlayFileController;

		[Token(Token = "0x4001561")]
		[FieldOffset(Offset = "0x30")]
		private bool m_bContentLoaded;

		[Token(Token = "0x4001562")]
		[FieldOffset(Offset = "0x38")]
		private string m_endpoint;

		[Token(Token = "0x4001563")]
		[FieldOffset(Offset = "0x40")]
		private Action<WebRequest> m_webInterface;

		[Token(Token = "0x4001564")]
		private const string m_facebookLoginRoute = "/login/facebook";

		[Token(Token = "0x4001565")]
		private const string m_facebookLinkRoute = "/link/facebook";

		[Token(Token = "0x4001566")]
		private const string m_guestUnlinkRoute = "/unlink/guest";

		[Token(Token = "0x4001567")]
		private const string m_facebookUnlinkRoute = "/unlink/facebook";

		[Token(Token = "0x4001568")]
		private const string m_guestLinkRoute = "/link/guest";

		[Token(Token = "0x4001569")]
		private const string m_guestLoginRoute = "/login/guest";

		[Token(Token = "0x400156A")]
		private const string m_refreshTokenRoute = "/refresh";

		[Token(Token = "0x170005E8")]
		public AuthenticationStatus authenticationStatus
		{
			[Token(Token = "0x6002232")]
			[Address(RVA = "0xA9B978", Offset = "0xA9B978", VA = "0xA9B978")]
			get
			{
				return default(AuthenticationStatus);
			}
		}

		[Token(Token = "0x6002233")]
		[Address(RVA = "0xA9B98C", Offset = "0xA9B98C", VA = "0xA9B98C")]
		public static bool HasSeenAppleSignIn()
		{
			return default(bool);
		}

		[Token(Token = "0x6002234")]
		[Address(RVA = "0xA9B9E8", Offset = "0xA9B9E8", VA = "0xA9B9E8")]
		public static void SetHasSeenAppleSignIn()
		{
		}

		[Token(Token = "0x6002235")]
		[Address(RVA = "0xA9BA38", Offset = "0xA9BA38", VA = "0xA9BA38")]
		public UkenAuth(string endpoint, string piiEndPoint, string scruAPIKey, Action<WebRequest> webInterfaceCB, string credentialFilePath, GooglePlayFileController googlePlayFileController, INetworkStatus networkStatus)
		{
		}

		[Token(Token = "0x6002236")]
		[Address(RVA = "0xA9BB50", Offset = "0xA9BB50", VA = "0xA9BB50")]
		public int GetUserCreationTime()
		{
			return default(int);
		}

		[Token(Token = "0x6002237")]
		[Address(RVA = "0xA9BB80", Offset = "0xA9BB80", VA = "0xA9BB80", Slot = "5")]
		public override bool LoadContent()
		{
			return default(bool);
		}

		[Token(Token = "0x6002238")]
		[Address(RVA = "0xA9BBBC", Offset = "0xA9BBBC", VA = "0xA9BBBC")]
		public string GetNativeUserName()
		{
			return null;
		}

		[Token(Token = "0x6002239")]
		[Address(RVA = "0xA9BD14", Offset = "0xA9BD14", VA = "0xA9BD14")]
		public string GetAccessToken()
		{
			return null;
		}

		[Token(Token = "0x600223A")]
		[Address(RVA = "0xA9BD44", Offset = "0xA9BD44", VA = "0xA9BD44")]
		public string GetUserID()
		{
			return null;
		}

		[Token(Token = "0x600223B")]
		[Address(RVA = "0xA9BD74", Offset = "0xA9BD74", VA = "0xA9BD74")]
		public long GetLoginTime()
		{
			return default(long);
		}

		[Token(Token = "0x600223C")]
		[Address(RVA = "0xA9BDA4", Offset = "0xA9BDA4", VA = "0xA9BDA4")]
		public void Login(Action<AuthenticationStatus> onComplete, LoginMethod loginMethod)
		{
		}

		[Token(Token = "0x600223D")]
		[Address(RVA = "0xA9BED0", Offset = "0xA9BED0", VA = "0xA9BED0")]
		private bool InitialGooglePlayLogin(Action<AuthenticationStatus> onComplete, LoginMethod loginMethod)
		{
			return default(bool);
		}

		[Token(Token = "0x600223E")]
		[Address(RVA = "0xA9C05C", Offset = "0xA9C05C", VA = "0xA9C05C")]
		private bool InitialAppleSignInLogin(Action<AuthenticationStatus> onComplete, LoginMethod loginMethod)
		{
			return default(bool);
		}

		[Token(Token = "0x600223F")]
		[Address(RVA = "0xA9C06C", Offset = "0xA9C06C", VA = "0xA9C06C")]
		public void LinkNativeAuth(Action<AuthenticationStatus, LinkResult> onComplete, bool forced)
		{
		}

		[Token(Token = "0x6002240")]
		[Address(RVA = "0xA9C0B4", Offset = "0xA9C0B4", VA = "0xA9C0B4")]
		public bool IsAuthenticated(double currentTime)
		{
			return default(bool);
		}

		[Token(Token = "0x6002241")]
		[Address(RVA = "0xA9C0F4", Offset = "0xA9C0F4", VA = "0xA9C0F4")]
		public bool IsSignedIn()
		{
			return default(bool);
		}

		[Token(Token = "0x6002242")]
		[Address(RVA = "0xA9C124", Offset = "0xA9C124", VA = "0xA9C124")]
		public void LinkGuest(Action<AuthenticationStatus, LinkResult> onComplete)
		{
		}

		[Token(Token = "0x6002243")]
		[Address(RVA = "0xA9C204", Offset = "0xA9C204", VA = "0xA9C204")]
		public void UnlinkGuest(Action<bool> onComplete)
		{
		}

		[Token(Token = "0x6002244")]
		[Address(RVA = "0xA9C2E0", Offset = "0xA9C2E0", VA = "0xA9C2E0")]
		public void UnlinkNativeAuth(Action<UnlinkResult> onComplete)
		{
		}

		[Token(Token = "0x6002245")]
		[Address(RVA = "0xA9C3BC", Offset = "0xA9C3BC", VA = "0xA9C3BC")]
		public void UnlinkAll(Action<UnlinkResult> onComplete)
		{
		}

		[Token(Token = "0x6002246")]
		[Address(RVA = "0xA9C498", Offset = "0xA9C498", VA = "0xA9C498")]
		public void Logout(Action<LogoutResult> onComplete)
		{
		}

		[Token(Token = "0x6002247")]
		[Address(RVA = "0xA9C574", Offset = "0xA9C574", VA = "0xA9C574")]
		public void ScrubUser(Action<bool> onComplete)
		{
		}

		[Token(Token = "0x6002248")]
		[Address(RVA = "0xA9C5E8", Offset = "0xA9C5E8", VA = "0xA9C5E8")]
		public bool IsNativeAuthAccount()
		{
			return default(bool);
		}

		[Token(Token = "0x6002249")]
		[Address(RVA = "0xA9C618", Offset = "0xA9C618", VA = "0xA9C618")]
		public bool IsConnectedToNativeAuth()
		{
			return default(bool);
		}

		[Token(Token = "0x600224A")]
		[Address(RVA = "0xA9C6BC", Offset = "0xA9C6BC", VA = "0xA9C6BC", Slot = "7")]
		public override void Update(float deltaTime)
		{
		}

		[Token(Token = "0x600224B")]
		[Address(RVA = "0xA9C720", Offset = "0xA9C720", VA = "0xA9C720")]
		public void OnApplicationPause(bool bPause)
		{
		}
	}
}
