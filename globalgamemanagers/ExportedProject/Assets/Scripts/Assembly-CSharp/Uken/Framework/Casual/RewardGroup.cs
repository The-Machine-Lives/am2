using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x2000518")]
	public class RewardGroup : RuntimeData<RDRewardGroup>
	{
		[Token(Token = "0x2000846")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8214A8", Offset = "0x8214A8")]
		private sealed class _003C_003Ec__DisplayClass16_0
		{
			[Token(Token = "0x40023BB")]
			[FieldOffset(Offset = "0x10")]
			public bool excludeInvisibleRewards;

			[Token(Token = "0x600335A")]
			[Address(RVA = "0xA8B420", Offset = "0xA8B420", VA = "0xA8B420")]
			public _003C_003Ec__DisplayClass16_0()
			{
			}

			[Token(Token = "0x600335B")]
			[Address(RVA = "0xA8B58C", Offset = "0xA8B58C", VA = "0xA8B58C")]
			internal bool _003CBuildTransactionOfRewards_003Eb__0(Reward reward)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x2000847")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8214B8", Offset = "0x8214B8")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x40023BC")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x40023BD")]
			[FieldOffset(Offset = "0x8")]
			public static Func<Reward, string> _003C_003E9__16_1;

			[Token(Token = "0x40023BE")]
			[FieldOffset(Offset = "0x10")]
			public static Func<string, string> _003C_003E9__16_2;

			[Token(Token = "0x40023BF")]
			[FieldOffset(Offset = "0x18")]
			public static Func<string, long> _003C_003E9__16_3;

			[Token(Token = "0x600335D")]
			[Address(RVA = "0xA8B538", Offset = "0xA8B538", VA = "0xA8B538")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x600335E")]
			[Address(RVA = "0xA8B540", Offset = "0xA8B540", VA = "0xA8B540")]
			internal string _003CBuildTransactionOfRewards_003Eb__16_1(Reward r)
			{
				return null;
			}

			[Token(Token = "0x600335F")]
			[Address(RVA = "0xA8B57C", Offset = "0xA8B57C", VA = "0xA8B57C")]
			internal string _003CBuildTransactionOfRewards_003Eb__16_2(string k)
			{
				return null;
			}

			[Token(Token = "0x6003360")]
			[Address(RVA = "0xA8B584", Offset = "0xA8B584", VA = "0xA8B584")]
			internal long _003CBuildTransactionOfRewards_003Eb__16_3(string _)
			{
				return default(long);
			}
		}

		[Token(Token = "0x40017DD")]
		[FieldOffset(Offset = "0x18")]
		private List<Reward> rewards;

		[Token(Token = "0x40017DE")]
		[FieldOffset(Offset = "0x20")]
		private List<Reward> randomRewards;

		[Token(Token = "0x40017DF")]
		[FieldOffset(Offset = "0x28")]
		private RewardGroupsController m_rewardGroupsController;

		[Token(Token = "0x40017E0")]
		[FieldOffset(Offset = "0x30")]
		private TierDropRate m_tierDropRate;

		[Token(Token = "0x40017E1")]
		[FieldOffset(Offset = "0x38")]
		private TierDropSet m_tierDropSet;

		[Token(Token = "0x60026C1")]
		[Address(RVA = "0xA89FE8", Offset = "0xA89FE8", VA = "0xA89FE8", Slot = "4")]
		public override void Initialize(RDRewardGroup referenceData)
		{
		}

		[Token(Token = "0x60026C2")]
		[Address(RVA = "0xA8A2A8", Offset = "0xA8A2A8", VA = "0xA8A2A8")]
		public List<Reward> GetAllRewardsUnfiltered()
		{
			return null;
		}

		[Token(Token = "0x60026C3")]
		[Address(RVA = "0xA8A2B0", Offset = "0xA8A2B0", VA = "0xA8A2B0")]
		public List<Reward> GetPossibleAwardAllRewards()
		{
			return null;
		}

		[Token(Token = "0x60026C4")]
		[Address(RVA = "0xA8A480", Offset = "0xA8A480", VA = "0xA8A480")]
		public List<Reward> GetPossibleAwardAllRewardsThatCanBeShown()
		{
			return null;
		}

		[Token(Token = "0x60026C5")]
		[Address(RVA = "0xA8A5B0", Offset = "0xA8A5B0", VA = "0xA8A5B0")]
		public List<Reward> GetRewards(bool ignorePercentChance = false)
		{
			return null;
		}

		[Token(Token = "0x60026C6")]
		[Address(RVA = "0xA8AA7C", Offset = "0xA8AA7C", VA = "0xA8AA7C")]
		public List<Reward> GetRewardsThatCanBeShown(bool ignorePercentChance = false)
		{
			return null;
		}

		[Token(Token = "0x60026C7")]
		[Address(RVA = "0xA8A498", Offset = "0xA8A498", VA = "0xA8A498")]
		private List<Reward> RemoveAllHiddenRewards(List<Reward> rewardsList)
		{
			return null;
		}

		[Token(Token = "0x60026C8")]
		[Address(RVA = "0xA8A658", Offset = "0xA8A658", VA = "0xA8A658")]
		private void AddRandomRewards(List<Reward> rewardsToAddTo, bool ignorePercentChance)
		{
		}

		[Token(Token = "0x60026C9")]
		[Address(RVA = "0xA8A804", Offset = "0xA8A804", VA = "0xA8A804")]
		private void AddNormalRewards(List<Reward> rewardsToAddTo, bool ignorePercentChance)
		{
		}

		[Token(Token = "0x60026CA")]
		[Address(RVA = "0xA8A934", Offset = "0xA8A934", VA = "0xA8A934")]
		private void AddTieredRewards(List<Reward> rewardsToAddTo, bool ignorePercentChance)
		{
		}

		[Token(Token = "0x60026CB")]
		[Address(RVA = "0xA8AA98", Offset = "0xA8AA98", VA = "0xA8AA98")]
		private void AddAwardBasedOnChance(List<Reward> rewardsToAddTo, Reward reward, bool ignorePercentChange)
		{
		}

		[Token(Token = "0x60026CC")]
		[Address(RVA = "0xA8AE54", Offset = "0xA8AE54", VA = "0xA8AE54")]
		public Dictionary<string, long> BuildTransactionOfRewards(bool ignorePercentChance = false, long volume = 1L, long formulaLevel = 0L, bool excludeInvisibleRewards = false)
		{
			return null;
		}

		[Token(Token = "0x60026CD")]
		[Address(RVA = "0xA8B428", Offset = "0xA8B428", VA = "0xA8B428")]
		public Dictionary<string, long> DisplayedRewardTransaction()
		{
			return null;
		}

		[Token(Token = "0x60026CE")]
		[Address(RVA = "0xA8B43C", Offset = "0xA8B43C", VA = "0xA8B43C")]
		public RewardGroup()
		{
		}
	}
}
