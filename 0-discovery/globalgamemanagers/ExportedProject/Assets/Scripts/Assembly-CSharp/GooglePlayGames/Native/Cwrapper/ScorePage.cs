using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	[Token(Token = "0x20002BA")]
	internal static class ScorePage
	{
		[PreserveSig]
		[Token(Token = "0x600154E")]
		[Address(RVA = "0x1325CBC", Offset = "0x1325CBC", VA = "0x1325CBC")]
		internal static extern void ScorePage_Dispose(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x600154F")]
		[Address(RVA = "0x1325D58", Offset = "0x1325D58", VA = "0x1325D58")]
		internal static extern Types.LeaderboardTimeSpan ScorePage_TimeSpan(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001550")]
		[Address(RVA = "0x1325DF4", Offset = "0x1325DF4", VA = "0x1325DF4")]
		internal static extern UIntPtr ScorePage_LeaderboardId(HandleRef self, [In][Out] byte[] out_arg, UIntPtr out_size);

		[PreserveSig]
		[Token(Token = "0x6001551")]
		[Address(RVA = "0x1325EB0", Offset = "0x1325EB0", VA = "0x1325EB0")]
		internal static extern Types.LeaderboardCollection ScorePage_Collection(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001552")]
		[Address(RVA = "0x1325F4C", Offset = "0x1325F4C", VA = "0x1325F4C")]
		internal static extern Types.LeaderboardStart ScorePage_Start(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001553")]
		[Address(RVA = "0x1325FE8", Offset = "0x1325FE8", VA = "0x1325FE8")]
		internal static extern bool ScorePage_Valid(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001554")]
		[Address(RVA = "0x132608C", Offset = "0x132608C", VA = "0x132608C")]
		internal static extern bool ScorePage_HasPreviousScorePage(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001555")]
		[Address(RVA = "0x1326130", Offset = "0x1326130", VA = "0x1326130")]
		internal static extern bool ScorePage_HasNextScorePage(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001556")]
		[Address(RVA = "0x13261D4", Offset = "0x13261D4", VA = "0x13261D4")]
		internal static extern IntPtr ScorePage_PreviousScorePageToken(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001557")]
		[Address(RVA = "0x1326270", Offset = "0x1326270", VA = "0x1326270")]
		internal static extern IntPtr ScorePage_NextScorePageToken(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001558")]
		[Address(RVA = "0x132630C", Offset = "0x132630C", VA = "0x132630C")]
		internal static extern UIntPtr ScorePage_Entries_Length(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001559")]
		[Address(RVA = "0x13263A8", Offset = "0x13263A8", VA = "0x13263A8")]
		internal static extern IntPtr ScorePage_Entries_GetElement(HandleRef self, UIntPtr index);

		[PreserveSig]
		[Token(Token = "0x600155A")]
		[Address(RVA = "0x1326454", Offset = "0x1326454", VA = "0x1326454")]
		internal static extern void ScorePage_Entry_Dispose(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x600155B")]
		[Address(RVA = "0x13264F0", Offset = "0x13264F0", VA = "0x13264F0")]
		internal static extern UIntPtr ScorePage_Entry_PlayerId(HandleRef self, [In][Out] byte[] out_arg, UIntPtr out_size);

		[PreserveSig]
		[Token(Token = "0x600155C")]
		[Address(RVA = "0x13265A8", Offset = "0x13265A8", VA = "0x13265A8")]
		internal static extern ulong ScorePage_Entry_LastModified(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x600155D")]
		[Address(RVA = "0x1326644", Offset = "0x1326644", VA = "0x1326644")]
		internal static extern IntPtr ScorePage_Entry_Score(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x600155E")]
		[Address(RVA = "0x13266E0", Offset = "0x13266E0", VA = "0x13266E0")]
		internal static extern bool ScorePage_Entry_Valid(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x600155F")]
		[Address(RVA = "0x1326784", Offset = "0x1326784", VA = "0x1326784")]
		internal static extern ulong ScorePage_Entry_LastModifiedTime(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001560")]
		[Address(RVA = "0x1326820", Offset = "0x1326820", VA = "0x1326820")]
		internal static extern bool ScorePage_ScorePageToken_Valid(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001561")]
		[Address(RVA = "0x13268C4", Offset = "0x13268C4", VA = "0x13268C4")]
		internal static extern void ScorePage_ScorePageToken_Dispose(HandleRef self);
	}
}
