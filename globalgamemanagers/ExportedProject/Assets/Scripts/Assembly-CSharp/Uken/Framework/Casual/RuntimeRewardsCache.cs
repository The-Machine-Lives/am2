using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x2000516")]
	public class RuntimeRewardsCache : RuntimeDataCache<Reward, RDReward>
	{
		[Token(Token = "0x60026BE")]
		[Address(RVA = "0xA8C9E4", Offset = "0xA8C9E4", VA = "0xA8C9E4")]
		public RuntimeRewardsCache(DepotEntity<RDReward> depot)
		{
		}

		[Token(Token = "0x60026BF")]
		[Address(RVA = "0xA8CA44", Offset = "0xA8CA44", VA = "0xA8CA44", Slot = "4")]
		public override void Initialize()
		{
		}
	}
}
