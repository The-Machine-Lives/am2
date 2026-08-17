using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	[Token(Token = "0x20002B0")]
	internal static class ParticipantResults
	{
		[PreserveSig]
		[Token(Token = "0x60014DB")]
		[Address(RVA = "0x147AED4", Offset = "0x147AED4", VA = "0x147AED4")]
		internal static extern IntPtr ParticipantResults_WithResult(HandleRef self, string participant_id, uint placing, Types.MatchResult result);

		[PreserveSig]
		[Token(Token = "0x60014DC")]
		[Address(RVA = "0x147AFB4", Offset = "0x147AFB4", VA = "0x147AFB4")]
		internal static extern bool ParticipantResults_Valid(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60014DD")]
		[Address(RVA = "0x147B058", Offset = "0x147B058", VA = "0x147B058")]
		internal static extern Types.MatchResult ParticipantResults_MatchResultForParticipant(HandleRef self, string participant_id);

		[PreserveSig]
		[Token(Token = "0x60014DE")]
		[Address(RVA = "0x147B120", Offset = "0x147B120", VA = "0x147B120")]
		internal static extern uint ParticipantResults_PlaceForParticipant(HandleRef self, string participant_id);

		[PreserveSig]
		[Token(Token = "0x60014DF")]
		[Address(RVA = "0x147B1E8", Offset = "0x147B1E8", VA = "0x147B1E8")]
		internal static extern bool ParticipantResults_HasResultsForParticipant(HandleRef self, string participant_id);

		[PreserveSig]
		[Token(Token = "0x60014E0")]
		[Address(RVA = "0x147B2B4", Offset = "0x147B2B4", VA = "0x147B2B4")]
		internal static extern void ParticipantResults_Dispose(HandleRef self);
	}
}
