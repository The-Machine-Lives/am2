using System;
using System.Runtime.InteropServices;
using GooglePlayGames.Native.Cwrapper;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	[Token(Token = "0x200026D")]
	internal class FetchResponse : BaseReferenceHolder
	{
		[Token(Token = "0x600125B")]
		[Address(RVA = "0xC73F88", Offset = "0xC73F88", VA = "0xC73F88")]
		internal FetchResponse(IntPtr selfPointer)
		{
		}

		[Token(Token = "0x600125C")]
		[Address(RVA = "0xC73FFC", Offset = "0xC73FFC", VA = "0xC73FFC", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		[Token(Token = "0x600125D")]
		[Address(RVA = "0xC74014", Offset = "0xC74014", VA = "0xC74014")]
		internal NativeLeaderboard Leaderboard()
		{
			return null;
		}

		[Token(Token = "0x600125E")]
		[Address(RVA = "0xC74034", Offset = "0xC74034", VA = "0xC74034")]
		internal CommonErrorStatus.ResponseStatus GetStatus()
		{
			return default(CommonErrorStatus.ResponseStatus);
		}

		[Token(Token = "0x600125F")]
		[Address(RVA = "0xC7404C", Offset = "0xC7404C", VA = "0xC7404C")]
		internal static FetchResponse FromPointer(IntPtr pointer)
		{
			return null;
		}
	}
}
