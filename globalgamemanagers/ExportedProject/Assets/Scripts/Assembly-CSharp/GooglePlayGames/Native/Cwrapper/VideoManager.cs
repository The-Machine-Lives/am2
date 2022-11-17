using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	[Token(Token = "0x20002CB")]
	internal static class VideoManager
	{
		[Token(Token = "0x200078D")]
		internal delegate void CaptureCapabilitiesCallback(IntPtr arg0, IntPtr arg1);

		[Token(Token = "0x200078E")]
		internal delegate void CaptureStateCallback(IntPtr arg0, IntPtr arg1);

		[Token(Token = "0x200078F")]
		internal delegate void IsCaptureAvailableCallback(IntPtr arg0, IntPtr arg1);

		[PreserveSig]
		[Token(Token = "0x60015FE")]
		[Address(RVA = "0x1330C20", Offset = "0x1330C20", VA = "0x1330C20")]
		internal static extern void VideoManager_GetCaptureCapabilities(HandleRef self, CaptureCapabilitiesCallback callback, IntPtr callback_arg);

		[PreserveSig]
		[Token(Token = "0x60015FF")]
		[Address(RVA = "0x1330CDC", Offset = "0x1330CDC", VA = "0x1330CDC")]
		internal static extern void VideoManager_ShowCaptureOverlay(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001600")]
		[Address(RVA = "0x1330D78", Offset = "0x1330D78", VA = "0x1330D78")]
		internal static extern void VideoManager_GetCaptureState(HandleRef self, CaptureStateCallback callback, IntPtr callback_arg);

		[PreserveSig]
		[Token(Token = "0x6001601")]
		[Address(RVA = "0x1330E34", Offset = "0x1330E34", VA = "0x1330E34")]
		internal static extern void VideoManager_IsCaptureAvailable(HandleRef self, Types.VideoCaptureMode capture_mode, IsCaptureAvailableCallback callback, IntPtr callback_arg);

		[PreserveSig]
		[Token(Token = "0x6001602")]
		[Address(RVA = "0x1330F00", Offset = "0x1330F00", VA = "0x1330F00")]
		internal static extern bool VideoManager_IsCaptureSupported(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001603")]
		[Address(RVA = "0x1330FA4", Offset = "0x1330FA4", VA = "0x1330FA4")]
		internal static extern void VideoManager_RegisterCaptureOverlayStateChangedListener(HandleRef self, IntPtr helper);

		[PreserveSig]
		[Token(Token = "0x6001604")]
		[Address(RVA = "0x1331050", Offset = "0x1331050", VA = "0x1331050")]
		internal static extern void VideoManager_UnregisterCaptureOverlayStateChangedListener(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001605")]
		[Address(RVA = "0x13310EC", Offset = "0x13310EC", VA = "0x13310EC")]
		internal static extern void VideoManager_GetCaptureCapabilitiesResponse_Dispose(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001606")]
		[Address(RVA = "0x1331188", Offset = "0x1331188", VA = "0x1331188")]
		internal static extern CommonErrorStatus.ResponseStatus VideoManager_GetCaptureCapabilitiesResponse_GetStatus(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001607")]
		[Address(RVA = "0x1331224", Offset = "0x1331224", VA = "0x1331224")]
		internal static extern IntPtr VideoManager_GetCaptureCapabilitiesResponse_GetVideoCapabilities(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001608")]
		[Address(RVA = "0x13312C0", Offset = "0x13312C0", VA = "0x13312C0")]
		internal static extern void VideoManager_GetCaptureStateResponse_Dispose(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001609")]
		[Address(RVA = "0x133135C", Offset = "0x133135C", VA = "0x133135C")]
		internal static extern CommonErrorStatus.ResponseStatus VideoManager_GetCaptureStateResponse_GetStatus(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x600160A")]
		[Address(RVA = "0x13313F8", Offset = "0x13313F8", VA = "0x13313F8")]
		internal static extern IntPtr VideoManager_GetCaptureStateResponse_GetVideoCaptureState(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x600160B")]
		[Address(RVA = "0x1331494", Offset = "0x1331494", VA = "0x1331494")]
		internal static extern void VideoManager_IsCaptureAvailableResponse_Dispose(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x600160C")]
		[Address(RVA = "0x1331530", Offset = "0x1331530", VA = "0x1331530")]
		internal static extern CommonErrorStatus.ResponseStatus VideoManager_IsCaptureAvailableResponse_GetStatus(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x600160D")]
		[Address(RVA = "0x13315CC", Offset = "0x13315CC", VA = "0x13315CC")]
		internal static extern bool VideoManager_IsCaptureAvailableResponse_GetIsCaptureAvailable(HandleRef self);
	}
}
