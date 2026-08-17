using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x2000525")]
	public class LTOSets : DepotController
	{
		[Token(Token = "0x4001836")]
		[FieldOffset(Offset = "0x20")]
		private CasualGame m_game;

		[Token(Token = "0x4001837")]
		[FieldOffset(Offset = "0x28")]
		private DynamicSaleItemController m_dynamicSaleItemCntrl;

		[Token(Token = "0x4001838")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<string, LTOSet> m_LTOSetCache;

		[Token(Token = "0x170006D3")]
		private DepotEntity<RDLTOSet> m_LTOSets
		{
			[Token(Token = "0x600276C")]
			[Address(RVA = "0xA6E04C", Offset = "0xA6E04C", VA = "0xA6E04C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600276D")]
		[Address(RVA = "0xA6E1B0", Offset = "0xA6E1B0", VA = "0xA6E1B0")]
		public LTOSets(CasualGame game, DynamicSaleItemController dynamicSaleItemCntrl, CasualDataStoreController dataStore)
		{
		}

		[Token(Token = "0x600276E")]
		[Address(RVA = "0xA6E248", Offset = "0xA6E248", VA = "0xA6E248", Slot = "9")]
		public override void OnDataUpdated()
		{
		}

		[Token(Token = "0x600276F")]
		[Address(RVA = "0xA6E2B4", Offset = "0xA6E2B4", VA = "0xA6E2B4")]
		public LTOSet Get(string reference)
		{
			return null;
		}

		[Token(Token = "0x6002770")]
		[Address(RVA = "0xA6E5FC", Offset = "0xA6E5FC", VA = "0xA6E5FC")]
		public List<LTOSet> GetLTOSetsForSurfacePoint(int surfacePoint)
		{
			return null;
		}

		[Token(Token = "0x6002771")]
		[Address(RVA = "0xA6E3A4", Offset = "0xA6E3A4", VA = "0xA6E3A4")]
		private LTOSet ConstructLTOSet(RDLTOSet ltoSetData)
		{
			return null;
		}
	}
}
