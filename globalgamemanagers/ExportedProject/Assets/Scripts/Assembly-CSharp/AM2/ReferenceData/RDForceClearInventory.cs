using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000373")]
	[Attribute(Name = "GroupAttribute", RVA = "0x81F330", Offset = "0x81F330")]
	public class RDForceClearInventory : BaseEntityDocument
	{
		[Token(Token = "0x40010FE")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82B83C", Offset = "0x82B83C")]
		public string m_minVersion;

		[Token(Token = "0x6001B7E")]
		[Address(RVA = "0x9BA4A0", Offset = "0x9BA4A0", VA = "0x9BA4A0")]
		public RDForceClearInventory()
		{
		}
	}
}
