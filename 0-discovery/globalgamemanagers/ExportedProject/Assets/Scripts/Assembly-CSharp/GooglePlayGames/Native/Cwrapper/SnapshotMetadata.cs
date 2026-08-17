using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	[Token(Token = "0x20002BE")]
	internal static class SnapshotMetadata
	{
		[PreserveSig]
		[Token(Token = "0x6001586")]
		[Address(RVA = "0x1329CDC", Offset = "0x1329CDC", VA = "0x1329CDC")]
		internal static extern void SnapshotMetadata_Dispose(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001587")]
		[Address(RVA = "0x1329D78", Offset = "0x1329D78", VA = "0x1329D78")]
		internal static extern UIntPtr SnapshotMetadata_CoverImageURL(HandleRef self, [In][Out] byte[] out_arg, UIntPtr out_size);

		[PreserveSig]
		[Token(Token = "0x6001588")]
		[Address(RVA = "0x1329E34", Offset = "0x1329E34", VA = "0x1329E34")]
		internal static extern UIntPtr SnapshotMetadata_Description(HandleRef self, [In][Out] byte[] out_arg, UIntPtr out_size);

		[PreserveSig]
		[Token(Token = "0x6001589")]
		[Address(RVA = "0x1329EF0", Offset = "0x1329EF0", VA = "0x1329EF0")]
		internal static extern bool SnapshotMetadata_IsOpen(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x600158A")]
		[Address(RVA = "0x1329F94", Offset = "0x1329F94", VA = "0x1329F94")]
		internal static extern UIntPtr SnapshotMetadata_FileName(HandleRef self, [In][Out] byte[] out_arg, UIntPtr out_size);

		[PreserveSig]
		[Token(Token = "0x600158B")]
		[Address(RVA = "0x132A050", Offset = "0x132A050", VA = "0x132A050")]
		internal static extern bool SnapshotMetadata_Valid(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x600158C")]
		[Address(RVA = "0x132A0F4", Offset = "0x132A0F4", VA = "0x132A0F4")]
		internal static extern long SnapshotMetadata_PlayedTime(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x600158D")]
		[Address(RVA = "0x132A190", Offset = "0x132A190", VA = "0x132A190")]
		internal static extern long SnapshotMetadata_LastModifiedTime(HandleRef self);
	}
}
