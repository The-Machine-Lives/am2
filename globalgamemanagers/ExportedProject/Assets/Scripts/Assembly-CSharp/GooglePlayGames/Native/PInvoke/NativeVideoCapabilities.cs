using System;
using System.Runtime.InteropServices;
using GooglePlayGames.Native.Cwrapper;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	[Token(Token = "0x2000286")]
	internal class NativeVideoCapabilities : BaseReferenceHolder
	{
		[Token(Token = "0x6001350")]
		[Address(RVA = "0xE5EE80", Offset = "0xE5EE80", VA = "0xE5EE80")]
		internal NativeVideoCapabilities(IntPtr selfPtr)
		{
		}

		[Token(Token = "0x6001351")]
		[Address(RVA = "0xE5EEF8", Offset = "0xE5EEF8", VA = "0xE5EEF8", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		[Token(Token = "0x6001352")]
		[Address(RVA = "0xE5EF08", Offset = "0xE5EF08", VA = "0xE5EF08")]
		internal bool IsCameraSupported()
		{
			return default(bool);
		}

		[Token(Token = "0x6001353")]
		[Address(RVA = "0xE5EF24", Offset = "0xE5EF24", VA = "0xE5EF24")]
		internal bool IsMicSupported()
		{
			return default(bool);
		}

		[Token(Token = "0x6001354")]
		[Address(RVA = "0xE5EF40", Offset = "0xE5EF40", VA = "0xE5EF40")]
		internal bool IsWriteStorageSupported()
		{
			return default(bool);
		}

		[Token(Token = "0x6001355")]
		[Address(RVA = "0xE5EF5C", Offset = "0xE5EF5C", VA = "0xE5EF5C")]
		internal bool SupportsCaptureMode(Types.VideoCaptureMode captureMode)
		{
			return default(bool);
		}

		[Token(Token = "0x6001356")]
		[Address(RVA = "0xE5EF88", Offset = "0xE5EF88", VA = "0xE5EF88")]
		internal bool SupportsQualityLevel(Types.VideoQualityLevel qualityLevel)
		{
			return default(bool);
		}

		[Token(Token = "0x6001357")]
		[Address(RVA = "0xE5EFB4", Offset = "0xE5EFB4", VA = "0xE5EFB4")]
		internal static NativeVideoCapabilities FromPointer(IntPtr pointer)
		{
			return null;
		}
	}
}
