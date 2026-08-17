using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x200037F")]
	[Attribute(Name = "GroupAttribute", RVA = "0x81F410", Offset = "0x81F410")]
	public class RDGlobalScaler : BaseEntityDocument
	{
		[Token(Token = "0x20007A8")]
		public enum ScalerOperation
		{
			[Token(Token = "0x400224F")]
			Add = 0,
			[Token(Token = "0x4002250")]
			Subtract = 1,
			[Token(Token = "0x4002251")]
			Divide = 2,
			[Token(Token = "0x4002252")]
			Multiply = 3
		}

		[Token(Token = "0x400110C")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "EntityReference", RVA = "0x82BAE8", Offset = "0x82BAE8")]
		public string upgradable;

		[Token(Token = "0x400110D")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "EntityReference", RVA = "0x82BB20", Offset = "0x82BB20")]
		public string scalingFormula;

		[Token(Token = "0x400110E")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x82BB58", Offset = "0x82BB58")]
		public ScalerOperation scalerOperation;

		[Token(Token = "0x6001BA0")]
		[Address(RVA = "0x9BA564", Offset = "0x9BA564", VA = "0x9BA564")]
		public RDGlobalScaler(string inReference)
		{
		}
	}
}
