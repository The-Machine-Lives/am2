using System;
using System.Runtime.InteropServices;
using GooglePlayGames.Native.Cwrapper;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	[Token(Token = "0x2000287")]
	internal class NativeVideoCaptureState : BaseReferenceHolder
	{
		[Token(Token = "0x6001358")]
		[Address(RVA = "0xE5F050", Offset = "0xE5F050", VA = "0xE5F050")]
		internal NativeVideoCaptureState(IntPtr selfPtr)
		{
		}

		[Token(Token = "0x6001359")]
		[Address(RVA = "0xE5F0C8", Offset = "0xE5F0C8", VA = "0xE5F0C8", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		[Token(Token = "0x600135A")]
		[Address(RVA = "0xE5F0D8", Offset = "0xE5F0D8", VA = "0xE5F0D8")]
		internal bool IsCapturing()
		{
			return default(bool);
		}

		[Token(Token = "0x600135B")]
		[Address(RVA = "0xE5F0F4", Offset = "0xE5F0F4", VA = "0xE5F0F4")]
		internal Types.VideoCaptureMode CaptureMode()
		{
			return default(Types.VideoCaptureMode);
		}

		[Token(Token = "0x600135C")]
		[Address(RVA = "0xE5F110", Offset = "0xE5F110", VA = "0xE5F110")]
		internal Types.VideoQualityLevel QualityLevel()
		{
			return default(Types.VideoQualityLevel);
		}

		[Token(Token = "0x600135D")]
		[Address(RVA = "0xE5F12C", Offset = "0xE5F12C", VA = "0xE5F12C")]
		internal bool IsOverlayVisible()
		{
			return default(bool);
		}

		[Token(Token = "0x600135E")]
		[Address(RVA = "0xE5F148", Offset = "0xE5F148", VA = "0xE5F148")]
		internal bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x600135F")]
		[Address(RVA = "0xE5F164", Offset = "0xE5F164", VA = "0xE5F164")]
		internal static NativeVideoCaptureState FromPointer(IntPtr pointer)
		{
			return null;
		}
	}
}
