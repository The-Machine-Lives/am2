using Il2CppDummyDll;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x2000550")]
	public class EventTicket
	{
		[Token(Token = "0x400195B")]
		[FieldOffset(Offset = "0x10")]
		private RDEventTicketItem ticketData;

		[Token(Token = "0x400195C")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83229C", Offset = "0x83229C")]
		private EventSchedule _003Cm_eventSchedule_003Ek__BackingField;

		[Token(Token = "0x17000728")]
		public string DisplayName
		{
			[Token(Token = "0x60028C7")]
			[Address(RVA = "0xA65838", Offset = "0xA65838", VA = "0xA65838")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000729")]
		public string EventDepot
		{
			[Token(Token = "0x60028C8")]
			[Address(RVA = "0xA65864", Offset = "0xA65864", VA = "0xA65864")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700072A")]
		public string ItemReference
		{
			[Token(Token = "0x60028C9")]
			[Address(RVA = "0xA65890", Offset = "0xA65890", VA = "0xA65890")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700072B")]
		public int Duration
		{
			[Token(Token = "0x60028CA")]
			[Address(RVA = "0xA658BC", Offset = "0xA658BC", VA = "0xA658BC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700072C")]
		public string IconPath
		{
			[Token(Token = "0x60028CB")]
			[Address(RVA = "0xA658E8", Offset = "0xA658E8", VA = "0xA658E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700072D")]
		public string AlertRef
		{
			[Token(Token = "0x60028CC")]
			[Address(RVA = "0xA65914", Offset = "0xA65914", VA = "0xA65914")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700072E")]
		public string Reference
		{
			[Token(Token = "0x60028CD")]
			[Address(RVA = "0xA65940", Offset = "0xA65940", VA = "0xA65940")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700072F")]
		public float Scalar
		{
			[Token(Token = "0x60028CE")]
			[Address(RVA = "0xA6596C", Offset = "0xA6596C", VA = "0xA6596C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000730")]
		public string TicketReference
		{
			[Token(Token = "0x60028CF")]
			[Address(RVA = "0xA65998", Offset = "0xA65998", VA = "0xA65998")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000731")]
		public EventSchedule m_eventSchedule
		{
			[Token(Token = "0x60028D0")]
			[Address(RVA = "0xA659C4", Offset = "0xA659C4", VA = "0xA659C4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A3D8", Offset = "0x83A3D8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60028D1")]
			[Address(RVA = "0xA659CC", Offset = "0xA659CC", VA = "0xA659CC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A3E8", Offset = "0x83A3E8")]
			protected set
			{
			}
		}

		[Token(Token = "0x60028D2")]
		[Address(RVA = "0xA659D4", Offset = "0xA659D4", VA = "0xA659D4")]
		public EventTicket(RDEventTicketItem ticket, EventTicketItem ticketItem)
		{
		}
	}
}
