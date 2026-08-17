using System.Collections.Generic;
using Il2CppDummyDll;

namespace Facebook.Unity
{
	[Token(Token = "0x2000026")]
	internal class CatalogResult : ResultBase, ICatalogResult, IResult
	{
		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8163C0", Offset = "0x8163C0")]
		private IList<Product> _003CProducts_003Ek__BackingField;

		[Token(Token = "0x17000047")]
		public IList<Product> Products
		{
			[Token(Token = "0x6000120")]
			[Address(RVA = "0xCCEDC0", Offset = "0xCCEDC0", VA = "0xCCEDC0", Slot = "19")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816B30", Offset = "0x816B30")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000121")]
			[Address(RVA = "0xCCEDB8", Offset = "0xCCEDB8", VA = "0xCCEDB8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816B40", Offset = "0x816B40")]
			private set
			{
			}
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0xCCEC90", Offset = "0xCCEC90", VA = "0xCCEC90")]
		public CatalogResult(ResultContainer resultContainer)
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0xCCEDC8", Offset = "0xCCEDC8", VA = "0xCCEDC8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
