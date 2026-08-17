using System.Reflection;
using Il2CppDummyDll;
using Opencoding.Shared.Utils;

namespace Opencoding.Console
{
	[Token(Token = "0x2000007")]
	internal static class NativeMethodsInterface
	{
		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x0")]
		private static MethodInfo _copyTextToClipboardMethod;

		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x8")]
		private static MethodInfo _emailMethod;

		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x10")]
		private static MethodInfo _getNativeScreenScaleFactorMethod;

		[Token(Token = "0x1700001A")]
		public static bool HasEmailSupport
		{
			[Token(Token = "0x6000059")]
			[Address(RVA = "0xE8EAF4", Offset = "0xE8EAF4", VA = "0xE8EAF4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0xE8F878", Offset = "0xE8F878", VA = "0xE8F878")]
		static NativeMethodsInterface()
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0xE8F4F4", Offset = "0xE8F4F4", VA = "0xE8F4F4")]
		public static void CopyTextToClipboard(string text)
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0xE80E70", Offset = "0xE80E70", VA = "0xE80E70")]
		public static void SendEmail(Email email)
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0xE8861C", Offset = "0xE8861C", VA = "0xE8861C")]
		public static float GetNativeScreenScaleFactor()
		{
			return default(float);
		}
	}
}
