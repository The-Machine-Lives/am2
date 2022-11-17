using Il2CppDummyDll;
using Uken.Library.Inventory;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x200054E")]
	public class EventTicketItem : Item
	{
		[Token(Token = "0x4001955")]
		public const string InventoryItemType = "EventTicketItem";

		[Token(Token = "0x4001956")]
		private const string ExpiresAtTraitKey = "expires_at";

		[Token(Token = "0x4001957")]
		private const string IsActivatedTraitKey = "isActivated";

		[Token(Token = "0x4001958")]
		private const int DateUnset = -1;

		[Token(Token = "0x60028B6")]
		[Address(RVA = "0xA65E00", Offset = "0xA65E00", VA = "0xA65E00")]
		public bool IsExpired(double utcNow)
		{
			return default(bool);
		}

		[Token(Token = "0x60028B7")]
		[Address(RVA = "0xA65E2C", Offset = "0xA65E2C", VA = "0xA65E2C")]
		public bool IsActivated()
		{
			return default(bool);
		}

		[Token(Token = "0x60028B8")]
		[Address(RVA = "0xA65E90", Offset = "0xA65E90", VA = "0xA65E90")]
		public void Deactivate()
		{
		}

		[Token(Token = "0x60028B9")]
		[Address(RVA = "0xA65EE8", Offset = "0xA65EE8", VA = "0xA65EE8")]
		public void Activate(int expiryEpochSeconds)
		{
		}

		[Token(Token = "0x60028BA")]
		[Address(RVA = "0xA65BCC", Offset = "0xA65BCC", VA = "0xA65BCC")]
		public int ExpiresAt()
		{
			return default(int);
		}

		[Token(Token = "0x60028BB")]
		[Address(RVA = "0xA65F68", Offset = "0xA65F68", VA = "0xA65F68")]
		public EventTicketItem()
		{
		}
	}
}
