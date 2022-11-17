using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	[Token(Token = "0x200029C")]
	internal static class Achievement
	{
		[PreserveSig]
		[Token(Token = "0x600142B")]
		[Address(RVA = "0x1468AE4", Offset = "0x1468AE4", VA = "0x1468AE4")]
		internal static extern uint Achievement_TotalSteps(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x600142C")]
		[Address(RVA = "0x1468B80", Offset = "0x1468B80", VA = "0x1468B80")]
		internal static extern UIntPtr Achievement_Description(HandleRef self, [In][Out] byte[] out_arg, UIntPtr out_size);

		[PreserveSig]
		[Token(Token = "0x600142D")]
		[Address(RVA = "0x1468C3C", Offset = "0x1468C3C", VA = "0x1468C3C")]
		internal static extern void Achievement_Dispose(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x600142E")]
		[Address(RVA = "0x1468CD8", Offset = "0x1468CD8", VA = "0x1468CD8")]
		internal static extern UIntPtr Achievement_UnlockedIconUrl(HandleRef self, [In][Out] byte[] out_arg, UIntPtr out_size);

		[PreserveSig]
		[Token(Token = "0x600142F")]
		[Address(RVA = "0x1468D94", Offset = "0x1468D94", VA = "0x1468D94")]
		internal static extern ulong Achievement_LastModifiedTime(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001430")]
		[Address(RVA = "0x1468E30", Offset = "0x1468E30", VA = "0x1468E30")]
		internal static extern UIntPtr Achievement_RevealedIconUrl(HandleRef self, [In][Out] byte[] out_arg, UIntPtr out_size);

		[PreserveSig]
		[Token(Token = "0x6001431")]
		[Address(RVA = "0x1468EEC", Offset = "0x1468EEC", VA = "0x1468EEC")]
		internal static extern uint Achievement_CurrentSteps(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001432")]
		[Address(RVA = "0x1468F88", Offset = "0x1468F88", VA = "0x1468F88")]
		internal static extern Types.AchievementState Achievement_State(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001433")]
		[Address(RVA = "0x1469024", Offset = "0x1469024", VA = "0x1469024")]
		internal static extern bool Achievement_Valid(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001434")]
		[Address(RVA = "0x14690C8", Offset = "0x14690C8", VA = "0x14690C8")]
		internal static extern ulong Achievement_LastModified(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001435")]
		[Address(RVA = "0x1469164", Offset = "0x1469164", VA = "0x1469164")]
		internal static extern ulong Achievement_XP(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001436")]
		[Address(RVA = "0x1469200", Offset = "0x1469200", VA = "0x1469200")]
		internal static extern Types.AchievementType Achievement_Type(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001437")]
		[Address(RVA = "0x146929C", Offset = "0x146929C", VA = "0x146929C")]
		internal static extern UIntPtr Achievement_Id(HandleRef self, [In][Out] byte[] out_arg, UIntPtr out_size);

		[PreserveSig]
		[Token(Token = "0x6001438")]
		[Address(RVA = "0x1469358", Offset = "0x1469358", VA = "0x1469358")]
		internal static extern UIntPtr Achievement_Name(HandleRef self, [In][Out] byte[] out_arg, UIntPtr out_size);
	}
}
