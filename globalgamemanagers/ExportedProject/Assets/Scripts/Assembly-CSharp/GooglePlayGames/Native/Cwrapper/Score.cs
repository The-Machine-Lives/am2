using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	[Token(Token = "0x20002B9")]
	internal static class Score
	{
		[PreserveSig]
		[Token(Token = "0x6001549")]
		[Address(RVA = "0x1325988", Offset = "0x1325988", VA = "0x1325988")]
		internal static extern ulong Score_Value(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x600154A")]
		[Address(RVA = "0x1325A24", Offset = "0x1325A24", VA = "0x1325A24")]
		internal static extern bool Score_Valid(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x600154B")]
		[Address(RVA = "0x1325AC8", Offset = "0x1325AC8", VA = "0x1325AC8")]
		internal static extern ulong Score_Rank(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x600154C")]
		[Address(RVA = "0x1325B64", Offset = "0x1325B64", VA = "0x1325B64")]
		internal static extern void Score_Dispose(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x600154D")]
		[Address(RVA = "0x1325C00", Offset = "0x1325C00", VA = "0x1325C00")]
		internal static extern UIntPtr Score_Metadata(HandleRef self, [In][Out] byte[] out_arg, UIntPtr out_size);
	}
}
