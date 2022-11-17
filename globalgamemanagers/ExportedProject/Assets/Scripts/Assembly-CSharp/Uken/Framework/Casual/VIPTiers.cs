using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Library.Inventory;
using Uken.Library.ReferenceData;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x2000557")]
	public class VIPTiers : DepotController
	{
		[Serializable]
		[Token(Token = "0x2000852")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8214E8", Offset = "0x8214E8")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x40023E6")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x40023E7")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<VIPTier> _003C_003E9__9_0;

			[Token(Token = "0x6003376")]
			[Address(RVA = "0xAA1480", Offset = "0xAA1480", VA = "0xAA1480")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6003377")]
			[Address(RVA = "0xAA1488", Offset = "0xAA1488", VA = "0xAA1488")]
			internal int _003CGetAllVIPTiers_003Eb__9_0(VIPTier a, VIPTier b)
			{
				return default(int);
			}
		}

		[Token(Token = "0x4001978")]
		public const string VIP_FEATURE_KEY = "vip_system";

		[Token(Token = "0x4001979")]
		public const string VIP_POINTS_ITEM = "vip_points";

		[Token(Token = "0x400197A")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<string, VIPTier> m_tierMap;

		[Token(Token = "0x400197B")]
		[FieldOffset(Offset = "0x28")]
		private InventoryController m_inventory;

		[Token(Token = "0x1700073B")]
		private DepotEntity<RDVIPTier> m_vipTiers
		{
			[Token(Token = "0x60028E6")]
			[Address(RVA = "0xAA0A20", Offset = "0xAA0A20", VA = "0xAA0A20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60028E7")]
		[Address(RVA = "0xAA0B88", Offset = "0xAA0B88", VA = "0xAA0B88")]
		public VIPTiers(DataStoreController controller, InventoryController inventory)
		{
		}

		[Token(Token = "0x60028E8")]
		[Address(RVA = "0xAA0C14", Offset = "0xAA0C14", VA = "0xAA0C14")]
		public bool IsEnabled()
		{
			return default(bool);
		}

		[Token(Token = "0x60028E9")]
		[Address(RVA = "0xAA0C94", Offset = "0xAA0C94", VA = "0xAA0C94")]
		public long GetVIPPoints()
		{
			return default(long);
		}

		[Token(Token = "0x60028EA")]
		[Address(RVA = "0xAA0D10", Offset = "0xAA0D10", VA = "0xAA0D10")]
		public List<VIPTier> GetAllVIPTiers()
		{
			return null;
		}

		[Token(Token = "0x60028EB")]
		[Address(RVA = "0xA9F178", Offset = "0xA9F178", VA = "0xA9F178")]
		public VIPTier GetCurrentVIPTier()
		{
			return null;
		}

		[Token(Token = "0x60028EC")]
		[Address(RVA = "0xAA123C", Offset = "0xAA123C", VA = "0xAA123C")]
		public long GetVipPointsInRewards(RewardGroup rewardGroup)
		{
			return default(long);
		}

		[Token(Token = "0x60028ED")]
		[Address(RVA = "0xAA0F80", Offset = "0xAA0F80", VA = "0xAA0F80")]
		public VIPTier Get(string reference)
		{
			return null;
		}

		[Token(Token = "0x60028EE")]
		[Address(RVA = "0xAA13C0", Offset = "0xAA13C0", VA = "0xAA13C0")]
		public VIPTier GetNextVIPTier()
		{
			return null;
		}

		[Token(Token = "0x60028EF")]
		[Address(RVA = "0xAA10B8", Offset = "0xAA10B8", VA = "0xAA10B8")]
		protected VIPTier GetByTier(int tier)
		{
			return null;
		}
	}
}
