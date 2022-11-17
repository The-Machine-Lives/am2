using System.Collections.Generic;
using AM2;
using Il2CppDummyDll;
using Uken.Library.ReferenceData;
using Uken.Library.UkenTime;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x20004E7")]
	public class AlertEvents : DepotController
	{
		[Token(Token = "0x4001743")]
		[FieldOffset(Offset = "0x20")]
		private CasualGame m_game;

		[Token(Token = "0x4001744")]
		[FieldOffset(Offset = "0x28")]
		private SharedDataCacheController m_dataCacheController;

		[Token(Token = "0x4001745")]
		[FieldOffset(Offset = "0x30")]
		private UserSegments m_userSegments;

		[Token(Token = "0x4001746")]
		[FieldOffset(Offset = "0x38")]
		private UserProfiler m_userProfiler;

		[Token(Token = "0x4001747")]
		[FieldOffset(Offset = "0x40")]
		private UkenTimeController m_time;

		[Token(Token = "0x4001748")]
		[FieldOffset(Offset = "0x48")]
		private Alerts m_alerts;

		[Token(Token = "0x1700065D")]
		private DepotEntity<RDAlertEvent> m_AlertEvents
		{
			[Token(Token = "0x60025CD")]
			[Address(RVA = "0xA248A8", Offset = "0xA248A8", VA = "0xA248A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60025CE")]
		[Address(RVA = "0xA24974", Offset = "0xA24974", VA = "0xA24974")]
		public AlertEvents(DataStoreController controller)
		{
		}

		[Token(Token = "0x60025CF")]
		[Address(RVA = "0xA2497C", Offset = "0xA2497C", VA = "0xA2497C", Slot = "4")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x60025D0")]
		[Address(RVA = "0xA24B10", Offset = "0xA24B10", VA = "0xA24B10")]
		public AlertEvent Get(string reference)
		{
			return null;
		}

		[Token(Token = "0x60025D1")]
		[Address(RVA = "0xA25038", Offset = "0xA25038", VA = "0xA25038")]
		public List<AlertEvent> GetActiveEvents()
		{
			return null;
		}
	}
}
