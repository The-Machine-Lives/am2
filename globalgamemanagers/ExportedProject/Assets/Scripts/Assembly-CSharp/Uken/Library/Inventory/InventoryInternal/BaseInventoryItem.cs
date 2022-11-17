using System.Collections.Generic;
using Il2CppDummyDll;

namespace Uken.Library.Inventory.InventoryInternal
{
	[Token(Token = "0x200045D")]
	public class BaseInventoryItem
	{
		[Token(Token = "0x2000810")]
		public static class RequiredItemTraits
		{
			[Token(Token = "0x400233B")]
			public const string mc_sReference = "reference";

			[Token(Token = "0x400233C")]
			public const string mc_sItemType = "item_type";

			[Token(Token = "0x400233D")]
			public const string mc_sMaxQuantity = "max_quantity";

			[Token(Token = "0x400233E")]
			public const string mc_sMinQuantity = "min_quantity";

			[Token(Token = "0x400233F")]
			public const string mc_sDirtyTraits = "dirty_traits";

			[Token(Token = "0x4002340")]
			public const string mc_sQuantity = "quantity";

			[Token(Token = "0x4002341")]
			public const string mc_deleteTrait = "delete";
		}

		[Token(Token = "0x400144C")]
		[FieldOffset(Offset = "0x10")]
		private readonly HashSet<string> readOnlyVMKeys;

		[Token(Token = "0x400144D")]
		[FieldOffset(Offset = "0x18")]
		protected List<object> m_DirtyTraits;

		[Token(Token = "0x400144E")]
		[FieldOffset(Offset = "0x20")]
		protected List<object> m_inFlightTraits;

		[Token(Token = "0x400144F")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<string, object> viewModel;

		[Token(Token = "0x170005C4")]
		public long Quantity
		{
			[Token(Token = "0x6002084")]
			[Address(RVA = "0xB9FC70", Offset = "0xB9FC70", VA = "0xB9FC70")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x170005C5")]
		public long? max_quantity
		{
			[Token(Token = "0x6002085")]
			[Address(RVA = "0xB9FBA8", Offset = "0xB9FBA8", VA = "0xB9FBA8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005C6")]
		public long? min_quantity
		{
			[Token(Token = "0x6002086")]
			[Address(RVA = "0xB9FC0C", Offset = "0xB9FC0C", VA = "0xB9FC0C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005C7")]
		public bool Deleted
		{
			[Token(Token = "0x6002087")]
			[Address(RVA = "0xBA21FC", Offset = "0xBA21FC", VA = "0xBA21FC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170005C8")]
		public string m_reference
		{
			[Token(Token = "0x600208B")]
			[Address(RVA = "0xB9E188", Offset = "0xB9E188", VA = "0xB9E188")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002088")]
		[Address(RVA = "0xBA0DA4", Offset = "0xBA0DA4", VA = "0xBA0DA4")]
		public BaseInventoryItem(Dictionary<string, object> vm, bool markDirty)
		{
		}

		[Token(Token = "0x6002089")]
		[Address(RVA = "0xBA4EA0", Offset = "0xBA4EA0", VA = "0xBA4EA0")]
		public BaseInventoryItem(BaseInventoryItem itemToCopy)
		{
		}

		[Token(Token = "0x600208A")]
		[Address(RVA = "0xBA3A40", Offset = "0xBA3A40", VA = "0xBA3A40")]
		public void PopulateViewModel(Dictionary<string, object> vm)
		{
		}

		[Token(Token = "0x600208C")]
		[Address(RVA = "0xBA5220", Offset = "0xBA5220", VA = "0xBA5220", Slot = "4")]
		public virtual bool ContainsKey(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x600208D")]
		[Address(RVA = "0xBA5290", Offset = "0xBA5290", VA = "0xBA5290", Slot = "5")]
		public virtual bool ContainsKeyAndValueNotNull(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x600208E")]
		[Address(RVA = "0xBA52F0", Offset = "0xBA52F0", VA = "0xBA52F0")]
		public object GetViewModelValue(string key)
		{
			return null;
		}

		[Token(Token = "0x600208F")]
		[Address(RVA = "0xBA0B54", Offset = "0xBA0B54", VA = "0xBA0B54")]
		public string GetTraitString(string key, string fallback)
		{
			return null;
		}

		[Token(Token = "0x6002090")]
		[Address(RVA = "0xBA5378", Offset = "0xBA5378", VA = "0xBA5378")]
		public int GetTraitInt(string key, int fallback)
		{
			return default(int);
		}

		[Token(Token = "0x6002091")]
		[Address(RVA = "0xBA53E8", Offset = "0xBA53E8", VA = "0xBA53E8")]
		public long GetTraitLong(string key, long fallback)
		{
			return default(long);
		}

		[Token(Token = "0x6002092")]
		[Address(RVA = "0xBA5438", Offset = "0xBA5438", VA = "0xBA5438")]
		public float GetTraitFloat(string key, float fallback)
		{
			return default(float);
		}

		[Token(Token = "0x6002093")]
		[Address(RVA = "0xBA5480", Offset = "0xBA5480", VA = "0xBA5480")]
		public double GetTraitDouble(string key, double fallback)
		{
			return default(double);
		}

		[Token(Token = "0x6002094")]
		[Address(RVA = "0xBA5540", Offset = "0xBA5540", VA = "0xBA5540")]
		public bool GetTraitBool(string key, bool fallback = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6002095")]
		[Address(RVA = "0xBA5604", Offset = "0xBA5604", VA = "0xBA5604", Slot = "6")]
		protected virtual void SetViewModelValue(string key, object value)
		{
		}

		[Token(Token = "0x6002096")]
		[Address(RVA = "0xBA572C", Offset = "0xBA572C", VA = "0xBA572C", Slot = "7")]
		public virtual List<object> DirtyTraits()
		{
			return null;
		}

		[Token(Token = "0x6002097")]
		[Address(RVA = "0xBA5734", Offset = "0xBA5734", VA = "0xBA5734")]
		public void MarkTraitDirty(string trait)
		{
		}

		[Token(Token = "0x6002098")]
		[Address(RVA = "0xBA57E0", Offset = "0xBA57E0", VA = "0xBA57E0", Slot = "8")]
		public virtual List<object> inFlightTraits()
		{
			return null;
		}

		[Token(Token = "0x6002099")]
		[Address(RVA = "0xBA57E8", Offset = "0xBA57E8", VA = "0xBA57E8", Slot = "9")]
		public virtual void SetDirtyTraits(List<object> dirty)
		{
		}

		[Token(Token = "0x600209A")]
		[Address(RVA = "0xBA57F0", Offset = "0xBA57F0", VA = "0xBA57F0", Slot = "10")]
		public virtual void SetInFlightTraits(List<object> inFlight)
		{
		}

		[Token(Token = "0x600209B")]
		[Address(RVA = "0xBA4E98", Offset = "0xBA4E98", VA = "0xBA4E98")]
		private void Initialize(Dictionary<string, object> vm)
		{
		}

		[Token(Token = "0x600209C")]
		[Address(RVA = "0xB9F418", Offset = "0xB9F418", VA = "0xB9F418")]
		public void MarkAllTraitsDirty()
		{
		}

		[Token(Token = "0x600209D")]
		[Address(RVA = "0xBA50B8", Offset = "0xBA50B8", VA = "0xBA50B8")]
		private void ExtractWeirdDirtyTraitStuff(Dictionary<string, object> vm)
		{
		}

		[Token(Token = "0x600209E")]
		[Address(RVA = "0xBA57F8", Offset = "0xBA57F8", VA = "0xBA57F8", Slot = "11")]
		public virtual void SetQuantity(long newQuantity)
		{
		}

		[Token(Token = "0x600209F")]
		[Address(RVA = "0xBA5894", Offset = "0xBA5894", VA = "0xBA5894", Slot = "12")]
		public virtual void InternalSetTrait(string name, string value)
		{
		}

		[Token(Token = "0x60020A0")]
		[Address(RVA = "0xBA5980", Offset = "0xBA5980", VA = "0xBA5980", Slot = "13")]
		public virtual void InternalSetTrait(string name, int value)
		{
		}

		[Token(Token = "0x60020A1")]
		[Address(RVA = "0xBA5A00", Offset = "0xBA5A00", VA = "0xBA5A00", Slot = "14")]
		public virtual void InternalSetTrait(string name, long value)
		{
		}

		[Token(Token = "0x60020A2")]
		[Address(RVA = "0xBA5A80", Offset = "0xBA5A80", VA = "0xBA5A80", Slot = "15")]
		public virtual void InternalSetTrait(string name, bool value)
		{
		}

		[Token(Token = "0x60020A3")]
		[Address(RVA = "0xBA5B00", Offset = "0xBA5B00", VA = "0xBA5B00", Slot = "16")]
		public virtual void InternalSetTrait(string name, double value)
		{
		}

		[Token(Token = "0x60020A4")]
		[Address(RVA = "0xBA5898", Offset = "0xBA5898", VA = "0xBA5898")]
		private void InternalSetTraitHelper(string name, object value)
		{
		}

		[Token(Token = "0x60020A5")]
		[Address(RVA = "0xBA5B88", Offset = "0xBA5B88", VA = "0xBA5B88", Slot = "17")]
		public virtual Dictionary<string, object> ViewModel()
		{
			return null;
		}

		[Token(Token = "0x60020A6")]
		[Address(RVA = "0xBA5B90", Offset = "0xBA5B90", VA = "0xBA5B90", Slot = "18")]
		public virtual Dictionary<string, object> ViewModelForStorage(bool isDirty)
		{
			return null;
		}
	}
}
