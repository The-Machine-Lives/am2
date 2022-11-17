using Il2CppDummyDll;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000356")]
	public enum EFormulaType
	{
		[Token(Token = "0x4001035")]
		Linear = 0,
		[Token(Token = "0x4001036")]
		ExponentialGrowth = 1,
		[Token(Token = "0x4001037")]
		ExponentialDecay = 2,
		[Token(Token = "0x4001038")]
		ContinuousGrowthDecay = 3,
		[Token(Token = "0x4001039")]
		LogarithmicGrowth = 4,
		[Token(Token = "0x400103A")]
		LogisticsGrowth = 5,
		[Token(Token = "0x400103B")]
		LinearWithLinearBonusIncrement = 6,
		[Token(Token = "0x400103C")]
		CustomNumbers = 7,
		[Token(Token = "0x400103D")]
		LinearWithExponentialBonus = 8,
		[Token(Token = "0x400103E")]
		NewUltimateFormula = 9,
		[Token(Token = "0x400103F")]
		IntervalNestedFormula1 = 10,
		[Token(Token = "0x4001040")]
		Bonus1 = 11,
		[Token(Token = "0x4001041")]
		CustomNumbersWithIndices = 12
	}
}
