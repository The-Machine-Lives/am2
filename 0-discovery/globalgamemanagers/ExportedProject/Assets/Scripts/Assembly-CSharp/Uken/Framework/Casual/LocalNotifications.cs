using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x2000511")]
	public class LocalNotifications : DepotController
	{
		[Token(Token = "0x40017C1")]
		[FieldOffset(Offset = "0x20")]
		private DepotEntity<RDLocalNotification> m_LocalNotifications;

		[Token(Token = "0x60026A3")]
		[Address(RVA = "0xA72E04", Offset = "0xA72E04", VA = "0xA72E04")]
		public LocalNotifications(CasualDataStoreController controller)
		{
		}

		[Token(Token = "0x60026A4")]
		[Address(RVA = "0xA72E0C", Offset = "0xA72E0C", VA = "0xA72E0C", Slot = "9")]
		public override void OnDataUpdated()
		{
		}

		[Token(Token = "0x60026A5")]
		[Address(RVA = "0xA72EC4", Offset = "0xA72EC4", VA = "0xA72EC4")]
		public List<RDLocalNotification> GetAll()
		{
			return null;
		}

		[Token(Token = "0x60026A6")]
		[Address(RVA = "0xA72F80", Offset = "0xA72F80", VA = "0xA72F80")]
		public RDLocalNotification Get(string reference)
		{
			return null;
		}
	}
}
