using Il2CppDummyDll;
using Uken.Library.Inventory.InventoryInternal;

namespace Uken.Library.Inventory
{
	[Token(Token = "0x200045B")]
	public class Item
	{
		[Token(Token = "0x4001447")]
		public const string mc_sItemType = "InventoryItem";

		[Token(Token = "0x4001448")]
		private const string c_lifetimeQuantity = "lifetime_quantity";

		[Token(Token = "0x4001449")]
		private const long c_defaultLifetimeQuantity = 0L;

		[Token(Token = "0x400144A")]
		[FieldOffset(Offset = "0x10")]
		private BaseInventoryItem m_inventoryItem;

		[Token(Token = "0x400144B")]
		[FieldOffset(Offset = "0x18")]
		private ITraitInterface m_setItemTrait;

		[Token(Token = "0x170005C0")]
		public string m_reference
		{
			[Token(Token = "0x6002067")]
			[Address(RVA = "0xB9C690", Offset = "0xB9C690", VA = "0xB9C690")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005C1")]
		public long Quantity
		{
			[Token(Token = "0x6002068")]
			[Address(RVA = "0xBA5CDC", Offset = "0xBA5CDC", VA = "0xBA5CDC")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x170005C2")]
		public bool Deleted
		{
			[Token(Token = "0x6002069")]
			[Address(RVA = "0xBA5D08", Offset = "0xBA5D08", VA = "0xBA5D08")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170005C3")]
		public long lifetimeQuantity
		{
			[Token(Token = "0x600206E")]
			[Address(RVA = "0xBA5D7C", Offset = "0xBA5D7C", VA = "0xBA5D7C")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x600206F")]
			[Address(RVA = "0xBA5DD0", Offset = "0xBA5DD0", VA = "0xBA5DD0")]
			protected set
			{
			}
		}

		[Token(Token = "0x600206A")]
		[Address(RVA = "0xBA5D34", Offset = "0xBA5D34", VA = "0xBA5D34")]
		public Item()
		{
		}

		[Token(Token = "0x600206B")]
		[Address(RVA = "0xBA5D3C", Offset = "0xBA5D3C", VA = "0xBA5D3C", Slot = "4")]
		public virtual void ResetTraits(bool resetLifeTimeQuantity = false)
		{
		}

		[Token(Token = "0x600206C")]
		[Address(RVA = "0xBA5E30", Offset = "0xBA5E30", VA = "0xBA5E30", Slot = "5")]
		public virtual bool ValidateTrait(string sName, object oValue)
		{
			return default(bool);
		}

		[Token(Token = "0x600206D")]
		[Address(RVA = "0xBA5E38", Offset = "0xBA5E38", VA = "0xBA5E38")]
		public void IncrementLifetimeQuantity(long delta)
		{
		}

		[Token(Token = "0x6002070")]
		[Address(RVA = "0xBA5F98", Offset = "0xBA5F98", VA = "0xBA5F98")]
		public void SetItemReference(BaseInventoryItem inventoryItem, ITraitInterface setItemTrait)
		{
		}

		[Token(Token = "0x6002071")]
		[Address(RVA = "0xBA5EC0", Offset = "0xBA5EC0", VA = "0xBA5EC0")]
		public void SetItemTrait(string key, long value)
		{
		}

		[Token(Token = "0x6002072")]
		[Address(RVA = "0xBA5FA0", Offset = "0xBA5FA0", VA = "0xBA5FA0")]
		public void SetItemTrait(string key, double value)
		{
		}

		[Token(Token = "0x6002073")]
		[Address(RVA = "0xBA6080", Offset = "0xBA6080", VA = "0xBA6080")]
		public void SetItemTrait(string key, bool value)
		{
		}

		[Token(Token = "0x6002074")]
		[Address(RVA = "0xBA6158", Offset = "0xBA6158", VA = "0xBA6158")]
		public void SetItemTrait(string key, string value)
		{
		}

		[Token(Token = "0x6002075")]
		[Address(RVA = "0xBA622C", Offset = "0xBA622C", VA = "0xBA622C")]
		protected object GetViewModelValue(string key)
		{
			return null;
		}

		[Token(Token = "0x6002076")]
		[Address(RVA = "0xBA6260", Offset = "0xBA6260", VA = "0xBA6260", Slot = "6")]
		public virtual string GetItemType()
		{
			return null;
		}

		[Token(Token = "0x6002077")]
		[Address(RVA = "0xBA62CC", Offset = "0xBA62CC", VA = "0xBA62CC")]
		public string GetLegacyCatagory()
		{
			return null;
		}

		[Token(Token = "0x6002078")]
		[Address(RVA = "0xBA6338", Offset = "0xBA6338", VA = "0xBA6338")]
		public string GetTraitString(string key, string fallback)
		{
			return null;
		}

		[Token(Token = "0x6002079")]
		[Address(RVA = "0xBA639C", Offset = "0xBA639C", VA = "0xBA639C")]
		public float GetTraitFloat(string key, float fallback)
		{
			return default(float);
		}

		[Token(Token = "0x600207A")]
		[Address(RVA = "0xBA63E0", Offset = "0xBA63E0", VA = "0xBA63E0")]
		public int GetTraitInt(string key, int fallback)
		{
			return default(int);
		}

		[Token(Token = "0x600207B")]
		[Address(RVA = "0xBA5E7C", Offset = "0xBA5E7C", VA = "0xBA5E7C")]
		public long GetTraitLong(string key, long fallback)
		{
			return default(long);
		}

		[Token(Token = "0x600207C")]
		[Address(RVA = "0xBA6424", Offset = "0xBA6424", VA = "0xBA6424")]
		public double GetTraitDouble(string key, double fallback)
		{
			return default(double);
		}

		[Token(Token = "0x600207D")]
		[Address(RVA = "0xBA6468", Offset = "0xBA6468", VA = "0xBA6468")]
		public bool GetTraitBool(string traitName, bool fallback = false)
		{
			return default(bool);
		}

		[Token(Token = "0x600207E")]
		[Address(RVA = "0xBA64AC", Offset = "0xBA64AC", VA = "0xBA64AC", Slot = "7")]
		public virtual string ItemSpritePath()
		{
			return null;
		}
	}
}
