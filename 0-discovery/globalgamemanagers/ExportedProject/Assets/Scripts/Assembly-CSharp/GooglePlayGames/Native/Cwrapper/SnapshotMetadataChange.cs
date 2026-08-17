using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	[Token(Token = "0x20002BF")]
	internal static class SnapshotMetadataChange
	{
		[PreserveSig]
		[Token(Token = "0x600158E")]
		[Address(RVA = "0x132A22C", Offset = "0x132A22C", VA = "0x132A22C")]
		internal static extern UIntPtr SnapshotMetadataChange_Description(HandleRef self, [In][Out] char[] out_arg, UIntPtr out_size);

		[PreserveSig]
		[Token(Token = "0x600158F")]
		[Address(RVA = "0x132A39C", Offset = "0x132A39C", VA = "0x132A39C")]
		internal static extern IntPtr SnapshotMetadataChange_Image(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001590")]
		[Address(RVA = "0x132A438", Offset = "0x132A438", VA = "0x132A438")]
		internal static extern bool SnapshotMetadataChange_PlayedTimeIsChanged(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001591")]
		[Address(RVA = "0x132A4DC", Offset = "0x132A4DC", VA = "0x132A4DC")]
		internal static extern bool SnapshotMetadataChange_Valid(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001592")]
		[Address(RVA = "0x132A580", Offset = "0x132A580", VA = "0x132A580")]
		internal static extern ulong SnapshotMetadataChange_PlayedTime(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001593")]
		[Address(RVA = "0x132A61C", Offset = "0x132A61C", VA = "0x132A61C")]
		internal static extern void SnapshotMetadataChange_Dispose(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001594")]
		[Address(RVA = "0x132A6B8", Offset = "0x132A6B8", VA = "0x132A6B8")]
		internal static extern bool SnapshotMetadataChange_ImageIsChanged(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001595")]
		[Address(RVA = "0x132A75C", Offset = "0x132A75C", VA = "0x132A75C")]
		internal static extern bool SnapshotMetadataChange_DescriptionIsChanged(HandleRef self);
	}
}
