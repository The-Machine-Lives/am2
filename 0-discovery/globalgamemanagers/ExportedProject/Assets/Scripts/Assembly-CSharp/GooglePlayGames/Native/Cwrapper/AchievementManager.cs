using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	[Token(Token = "0x200029D")]
	internal static class AchievementManager
	{
		[Token(Token = "0x200072C")]
		internal delegate void FetchAllCallback(IntPtr arg0, IntPtr arg1);

		[Token(Token = "0x200072D")]
		internal delegate void FetchCallback(IntPtr arg0, IntPtr arg1);

		[Token(Token = "0x200072E")]
		internal delegate void ShowAllUICallback(CommonErrorStatus.UIStatus arg0, IntPtr arg1);

		[PreserveSig]
		[Token(Token = "0x6001439")]
		[Address(RVA = "0x1469414", Offset = "0x1469414", VA = "0x1469414")]
		internal static extern void AchievementManager_FetchAll(HandleRef self, Types.DataSource data_source, FetchAllCallback callback, IntPtr callback_arg);

		[PreserveSig]
		[Token(Token = "0x600143A")]
		[Address(RVA = "0x14694E0", Offset = "0x14694E0", VA = "0x14694E0")]
		internal static extern void AchievementManager_Reveal(HandleRef self, string achievement_id);

		[PreserveSig]
		[Token(Token = "0x600143B")]
		[Address(RVA = "0x14695A0", Offset = "0x14695A0", VA = "0x14695A0")]
		internal static extern void AchievementManager_Unlock(HandleRef self, string achievement_id);

		[PreserveSig]
		[Token(Token = "0x600143C")]
		[Address(RVA = "0x1469660", Offset = "0x1469660", VA = "0x1469660")]
		internal static extern void AchievementManager_ShowAllUI(HandleRef self, ShowAllUICallback callback, IntPtr callback_arg);

		[PreserveSig]
		[Token(Token = "0x600143D")]
		[Address(RVA = "0x146971C", Offset = "0x146971C", VA = "0x146971C")]
		internal static extern void AchievementManager_SetStepsAtLeast(HandleRef self, string achievement_id, uint steps);

		[PreserveSig]
		[Token(Token = "0x600143E")]
		[Address(RVA = "0x14697E4", Offset = "0x14697E4", VA = "0x14697E4")]
		internal static extern void AchievementManager_Increment(HandleRef self, string achievement_id, uint steps);

		[PreserveSig]
		[Token(Token = "0x600143F")]
		[Address(RVA = "0x14698AC", Offset = "0x14698AC", VA = "0x14698AC")]
		internal static extern void AchievementManager_Fetch(HandleRef self, Types.DataSource data_source, string achievement_id, FetchCallback callback, IntPtr callback_arg);

		[PreserveSig]
		[Token(Token = "0x6001440")]
		[Address(RVA = "0x1469994", Offset = "0x1469994", VA = "0x1469994")]
		internal static extern void AchievementManager_FetchAllResponse_Dispose(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001441")]
		[Address(RVA = "0x1469A30", Offset = "0x1469A30", VA = "0x1469A30")]
		internal static extern CommonErrorStatus.ResponseStatus AchievementManager_FetchAllResponse_GetStatus(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001442")]
		[Address(RVA = "0x1469ACC", Offset = "0x1469ACC", VA = "0x1469ACC")]
		internal static extern UIntPtr AchievementManager_FetchAllResponse_GetData_Length(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001443")]
		[Address(RVA = "0x1469B68", Offset = "0x1469B68", VA = "0x1469B68")]
		internal static extern IntPtr AchievementManager_FetchAllResponse_GetData_GetElement(HandleRef self, UIntPtr index);

		[PreserveSig]
		[Token(Token = "0x6001444")]
		[Address(RVA = "0x1469C14", Offset = "0x1469C14", VA = "0x1469C14")]
		internal static extern void AchievementManager_FetchResponse_Dispose(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001445")]
		[Address(RVA = "0x1469CB0", Offset = "0x1469CB0", VA = "0x1469CB0")]
		internal static extern CommonErrorStatus.ResponseStatus AchievementManager_FetchResponse_GetStatus(HandleRef self);

		[PreserveSig]
		[Token(Token = "0x6001446")]
		[Address(RVA = "0x1469D4C", Offset = "0x1469D4C", VA = "0x1469D4C")]
		internal static extern IntPtr AchievementManager_FetchResponse_GetData(HandleRef self);
	}
}
