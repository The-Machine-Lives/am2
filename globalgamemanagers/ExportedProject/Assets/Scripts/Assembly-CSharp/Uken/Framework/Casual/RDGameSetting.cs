using Il2CppDummyDll;
using Newtonsoft.Json;
using Uken.Library.ReferenceData;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x20004FA")]
	public class RDGameSetting : BaseEntityDocument
	{
		[Token(Token = "0x4001781")]
		[FieldOffset(Offset = "0x30")]
		public string value;

		[Token(Token = "0x600264D")]
		[Address(RVA = "0xA81150", Offset = "0xA81150", VA = "0xA81150")]
		[JsonConstructor]
		public RDGameSetting(string _ref)
		{
		}

		[Token(Token = "0x600264E")]
		[Address(RVA = "0xA811B0", Offset = "0xA811B0", VA = "0xA811B0")]
		public RDGameSetting(string _refName, string _value)
		{
		}
	}
}
