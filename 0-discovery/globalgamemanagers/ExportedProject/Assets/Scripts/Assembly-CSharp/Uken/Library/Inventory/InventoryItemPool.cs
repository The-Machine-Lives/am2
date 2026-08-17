using System.Collections.Generic;
using Il2CppDummyDll;

namespace Uken.Library.Inventory
{
	[Token(Token = "0x2000450")]
	public class InventoryItemPool<T> where T : Item, new()
	{
		[Token(Token = "0x4001401")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<string, bool> m_itemStates;

		[Token(Token = "0x4001402")]
		[FieldOffset(Offset = "0x0")]
		private int m_maxSize;

		[Token(Token = "0x4001403")]
		[FieldOffset(Offset = "0x0")]
		private InventoryController m_inventoryController;

		[Token(Token = "0x6001FE7")]
		public InventoryItemPool(string baseName, int maxSize, InventoryController inventoryController)
		{
		}

		[Token(Token = "0x6001FE8")]
		public T Get()
		{
			return null;
		}

		[Token(Token = "0x6001FE9")]
		public List<T> GetAll()
		{
			return null;
		}

		[Token(Token = "0x6001FEA")]
		public T Claim(string itemReference)
		{
			return null;
		}

		[Token(Token = "0x6001FEB")]
		public void Return(T item)
		{
		}
	}
}
