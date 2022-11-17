using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	[Token(Token = "0x20002C4")]
	internal static class TurnBasedMatch
	{
		[PreserveSig]
		[Token(Token = "0x60015A0")]
		[Address(RVA = "0x132B3B0", Offset = "0x132B3B0", VA = "0x132B3B0")]
		internal static extern uint TurnBasedMatch_AutomatchingSlotsAvailable(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60015A1")]
		[Address(RVA = "0x132B44C", Offset = "0x132B44C", VA = "0x132B44C")]
		internal static extern ulong TurnBasedMatch_CreationTime(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60015A2")]
		[Address(RVA = "0x132B4E8", Offset = "0x132B4E8", VA = "0x132B4E8")]
		internal static extern UIntPtr TurnBasedMatch_Participants_Length(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60015A3")]
		[Address(RVA = "0x132B584", Offset = "0x132B584", VA = "0x132B584")]
		internal static extern IntPtr TurnBasedMatch_Participants_GetElement(HandleRef self, UIntPtr index);

		[PreserveSig]
		[Token(Token = "0x60015A4")]
		[Address(RVA = "0x132B630", Offset = "0x132B630", VA = "0x132B630")]
		internal static extern uint TurnBasedMatch_Version(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60015A5")]
		[Address(RVA = "0x132B6CC", Offset = "0x132B6CC", VA = "0x132B6CC")]
		internal static extern IntPtr TurnBasedMatch_ParticipantResults(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60015A6")]
		[Address(RVA = "0x132B768", Offset = "0x132B768", VA = "0x132B768")]
		internal static extern Types.MatchStatus TurnBasedMatch_Status(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60015A7")]
		[Address(RVA = "0x132B804", Offset = "0x132B804", VA = "0x132B804")]
		internal static extern UIntPtr TurnBasedMatch_Description(HandleRef self, [In][Out] byte[] out_arg, UIntPtr out_size);

		[PreserveSig]
		[Token(Token = "0x60015A8")]
		[Address(RVA = "0x132B8C0", Offset = "0x132B8C0", VA = "0x132B8C0")]
		internal static extern IntPtr TurnBasedMatch_PendingParticipant(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60015A9")]
		[Address(RVA = "0x132B95C", Offset = "0x132B95C", VA = "0x132B95C")]
		internal static extern uint TurnBasedMatch_Variant(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60015AA")]
		[Address(RVA = "0x132B9F8", Offset = "0x132B9F8", VA = "0x132B9F8")]
		internal static extern bool TurnBasedMatch_HasPreviousMatchData(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60015AB")]
		[Address(RVA = "0x132BA9C", Offset = "0x132BA9C", VA = "0x132BA9C")]
		internal static extern UIntPtr TurnBasedMatch_Data(HandleRef self, [In][Out] byte[] out_arg, UIntPtr out_size);

		[PreserveSig]
		[Token(Token = "0x60015AC")]
		[Address(RVA = "0x132BB58", Offset = "0x132BB58", VA = "0x132BB58")]
		internal static extern IntPtr TurnBasedMatch_LastUpdatingParticipant(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60015AD")]
		[Address(RVA = "0x132BBF4", Offset = "0x132BBF4", VA = "0x132BBF4")]
		internal static extern bool TurnBasedMatch_HasData(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60015AE")]
		[Address(RVA = "0x132BC98", Offset = "0x132BC98", VA = "0x132BC98")]
		internal static extern IntPtr TurnBasedMatch_SuggestedNextParticipant(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60015AF")]
		[Address(RVA = "0x132BD34", Offset = "0x132BD34", VA = "0x132BD34")]
		internal static extern UIntPtr TurnBasedMatch_PreviousMatchData(HandleRef self, [In][Out] byte[] out_arg, UIntPtr out_size);

		[PreserveSig]
		[Token(Token = "0x60015B0")]
		[Address(RVA = "0x132BDF0", Offset = "0x132BDF0", VA = "0x132BDF0")]
		internal static extern ulong TurnBasedMatch_LastUpdateTime(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60015B1")]
		[Address(RVA = "0x132BE8C", Offset = "0x132BE8C", VA = "0x132BE8C")]
		internal static extern UIntPtr TurnBasedMatch_RematchId(HandleRef self, [In][Out] byte[] out_arg, UIntPtr out_size);

		[PreserveSig]
		[Token(Token = "0x60015B2")]
		[Address(RVA = "0x132BF44", Offset = "0x132BF44", VA = "0x132BF44")]
		internal static extern uint TurnBasedMatch_Number(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60015B3")]
		[Address(RVA = "0x132BFE0", Offset = "0x132BFE0", VA = "0x132BFE0")]
		internal static extern bool TurnBasedMatch_HasRematchId(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60015B4")]
		[Address(RVA = "0x132C084", Offset = "0x132C084", VA = "0x132C084")]
		internal static extern bool TurnBasedMatch_Valid(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60015B5")]
		[Address(RVA = "0x132C128", Offset = "0x132C128", VA = "0x132C128")]
		internal static extern IntPtr TurnBasedMatch_CreatingParticipant(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60015B6")]
		[Address(RVA = "0x132C1C4", Offset = "0x132C1C4", VA = "0x132C1C4")]
		internal static extern UIntPtr TurnBasedMatch_Id(HandleRef self, [In][Out] byte[] out_arg, UIntPtr out_size);

		[PreserveSig]
		[Token(Token = "0x60015B7")]
		[Address(RVA = "0x132C280", Offset = "0x132C280", VA = "0x132C280")]
		internal static extern void TurnBasedMatch_Dispose(HandleRef self);
	}
}
