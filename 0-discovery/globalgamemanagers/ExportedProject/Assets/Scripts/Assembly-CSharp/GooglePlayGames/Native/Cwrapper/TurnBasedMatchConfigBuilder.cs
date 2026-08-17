using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	[Token(Token = "0x20002C6")]
	internal static class TurnBasedMatchConfigBuilder
	{
		[PreserveSig]
		[Token(Token = "0x60015C0")]
		[Address(RVA = "0x132C834", Offset = "0x132C834", VA = "0x132C834")]
		internal static extern void TurnBasedMatchConfig_Builder_PopulateFromPlayerSelectUIResponse(HandleRef self, IntPtr response);

		[PreserveSig]
		[Token(Token = "0x60015C1")]
		[Address(RVA = "0x132C8E0", Offset = "0x132C8E0", VA = "0x132C8E0")]
		internal static extern void TurnBasedMatchConfig_Builder_SetVariant(HandleRef self, uint variant);

		[PreserveSig]
		[Token(Token = "0x60015C2")]
		[Address(RVA = "0x132C98C", Offset = "0x132C98C", VA = "0x132C98C")]
		internal static extern void TurnBasedMatchConfig_Builder_AddPlayerToInvite(HandleRef self, string player_id);

		[PreserveSig]
		[Token(Token = "0x60015C3")]
		[Address(RVA = "0x132CA4C", Offset = "0x132CA4C", VA = "0x132CA4C")]
		internal static extern IntPtr TurnBasedMatchConfig_Builder_Construct();

		[PreserveSig]
		[Token(Token = "0x60015C4")]
		[Address(RVA = "0x132CAD8", Offset = "0x132CAD8", VA = "0x132CAD8")]
		internal static extern void TurnBasedMatchConfig_Builder_SetExclusiveBitMask(HandleRef self, ulong exclusive_bit_mask);

		[PreserveSig]
		[Token(Token = "0x60015C5")]
		[Address(RVA = "0x132CB84", Offset = "0x132CB84", VA = "0x132CB84")]
		internal static extern void TurnBasedMatchConfig_Builder_SetMaximumAutomatchingPlayers(HandleRef self, uint maximum_automatching_players);

		[PreserveSig]
		[Token(Token = "0x60015C6")]
		[Address(RVA = "0x132CC30", Offset = "0x132CC30", VA = "0x132CC30")]
		internal static extern IntPtr TurnBasedMatchConfig_Builder_Create(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60015C7")]
		[Address(RVA = "0x132CCCC", Offset = "0x132CCCC", VA = "0x132CCCC")]
		internal static extern void TurnBasedMatchConfig_Builder_SetMinimumAutomatchingPlayers(HandleRef self, uint minimum_automatching_players);

		[PreserveSig]
		[Token(Token = "0x60015C8")]
		[Address(RVA = "0x132CD78", Offset = "0x132CD78", VA = "0x132CD78")]
		internal static extern void TurnBasedMatchConfig_Builder_Dispose(HandleRef self);
	}
}
