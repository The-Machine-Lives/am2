using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	[Token(Token = "0x20002A7")]
	internal static class Leaderboard
	{
		[PreserveSig]
		[Token(Token = "0x600147D")]
		[Address(RVA = "0x147219C", Offset = "0x147219C", VA = "0x147219C")]
		internal static extern UIntPtr Leaderboard_Name(HandleRef self, [In][Out] byte[] out_arg, UIntPtr out_size);

		[PreserveSig]
		[Token(Token = "0x600147E")]
		[Address(RVA = "0x1472258", Offset = "0x1472258", VA = "0x1472258")]
		internal static extern UIntPtr Leaderboard_Id(HandleRef self, [In][Out] byte[] out_arg, UIntPtr out_size);

		[PreserveSig]
		[Token(Token = "0x600147F")]
		[Address(RVA = "0x1472314", Offset = "0x1472314", VA = "0x1472314")]
		internal static extern UIntPtr Leaderboard_IconUrl(HandleRef self, [In][Out] byte[] out_arg, UIntPtr out_size);

		[PreserveSig]
		[Token(Token = "0x6001480")]
		[Address(RVA = "0x14723D0", Offset = "0x14723D0", VA = "0x14723D0")]
		internal static extern void Leaderboard_Dispose(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001481")]
		[Address(RVA = "0x147246C", Offset = "0x147246C", VA = "0x147246C")]
		internal static extern bool Leaderboard_Valid(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001482")]
		[Address(RVA = "0x1472510", Offset = "0x1472510", VA = "0x1472510")]
		internal static extern Types.LeaderboardOrder Leaderboard_Order(HandleRef self);
	}
}
