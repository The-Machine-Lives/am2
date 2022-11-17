using System.Collections.Generic;
using Il2CppDummyDll;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x200051B")]
	public class TierDropRate : RuntimeData<RDTierDropRate>
	{
		[Token(Token = "0x2000848")]
		public class TierWeight : IWeighted
		{
			[Token(Token = "0x40023C0")]
			[FieldOffset(Offset = "0x10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8330B0", Offset = "0x8330B0")]
			private readonly EDropTier _003Ctier_003Ek__BackingField;

			[Token(Token = "0x40023C1")]
			[FieldOffset(Offset = "0x14")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8330C0", Offset = "0x8330C0")]
			private readonly int _003Cweight_003Ek__BackingField;

			[Token(Token = "0x17000830")]
			public EDropTier tier
			{
				[Token(Token = "0x6003361")]
				[Address(RVA = "0xA9AE90", Offset = "0xA9AE90", VA = "0xA9AE90")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83BD1C", Offset = "0x83BD1C")]
				get
				{
					return default(EDropTier);
				}
			}

			[Token(Token = "0x17000831")]
			public int weight
			{
				[Token(Token = "0x6003362")]
				[Address(RVA = "0xA9AF10", Offset = "0xA9AF10", VA = "0xA9AF10", Slot = "4")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83BD2C", Offset = "0x83BD2C")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x6003363")]
			[Address(RVA = "0xA9AE58", Offset = "0xA9AE58", VA = "0xA9AE58")]
			public TierWeight(EDropTier inTier, int inWeight)
			{
			}
		}

		[Token(Token = "0x40017EE")]
		[FieldOffset(Offset = "0x18")]
		private List<TierWeight> m_dropRates;

		[Token(Token = "0x40017EF")]
		[FieldOffset(Offset = "0x20")]
		private int m_totalWeight;

		[Token(Token = "0x60026D0")]
		[Address(RVA = "0xA9AC4C", Offset = "0xA9AC4C", VA = "0xA9AC4C", Slot = "4")]
		public override void Initialize(RDTierDropRate referenceData)
		{
		}

		[Token(Token = "0x60026D1")]
		[Address(RVA = "0xA9ADA4", Offset = "0xA9ADA4", VA = "0xA9ADA4")]
		private void InitializeDropWeight(EDropTier tier, int weight)
		{
		}

		[Token(Token = "0x60026D2")]
		[Address(RVA = "0xA8AB40", Offset = "0xA8AB40", VA = "0xA8AB40")]
		public List<EDropTier> RollForDrop()
		{
			return null;
		}

		[Token(Token = "0x60026D3")]
		[Address(RVA = "0xA9AE98", Offset = "0xA9AE98", VA = "0xA9AE98")]
		public TierDropRate()
		{
		}
	}
}
