using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000364")]
	[Attribute(Name = "GroupAttribute", RVA = "0x81F1E0", Offset = "0x81F1E0")]
	public class RDRegent : BaseEntityDocument
	{
		[Token(Token = "0x40010A1")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "RequiredAttribute", RVA = "0x82A8B8", Offset = "0x82A8B8")]
		[Attribute(Name = "MultiEntityReference", RVA = "0x82A8B8", Offset = "0x82A8B8")]
		public string itemName;

		[Token(Token = "0x40010A2")]
		[FieldOffset(Offset = "0x38")]
		public long quantity;

		[Token(Token = "0x6001AE9")]
		[Address(RVA = "0x9BAA18", Offset = "0x9BAA18", VA = "0x9BAA18")]
		public RDRegent()
		{
		}
	}
}
