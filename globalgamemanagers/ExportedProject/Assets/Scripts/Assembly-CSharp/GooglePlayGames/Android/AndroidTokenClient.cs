using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GooglePlayGames.Android
{
	[Token(Token = "0x20002CC")]
	internal class AndroidTokenClient : TokenClient
	{
		[Token(Token = "0x2000790")]
		private class ResultCallbackProxy : AndroidJavaProxy
		{
			[Token(Token = "0x40021F8")]
			[FieldOffset(Offset = "0x20")]
			private Action<AndroidJavaObject> mCallback;

			[Token(Token = "0x6003167")]
			[Address(RVA = "0x145FC88", Offset = "0x145FC88", VA = "0x145FC88")]
			public ResultCallbackProxy(Action<AndroidJavaObject> callback)
			{
			}

			[Token(Token = "0x6003168")]
			[Address(RVA = "0x145FD10", Offset = "0x145FD10", VA = "0x145FD10")]
			public void onResult(AndroidJavaObject tokenResult)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000791")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820EB8", Offset = "0x820EB8")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x40021F9")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x40021FA")]
			[FieldOffset(Offset = "0x8")]
			public static Action _003C_003E9__21_0;

			[Token(Token = "0x600316A")]
			[Address(RVA = "0x145F824", Offset = "0x145F824", VA = "0x145F824")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x600316B")]
			[Address(RVA = "0x145F82C", Offset = "0x145F82C", VA = "0x145F82C")]
			internal void _003CSignout_003Eb__21_0()
			{
			}
		}

		[Token(Token = "0x2000792")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820EC8", Offset = "0x820EC8")]
		private sealed class _003C_003Ec__DisplayClass25_0
		{
			[Token(Token = "0x40021FB")]
			[FieldOffset(Offset = "0x10")]
			public AndroidTokenClient _003C_003E4__this;

			[Token(Token = "0x40021FC")]
			[FieldOffset(Offset = "0x18")]
			public bool silent;

			[Token(Token = "0x40021FD")]
			[FieldOffset(Offset = "0x20")]
			public Action<int> callback;

			[Token(Token = "0x600316C")]
			[Address(RVA = "0x145F96C", Offset = "0x145F96C", VA = "0x145F96C")]
			public _003C_003Ec__DisplayClass25_0()
			{
			}

			[Token(Token = "0x600316D")]
			[Address(RVA = "0x145F974", Offset = "0x145F974", VA = "0x145F974")]
			internal void _003CFetchTokens_003Eb__0()
			{
			}
		}

		[Token(Token = "0x2000793")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820ED8", Offset = "0x820ED8")]
		private sealed class _003C_003Ec__DisplayClass26_0
		{
			[Token(Token = "0x40021FE")]
			[FieldOffset(Offset = "0x10")]
			public AndroidTokenClient _003C_003E4__this;

			[Token(Token = "0x40021FF")]
			[FieldOffset(Offset = "0x18")]
			public Action<int> callback;

			[Token(Token = "0x600316E")]
			[Address(RVA = "0x145F9C0", Offset = "0x145F9C0", VA = "0x145F9C0")]
			public _003C_003Ec__DisplayClass26_0()
			{
			}

			[Token(Token = "0x600316F")]
			[Address(RVA = "0x145F9C8", Offset = "0x145F9C8", VA = "0x145F9C8")]
			internal void _003CDoFetchToken_003Eb__0(AndroidJavaObject tokenResult)
			{
			}
		}

		[Token(Token = "0x2000794")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820EE8", Offset = "0x820EE8")]
		private sealed class _003C_003Ec__DisplayClass27_0
		{
			[Token(Token = "0x4002200")]
			[FieldOffset(Offset = "0x10")]
			public AndroidTokenClient _003C_003E4__this;

			[Token(Token = "0x4002201")]
			[FieldOffset(Offset = "0x18")]
			public bool reAuthenticateIfNeeded;

			[Token(Token = "0x4002202")]
			[FieldOffset(Offset = "0x20")]
			public Action<string> callback;

			[Token(Token = "0x6003170")]
			[Address(RVA = "0x145FB74", Offset = "0x145FB74", VA = "0x145FB74")]
			public _003C_003Ec__DisplayClass27_0()
			{
			}

			[Token(Token = "0x6003171")]
			[Address(RVA = "0x145FB7C", Offset = "0x145FB7C", VA = "0x145FB7C")]
			internal void _003CGetAnotherServerAuthCode_003Eb__0()
			{
			}
		}

		[Token(Token = "0x2000795")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820EF8", Offset = "0x820EF8")]
		private sealed class _003C_003Ec__DisplayClass28_0
		{
			[Token(Token = "0x4002203")]
			[FieldOffset(Offset = "0x10")]
			public Action<string> callback;

			[Token(Token = "0x6003172")]
			[Address(RVA = "0x145FBC8", Offset = "0x145FBC8", VA = "0x145FBC8")]
			public _003C_003Ec__DisplayClass28_0()
			{
			}

			[Token(Token = "0x6003173")]
			[Address(RVA = "0x145FBD0", Offset = "0x145FBD0", VA = "0x145FBD0")]
			internal void _003CDoGetAnotherServerAuthCode_003Eb__0(AndroidJavaObject tokenResult)
			{
			}
		}

		[Token(Token = "0x4000D2B")]
		private const string TokenFragmentClass = "com.google.games.bridge.TokenFragment";

		[Token(Token = "0x4000D2C")]
		[FieldOffset(Offset = "0x10")]
		private bool requestEmail;

		[Token(Token = "0x4000D2D")]
		[FieldOffset(Offset = "0x11")]
		private bool requestAuthCode;

		[Token(Token = "0x4000D2E")]
		[FieldOffset(Offset = "0x12")]
		private bool requestIdToken;

		[Token(Token = "0x4000D2F")]
		[FieldOffset(Offset = "0x18")]
		private List<string> oauthScopes;

		[Token(Token = "0x4000D30")]
		[FieldOffset(Offset = "0x20")]
		private string webClientId;

		[Token(Token = "0x4000D31")]
		[FieldOffset(Offset = "0x28")]
		private bool forceRefresh;

		[Token(Token = "0x4000D32")]
		[FieldOffset(Offset = "0x29")]
		private bool hidePopups;

		[Token(Token = "0x4000D33")]
		[FieldOffset(Offset = "0x30")]
		private string accountName;

		[Token(Token = "0x4000D34")]
		[FieldOffset(Offset = "0x38")]
		private string email;

		[Token(Token = "0x4000D35")]
		[FieldOffset(Offset = "0x40")]
		private string authCode;

		[Token(Token = "0x4000D36")]
		[FieldOffset(Offset = "0x48")]
		private string idToken;

		[Token(Token = "0x600160E")]
		[Address(RVA = "0x9D8C94", Offset = "0x9D8C94", VA = "0x9D8C94")]
		public static AndroidJavaObject CreateInvisibleView()
		{
			return null;
		}

		[Token(Token = "0x600160F")]
		[Address(RVA = "0x9D8E68", Offset = "0x9D8E68", VA = "0x9D8E68")]
		public static AndroidJavaObject GetActivity()
		{
			return null;
		}

		[Token(Token = "0x6001610")]
		[Address(RVA = "0x9D8FC0", Offset = "0x9D8FC0", VA = "0x9D8FC0", Slot = "9")]
		public void SetRequestAuthCode(bool flag, bool forceRefresh)
		{
		}

		[Token(Token = "0x6001611")]
		[Address(RVA = "0x9D8FD4", Offset = "0x9D8FD4", VA = "0x9D8FD4", Slot = "10")]
		public void SetRequestEmail(bool flag)
		{
		}

		[Token(Token = "0x6001612")]
		[Address(RVA = "0x9D8FE0", Offset = "0x9D8FE0", VA = "0x9D8FE0", Slot = "11")]
		public void SetRequestIdToken(bool flag)
		{
		}

		[Token(Token = "0x6001613")]
		[Address(RVA = "0x9D8FEC", Offset = "0x9D8FEC", VA = "0x9D8FEC", Slot = "12")]
		public void SetWebClientId(string webClientId)
		{
		}

		[Token(Token = "0x6001614")]
		[Address(RVA = "0x9D8FF4", Offset = "0x9D8FF4", VA = "0x9D8FF4", Slot = "15")]
		public void SetHidePopups(bool flag)
		{
		}

		[Token(Token = "0x6001615")]
		[Address(RVA = "0x9D9000", Offset = "0x9D9000", VA = "0x9D9000", Slot = "13")]
		public void SetAccountName(string accountName)
		{
		}

		[Token(Token = "0x6001616")]
		[Address(RVA = "0x9D9008", Offset = "0x9D9008", VA = "0x9D9008", Slot = "14")]
		public void AddOauthScopes(params string[] scopes)
		{
		}

		[Token(Token = "0x6001617")]
		[Address(RVA = "0x9D90B8", Offset = "0x9D90B8", VA = "0x9D90B8", Slot = "8")]
		public void Signout()
		{
		}

		[Token(Token = "0x6001618")]
		[Address(RVA = "0x9D91B8", Offset = "0x9D91B8", VA = "0x9D91B8", Slot = "4")]
		public string GetEmail()
		{
			return null;
		}

		[Token(Token = "0x6001619")]
		[Address(RVA = "0x9D91C0", Offset = "0x9D91C0", VA = "0x9D91C0", Slot = "5")]
		public string GetAuthCode()
		{
			return null;
		}

		[Token(Token = "0x600161A")]
		[Address(RVA = "0x9D91C8", Offset = "0x9D91C8", VA = "0x9D91C8", Slot = "6")]
		public string GetIdToken()
		{
			return null;
		}

		[Token(Token = "0x600161B")]
		[Address(RVA = "0x9D91D0", Offset = "0x9D91D0", VA = "0x9D91D0", Slot = "16")]
		public void FetchTokens(bool silent, Action<int> callback)
		{
		}

		[Token(Token = "0x600161C")]
		[Address(RVA = "0x9D92D4", Offset = "0x9D92D4", VA = "0x9D92D4")]
		private void DoFetchToken(bool silent, Action<int> callback)
		{
		}

		[Token(Token = "0x600161D")]
		[Address(RVA = "0x9D9CA8", Offset = "0x9D9CA8", VA = "0x9D9CA8", Slot = "7")]
		public void GetAnotherServerAuthCode(bool reAuthenticateIfNeeded, Action<string> callback)
		{
		}

		[Token(Token = "0x600161E")]
		[Address(RVA = "0x9D9DAC", Offset = "0x9D9DAC", VA = "0x9D9DAC")]
		private void DoGetAnotherServerAuthCode(bool reAuthenticateIfNeeded, Action<string> callback)
		{
		}

		[Token(Token = "0x600161F")]
		[Address(RVA = "0x9DA768", Offset = "0x9DA768", VA = "0x9DA768")]
		public AndroidTokenClient()
		{
		}
	}
}
