using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;

namespace Opencoding.Console
{
	[Token(Token = "0x200001F")]
	internal class LogHistoryEmailView
	{
		[Token(Token = "0x4000114")]
		[FieldOffset(Offset = "0x10")]
		private readonly string _logEmailHeader;

		[Token(Token = "0x4000115")]
		[FieldOffset(Offset = "0x18")]
		private readonly string _logEmailFooter;

		[Token(Token = "0x4000116")]
		[FieldOffset(Offset = "0x20")]
		private readonly DebugConsole _debugConsole;

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0xE800DC", Offset = "0xE800DC", VA = "0xE800DC")]
		public LogHistoryEmailView(string logEmailHeader, string logEmailFooter, DebugConsole debugConsole)
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0xE8011C", Offset = "0xE8011C", VA = "0xE8011C")]
		public void WriteToFile(string filename, byte[] screenshotData, IEnumerable<SaveFileData> saveFiles, IEnumerable<KeyValuePair<string, string>> gameInfo)
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0xE8ACD0", Offset = "0xE8ACD0", VA = "0xE8ACD0")]
		private static StringBuilder GenerateSaveFileBody(IEnumerable<SaveFileData> saveFiles)
		{
			return null;
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0xE8C60C", Offset = "0xE8C60C", VA = "0xE8C60C")]
		private string GenerateScreenshot(byte[] screenshotData)
		{
			return null;
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0xE8BB30", Offset = "0xE8BB30", VA = "0xE8BB30")]
		private string GenerateHardwareInformationSection()
		{
			return null;
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0xE8C7B0", Offset = "0xE8C7B0", VA = "0xE8C7B0")]
		private string ToFriendlyName(string unfriendlyName)
		{
			return null;
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0xE8B904", Offset = "0xE8B904", VA = "0xE8B904")]
		private string GenerateGeneralInformationSection()
		{
			return null;
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0xE8A778", Offset = "0xE8A778", VA = "0xE8A778")]
		private string ToHTMLTable(IEnumerable<KeyValuePair<string, string>> data)
		{
			return null;
		}
	}
}
