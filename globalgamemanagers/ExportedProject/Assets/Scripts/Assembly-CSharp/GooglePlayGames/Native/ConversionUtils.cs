using GooglePlayGames.BasicApi;
using GooglePlayGames.Native.Cwrapper;
using Il2CppDummyDll;

namespace GooglePlayGames.Native
{
	[Token(Token = "0x2000256")]
	internal static class ConversionUtils
	{
		[Token(Token = "0x600113E")]
		[Address(RVA = "0x14683E8", Offset = "0x14683E8", VA = "0x14683E8")]
		internal static ResponseStatus ConvertResponseStatus(CommonErrorStatus.ResponseStatus status)
		{
			return default(ResponseStatus);
		}

		[Token(Token = "0x600113F")]
		[Address(RVA = "0x14684D0", Offset = "0x14684D0", VA = "0x14684D0")]
		internal static CommonStatusCodes ConvertResponseStatusToCommonStatus(CommonErrorStatus.ResponseStatus status)
		{
			return default(CommonStatusCodes);
		}

		[Token(Token = "0x6001140")]
		[Address(RVA = "0x14685BC", Offset = "0x14685BC", VA = "0x14685BC")]
		internal static UIStatus ConvertUIStatus(CommonErrorStatus.UIStatus status)
		{
			return default(UIStatus);
		}

		[Token(Token = "0x6001141")]
		[Address(RVA = "0x14686A4", Offset = "0x14686A4", VA = "0x14686A4")]
		internal static Types.DataSource AsDataSource(DataSource source)
		{
			return default(Types.DataSource);
		}

		[Token(Token = "0x6001142")]
		[Address(RVA = "0x146877C", Offset = "0x146877C", VA = "0x146877C")]
		internal static Types.VideoCaptureMode ConvertVideoCaptureMode(VideoCaptureMode captureMode)
		{
			return default(Types.VideoCaptureMode);
		}

		[Token(Token = "0x6001143")]
		[Address(RVA = "0x1468850", Offset = "0x1468850", VA = "0x1468850")]
		internal static VideoCaptureMode ConvertNativeVideoCaptureMode(Types.VideoCaptureMode nativeCaptureMode)
		{
			return default(VideoCaptureMode);
		}

		[Token(Token = "0x6001144")]
		[Address(RVA = "0x1468924", Offset = "0x1468924", VA = "0x1468924")]
		internal static VideoQualityLevel ConvertNativeVideoQualityLevel(Types.VideoQualityLevel nativeQualityLevel)
		{
			return default(VideoQualityLevel);
		}

		[Token(Token = "0x6001145")]
		[Address(RVA = "0x14689F8", Offset = "0x14689F8", VA = "0x14689F8")]
		internal static VideoCaptureOverlayState ConvertNativeVideoCaptureOverlayState(Types.VideoCaptureOverlayState nativeOverlayState)
		{
			return default(VideoCaptureOverlayState);
		}
	}
}
