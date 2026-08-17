using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x2000506")]
	public class ItemController : DepotController
	{
		[Token(Token = "0x40017AA")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<string, ItemView> m_items;

		[Token(Token = "0x1700069E")]
		protected DepotEntity<RDItem> m_itemDepot
		{
			[Token(Token = "0x600267A")]
			[Address(RVA = "0xA6A718", Offset = "0xA6A718", VA = "0xA6A718")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600267B")]
		[Address(RVA = "0xA6A880", Offset = "0xA6A880", VA = "0xA6A880")]
		public ItemController(CasualDataStoreController controller)
		{
		}

		[Token(Token = "0x600267C")]
		[Address(RVA = "0xA6A900", Offset = "0xA6A900", VA = "0xA6A900")]
		public ItemView Get(string reference)
		{
			return null;
		}

		[Token(Token = "0x600267D")]
		[Address(RVA = "0xA6AB80", Offset = "0xA6AB80", VA = "0xA6AB80", Slot = "10")]
		protected virtual string GetFallbackReference(string reference)
		{
			return null;
		}
	}
}
