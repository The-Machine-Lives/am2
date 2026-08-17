using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x200054F")]
	public class EventTickets : DepotController
	{
		[Token(Token = "0x4001959")]
		[FieldOffset(Offset = "0x20")]
		private float validationTimer;

		[Token(Token = "0x400195A")]
		[FieldOffset(Offset = "0x24")]
		private readonly float validationInterval;

		[Token(Token = "0x17000726")]
		private DepotEntity<RDEventTicketItem> m_EventTickets
		{
			[Token(Token = "0x60028BC")]
			[Address(RVA = "0xA65F70", Offset = "0xA65F70", VA = "0xA65F70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000727")]
		public virtual int CollectionEventTicketType
		{
			[Token(Token = "0x60028BD")]
			[Address(RVA = "0xA660D4", Offset = "0xA660D4", VA = "0xA660D4", Slot = "10")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60028BE")]
		[Address(RVA = "0xA660DC", Offset = "0xA660DC", VA = "0xA660DC")]
		public EventTickets(DataStoreController controller)
		{
		}

		[Token(Token = "0x60028BF")]
		[Address(RVA = "0xA660EC", Offset = "0xA660EC", VA = "0xA660EC", Slot = "7")]
		public override void Update(float deltaTime)
		{
		}

		[Token(Token = "0x60028C0")]
		[Address(RVA = "0xA662C4", Offset = "0xA662C4", VA = "0xA662C4")]
		public EventTicket Get(string referenceName)
		{
			return null;
		}

		[Token(Token = "0x60028C1")]
		[Address(RVA = "0xA663C0", Offset = "0xA663C0", VA = "0xA663C0")]
		public List<EventTicket> GetActiveTickets()
		{
			return null;
		}

		[Token(Token = "0x60028C2")]
		[Address(RVA = "0xA665A8", Offset = "0xA665A8", VA = "0xA665A8")]
		public Dictionary<string, EventTicket> GetActiveTicketsForDepot(string depotClassName)
		{
			return null;
		}

		[Token(Token = "0x60028C3")]
		[Address(RVA = "0xA6655C", Offset = "0xA6655C", VA = "0xA6655C")]
		private EventTicket CreateEventTicket(RDEventTicketItem eventTicketData)
		{
			return null;
		}

		[Token(Token = "0x60028C4")]
		[Address(RVA = "0xA66144", Offset = "0xA66144", VA = "0xA66144")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x83A368", Offset = "0x83A368")]
		private void AutoActivateAnyPendingTickets()
		{
		}

		[Token(Token = "0x60028C5")]
		[Address(RVA = "0xA66838", Offset = "0xA66838", VA = "0xA66838")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x83A3A0", Offset = "0x83A3A0")]
		private bool AutoActivateAndIsActiveCheck(RDEventTicketItem ticketData)
		{
			return default(bool);
		}

		[Token(Token = "0x60028C6")]
		[Address(RVA = "0xA66A5C", Offset = "0xA66A5C", VA = "0xA66A5C")]
		private void ActivateTicket(RDEventTicketItem ticketData)
		{
		}
	}
}
