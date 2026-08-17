using System;
using System.Runtime.InteropServices;
using GooglePlayGames.Native.Cwrapper;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	[Token(Token = "0x200029B")]
	internal class IsCaptureAvailableResponse : BaseReferenceHolder
	{
		[Token(Token = "0x6001425")]
		[Address(RVA = "0xC760D4", Offset = "0xC760D4", VA = "0xC760D4")]
		internal IsCaptureAvailableResponse(IntPtr selfPointer)
		{
		}

		[Token(Token = "0x6001426")]
		[Address(RVA = "0xC76148", Offset = "0xC76148", VA = "0xC76148", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		[Token(Token = "0x6001427")]
		[Address(RVA = "0xC70D50", Offset = "0xC70D50", VA = "0xC70D50")]
		internal CommonErrorStatus.ResponseStatus GetStatus()
		{
			return default(CommonErrorStatus.ResponseStatus);
		}

		[Token(Token = "0x6001428")]
		[Address(RVA = "0xC70D68", Offset = "0xC70D68", VA = "0xC70D68")]
		internal bool RequestSucceeded()
		{
			return default(bool);
		}

		[Token(Token = "0x6001429")]
		[Address(RVA = "0xC70D8C", Offset = "0xC70D8C", VA = "0xC70D8C")]
		internal bool IsCaptureAvailable()
		{
			return default(bool);
		}

		[Token(Token = "0x600142A")]
		[Address(RVA = "0xC76158", Offset = "0xC76158", VA = "0xC76158")]
		internal static IsCaptureAvailableResponse FromPointer(IntPtr pointer)
		{
			return null;
		}
	}
}
