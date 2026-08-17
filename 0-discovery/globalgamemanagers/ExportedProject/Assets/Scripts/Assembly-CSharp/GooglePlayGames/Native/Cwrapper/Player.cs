using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	[Token(Token = "0x20002B1")]
	internal static class Player
	{
		[PreserveSig]
		[Token(Token = "0x60014E1")]
		[Address(RVA = "0x147B350", Offset = "0x147B350", VA = "0x147B350")]
		internal static extern IntPtr Player_CurrentLevel(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60014E2")]
		[Address(RVA = "0x147B3EC", Offset = "0x147B3EC", VA = "0x147B3EC")]
		internal static extern UIntPtr Player_Name(HandleRef self, [In][Out] byte[] out_arg, UIntPtr out_size);

		[PreserveSig]
		[Token(Token = "0x60014E3")]
		[Address(RVA = "0x147B4A8", Offset = "0x147B4A8", VA = "0x147B4A8")]
		internal static extern void Player_Dispose(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60014E4")]
		[Address(RVA = "0x147B544", Offset = "0x147B544", VA = "0x147B544")]
		internal static extern UIntPtr Player_AvatarUrl(HandleRef self, Types.ImageResolution resolution, [In][Out] byte[] out_arg, UIntPtr out_size);

		[PreserveSig]
		[Token(Token = "0x60014E5")]
		[Address(RVA = "0x147B610", Offset = "0x147B610", VA = "0x147B610")]
		internal static extern ulong Player_LastLevelUpTime(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60014E6")]
		[Address(RVA = "0x147B6AC", Offset = "0x147B6AC", VA = "0x147B6AC")]
		internal static extern UIntPtr Player_Title(HandleRef self, [In][Out] byte[] out_arg, UIntPtr out_size);

		[PreserveSig]
		[Token(Token = "0x60014E7")]
		[Address(RVA = "0x147B768", Offset = "0x147B768", VA = "0x147B768")]
		internal static extern ulong Player_CurrentXP(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60014E8")]
		[Address(RVA = "0x147B804", Offset = "0x147B804", VA = "0x147B804")]
		internal static extern bool Player_Valid(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60014E9")]
		[Address(RVA = "0x147B8A8", Offset = "0x147B8A8", VA = "0x147B8A8")]
		internal static extern bool Player_HasLevelInfo(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60014EA")]
		[Address(RVA = "0x147B94C", Offset = "0x147B94C", VA = "0x147B94C")]
		internal static extern IntPtr Player_NextLevel(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60014EB")]
		[Address(RVA = "0x147B9E8", Offset = "0x147B9E8", VA = "0x147B9E8")]
		internal static extern UIntPtr Player_Id(HandleRef self, [In][Out] byte[] out_arg, UIntPtr out_size);
	}
}
