using System;
using System.Runtime.InteropServices;
using GooglePlayGames.Native.Cwrapper;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	[Token(Token = "0x200026A")]
	internal class GameServicesBuilder : BaseReferenceHolder
	{
		[Token(Token = "0x2000709")]
		internal delegate void AuthFinishedCallback(Types.AuthOperation operation, CommonErrorStatus.AuthStatus status);

		[Token(Token = "0x200070A")]
		internal delegate void AuthStartedCallback(Types.AuthOperation operation);

		[Token(Token = "0x600123A")]
		[Address(RVA = "0xC74E18", Offset = "0xC74E18", VA = "0xC74E18")]
		private GameServicesBuilder(IntPtr selfPointer)
		{
		}

		[Token(Token = "0x600123B")]
		[Address(RVA = "0xC74EA8", Offset = "0xC74EA8", VA = "0xC74EA8")]
		internal void SetOnAuthFinishedCallback(AuthFinishedCallback callback)
		{
		}

		[Token(Token = "0x600123C")]
		[Address(RVA = "0xC74F6C", Offset = "0xC74F6C", VA = "0xC74F6C")]
		internal void EnableSnapshots()
		{
		}

		[Token(Token = "0x600123D")]
		[Address(RVA = "0xC74F84", Offset = "0xC74F84", VA = "0xC74F84")]
		internal void AddOauthScope(string scope)
		{
		}

		[Token(Token = "0x600123E")]
		[Address(RVA = "0xC74664", Offset = "0xC74664", VA = "0xC74664")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x835F58", Offset = "0x835F58")]
		private static void InternalAuthFinishedCallback(Types.AuthOperation op, CommonErrorStatus.AuthStatus status, IntPtr data)
		{
		}

		[Token(Token = "0x600123F")]
		[Address(RVA = "0xC75414", Offset = "0xC75414", VA = "0xC75414")]
		internal void SetOnAuthStartedCallback(AuthStartedCallback callback)
		{
		}

		[Token(Token = "0x6001240")]
		[Address(RVA = "0xC747BC", Offset = "0xC747BC", VA = "0xC747BC")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x835FBC", Offset = "0x835FBC")]
		private static void InternalAuthStartedCallback(Types.AuthOperation op, IntPtr data)
		{
		}

		[Token(Token = "0x6001241")]
		[Address(RVA = "0xC75918", Offset = "0xC75918", VA = "0xC75918")]
		internal void SetShowConnectingPopup(bool flag)
		{
		}

		[Token(Token = "0x6001242")]
		[Address(RVA = "0xC75940", Offset = "0xC75940", VA = "0xC75940", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		[Token(Token = "0x6001243")]
		[Address(RVA = "0xC7490C", Offset = "0xC7490C", VA = "0xC7490C")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x836020", Offset = "0x836020")]
		private static void InternalOnTurnBasedMatchEventCallback(Types.MultiplayerEvent eventType, string matchId, IntPtr match, IntPtr userData)
		{
		}

		[Token(Token = "0x6001244")]
		[Address(RVA = "0xC75950", Offset = "0xC75950", VA = "0xC75950")]
		internal void SetOnTurnBasedMatchEventCallback(Action<Types.MultiplayerEvent, string, NativeTurnBasedMatch> callback)
		{
		}

		[Token(Token = "0x6001245")]
		[Address(RVA = "0xC74B94", Offset = "0xC74B94", VA = "0xC74B94")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x836084", Offset = "0x836084")]
		private static void InternalOnMultiplayerInvitationEventCallback(Types.MultiplayerEvent eventType, string matchId, IntPtr match, IntPtr userData)
		{
		}

		[Token(Token = "0x6001246")]
		[Address(RVA = "0xC75AAC", Offset = "0xC75AAC", VA = "0xC75AAC")]
		internal void SetOnMultiplayerInvitationEventCallback(Action<Types.MultiplayerEvent, string, MultiplayerInvitation> callback)
		{
		}

		[Token(Token = "0x6001247")]
		[Address(RVA = "0xC75B74", Offset = "0xC75B74", VA = "0xC75B74")]
		internal GameServices Build(PlatformConfiguration configRef)
		{
			return null;
		}

		[Token(Token = "0x6001248")]
		[Address(RVA = "0xC75CAC", Offset = "0xC75CAC", VA = "0xC75CAC")]
		internal static GameServicesBuilder Create()
		{
			return null;
		}
	}
}
