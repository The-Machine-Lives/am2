using System.Collections.Generic;
using AM2;
using Il2CppDummyDll;
using Uken.Library.ReferenceData;
using Uken.Library.UkenTime;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x20004E9")]
	public class Alerts : DepotController
	{
		[Token(Token = "0x4001751")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<string, Alert> m_alertCache;

		[Token(Token = "0x4001752")]
		[FieldOffset(Offset = "0x28")]
		private CasualGame m_game;

		[Token(Token = "0x4001753")]
		[FieldOffset(Offset = "0x30")]
		private SharedDataCacheController m_dataCacheController;

		[Token(Token = "0x4001754")]
		[FieldOffset(Offset = "0x38")]
		private UserSegments m_userSegments;

		[Token(Token = "0x4001755")]
		[FieldOffset(Offset = "0x40")]
		private UserProfiler m_userProfiler;

		[Token(Token = "0x4001756")]
		[FieldOffset(Offset = "0x48")]
		private UkenTimeController m_time;

		[Token(Token = "0x17000669")]
		private DepotEntity<RDAlert> m_Alerts
		{
			[Token(Token = "0x60025E9")]
			[Address(RVA = "0xA251B4", Offset = "0xA251B4", VA = "0xA251B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60025EA")]
		[Address(RVA = "0xA2527C", Offset = "0xA2527C", VA = "0xA2527C")]
		public Alerts(DataStoreController controller)
		{
		}

		[Token(Token = "0x60025EB")]
		[Address(RVA = "0xA252FC", Offset = "0xA252FC", VA = "0xA252FC", Slot = "4")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x60025EC")]
		[Address(RVA = "0xA24D7C", Offset = "0xA24D7C", VA = "0xA24D7C")]
		public Alert Get(string reference)
		{
			return null;
		}

		[Token(Token = "0x60025ED")]
		[Address(RVA = "0xA25454", Offset = "0xA25454", VA = "0xA25454")]
		public List<Alert> GetAlertsToShow()
		{
			return null;
		}
	}
}
