using System.Collections.Generic;
using Il2CppDummyDll;

namespace Facebook.Unity
{
	[Token(Token = "0x2000049")]
	internal class PurchasesResult : ResultBase, IPurchasesResult, IResult
	{
		[Token(Token = "0x4000068")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816430", Offset = "0x816430")]
		private IList<Purchase> _003CPurchases_003Ek__BackingField;

		[Token(Token = "0x17000057")]
		public IList<Purchase> Purchases
		{
			[Token(Token = "0x600014B")]
			[Address(RVA = "0x17C2434", Offset = "0x17C2434", VA = "0x17C2434", Slot = "19")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816C00", Offset = "0x816C00")]
			get
			{
				return null;
			}
			[Token(Token = "0x600014C")]
			[Address(RVA = "0x17C242C", Offset = "0x17C242C", VA = "0x17C242C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816C10", Offset = "0x816C10")]
			private set
			{
			}
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x17BDA70", Offset = "0x17BDA70", VA = "0x17BDA70")]
		public PurchasesResult(ResultContainer resultContainer)
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x17C243C", Offset = "0x17C243C", VA = "0x17C243C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
