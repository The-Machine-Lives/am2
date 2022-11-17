using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	[Token(Token = "0x20002AB")]
	internal static class MultiplayerParticipant
	{
		[PreserveSig]
		[Token(Token = "0x60014AB")]
		[Address(RVA = "0x14770E8", Offset = "0x14770E8", VA = "0x14770E8")]
		internal static extern Types.ParticipantStatus MultiplayerParticipant_Status(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60014AC")]
		[Address(RVA = "0x1477184", Offset = "0x1477184", VA = "0x1477184")]
		internal static extern uint MultiplayerParticipant_MatchRank(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60014AD")]
		[Address(RVA = "0x1477220", Offset = "0x1477220", VA = "0x1477220")]
		internal static extern bool MultiplayerParticipant_IsConnectedToRoom(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60014AE")]
		[Address(RVA = "0x14772C4", Offset = "0x14772C4", VA = "0x14772C4")]
		internal static extern UIntPtr MultiplayerParticipant_DisplayName(HandleRef self, [In][Out] byte[] out_arg, UIntPtr out_size);

		[PreserveSig]
		[Token(Token = "0x60014AF")]
		[Address(RVA = "0x1477380", Offset = "0x1477380", VA = "0x1477380")]
		internal static extern bool MultiplayerParticipant_HasPlayer(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60014B0")]
		[Address(RVA = "0x1477424", Offset = "0x1477424", VA = "0x1477424")]
		internal static extern UIntPtr MultiplayerParticipant_AvatarUrl(HandleRef self, Types.ImageResolution resolution, [In][Out] char[] out_arg, UIntPtr out_size);

		[PreserveSig]
		[Token(Token = "0x60014B1")]
		[Address(RVA = "0x14775AC", Offset = "0x14775AC", VA = "0x14775AC")]
		internal static extern Types.MatchResult MultiplayerParticipant_MatchResult(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60014B2")]
		[Address(RVA = "0x1477648", Offset = "0x1477648", VA = "0x1477648")]
		internal static extern IntPtr MultiplayerParticipant_Player(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60014B3")]
		[Address(RVA = "0x14776E4", Offset = "0x14776E4", VA = "0x14776E4")]
		internal static extern void MultiplayerParticipant_Dispose(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60014B4")]
		[Address(RVA = "0x1477780", Offset = "0x1477780", VA = "0x1477780")]
		internal static extern bool MultiplayerParticipant_Valid(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60014B5")]
		[Address(RVA = "0x1477824", Offset = "0x1477824", VA = "0x1477824")]
		internal static extern bool MultiplayerParticipant_HasMatchResult(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60014B6")]
		[Address(RVA = "0x14778C8", Offset = "0x14778C8", VA = "0x14778C8")]
		internal static extern UIntPtr MultiplayerParticipant_Id(HandleRef self, [In][Out] byte[] out_arg, UIntPtr out_size);
	}
}
