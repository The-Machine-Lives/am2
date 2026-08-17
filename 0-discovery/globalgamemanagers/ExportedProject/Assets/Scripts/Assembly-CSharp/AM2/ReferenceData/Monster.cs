using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Framework.Casual;

namespace AM2.ReferenceData
{
	[Token(Token = "0x200032D")]
	public class Monster : RuntimeData<RDMonster>, IItemModel, IInfoText
	{
		[Token(Token = "0x4000FB8")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x828514", Offset = "0x828514")]
		private List<Buff> _003CstartingBuffs_003Ek__BackingField;

		[Token(Token = "0x4000FB9")]
		[FieldOffset(Offset = "0x20")]
		public HealthType healthType;

		[Token(Token = "0x4000FBA")]
		[FieldOffset(Offset = "0x28")]
		private int m_totalAbilityGroupWeight;

		[Token(Token = "0x4000FBB")]
		[FieldOffset(Offset = "0x30")]
		private List<AbilityGroup> m_abilityGroups;

		[Token(Token = "0x4000FBC")]
		[FieldOffset(Offset = "0x38")]
		private RewardGroup rewardGroup;

		[Token(Token = "0x170003EC")]
		public string readableItemName
		{
			[Token(Token = "0x6001999")]
			[Address(RVA = "0x9B60E4", Offset = "0x9B60E4", VA = "0x9B60E4", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003ED")]
		public List<Buff> startingBuffs
		{
			[Token(Token = "0x600199A")]
			[Address(RVA = "0x9B6110", Offset = "0x9B6110", VA = "0x9B6110")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837C50", Offset = "0x837C50")]
			get
			{
				return null;
			}
			[Token(Token = "0x600199B")]
			[Address(RVA = "0x9B6118", Offset = "0x9B6118", VA = "0x9B6118")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837C60", Offset = "0x837C60")]
			private set
			{
			}
		}

		[Token(Token = "0x170003EE")]
		public long health
		{
			[Token(Token = "0x600199C")]
			[Address(RVA = "0x9B6120", Offset = "0x9B6120", VA = "0x9B6120")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x170003EF")]
		public string healthTypeKey
		{
			[Token(Token = "0x600199D")]
			[Address(RVA = "0x9B614C", Offset = "0x9B614C", VA = "0x9B614C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003F0")]
		public bool isThreat
		{
			[Token(Token = "0x600199E")]
			[Address(RVA = "0x9A61E0", Offset = "0x9A61E0", VA = "0x9A61E0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170003F1")]
		public bool HasAnyAbilities
		{
			[Token(Token = "0x600199F")]
			[Address(RVA = "0x9A6088", Offset = "0x9A6088", VA = "0x9A6088")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170003F2")]
		public long level
		{
			[Token(Token = "0x60019A0")]
			[Address(RVA = "0x9A6054", Offset = "0x9A6054", VA = "0x9A6054")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x170003F3")]
		public BISoundEvents.EventKey deathSoundEventOverride
		{
			[Token(Token = "0x60019A1")]
			[Address(RVA = "0x9A6730", Offset = "0x9A6730", VA = "0x9A6730")]
			get
			{
				return default(BISoundEvents.EventKey);
			}
		}

		[Token(Token = "0x170003F4")]
		public string description
		{
			[Token(Token = "0x60019A2")]
			[Address(RVA = "0x9B6178", Offset = "0x9B6178", VA = "0x9B6178", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003F5")]
		public string researchInfoText
		{
			[Token(Token = "0x60019A3")]
			[Address(RVA = "0x9B61C8", Offset = "0x9B61C8", VA = "0x9B61C8", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003F6")]
		public string infoImageSource
		{
			[Token(Token = "0x60019A4")]
			[Address(RVA = "0x9B6218", Offset = "0x9B6218", VA = "0x9B6218", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60019A5")]
		[Address(RVA = "0x9B6268", Offset = "0x9B6268", VA = "0x9B6268")]
		public void Setup(RuntimeDataCache<RewardGroup, RDRewardGroup> rewardGroupsCache, RuntimeDataCache<AbilityGroup, RDAbilityGroup> abilityGroupsCache, RuntimeDataCache<Buff, RDBuff> buffsCache, RuntimeDataCache<HealthType, RDHealthType> healthTypesCache)
		{
		}

		[Token(Token = "0x60019A6")]
		[Address(RVA = "0x9A60FC", Offset = "0x9A60FC", VA = "0x9A60FC")]
		public AbilityGroup SelectAbilityGroup()
		{
			return null;
		}

		[Token(Token = "0x60019A7")]
		[Address(RVA = "0x9B64C4", Offset = "0x9B64C4", VA = "0x9B64C4")]
		public List<Reward> GetRewards()
		{
			return null;
		}

		[Token(Token = "0x60019A8")]
		[Address(RVA = "0x9B6548", Offset = "0x9B6548", VA = "0x9B6548")]
		public Monster()
		{
		}
	}
}
