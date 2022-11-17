using System;
using System.Runtime.InteropServices;
using GooglePlayGames.Native.Cwrapper;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	[Token(Token = "0x200026E")]
	internal class FetchScoreSummaryResponse : BaseReferenceHolder
	{
		[Token(Token = "0x6001260")]
		[Address(RVA = "0xC74248", Offset = "0xC74248", VA = "0xC74248")]
		internal FetchScoreSummaryResponse(IntPtr selfPointer)
		{
		}

		[Token(Token = "0x6001261")]
		[Address(RVA = "0xC742BC", Offset = "0xC742BC", VA = "0xC742BC", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		[Token(Token = "0x6001262")]
		[Address(RVA = "0xC742CC", Offset = "0xC742CC", VA = "0xC742CC")]
		internal CommonErrorStatus.ResponseStatus GetStatus()
		{
			return default(CommonErrorStatus.ResponseStatus);
		}

		[Token(Token = "0x6001263")]
		[Address(RVA = "0xC742E4", Offset = "0xC742E4", VA = "0xC742E4")]
		internal NativeScoreSummary GetScoreSummary()
		{
			return null;
		}

		[Token(Token = "0x6001264")]
		[Address(RVA = "0xC74304", Offset = "0xC74304", VA = "0xC74304")]
		internal static FetchScoreSummaryResponse FromPointer(IntPtr pointer)
		{
			return null;
		}
	}
}
