using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Uken.Core
{
	[Token(Token = "0x20003C7")]
	public class JSONHelper
	{
		[Token(Token = "0x40011E4")]
		[FieldOffset(Offset = "0x0")]
		private static JsonConverter dictionaryConverter;

		[Token(Token = "0x6001D38")]
		public static T Parse<T>(string jsonString) where T : class
		{
			return null;
		}

		[Token(Token = "0x6001D39")]
		[Address(RVA = "0xA186DC", Offset = "0xA186DC", VA = "0xA186DC")]
		public static string ToJson(object o, Formatting formatting = Formatting.None)
		{
			return null;
		}

		[Token(Token = "0x6001D3A")]
		[Address(RVA = "0xA18754", Offset = "0xA18754", VA = "0xA18754")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x8387C0", Offset = "0x8387C0")]
		public static object ParseLegacy(string jsonString)
		{
			return null;
		}

		[Token(Token = "0x6001D3B")]
		[Address(RVA = "0xA18870", Offset = "0xA18870", VA = "0xA18870")]
		public JSONHelper()
		{
		}
	}
}
