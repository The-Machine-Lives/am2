using Il2CppDummyDll;

namespace Uken.Core
{
	[Token(Token = "0x20003CE")]
	public class UkenPlayerPrefs
	{
		[Token(Token = "0x6001D7E")]
		public static T GetObject<T>(string key) where T : class, new()
		{
			return null;
		}

		[Token(Token = "0x6001D7F")]
		public static void SetObject<T>(string key, T updatedObject)
		{
		}

		[Token(Token = "0x6001D80")]
		[Address(RVA = "0xA1C8A4", Offset = "0xA1C8A4", VA = "0xA1C8A4")]
		public static bool GetBool(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x6001D81")]
		[Address(RVA = "0xA1C8E8", Offset = "0xA1C8E8", VA = "0xA1C8E8")]
		public static bool GetBool(string key, bool defaultValue)
		{
			return default(bool);
		}

		[Token(Token = "0x6001D82")]
		[Address(RVA = "0xA1C92C", Offset = "0xA1C92C", VA = "0xA1C92C")]
		public static void SetBool(string key, bool value)
		{
		}

		[Token(Token = "0x6001D83")]
		[Address(RVA = "0xA1C938", Offset = "0xA1C938", VA = "0xA1C938")]
		public UkenPlayerPrefs()
		{
		}
	}
}
