using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	[Token(Token = "0x20002C9")]
	internal static class VideoCapabilities
	{
		[PreserveSig]
		[Token(Token = "0x60015F0")]
		[Address(RVA = "0x1330328", Offset = "0x1330328", VA = "0x1330328")]
		internal static extern bool VideoCapabilities_IsCameraSupported(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60015F1")]
		[Address(RVA = "0x13303CC", Offset = "0x13303CC", VA = "0x13303CC")]
		internal static extern bool VideoCapabilities_IsMicSupported(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60015F2")]
		[Address(RVA = "0x1330470", Offset = "0x1330470", VA = "0x1330470")]
		internal static extern bool VideoCapabilities_IsWriteStorageSupported(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60015F3")]
		[Address(RVA = "0x1330514", Offset = "0x1330514", VA = "0x1330514")]
		internal static extern bool VideoCapabilities_SupportsCaptureMode(HandleRef self, Types.VideoCaptureMode capture_mode);

		[PreserveSig]
		[Token(Token = "0x60015F4")]
		[Address(RVA = "0x13305C8", Offset = "0x13305C8", VA = "0x13305C8")]
		internal static extern bool VideoCapabilities_SupportsQualityLevel(HandleRef self, Types.VideoQualityLevel quality_level);

		[PreserveSig]
		[Token(Token = "0x60015F5")]
		[Address(RVA = "0x133067C", Offset = "0x133067C", VA = "0x133067C")]
		internal static extern void VideoCapabilities_Dispose(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60015F6")]
		[Address(RVA = "0x1330718", Offset = "0x1330718", VA = "0x1330718")]
		internal static extern bool VideoCapabilities_Valid(HandleRef self);
	}
}
