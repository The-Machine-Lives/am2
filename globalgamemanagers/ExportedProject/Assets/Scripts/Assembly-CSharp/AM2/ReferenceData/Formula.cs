using Il2CppDummyDll;
using Uken.Framework.Casual;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000358")]
	public class Formula : RuntimeData<RDFormula>
	{
		[Token(Token = "0x400104F")]
		[FieldOffset(Offset = "0x18")]
		private long m_previousLevel;

		[Token(Token = "0x4001050")]
		[FieldOffset(Offset = "0x20")]
		private double m_calculatedAmount;

		[Token(Token = "0x4001051")]
		[FieldOffset(Offset = "0x28")]
		private Formula nestedFormula1;

		[Token(Token = "0x4001052")]
		[FieldOffset(Offset = "0x30")]
		private Formula nestedFormula2;

		[Token(Token = "0x1700044A")]
		public EFormulaType formulaType
		{
			[Token(Token = "0x6001A72")]
			[Address(RVA = "0x9B32CC", Offset = "0x9B32CC", VA = "0x9B32CC")]
			get
			{
				return default(EFormulaType);
			}
		}

		[Token(Token = "0x1700044B")]
		public double bonusConstant
		{
			[Token(Token = "0x6001A73")]
			[Address(RVA = "0x9B32F8", Offset = "0x9B32F8", VA = "0x9B32F8")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x6001A74")]
		[Address(RVA = "0x9B3324", Offset = "0x9B3324", VA = "0x9B3324")]
		public Formula()
		{
		}

		[Token(Token = "0x6001A75")]
		[Address(RVA = "0x9B337C", Offset = "0x9B337C", VA = "0x9B337C", Slot = "4")]
		public override void Initialize(RDFormula referenceData)
		{
		}

		[Token(Token = "0x6001A76")]
		[Address(RVA = "0x9B33DC", Offset = "0x9B33DC", VA = "0x9B33DC")]
		public void PostInitialize()
		{
		}

		[Token(Token = "0x6001A77")]
		[Address(RVA = "0x9B3668", Offset = "0x9B3668", VA = "0x9B3668")]
		public bool IsBonusType()
		{
			return default(bool);
		}

		[Token(Token = "0x6001A78")]
		[Address(RVA = "0x9ABDFC", Offset = "0x9ABDFC", VA = "0x9ABDFC")]
		public double Calculate(long level)
		{
			return default(double);
		}

		[Token(Token = "0x6001A79")]
		[Address(RVA = "0x9AD440", Offset = "0x9AD440", VA = "0x9AD440")]
		public long CalculatedAmountLong(long level)
		{
			return default(long);
		}

		[Token(Token = "0x6001A7A")]
		[Address(RVA = "0x9B36F4", Offset = "0x9B36F4", VA = "0x9B36F4")]
		private double CalculateInternal(long level)
		{
			return default(double);
		}
	}
}
