using System;
using System.Runtime.InteropServices;
using GooglePlayGames.Native.Cwrapper;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	[Token(Token = "0x200026C")]
	internal class FetchScorePageResponse : BaseReferenceHolder
	{
		[Token(Token = "0x6001256")]
		[Address(RVA = "0xC740E8", Offset = "0xC740E8", VA = "0xC740E8")]
		internal FetchScorePageResponse(IntPtr selfPointer)
		{
		}

		[Token(Token = "0x6001257")]
		[Address(RVA = "0xC7415C", Offset = "0xC7415C", VA = "0xC7415C", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		[Token(Token = "0x6001258")]
		[Address(RVA = "0xC74174", Offset = "0xC74174", VA = "0xC74174")]
		internal CommonErrorStatus.ResponseStatus GetStatus()
		{
			return default(CommonErrorStatus.ResponseStatus);
		}

		[Token(Token = "0x6001259")]
		[Address(RVA = "0xC7418C", Offset = "0xC7418C", VA = "0xC7418C")]
		internal NativeScorePage GetScorePage()
		{
			return null;
		}

		[Token(Token = "0x600125A")]
		[Address(RVA = "0xC741AC", Offset = "0xC741AC", VA = "0xC741AC")]
		internal static FetchScorePageResponse FromPointer(IntPtr pointer)
		{
			return null;
		}
	}
}
