using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	[Token(Token = "0x20002B6")]
	internal static class RealTimeRoom
	{
		[PreserveSig]
		[Token(Token = "0x600152C")]
		[Address(RVA = "0x132457C", Offset = "0x132457C", VA = "0x132457C")]
		internal static extern Types.RealTimeRoomStatus RealTimeRoom_Status(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x600152D")]
		[Address(RVA = "0x1324618", Offset = "0x1324618", VA = "0x1324618")]
		internal static extern UIntPtr RealTimeRoom_Description(HandleRef self, [In][Out] char[] out_arg, UIntPtr out_size);

		[PreserveSig]
		[Token(Token = "0x600152E")]
		[Address(RVA = "0x1324784", Offset = "0x1324784", VA = "0x1324784")]
		internal static extern uint RealTimeRoom_Variant(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x600152F")]
		[Address(RVA = "0x1324820", Offset = "0x1324820", VA = "0x1324820")]
		internal static extern ulong RealTimeRoom_CreationTime(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001530")]
		[Address(RVA = "0x13248BC", Offset = "0x13248BC", VA = "0x13248BC")]
		internal static extern UIntPtr RealTimeRoom_Participants_Length(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001531")]
		[Address(RVA = "0x1324958", Offset = "0x1324958", VA = "0x1324958")]
		internal static extern IntPtr RealTimeRoom_Participants_GetElement(HandleRef self, UIntPtr index);

		[PreserveSig]
		[Token(Token = "0x6001532")]
		[Address(RVA = "0x1324A04", Offset = "0x1324A04", VA = "0x1324A04")]
		internal static extern bool RealTimeRoom_Valid(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001533")]
		[Address(RVA = "0x1324AA8", Offset = "0x1324AA8", VA = "0x1324AA8")]
		internal static extern uint RealTimeRoom_RemainingAutomatchingSlots(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001534")]
		[Address(RVA = "0x1324B44", Offset = "0x1324B44", VA = "0x1324B44")]
		internal static extern ulong RealTimeRoom_AutomatchWaitEstimate(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001535")]
		[Address(RVA = "0x1324BE0", Offset = "0x1324BE0", VA = "0x1324BE0")]
		internal static extern IntPtr RealTimeRoom_CreatingParticipant(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001536")]
		[Address(RVA = "0x1324C7C", Offset = "0x1324C7C", VA = "0x1324C7C")]
		internal static extern UIntPtr RealTimeRoom_Id(HandleRef self, [In][Out] byte[] out_arg, UIntPtr out_size);

		[PreserveSig]
		[Token(Token = "0x6001537")]
		[Address(RVA = "0x1324D38", Offset = "0x1324D38", VA = "0x1324D38")]
		internal static extern void RealTimeRoom_Dispose(HandleRef self);
	}
}
