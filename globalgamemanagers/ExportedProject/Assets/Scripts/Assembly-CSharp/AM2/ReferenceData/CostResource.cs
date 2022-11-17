using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Framework.Casual;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000352")]
	public class CostResource : RuntimeData<RDCostResource>
	{
		[Token(Token = "0x4001017")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x829484", Offset = "0x829484")]
		private Formula _003Cformula_003Ek__BackingField;

		[Token(Token = "0x17000438")]
		public string itemRef
		{
			[Token(Token = "0x6001A39")]
			[Address(RVA = "0x9AEDF8", Offset = "0x9AEDF8", VA = "0x9AEDF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000439")]
		public Formula formula
		{
			[Token(Token = "0x6001A3A")]
			[Address(RVA = "0x9AEE24", Offset = "0x9AEE24", VA = "0x9AEE24")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837E00", Offset = "0x837E00")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001A3B")]
			[Address(RVA = "0x9AEE2C", Offset = "0x9AEE2C", VA = "0x9AEE2C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837E10", Offset = "0x837E10")]
			private set
			{
			}
		}

		[Token(Token = "0x6001A3C")]
		[Address(RVA = "0x9AEE34", Offset = "0x9AEE34", VA = "0x9AEE34")]
		public static Dictionary<string, long> GetCostsDict(long level, List<CostResource> costResources)
		{
			return null;
		}

		[Token(Token = "0x6001A3D")]
		[Address(RVA = "0x9AEFD0", Offset = "0x9AEFD0", VA = "0x9AEFD0")]
		public void Setup(RuntimeDataCache<Formula, RDFormula> formulas)
		{
		}

		[Token(Token = "0x6001A3E")]
		[Address(RVA = "0x9AEF9C", Offset = "0x9AEF9C", VA = "0x9AEF9C")]
		public long CalculateCost(long level)
		{
			return default(long);
		}

		[Token(Token = "0x6001A3F")]
		[Address(RVA = "0x9AF058", Offset = "0x9AF058", VA = "0x9AF058")]
		public CostResource()
		{
		}
	}
}
