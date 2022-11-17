using Il2CppDummyDll;
using Opencoding.Shared.Utils;

namespace Opencoding.Console
{
	[Token(Token = "0x2000233")]
	internal static class NativeMethods
	{
		[Token(Token = "0x6000FBA")]
		[Address(RVA = "0x99E670", Offset = "0x99E670", VA = "0x99E670")]
		public static void SendEmail(Email email)
		{
		}

		[Token(Token = "0x6000FBB")]
		[Address(RVA = "0x99ECF0", Offset = "0x99ECF0", VA = "0x99ECF0")]
		public static void CopyTextToClipboard(string text)
		{
		}

		[Token(Token = "0x6000FBC")]
		[Address(RVA = "0x99EDF0", Offset = "0x99EDF0", VA = "0x99EDF0")]
		public static float GetNativeScreenScaleFactor()
		{
			return default(float);
		}
	}
}
