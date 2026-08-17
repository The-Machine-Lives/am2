using System.Collections.Generic;
using Il2CppDummyDll;

namespace Uken.Library.Inventory
{
	[Token(Token = "0x2000453")]
	public class ItemReferenceIndex
	{
		[Token(Token = "0x2000803")]
		protected class ItemReferenceHash
		{
			[Token(Token = "0x4002325")]
			[FieldOffset(Offset = "0x10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x832FC0", Offset = "0x832FC0")]
			private HashSet<string> _003CitemRefs_003Ek__BackingField;

			[Token(Token = "0x17000821")]
			public HashSet<string> itemRefs
			{
				[Token(Token = "0x60032B7")]
				[Address(RVA = "0xBA6664", Offset = "0xBA6664", VA = "0xBA6664")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83BB3C", Offset = "0x83BB3C")]
				get
				{
					return null;
				}
				[Token(Token = "0x60032B8")]
				[Address(RVA = "0xBA666C", Offset = "0xBA666C", VA = "0xBA666C")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83BB4C", Offset = "0x83BB4C")]
				private set
				{
				}
			}

			[Token(Token = "0x60032B9")]
			[Address(RVA = "0xBA6584", Offset = "0xBA6584", VA = "0xBA6584")]
			public void AddItemRef(string itemRef)
			{
			}

			[Token(Token = "0x60032BA")]
			[Address(RVA = "0xBA65F4", Offset = "0xBA65F4", VA = "0xBA65F4")]
			public void RemoveItemRef(string itemRef)
			{
			}

			[Token(Token = "0x60032BB")]
			[Address(RVA = "0xBA6514", Offset = "0xBA6514", VA = "0xBA6514")]
			public ItemReferenceHash()
			{
			}
		}

		[Token(Token = "0x4001408")]
		[FieldOffset(Offset = "0x10")]
		protected Dictionary<string, ItemReferenceHash> m_itemRefs;

		[Token(Token = "0x6001FF2")]
		[Address(RVA = "0xBA3BF8", Offset = "0xBA3BF8", VA = "0xBA3BF8")]
		public void AddItemRef(string itemKey, string itemRef)
		{
		}

		[Token(Token = "0x6001FF3")]
		[Address(RVA = "0xBA2D68", Offset = "0xBA2D68", VA = "0xBA2D68")]
		public void RemoveItemRef(string itemKey, string itemRef)
		{
		}

		[Token(Token = "0x6001FF4")]
		[Address(RVA = "0xBA1218", Offset = "0xBA1218", VA = "0xBA1218")]
		public HashSet<string> GetAllItemsForKey(string itemKey)
		{
			return null;
		}

		[Token(Token = "0x6001FF5")]
		[Address(RVA = "0xB9BC4C", Offset = "0xB9BC4C", VA = "0xB9BC4C")]
		public ItemReferenceIndex()
		{
		}
	}
}
