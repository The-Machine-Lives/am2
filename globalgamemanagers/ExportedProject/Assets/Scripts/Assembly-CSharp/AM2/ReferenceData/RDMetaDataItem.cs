using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x20003BB")]
	[Attribute(Name = "GroupAttribute", RVA = "0x81F950", Offset = "0x81F950")]
	public class RDMetaDataItem : BaseEntityDocument
	{
		[Token(Token = "0x6001CBE")]
		[Address(RVA = "0x9BA628", Offset = "0x9BA628", VA = "0x9BA628")]
		private RDMetaDataItem()
		{
		}

		[Token(Token = "0x6001CBF")]
		[Address(RVA = "0x9BA630", Offset = "0x9BA630", VA = "0x9BA630")]
		public RDMetaDataItem(string _refName)
		{
		}
	}
}
