using Il2CppDummyDll;

namespace Facebook.Unity
{
	[Token(Token = "0x2000048")]
	internal class PurchaseResult : ResultBase, IPurchaseResult, IResult
	{
		[Token(Token = "0x4000067")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816420", Offset = "0x816420")]
		private Purchase _003CPurchase_003Ek__BackingField;

		[Token(Token = "0x17000056")]
		public Purchase Purchase
		{
			[Token(Token = "0x6000147")]
			[Address(RVA = "0x17C192C", Offset = "0x17C192C", VA = "0x17C192C", Slot = "19")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816BE0", Offset = "0x816BE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000148")]
			[Address(RVA = "0x17C1924", Offset = "0x17C1924", VA = "0x17C1924")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816BF0", Offset = "0x816BF0")]
			private set
			{
			}
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x17BDC1C", Offset = "0x17BDC1C", VA = "0x17BDC1C")]
		public PurchaseResult(ResultContainer resultContainer)
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x17C1934", Offset = "0x17C1934", VA = "0x17C1934", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
