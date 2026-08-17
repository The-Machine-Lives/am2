using System;
using System.Runtime.InteropServices;
using GooglePlayGames.Native.Cwrapper;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	[Token(Token = "0x2000267")]
	internal class CaptureOverlayStateListenerHelper : BaseReferenceHolder
	{
		[Token(Token = "0x6001225")]
		[Address(RVA = "0xC734B0", Offset = "0xC734B0", VA = "0xC734B0")]
		internal CaptureOverlayStateListenerHelper(IntPtr selfPointer)
		{
		}

		[Token(Token = "0x6001226")]
		[Address(RVA = "0xC73524", Offset = "0xC73524", VA = "0xC73524", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		[Token(Token = "0x6001227")]
		[Address(RVA = "0xC7085C", Offset = "0xC7085C", VA = "0xC7085C")]
		internal CaptureOverlayStateListenerHelper SetOnCaptureOverlayStateChangedCallback(Action<Types.VideoCaptureOverlayState> callback)
		{
			return null;
		}

		[Token(Token = "0x6001228")]
		[Address(RVA = "0xC73348", Offset = "0xC73348", VA = "0xC73348")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x835E2C", Offset = "0x835E2C")]
		internal static void InternalOnCaptureOverlayStateChangedCallback(Types.VideoCaptureOverlayState response, IntPtr data)
		{
		}

		[Token(Token = "0x6001229")]
		[Address(RVA = "0xC707F0", Offset = "0xC707F0", VA = "0xC707F0")]
		internal static CaptureOverlayStateListenerHelper Create()
		{
			return null;
		}
	}
}
