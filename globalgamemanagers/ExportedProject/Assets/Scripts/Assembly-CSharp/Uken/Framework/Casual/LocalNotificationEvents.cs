using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x2000510")]
	public class LocalNotificationEvents : DepotController
	{
		[Token(Token = "0x40017C0")]
		[FieldOffset(Offset = "0x20")]
		private DepotEntity<RDLocalNotificationEvent> m_LocalNotificationEvents;

		[Token(Token = "0x600269F")]
		[Address(RVA = "0xA72BF0", Offset = "0xA72BF0", VA = "0xA72BF0")]
		public LocalNotificationEvents(CasualDataStoreController controller)
		{
		}

		[Token(Token = "0x60026A0")]
		[Address(RVA = "0xA72BF8", Offset = "0xA72BF8", VA = "0xA72BF8", Slot = "9")]
		public override void OnDataUpdated()
		{
		}

		[Token(Token = "0x60026A1")]
		[Address(RVA = "0xA72CB4", Offset = "0xA72CB4", VA = "0xA72CB4")]
		public RDLocalNotificationEvent Get(string reference)
		{
			return null;
		}

		[Token(Token = "0x60026A2")]
		[Address(RVA = "0xA72D70", Offset = "0xA72D70", VA = "0xA72D70")]
		public List<RDLocalNotificationEvent> GetAllEvents()
		{
			return null;
		}
	}
}
