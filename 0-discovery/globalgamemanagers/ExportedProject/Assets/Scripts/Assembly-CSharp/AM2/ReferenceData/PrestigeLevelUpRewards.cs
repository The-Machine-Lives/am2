using Il2CppDummyDll;
using Uken.Framework.Casual;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000384")]
	public class PrestigeLevelUpRewards : RuntimeData<RDPrestigeLevelUpRewards>
	{
		[Token(Token = "0x400112E")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82C320", Offset = "0x82C320")]
		private RewardGroup _003CprestigeRewardGroup_003Ek__BackingField;

		[Token(Token = "0x170004E5")]
		public RewardGroup prestigeRewardGroup
		{
			[Token(Token = "0x6001BB5")]
			[Address(RVA = "0x9B7370", Offset = "0x9B7370", VA = "0x9B7370")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838480", Offset = "0x838480")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001BB6")]
			[Address(RVA = "0x9B7378", Offset = "0x9B7378", VA = "0x9B7378")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838490", Offset = "0x838490")]
			private set
			{
			}
		}

		[Token(Token = "0x6001BB7")]
		[Address(RVA = "0x9B7380", Offset = "0x9B7380", VA = "0x9B7380")]
		public PrestigeLevelUpRewards()
		{
		}

		[Token(Token = "0x6001BB8")]
		[Address(RVA = "0x9B73D0", Offset = "0x9B73D0", VA = "0x9B73D0")]
		public void Setup(RuntimeDataCache<RewardGroup, RDRewardGroup> rewardGroupsCache)
		{
		}
	}
}
