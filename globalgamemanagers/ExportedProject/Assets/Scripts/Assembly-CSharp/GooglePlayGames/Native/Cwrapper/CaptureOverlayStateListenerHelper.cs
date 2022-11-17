using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	[Token(Token = "0x20002A0")]
	internal static class CaptureOverlayStateListenerHelper
	{
		[Token(Token = "0x2000738")]
		internal delegate void OnCaptureOverlayStateChangedCallback(Types.VideoCaptureOverlayState arg0, IntPtr arg1);

		[PreserveSig]
		[Token(Token = "0x600145D")]
		[Address(RVA = "0x146ECAC", Offset = "0x146ECAC", VA = "0x146ECAC")]
		internal static extern void CaptureOverlayStateListenerHelper_SetOnCaptureOverlayStateChangedCallback(HandleRef self, OnCaptureOverlayStateChangedCallback callback, IntPtr callback_arg);

		[PreserveSig]
		[Token(Token = "0x600145E")]
		[Address(RVA = "0x146ED68", Offset = "0x146ED68", VA = "0x146ED68")]
		internal static extern IntPtr CaptureOverlayStateListenerHelper_Construct();

		[PreserveSig]
		[Token(Token = "0x600145F")]
		[Address(RVA = "0x146EDF4", Offset = "0x146EDF4", VA = "0x146EDF4")]
		internal static extern void CaptureOverlayStateListenerHelper_Dispose(HandleRef self);
	}
}
