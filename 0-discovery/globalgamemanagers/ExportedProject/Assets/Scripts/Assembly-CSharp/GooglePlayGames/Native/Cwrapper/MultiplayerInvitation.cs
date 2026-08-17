using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	[Token(Token = "0x20002AA")]
	internal static class MultiplayerInvitation
	{
		[PreserveSig]
		[Token(Token = "0x60014A1")]
		[Address(RVA = "0x1476A9C", Offset = "0x1476A9C", VA = "0x1476A9C")]
		internal static extern uint MultiplayerInvitation_AutomatchingSlotsAvailable(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60014A2")]
		[Address(RVA = "0x1476B38", Offset = "0x1476B38", VA = "0x1476B38")]
		internal static extern IntPtr MultiplayerInvitation_InvitingParticipant(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60014A3")]
		[Address(RVA = "0x1476BD4", Offset = "0x1476BD4", VA = "0x1476BD4")]
		internal static extern uint MultiplayerInvitation_Variant(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60014A4")]
		[Address(RVA = "0x1476C70", Offset = "0x1476C70", VA = "0x1476C70")]
		internal static extern ulong MultiplayerInvitation_CreationTime(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60014A5")]
		[Address(RVA = "0x1476D0C", Offset = "0x1476D0C", VA = "0x1476D0C")]
		internal static extern UIntPtr MultiplayerInvitation_Participants_Length(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60014A6")]
		[Address(RVA = "0x1476DA8", Offset = "0x1476DA8", VA = "0x1476DA8")]
		internal static extern IntPtr MultiplayerInvitation_Participants_GetElement(HandleRef self, UIntPtr index);

		[PreserveSig]
		[Token(Token = "0x60014A7")]
		[Address(RVA = "0x1476E54", Offset = "0x1476E54", VA = "0x1476E54")]
		internal static extern bool MultiplayerInvitation_Valid(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60014A8")]
		[Address(RVA = "0x1476EF8", Offset = "0x1476EF8", VA = "0x1476EF8")]
		internal static extern Types.MultiplayerInvitationType MultiplayerInvitation_Type(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60014A9")]
		[Address(RVA = "0x1476F94", Offset = "0x1476F94", VA = "0x1476F94")]
		internal static extern UIntPtr MultiplayerInvitation_Id(HandleRef self, [In][Out] byte[] out_arg, UIntPtr out_size);

		[PreserveSig]
		[Token(Token = "0x60014AA")]
		[Address(RVA = "0x147704C", Offset = "0x147704C", VA = "0x147704C")]
		internal static extern void MultiplayerInvitation_Dispose(HandleRef self);
	}
}
