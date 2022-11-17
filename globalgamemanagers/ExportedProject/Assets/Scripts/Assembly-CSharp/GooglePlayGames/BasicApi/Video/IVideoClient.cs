using System;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.Video
{
	[Token(Token = "0x20002E7")]
	public interface IVideoClient
	{
		[Token(Token = "0x60016F1")]
		void GetCaptureCapabilities(Action<ResponseStatus, VideoCapabilities> callback);

		[Token(Token = "0x60016F2")]
		void ShowCaptureOverlay();

		[Token(Token = "0x60016F3")]
		void GetCaptureState(Action<ResponseStatus, VideoCaptureState> callback);

		[Token(Token = "0x60016F4")]
		void IsCaptureAvailable(VideoCaptureMode captureMode, Action<ResponseStatus, bool> callback);

		[Token(Token = "0x60016F5")]
		bool IsCaptureSupported();

		[Token(Token = "0x60016F6")]
		void RegisterCaptureOverlayStateChangedListener(CaptureOverlayStateListener listener);

		[Token(Token = "0x60016F7")]
		void UnregisterCaptureOverlayStateChangedListener();
	}
}
