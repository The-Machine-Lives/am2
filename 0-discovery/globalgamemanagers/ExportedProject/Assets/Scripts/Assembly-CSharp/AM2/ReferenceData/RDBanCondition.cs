using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x200037D")]
	[Attribute(Name = "GroupAttribute", RVA = "0x81F3D8", Offset = "0x81F3D8")]
	public class RDBanCondition : BaseEntityDocument
	{
		[Token(Token = "0x4001109")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82BA40", Offset = "0x82BA40")]
		public EBanType banType;

		[Token(Token = "0x400110A")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82BA78", Offset = "0x82BA78")]
		public string itemReference;

		[Token(Token = "0x400110B")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82BAB0", Offset = "0x82BAB0")]
		public long maxAmount;

		[Token(Token = "0x6001B9B")]
		[Address(RVA = "0x9BA1AC", Offset = "0x9BA1AC", VA = "0x9BA1AC")]
		public RDBanCondition(string inReference)
		{
		}
	}
}
