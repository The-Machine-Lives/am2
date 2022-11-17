using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	[Token(Token = "0x20002BB")]
	internal static class ScoreSummary
	{
		[PreserveSig]
		[Token(Token = "0x6001562")]
		[Address(RVA = "0x1326960", Offset = "0x1326960", VA = "0x1326960")]
		internal static extern ulong ScoreSummary_ApproximateNumberOfScores(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001563")]
		[Address(RVA = "0x13269FC", Offset = "0x13269FC", VA = "0x13269FC")]
		internal static extern Types.LeaderboardTimeSpan ScoreSummary_TimeSpan(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001564")]
		[Address(RVA = "0x1326A98", Offset = "0x1326A98", VA = "0x1326A98")]
		internal static extern UIntPtr ScoreSummary_LeaderboardId(HandleRef self, [In][Out] char[] out_arg, UIntPtr out_size);

		[PreserveSig]
		[Token(Token = "0x6001565")]
		[Address(RVA = "0x1326C08", Offset = "0x1326C08", VA = "0x1326C08")]
		internal static extern Types.LeaderboardCollection ScoreSummary_Collection(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001566")]
		[Address(RVA = "0x1326CA4", Offset = "0x1326CA4", VA = "0x1326CA4")]
		internal static extern bool ScoreSummary_Valid(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001567")]
		[Address(RVA = "0x1326D48", Offset = "0x1326D48", VA = "0x1326D48")]
		internal static extern IntPtr ScoreSummary_CurrentPlayerScore(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001568")]
		[Address(RVA = "0x1326DE4", Offset = "0x1326DE4", VA = "0x1326DE4")]
		internal static extern void ScoreSummary_Dispose(HandleRef self);
	}
}
