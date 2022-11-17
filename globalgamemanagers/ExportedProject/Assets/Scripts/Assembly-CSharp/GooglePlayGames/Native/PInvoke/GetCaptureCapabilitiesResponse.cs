using System;
using System.Runtime.InteropServices;
using GooglePlayGames.Native.Cwrapper;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	[Token(Token = "0x2000299")]
	internal class GetCaptureCapabilitiesResponse : BaseReferenceHolder
	{
		[Token(Token = "0x6001419")]
		[Address(RVA = "0xC75E84", Offset = "0xC75E84", VA = "0xC75E84")]
		internal GetCaptureCapabilitiesResponse(IntPtr selfPointer)
		{
		}

		[Token(Token = "0x600141A")]
		[Address(RVA = "0xC75EF8", Offset = "0xC75EF8", VA = "0xC75EF8", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		[Token(Token = "0x600141B")]
		[Address(RVA = "0xC70A7C", Offset = "0xC70A7C", VA = "0xC70A7C")]
		internal CommonErrorStatus.ResponseStatus GetStatus()
		{
			return default(CommonErrorStatus.ResponseStatus);
		}

		[Token(Token = "0x600141C")]
		[Address(RVA = "0xC70A94", Offset = "0xC70A94", VA = "0xC70A94")]
		internal bool RequestSucceeded()
		{
			return default(bool);
		}

		[Token(Token = "0x600141D")]
		[Address(RVA = "0xC70AB8", Offset = "0xC70AB8", VA = "0xC70AB8")]
		internal NativeVideoCapabilities GetData()
		{
			return null;
		}

		[Token(Token = "0x600141E")]
		[Address(RVA = "0xC75F10", Offset = "0xC75F10", VA = "0xC75F10")]
		internal static GetCaptureCapabilitiesResponse FromPointer(IntPtr pointer)
		{
			return null;
		}
	}
}
