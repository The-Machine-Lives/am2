using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	[Token(Token = "0x20002CA")]
	internal static class VideoCaptureState
	{
		[PreserveSig]
		[Token(Token = "0x60015F7")]
		[Address(RVA = "0x13307BC", Offset = "0x13307BC", VA = "0x13307BC")]
		internal static extern bool VideoCaptureState_IsCapturing(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60015F8")]
		[Address(RVA = "0x1330860", Offset = "0x1330860", VA = "0x1330860")]
		internal static extern Types.VideoCaptureMode VideoCaptureState_CaptureMode(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60015F9")]
		[Address(RVA = "0x13308FC", Offset = "0x13308FC", VA = "0x13308FC")]
		internal static extern Types.VideoQualityLevel VideoCaptureState_QualityLevel(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60015FA")]
		[Address(RVA = "0x1330998", Offset = "0x1330998", VA = "0x1330998")]
		internal static extern bool VideoCaptureState_IsOverlayVisible(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60015FB")]
		[Address(RVA = "0x1330A3C", Offset = "0x1330A3C", VA = "0x1330A3C")]
		internal static extern bool VideoCaptureState_IsPaused(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60015FC")]
		[Address(RVA = "0x1330AE0", Offset = "0x1330AE0", VA = "0x1330AE0")]
		internal static extern void VideoCaptureState_Dispose(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60015FD")]
		[Address(RVA = "0x1330B7C", Offset = "0x1330B7C", VA = "0x1330B7C")]
		internal static extern bool VideoCaptureState_Valid(HandleRef self);
	}
}
