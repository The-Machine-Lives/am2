using System;
using GooglePlayGames.BasicApi;
using GooglePlayGames.BasicApi.Video;
using GooglePlayGames.Native.Cwrapper;
using GooglePlayGames.Native.PInvoke;
using Il2CppDummyDll;

namespace GooglePlayGames.Native
{
	[Token(Token = "0x200025F")]
	internal class NativeVideoClient : IVideoClient
	{
		[Token(Token = "0x20006F3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820D28", Offset = "0x820D28")]
		private sealed class _003C_003Ec__DisplayClass2_0
		{
			[Token(Token = "0x40020DB")]
			[FieldOffset(Offset = "0x10")]
			public Action<ResponseStatus, GooglePlayGames.BasicApi.Video.VideoCapabilities> callback;

			[Token(Token = "0x40020DC")]
			[FieldOffset(Offset = "0x18")]
			public NativeVideoClient _003C_003E4__this;

			[Token(Token = "0x6002F80")]
			[Address(RVA = "0xC6FF48", Offset = "0xC6FF48", VA = "0xC6FF48")]
			public _003C_003Ec__DisplayClass2_0()
			{
			}

			[Token(Token = "0x6002F81")]
			[Address(RVA = "0xC70960", Offset = "0xC70960", VA = "0xC70960")]
			internal void _003CGetCaptureCapabilities_003Eb__0(GetCaptureCapabilitiesResponse response)
			{
			}
		}

		[Token(Token = "0x20006F4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820D38", Offset = "0x820D38")]
		private sealed class _003C_003Ec__DisplayClass5_0
		{
			[Token(Token = "0x40020DD")]
			[FieldOffset(Offset = "0x10")]
			public Action<ResponseStatus, GooglePlayGames.BasicApi.Video.VideoCaptureState> callback;

			[Token(Token = "0x40020DE")]
			[FieldOffset(Offset = "0x18")]
			public NativeVideoClient _003C_003E4__this;

			[Token(Token = "0x6002F82")]
			[Address(RVA = "0xC703DC", Offset = "0xC703DC", VA = "0xC703DC")]
			public _003C_003Ec__DisplayClass5_0()
			{
			}

			[Token(Token = "0x6002F83")]
			[Address(RVA = "0xC70AD8", Offset = "0xC70AD8", VA = "0xC70AD8")]
			internal void _003CGetCaptureState_003Eb__0(GetCaptureStateResponse response)
			{
			}
		}

		[Token(Token = "0x20006F5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820D48", Offset = "0x820D48")]
		private sealed class _003C_003Ec__DisplayClass7_0
		{
			[Token(Token = "0x40020DF")]
			[FieldOffset(Offset = "0x10")]
			public Action<ResponseStatus, bool> callback;

			[Token(Token = "0x6002F84")]
			[Address(RVA = "0xC70698", Offset = "0xC70698", VA = "0xC70698")]
			public _003C_003Ec__DisplayClass7_0()
			{
			}

			[Token(Token = "0x6002F85")]
			[Address(RVA = "0xC70C4C", Offset = "0xC70C4C", VA = "0xC70C4C")]
			internal void _003CIsCaptureAvailable_003Eb__0(IsCaptureAvailableResponse response)
			{
			}
		}

		[Token(Token = "0x20006F6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820D58", Offset = "0x820D58")]
		private sealed class _003C_003Ec__DisplayClass9_0
		{
			[Token(Token = "0x40020E0")]
			[FieldOffset(Offset = "0x10")]
			public CaptureOverlayStateListener listener;

			[Token(Token = "0x6002F86")]
			[Address(RVA = "0xC707E8", Offset = "0xC707E8", VA = "0xC707E8")]
			public _003C_003Ec__DisplayClass9_0()
			{
			}

			[Token(Token = "0x6002F87")]
			[Address(RVA = "0xC70DA4", Offset = "0xC70DA4", VA = "0xC70DA4")]
			internal void _003CRegisterCaptureOverlayStateChangedListener_003Eb__0(Types.VideoCaptureOverlayState response)
			{
			}
		}

		[Token(Token = "0x4000D11")]
		[FieldOffset(Offset = "0x10")]
		private readonly GooglePlayGames.Native.PInvoke.VideoManager mManager;

		[Token(Token = "0x60011DE")]
		[Address(RVA = "0xC6FD78", Offset = "0xC6FD78", VA = "0xC6FD78")]
		internal NativeVideoClient(GooglePlayGames.Native.PInvoke.VideoManager manager)
		{
		}

		[Token(Token = "0x60011DF")]
		[Address(RVA = "0xC6FDE8", Offset = "0xC6FDE8", VA = "0xC6FDE8", Slot = "4")]
		public void GetCaptureCapabilities(Action<ResponseStatus, GooglePlayGames.BasicApi.Video.VideoCapabilities> callback)
		{
		}

		[Token(Token = "0x60011E0")]
		[Address(RVA = "0xC6FF50", Offset = "0xC6FF50", VA = "0xC6FF50")]
		private GooglePlayGames.BasicApi.Video.VideoCapabilities FromNativeVideoCapabilities(NativeVideoCapabilities capabilities)
		{
			return null;
		}

		[Token(Token = "0x60011E1")]
		[Address(RVA = "0xC7024C", Offset = "0xC7024C", VA = "0xC7024C", Slot = "5")]
		public void ShowCaptureOverlay()
		{
		}

		[Token(Token = "0x60011E2")]
		[Address(RVA = "0xC7027C", Offset = "0xC7027C", VA = "0xC7027C", Slot = "6")]
		public void GetCaptureState(Action<ResponseStatus, GooglePlayGames.BasicApi.Video.VideoCaptureState> callback)
		{
		}

		[Token(Token = "0x60011E3")]
		[Address(RVA = "0xC703E4", Offset = "0xC703E4", VA = "0xC703E4")]
		private GooglePlayGames.BasicApi.Video.VideoCaptureState FromNativeVideoCaptureState(NativeVideoCaptureState captureState)
		{
			return null;
		}

		[Token(Token = "0x60011E4")]
		[Address(RVA = "0xC70528", Offset = "0xC70528", VA = "0xC70528", Slot = "7")]
		public void IsCaptureAvailable(VideoCaptureMode captureMode, Action<ResponseStatus, bool> callback)
		{
		}

		[Token(Token = "0x60011E5")]
		[Address(RVA = "0xC706A0", Offset = "0xC706A0", VA = "0xC706A0", Slot = "8")]
		public bool IsCaptureSupported()
		{
			return default(bool);
		}

		[Token(Token = "0x60011E6")]
		[Address(RVA = "0xC706D0", Offset = "0xC706D0", VA = "0xC706D0", Slot = "9")]
		public void RegisterCaptureOverlayStateChangedListener(CaptureOverlayStateListener listener)
		{
		}

		[Token(Token = "0x60011E7")]
		[Address(RVA = "0xC70930", Offset = "0xC70930", VA = "0xC70930", Slot = "10")]
		public void UnregisterCaptureOverlayStateChangedListener()
		{
		}
	}
}
