using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	[Token(Token = "0x20002B7")]
	internal static class RealTimeRoomConfig
	{
		[PreserveSig]
		[Token(Token = "0x6001538")]
		[Address(RVA = "0x1324DD4", Offset = "0x1324DD4", VA = "0x1324DD4")]
		internal static extern UIntPtr RealTimeRoomConfig_PlayerIdsToInvite_Length(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001539")]
		[Address(RVA = "0x1324E70", Offset = "0x1324E70", VA = "0x1324E70")]
		internal static extern UIntPtr RealTimeRoomConfig_PlayerIdsToInvite_GetElement(HandleRef self, UIntPtr index, [In][Out] char[] out_arg, UIntPtr out_size);

		[PreserveSig]
		[Token(Token = "0x600153A")]
		[Address(RVA = "0x1324FF8", Offset = "0x1324FF8", VA = "0x1324FF8")]
		internal static extern uint RealTimeRoomConfig_Variant(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x600153B")]
		[Address(RVA = "0x1325094", Offset = "0x1325094", VA = "0x1325094")]
		internal static extern long RealTimeRoomConfig_ExclusiveBitMask(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x600153C")]
		[Address(RVA = "0x1325130", Offset = "0x1325130", VA = "0x1325130")]
		internal static extern bool RealTimeRoomConfig_Valid(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x600153D")]
		[Address(RVA = "0x13251D4", Offset = "0x13251D4", VA = "0x13251D4")]
		internal static extern uint RealTimeRoomConfig_MaximumAutomatchingPlayers(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x600153E")]
		[Address(RVA = "0x1325270", Offset = "0x1325270", VA = "0x1325270")]
		internal static extern uint RealTimeRoomConfig_MinimumAutomatchingPlayers(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x600153F")]
		[Address(RVA = "0x132530C", Offset = "0x132530C", VA = "0x132530C")]
		internal static extern void RealTimeRoomConfig_Dispose(HandleRef self);
	}
}
