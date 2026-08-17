using System;
using System.Runtime.InteropServices;
using GooglePlayGames.Native.Cwrapper;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	[Token(Token = "0x200029A")]
	internal class GetCaptureStateResponse : BaseReferenceHolder
	{
		[Token(Token = "0x600141F")]
		[Address(RVA = "0xC75FAC", Offset = "0xC75FAC", VA = "0xC75FAC")]
		internal GetCaptureStateResponse(IntPtr selfPointer)
		{
		}

		[Token(Token = "0x6001420")]
		[Address(RVA = "0xC76020", Offset = "0xC76020", VA = "0xC76020", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		[Token(Token = "0x6001421")]
		[Address(RVA = "0xC70C2C", Offset = "0xC70C2C", VA = "0xC70C2C")]
		internal NativeVideoCaptureState GetData()
		{
			return null;
		}

		[Token(Token = "0x6001422")]
		[Address(RVA = "0xC70BF0", Offset = "0xC70BF0", VA = "0xC70BF0")]
		internal CommonErrorStatus.ResponseStatus GetStatus()
		{
			return default(CommonErrorStatus.ResponseStatus);
		}

		[Token(Token = "0x6001423")]
		[Address(RVA = "0xC70C08", Offset = "0xC70C08", VA = "0xC70C08")]
		internal bool RequestSucceeded()
		{
			return default(bool);
		}

		[Token(Token = "0x6001424")]
		[Address(RVA = "0xC76038", Offset = "0xC76038", VA = "0xC76038")]
		internal static GetCaptureStateResponse FromPointer(IntPtr pointer)
		{
			return null;
		}
	}
}
