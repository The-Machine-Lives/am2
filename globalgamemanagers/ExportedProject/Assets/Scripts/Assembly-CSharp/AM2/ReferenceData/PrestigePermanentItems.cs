using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Library.Inventory;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000387")]
	public class PrestigePermanentItems : RuntimeData<RDPrestigePermanentItems>
	{
		[Token(Token = "0x4001142")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82C968", Offset = "0x82C968")]
		private HashSet<string> _003CallIndividualItemsToKeep_003Ek__BackingField;

		[Token(Token = "0x4001143")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82C978", Offset = "0x82C978")]
		private HashSet<string> _003CallItemTypesToKeep_003Ek__BackingField;

		[Token(Token = "0x4001144")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82C988", Offset = "0x82C988")]
		private HashSet<string> _003CitemTransactionOnResetWhiteList_003Ek__BackingField;

		[Token(Token = "0x4001145")]
		[FieldOffset(Offset = "0x30")]
		private InventoryController m_inventoryController;

		[Token(Token = "0x4001146")]
		[FieldOffset(Offset = "0x38")]
		private SharedDataCacheController m_sharedDataCacheController;

		[Token(Token = "0x170004E6")]
		public List<string> equipmentToKeep
		{
			[Token(Token = "0x6001BBC")]
			[Address(RVA = "0x9B7478", Offset = "0x9B7478", VA = "0x9B7478")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004E7")]
		public List<string> recipeToKeep
		{
			[Token(Token = "0x6001BBD")]
			[Address(RVA = "0x9B74A4", Offset = "0x9B74A4", VA = "0x9B74A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004E8")]
		public List<string> badgesToKeep
		{
			[Token(Token = "0x6001BBE")]
			[Address(RVA = "0x9B74D0", Offset = "0x9B74D0", VA = "0x9B74D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004E9")]
		public List<string> titlesToKeep
		{
			[Token(Token = "0x6001BBF")]
			[Address(RVA = "0x9B74FC", Offset = "0x9B74FC", VA = "0x9B74FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004EA")]
		public List<string> dyesToKeep
		{
			[Token(Token = "0x6001BC0")]
			[Address(RVA = "0x9B7528", Offset = "0x9B7528", VA = "0x9B7528")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004EB")]
		public List<string> unlockersToKeep
		{
			[Token(Token = "0x6001BC1")]
			[Address(RVA = "0x9B7554", Offset = "0x9B7554", VA = "0x9B7554")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004EC")]
		public List<string> researchToKeep
		{
			[Token(Token = "0x6001BC2")]
			[Address(RVA = "0x9B7580", Offset = "0x9B7580", VA = "0x9B7580")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004ED")]
		public List<string> upgradablesToKeep
		{
			[Token(Token = "0x6001BC3")]
			[Address(RVA = "0x9B75AC", Offset = "0x9B75AC", VA = "0x9B75AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004EE")]
		public List<string> itemConvertersToKeep
		{
			[Token(Token = "0x6001BC4")]
			[Address(RVA = "0x9B75D8", Offset = "0x9B75D8", VA = "0x9B75D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004EF")]
		public List<string> scenesToKeep
		{
			[Token(Token = "0x6001BC5")]
			[Address(RVA = "0x9B7604", Offset = "0x9B7604", VA = "0x9B7604")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004F0")]
		public HashSet<string> allIndividualItemsToKeep
		{
			[Token(Token = "0x6001BC6")]
			[Address(RVA = "0x9B7630", Offset = "0x9B7630", VA = "0x9B7630")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8384A0", Offset = "0x8384A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001BC7")]
			[Address(RVA = "0x9B7638", Offset = "0x9B7638", VA = "0x9B7638")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8384B0", Offset = "0x8384B0")]
			private set
			{
			}
		}

		[Token(Token = "0x170004F1")]
		public HashSet<string> allItemTypesToKeep
		{
			[Token(Token = "0x6001BC8")]
			[Address(RVA = "0x9B7640", Offset = "0x9B7640", VA = "0x9B7640")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8384C0", Offset = "0x8384C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001BC9")]
			[Address(RVA = "0x9B7648", Offset = "0x9B7648", VA = "0x9B7648")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8384D0", Offset = "0x8384D0")]
			private set
			{
			}
		}

		[Token(Token = "0x170004F2")]
		public HashSet<string> itemTransactionOnResetWhiteList
		{
			[Token(Token = "0x6001BCA")]
			[Address(RVA = "0x9B7650", Offset = "0x9B7650", VA = "0x9B7650")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8384E0", Offset = "0x8384E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001BCB")]
			[Address(RVA = "0x9B7658", Offset = "0x9B7658", VA = "0x9B7658")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8384F0", Offset = "0x8384F0")]
			private set
			{
			}
		}

		[Token(Token = "0x6001BCC")]
		[Address(RVA = "0x9B7660", Offset = "0x9B7660", VA = "0x9B7660")]
		public PrestigePermanentItems()
		{
		}

		[Token(Token = "0x6001BCD")]
		[Address(RVA = "0x9B7710", Offset = "0x9B7710", VA = "0x9B7710")]
		private void AddAllPermanentItemTypesToSingleHash()
		{
		}

		[Token(Token = "0x6001BCE")]
		[Address(RVA = "0x9B79EC", Offset = "0x9B79EC", VA = "0x9B79EC")]
		private void AddAllPermanentItemsToSingleHash(List<Prestiges> prestiges, List<EventQuest> eventQuests)
		{
		}

		[Token(Token = "0x6001BCF")]
		[Address(RVA = "0x9B86C8", Offset = "0x9B86C8", VA = "0x9B86C8")]
		private void AddEventQuestItemsToKeep(List<EventQuest> eventQuests)
		{
		}

		[Token(Token = "0x6001BD0")]
		[Address(RVA = "0x9B8E5C", Offset = "0x9B8E5C", VA = "0x9B8E5C")]
		private void AddItemsToTransactionWhiteList()
		{
		}

		[Token(Token = "0x6001BD1")]
		[Address(RVA = "0x9B8FAC", Offset = "0x9B8FAC", VA = "0x9B8FAC")]
		public void Setup(RuntimeDataCache<Prestiges, RDPrestiges> prestigesCache, RuntimeDataCache<EventQuest, RDEventQuest> m_eventQuestCache)
		{
		}
	}
}
