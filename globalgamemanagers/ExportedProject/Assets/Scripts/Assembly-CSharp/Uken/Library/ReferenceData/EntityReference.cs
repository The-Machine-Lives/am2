using Il2CppDummyDll;

namespace Uken.Library.ReferenceData
{
	[Token(Token = "0x2000471")]
	public class EntityReference : DropdownAttribute
	{
		[Token(Token = "0x400148D")]
		[FieldOffset(Offset = "0x18")]
		public string Depot;

		[Token(Token = "0x6002110")]
		[Address(RVA = "0xB37AE0", Offset = "0xB37AE0", VA = "0xB37AE0")]
		public EntityReference(string _depot)
		{
		}
	}
}
