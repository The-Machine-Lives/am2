using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	[Token(Token = "0x20002C5")]
	internal static class TurnBasedMatchConfig
	{
		[PreserveSig]
		[Token(Token = "0x60015B8")]
		[Address(RVA = "0x132C31C", Offset = "0x132C31C", VA = "0x132C31C")]
		internal static extern UIntPtr TurnBasedMatchConfig_PlayerIdsToInvite_Length(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60015B9")]
		[Address(RVA = "0x132C3B8", Offset = "0x132C3B8", VA = "0x132C3B8")]
		internal static extern UIntPtr TurnBasedMatchConfig_PlayerIdsToInvite_GetElement(HandleRef self, UIntPtr index, [In][Out] byte[] out_arg, UIntPtr out_size);

		[PreserveSig]
		[Token(Token = "0x60015BA")]
		[Address(RVA = "0x132C484", Offset = "0x132C484", VA = "0x132C484")]
		internal static extern uint TurnBasedMatchConfig_Variant(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60015BB")]
		[Address(RVA = "0x132C520", Offset = "0x132C520", VA = "0x132C520")]
		internal static extern long TurnBasedMatchConfig_ExclusiveBitMask(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60015BC")]
		[Address(RVA = "0x132C5BC", Offset = "0x132C5BC", VA = "0x132C5BC")]
		internal static extern bool TurnBasedMatchConfig_Valid(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60015BD")]
		[Address(RVA = "0x132C660", Offset = "0x132C660", VA = "0x132C660")]
		internal static extern uint TurnBasedMatchConfig_MaximumAutomatchingPlayers(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60015BE")]
		[Address(RVA = "0x132C6FC", Offset = "0x132C6FC", VA = "0x132C6FC")]
		internal static extern uint TurnBasedMatchConfig_MinimumAutomatchingPlayers(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60015BF")]
		[Address(RVA = "0x132C798", Offset = "0x132C798", VA = "0x132C798")]
		internal static extern void TurnBasedMatchConfig_Dispose(HandleRef self);
	}
}
