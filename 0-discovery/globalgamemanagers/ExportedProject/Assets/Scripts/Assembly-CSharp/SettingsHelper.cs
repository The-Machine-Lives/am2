using Il2CppDummyDll;

[Token(Token = "0x200010D")]
public class SettingsHelper
{
	[Token(Token = "0x40006B3")]
	private const string c_frameRateKey = "fps";

	[Token(Token = "0x6000770")]
	[Address(RVA = "0x9FF8C0", Offset = "0x9FF8C0", VA = "0x9FF8C0")]
	public static void InitializeSettings()
	{
	}

	[Token(Token = "0x6000771")]
	[Address(RVA = "0x9FF8D8", Offset = "0x9FF8D8", VA = "0x9FF8D8")]
	public static int GetFrameRate()
	{
		return default(int);
	}

	[Token(Token = "0x6000772")]
	[Address(RVA = "0x9FF9B8", Offset = "0x9FF9B8", VA = "0x9FF9B8")]
	public static string RemoveCommas(string text)
	{
		return null;
	}

	[Token(Token = "0x6000773")]
	[Address(RVA = "0x9FF928", Offset = "0x9FF928", VA = "0x9FF928")]
	public static void SetFrameRate(int frameRate, bool writeToDisk)
	{
	}

	[Token(Token = "0x6000774")]
	[Address(RVA = "0x9FFA24", Offset = "0x9FFA24", VA = "0x9FFA24")]
	public SettingsHelper()
	{
	}
}
