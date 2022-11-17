using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	[Token(Token = "0x20002C0")]
	internal static class SnapshotMetadataChangeBuilder
	{
		[PreserveSig]
		[Token(Token = "0x6001596")]
		[Address(RVA = "0x132A800", Offset = "0x132A800", VA = "0x132A800")]
		internal static extern void SnapshotMetadataChange_Builder_SetDescription(HandleRef self, string description);

		[PreserveSig]
		[Token(Token = "0x6001597")]
		[Address(RVA = "0x132A8C0", Offset = "0x132A8C0", VA = "0x132A8C0")]
		internal static extern IntPtr SnapshotMetadataChange_Builder_Construct();

		[PreserveSig]
		[Token(Token = "0x6001598")]
		[Address(RVA = "0x132A94C", Offset = "0x132A94C", VA = "0x132A94C")]
		internal static extern void SnapshotMetadataChange_Builder_SetPlayedTime(HandleRef self, ulong played_time);

		[PreserveSig]
		[Token(Token = "0x6001599")]
		[Address(RVA = "0x132A9F8", Offset = "0x132A9F8", VA = "0x132A9F8")]
		internal static extern void SnapshotMetadataChange_Builder_SetCoverImageFromPngData(HandleRef self, byte[] png_data, UIntPtr png_data_size);

		[PreserveSig]
		[Token(Token = "0x600159A")]
		[Address(RVA = "0x132AAB4", Offset = "0x132AAB4", VA = "0x132AAB4")]
		internal static extern IntPtr SnapshotMetadataChange_Builder_Create(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x600159B")]
		[Address(RVA = "0x132AB50", Offset = "0x132AB50", VA = "0x132AB50")]
		internal static extern void SnapshotMetadataChange_Builder_Dispose(HandleRef self);
	}
}
