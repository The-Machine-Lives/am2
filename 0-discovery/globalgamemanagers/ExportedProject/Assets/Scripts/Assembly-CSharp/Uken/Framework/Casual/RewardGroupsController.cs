using System.Collections.Generic;
using AM2;
using Il2CppDummyDll;
using Uken.Core;
using Uken.Library.Inventory;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x200051E")]
	public class RewardGroupsController : UkenController
	{
		[Token(Token = "0x40017F6")]
		[FieldOffset(Offset = "0x18")]
		private HashSet<string> s_oneTimeItemTypes;

		[Token(Token = "0x40017F7")]
		[FieldOffset(Offset = "0x20")]
		private SharedDataCacheController m_dataCacheController;

		[Token(Token = "0x40017F8")]
		[FieldOffset(Offset = "0x28")]
		private InventoryController m_inventoryController;

		[Token(Token = "0x170006AB")]
		public RuntimeDataCache<RewardGroup, RDRewardGroup> rewardGroupsCache
		{
			[Token(Token = "0x60026DA")]
			[Address(RVA = "0xA8B5E0", Offset = "0xA8B5E0", VA = "0xA8B5E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60026DB")]
		[Address(RVA = "0xA8B610", Offset = "0xA8B610", VA = "0xA8B610")]
		public RewardGroupsController(SharedDataCacheController dataCacheController, InventoryController inventoryController)
		{
		}

		[Token(Token = "0x60026DC")]
		[Address(RVA = "0xA8B7FC", Offset = "0xA8B7FC", VA = "0xA8B7FC")]
		public RewardGroup Get(string reference)
		{
			return null;
		}

		[Token(Token = "0x60026DD")]
		[Address(RVA = "0xA8A410", Offset = "0xA8A410", VA = "0xA8A410")]
		public Reward GetRewardToGive(Reward reward, List<Reward> pendingRewards)
		{
			return null;
		}

		[Token(Token = "0x60026DE")]
		[Address(RVA = "0xA8B834", Offset = "0xA8B834", VA = "0xA8B834")]
		public bool IsOneTimeReward(Reward reward)
		{
			return default(bool);
		}

		[Token(Token = "0x60026DF")]
		[Address(RVA = "0xA8AE00", Offset = "0xA8AE00", VA = "0xA8AE00")]
		public bool IsOneTimeRewardAndOwned(Reward reward, List<Reward> pendingRewards)
		{
			return default(bool);
		}

		[Token(Token = "0x60026E0")]
		[Address(RVA = "0xA8B900", Offset = "0xA8B900", VA = "0xA8B900")]
		public bool IsOneTimeRewardAlreadyGiven(Reward reward, List<Reward> pendingRewards)
		{
			return default(bool);
		}
	}
}
