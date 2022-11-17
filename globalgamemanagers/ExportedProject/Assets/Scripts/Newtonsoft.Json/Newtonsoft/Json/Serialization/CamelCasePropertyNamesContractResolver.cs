using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x2000087")]
	[Preserve]
	public class CamelCasePropertyNamesContractResolver : DefaultContractResolver
	{
		[Token(Token = "0x60003B9")]
		[Address(RVA = "0xD07770", Offset = "0xD07770", VA = "0xD07770")]
		public CamelCasePropertyNamesContractResolver()
		{
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0xD0780C", Offset = "0xD0780C", VA = "0xD0780C", Slot = "21")]
		protected override string ResolvePropertyName(string propertyName)
		{
			return null;
		}
	}
}
