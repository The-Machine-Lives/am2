using System;
using GooglePlayGames.Native.Cwrapper;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	[Token(Token = "0x2000298")]
	internal class VideoManager
	{
		[Token(Token = "0x4000D29")]
		[FieldOffset(Offset = "0x10")]
		private readonly GameServices mServices;

		[Token(Token = "0x170002AD")]
		internal int NumCaptureModes
		{
			[Token(Token = "0x600140D")]
			[Address(RVA = "0xE6AF70", Offset = "0xE6AF70", VA = "0xE6AF70")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170002AE")]
		internal int NumQualityLevels
		{
			[Token(Token = "0x600140E")]
			[Address(RVA = "0xE6AF78", Offset = "0xE6AF78", VA = "0xE6AF78")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600140C")]
		[Address(RVA = "0xE6AF00", Offset = "0xE6AF00", VA = "0xE6AF00")]
		internal VideoManager(GameServices services)
		{
		}

		[Token(Token = "0x600140F")]
		[Address(RVA = "0xE6AF80", Offset = "0xE6AF80", VA = "0xE6AF80")]
		internal void GetCaptureCapabilities(Action<GetCaptureCapabilitiesResponse> callback)
		{
		}

		[Token(Token = "0x6001410")]
		[Address(RVA = "0xE6AD68", Offset = "0xE6AD68", VA = "0xE6AD68")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x8372A4", Offset = "0x8372A4")]
		internal static void InternalCaptureCapabilitiesCallback(IntPtr response, IntPtr data)
		{
		}

		[Token(Token = "0x6001411")]
		[Address(RVA = "0xE6B0A4", Offset = "0xE6B0A4", VA = "0xE6B0A4")]
		internal void ShowCaptureOverlay()
		{
		}

		[Token(Token = "0x6001412")]
		[Address(RVA = "0xE6B0DC", Offset = "0xE6B0DC", VA = "0xE6B0DC")]
		internal void GetCaptureState(Action<GetCaptureStateResponse> callback)
		{
		}

		[Token(Token = "0x6001413")]
		[Address(RVA = "0xE6ADF0", Offset = "0xE6ADF0", VA = "0xE6ADF0")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x837308", Offset = "0x837308")]
		internal static void InternalCaptureStateCallback(IntPtr response, IntPtr data)
		{
		}

		[Token(Token = "0x6001414")]
		[Address(RVA = "0xE6B200", Offset = "0xE6B200", VA = "0xE6B200")]
		internal void IsCaptureAvailable(Types.VideoCaptureMode captureMode, Action<IsCaptureAvailableResponse> callback)
		{
		}

		[Token(Token = "0x6001415")]
		[Address(RVA = "0xE6AE78", Offset = "0xE6AE78", VA = "0xE6AE78")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x83736C", Offset = "0x83736C")]
		internal static void InternalIsCaptureAvailableCallback(IntPtr response, IntPtr data)
		{
		}

		[Token(Token = "0x6001416")]
		[Address(RVA = "0xE6B32C", Offset = "0xE6B32C", VA = "0xE6B32C")]
		internal bool IsCaptureSupported()
		{
			return default(bool);
		}

		[Token(Token = "0x6001417")]
		[Address(RVA = "0xE6B364", Offset = "0xE6B364", VA = "0xE6B364")]
		internal void RegisterCaptureOverlayStateChangedListener(CaptureOverlayStateListenerHelper helper)
		{
		}

		[Token(Token = "0x6001418")]
		[Address(RVA = "0xE6B3D4", Offset = "0xE6B3D4", VA = "0xE6B3D4")]
		internal void UnregisterCaptureOverlayStateChangedListener()
		{
		}
	}
}
