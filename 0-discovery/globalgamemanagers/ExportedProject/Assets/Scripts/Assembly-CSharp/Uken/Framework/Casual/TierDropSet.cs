using System.Collections.Generic;
using AM2;
using Il2CppDummyDll;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x200051D")]
	public class TierDropSet : RuntimeData<RDTierDropSet>
	{
		[Token(Token = "0x2000849")]
		private class TierRewards
		{
			[Token(Token = "0x40023C2")]
			[FieldOffset(Offset = "0x10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8330D0", Offset = "0x8330D0")]
			private readonly EDropTier _003Ctier_003Ek__BackingField;

			[Token(Token = "0x40023C3")]
			[FieldOffset(Offset = "0x18")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8330E0", Offset = "0x8330E0")]
			private readonly List<Reward> _003Crewards_003Ek__BackingField;

			[Token(Token = "0x40023C4")]
			[FieldOffset(Offset = "0x20")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8330F0", Offset = "0x8330F0")]
			private int _003CtotalWeight_003Ek__BackingField;

			[Token(Token = "0x17000832")]
			public EDropTier tier
			{
				[Token(Token = "0x6003364")]
				[Address(RVA = "0xA9B574", Offset = "0xA9B574", VA = "0xA9B574")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83BD3C", Offset = "0x83BD3C")]
				get
				{
					return default(EDropTier);
				}
			}

			[Token(Token = "0x17000833")]
			public List<Reward> rewards
			{
				[Token(Token = "0x6003365")]
				[Address(RVA = "0xA9B56C", Offset = "0xA9B56C", VA = "0xA9B56C")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83BD4C", Offset = "0x83BD4C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000834")]
			public int totalWeight
			{
				[Token(Token = "0x6003366")]
				[Address(RVA = "0xA9B57C", Offset = "0xA9B57C", VA = "0xA9B57C")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83BD5C", Offset = "0x83BD5C")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6003367")]
				[Address(RVA = "0xA9B584", Offset = "0xA9B584", VA = "0xA9B584")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83BD6C", Offset = "0x83BD6C")]
				set
				{
				}
			}

			[Token(Token = "0x6003368")]
			[Address(RVA = "0xA9B2A4", Offset = "0xA9B2A4", VA = "0xA9B2A4")]
			public TierRewards(EDropTier inTier, List<Reward> inRewards, int inTotalWeight)
			{
			}
		}

		[Token(Token = "0x40017F4")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<EDropTier, TierRewards> m_rewards;

		[Token(Token = "0x40017F5")]
		[FieldOffset(Offset = "0x20")]
		private RewardGroupsController m_rewardGroupsController;

		[Token(Token = "0x60026D5")]
		[Address(RVA = "0xA9AF18", Offset = "0xA9AF18", VA = "0xA9AF18", Slot = "4")]
		public override void Initialize(RDTierDropSet referenceData)
		{
		}

		[Token(Token = "0x60026D6")]
		[Address(RVA = "0xA9B1D0", Offset = "0xA9B1D0", VA = "0xA9B1D0")]
		private TierRewards InitializeTierRewards(SharedDataCacheController dataCacheController, EDropTier tier, List<string> rewardRefs)
		{
			return null;
		}

		[Token(Token = "0x60026D7")]
		[Address(RVA = "0xA9B2E8", Offset = "0xA9B2E8", VA = "0xA9B2E8")]
		private TierRewards CullOwnedRewards(TierRewards tierRewards, List<Reward> rewardsSoFar)
		{
			return null;
		}

		[Token(Token = "0x60026D8")]
		[Address(RVA = "0xA8AC64", Offset = "0xA8AC64", VA = "0xA8AC64")]
		public List<Reward> GetRewards(List<EDropTier> tiersToReward)
		{
			return null;
		}

		[Token(Token = "0x60026D9")]
		[Address(RVA = "0xA9B58C", Offset = "0xA9B58C", VA = "0xA9B58C")]
		public TierDropSet()
		{
		}
	}
}
