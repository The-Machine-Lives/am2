using System.Collections.Generic;
using AM2;
using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Core;
using Uken.Library.Inventory;
using Uken.Library.Observe;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x20004AB")]
	public class ItemConverterController : UkenController, IInventoryProgressTracker, IUkenObserver<List<Unlocker>>
	{
		[Token(Token = "0x2000820")]
		public class ConvertResult
		{
			[Token(Token = "0x400235A")]
			[FieldOffset(Offset = "0x10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x832FD0", Offset = "0x832FD0")]
			private long _003Cvolume_003Ek__BackingField;

			[Token(Token = "0x400235B")]
			[FieldOffset(Offset = "0x18")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x832FE0", Offset = "0x832FE0")]
			private long _003CquantityProduced_003Ek__BackingField;

			[Token(Token = "0x17000822")]
			public long volume
			{
				[Token(Token = "0x60032F9")]
				[Address(RVA = "0xA6B35C", Offset = "0xA6B35C", VA = "0xA6B35C")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83BB5C", Offset = "0x83BB5C")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x60032FA")]
				[Address(RVA = "0xA6B354", Offset = "0xA6B354", VA = "0xA6B354")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83BB6C", Offset = "0x83BB6C")]
				set
				{
				}
			}

			[Token(Token = "0x17000823")]
			public long quantityProduced
			{
				[Token(Token = "0x60032FB")]
				[Address(RVA = "0xA6B8B4", Offset = "0xA6B8B4", VA = "0xA6B8B4")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83BB7C", Offset = "0x83BB7C")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x60032FC")]
				[Address(RVA = "0xA6B364", Offset = "0xA6B364", VA = "0xA6B364")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83BB8C", Offset = "0x83BB8C")]
				set
				{
				}
			}

			[Token(Token = "0x60032FD")]
			[Address(RVA = "0xA6B34C", Offset = "0xA6B34C", VA = "0xA6B34C")]
			public ConvertResult()
			{
			}
		}

		[Token(Token = "0x40015A6")]
		[FieldOffset(Offset = "0x18")]
		private List<ItemConverter> m_cachedOwnedItemConverters;

		[Token(Token = "0x40015A7")]
		[FieldOffset(Offset = "0x20")]
		private SharedDataCacheController m_dataCacheController;

		[Token(Token = "0x40015A8")]
		[FieldOffset(Offset = "0x28")]
		private AM2InventoryController m_inventoryController;

		[Token(Token = "0x40015A9")]
		[FieldOffset(Offset = "0x30")]
		private FTUEController m_ftueController;

		[Token(Token = "0x40015AA")]
		[FieldOffset(Offset = "0x38")]
		private ConstructionController m_constructionController;

		[Token(Token = "0x40015AB")]
		[FieldOffset(Offset = "0x40")]
		private UIAlertController m_uiAlertController;

		[Token(Token = "0x40015AC")]
		[FieldOffset(Offset = "0x48")]
		private RecipeController m_recipeController;

		[Token(Token = "0x40015AD")]
		[FieldOffset(Offset = "0x50")]
		private UkenUnsubscriber<List<Unlocker>> m_ftueSignalHandle;

		[Token(Token = "0x60022BB")]
		[Address(RVA = "0xA6ABC8", Offset = "0xA6ABC8", VA = "0xA6ABC8")]
		public ItemConverterController(SharedDataCacheController dataCacheController, AM2InventoryController inventoryController, FTUEController ftueController, ConstructionController constructionController, UIAlertController uiAlertController, RecipeController recipeController)
		{
		}

		[Token(Token = "0x60022BC")]
		[Address(RVA = "0xA6AC98", Offset = "0xA6AC98", VA = "0xA6AC98", Slot = "6")]
		public override bool PostLoadContent()
		{
			return default(bool);
		}

		[Token(Token = "0x60022BD")]
		[Address(RVA = "0xA6AE18", Offset = "0xA6AE18", VA = "0xA6AE18", Slot = "10")]
		public void TrackProgress(string reference, long delta, ItemMinimalDetails itemDetails)
		{
		}

		[Token(Token = "0x60022BE")]
		[Address(RVA = "0xA6AEB4", Offset = "0xA6AEB4", VA = "0xA6AEB4", Slot = "11")]
		private void Uken_002ELibrary_002EObserve_002EIUkenObserver_003CSystem_002ECollections_002EGeneric_002EList_003CAM2_002EReferenceData_002EUnlocker_003E_003E_002EOnEmit(List<Unlocker> unlockers)
		{
		}

		[Token(Token = "0x60022BF")]
		[Address(RVA = "0xA6AFEC", Offset = "0xA6AFEC", VA = "0xA6AFEC")]
		public Recipe GetOutputRecipeForItemConverter(ItemConverter itemConverter)
		{
			return null;
		}

		[Token(Token = "0x60022C0")]
		[Address(RVA = "0xA6B114", Offset = "0xA6B114", VA = "0xA6B114")]
		public ConvertResult GetConvertVolume(ItemConverter itemConverter, Item inputItem, Item outputItem, long volume, long calculatedInput, long calculatedOutput)
		{
			return null;
		}

		[Token(Token = "0x60022C1")]
		[Address(RVA = "0xA6B36C", Offset = "0xA6B36C", VA = "0xA6B36C")]
		public bool TryToConvert(ItemConverter itemConverter, Item inputItem, Item outputItem, long volume, out Dictionary<string, long> rewardGroupTransaction)
		{
			return default(bool);
		}

		[Token(Token = "0x60022C2")]
		[Address(RVA = "0xA6B770", Offset = "0xA6B770", VA = "0xA6B770")]
		public TagItem TryGetTagItem(ItemConverter itemConverter)
		{
			return null;
		}

		[Token(Token = "0x60022C3")]
		[Address(RVA = "0xA6B868", Offset = "0xA6B868", VA = "0xA6B868")]
		public long CalculateItemConvert(Item tagItem, Formula formula, long defaultQuantity)
		{
			return default(long);
		}

		[Token(Token = "0x60022C4")]
		[Address(RVA = "0xA6B8BC", Offset = "0xA6B8BC", VA = "0xA6B8BC")]
		public long CalculateItemConvertPercentChange(Item tagItem, Formula formula)
		{
			return default(long);
		}
	}
}
