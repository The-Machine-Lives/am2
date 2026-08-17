using Il2CppDummyDll;
using Uken.Framework.Casual;

namespace AM2.ReferenceData
{
	[Token(Token = "0x20003A3")]
	public class Task : RuntimeData<RDTask>
	{
		[Token(Token = "0x400118D")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82D94C", Offset = "0x82D94C")]
		private Formula _003CitemQuantityFormula_003Ek__BackingField;

		[Token(Token = "0x1700053C")]
		public string acquireText
		{
			[Token(Token = "0x6001C56")]
			[Address(RVA = "0x9714A8", Offset = "0x9714A8", VA = "0x9714A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700053D")]
		public string itemRef
		{
			[Token(Token = "0x6001C57")]
			[Address(RVA = "0x9714D4", Offset = "0x9714D4", VA = "0x9714D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700053E")]
		public long itemQuantity
		{
			[Token(Token = "0x6001C58")]
			[Address(RVA = "0x971500", Offset = "0x971500", VA = "0x971500")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x1700053F")]
		public Formula itemQuantityFormula
		{
			[Token(Token = "0x6001C59")]
			[Address(RVA = "0x97152C", Offset = "0x97152C", VA = "0x97152C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8386C0", Offset = "0x8386C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C5A")]
			[Address(RVA = "0x971534", Offset = "0x971534", VA = "0x971534")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8386D0", Offset = "0x8386D0")]
			private set
			{
			}
		}

		[Token(Token = "0x6001C5B")]
		[Address(RVA = "0x97153C", Offset = "0x97153C", VA = "0x97153C")]
		public Task()
		{
		}

		[Token(Token = "0x6001C5C")]
		[Address(RVA = "0x96E188", Offset = "0x96E188", VA = "0x96E188")]
		public void Setup(RuntimeDataCache<Formula, RDFormula> formulas)
		{
		}

		[Token(Token = "0x6001C5D")]
		[Address(RVA = "0x97158C", Offset = "0x97158C", VA = "0x97158C")]
		public long CalculateTaskFormula(long level)
		{
			return default(long);
		}
	}
}
