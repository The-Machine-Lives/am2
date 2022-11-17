using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Library.Inventory;
using Uken.Library.ReferenceData;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x2000576")]
	public class RuntimeItemModelDataCache<T, U> : RuntimeDataCache<T, U>, IItemModelIndexer where T : RuntimeData<U>, IItemModel, new()where U : BaseEntityDocument
	{
		[Token(Token = "0x40019FD")]
		[FieldOffset(Offset = "0x0")]
		protected InventoryController m_inventoryController;

		[Token(Token = "0x40019FE")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8329D8", Offset = "0x8329D8")]
		private string _003CitemType_003Ek__BackingField;

		[Token(Token = "0x17000756")]
		public string itemType
		{
			[Token(Token = "0x60029CE")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A59C", Offset = "0x83A59C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60029CF")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A5AC", Offset = "0x83A5AC")]
			private set
			{
			}
		}

		[Token(Token = "0x60029D0")]
		public RuntimeItemModelDataCache(DepotEntity<U> depot, string inItemType)
		{
		}

		[Token(Token = "0x60029D1")]
		public virtual Dictionary<string, ItemMinimalDetails> GetAllItemDetails()
		{
			return null;
		}

		[Token(Token = "0x60029D2")]
		protected virtual string GetReadableResearchNameForItem(T runtimeData)
		{
			return null;
		}

		[Token(Token = "0x60029D3")]
		public List<T> GetAllOwnedFromCollection(ICollection<string> stringList)
		{
			return null;
		}

		[Token(Token = "0x60029D4")]
		protected virtual string GetDescriptionForItem(T runtimeData)
		{
			return null;
		}
	}
}
