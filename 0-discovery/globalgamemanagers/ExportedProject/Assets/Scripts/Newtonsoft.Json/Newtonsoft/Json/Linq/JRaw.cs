using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq
{
	[Token(Token = "0x20000BF")]
	[Preserve]
	public class JRaw : JValue
	{
		[Token(Token = "0x600058D")]
		[Address(RVA = "0xFF3FF0", Offset = "0xFF3FF0", VA = "0xFF3FF0")]
		public JRaw(JRaw other)
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0xFF3FF8", Offset = "0xFF3FF8", VA = "0xFF3FF8")]
		public JRaw(object rawJson)
		{
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0xFF4004", Offset = "0xFF4004", VA = "0xFF4004")]
		public static JRaw Create(JsonReader reader)
		{
			return null;
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0xFF42EC", Offset = "0xFF42EC", VA = "0xFF42EC", Slot = "10")]
		internal override JToken CloneToken()
		{
			return null;
		}
	}
}
