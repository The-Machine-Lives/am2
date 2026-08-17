using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	[Token(Token = "0x20002B3")]
	internal static class PlayerStats
	{
		[PreserveSig]
		[Token(Token = "0x60014FB")]
		[Address(RVA = "0x131DF34", Offset = "0x131DF34", VA = "0x131DF34")]
		internal static extern bool PlayerStats_Valid(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60014FC")]
		[Address(RVA = "0x131DFD8", Offset = "0x131DFD8", VA = "0x131DFD8")]
		internal static extern void PlayerStats_Dispose(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60014FD")]
		[Address(RVA = "0x131E074", Offset = "0x131E074", VA = "0x131E074")]
		internal static extern bool PlayerStats_HasAverageSessionLength(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60014FE")]
		[Address(RVA = "0x131E118", Offset = "0x131E118", VA = "0x131E118")]
		internal static extern float PlayerStats_AverageSessionLength(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x60014FF")]
		[Address(RVA = "0x131E1B4", Offset = "0x131E1B4", VA = "0x131E1B4")]
		internal static extern bool PlayerStats_HasChurnProbability(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001500")]
		[Address(RVA = "0x131E258", Offset = "0x131E258", VA = "0x131E258")]
		internal static extern float PlayerStats_ChurnProbability(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001501")]
		[Address(RVA = "0x131E2F4", Offset = "0x131E2F4", VA = "0x131E2F4")]
		internal static extern bool PlayerStats_HasDaysSinceLastPlayed(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001502")]
		[Address(RVA = "0x131E398", Offset = "0x131E398", VA = "0x131E398")]
		internal static extern int PlayerStats_DaysSinceLastPlayed(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001503")]
		[Address(RVA = "0x131E434", Offset = "0x131E434", VA = "0x131E434")]
		internal static extern bool PlayerStats_HasNumberOfPurchases(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001504")]
		[Address(RVA = "0x131E4D8", Offset = "0x131E4D8", VA = "0x131E4D8")]
		internal static extern int PlayerStats_NumberOfPurchases(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001505")]
		[Address(RVA = "0x131E574", Offset = "0x131E574", VA = "0x131E574")]
		internal static extern bool PlayerStats_HasNumberOfSessions(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001506")]
		[Address(RVA = "0x131E618", Offset = "0x131E618", VA = "0x131E618")]
		internal static extern int PlayerStats_NumberOfSessions(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001507")]
		[Address(RVA = "0x131E6B4", Offset = "0x131E6B4", VA = "0x131E6B4")]
		internal static extern bool PlayerStats_HasSessionPercentile(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001508")]
		[Address(RVA = "0x131E758", Offset = "0x131E758", VA = "0x131E758")]
		internal static extern float PlayerStats_SessionPercentile(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001509")]
		[Address(RVA = "0x131E7F4", Offset = "0x131E7F4", VA = "0x131E7F4")]
		internal static extern bool PlayerStats_HasSpendPercentile(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x600150A")]
		[Address(RVA = "0x131E898", Offset = "0x131E898", VA = "0x131E898")]
		internal static extern float PlayerStats_SpendPercentile(HandleRef self);
	}
}
