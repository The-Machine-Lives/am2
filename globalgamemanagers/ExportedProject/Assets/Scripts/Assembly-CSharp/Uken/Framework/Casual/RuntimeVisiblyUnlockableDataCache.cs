using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Library.Inventory;
using Uken.Library.ReferenceData;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x2000577")]
	public class RuntimeVisiblyUnlockableDataCache<T, U, V> : RuntimeItemModelDataCache<T, U> where T : RuntimeData<U>, IItemModel, new()where U : BaseEntityDocument where V : VisiblyUnlockableItem, new()
	{
		[Token(Token = "0x40019FF")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8329E8", Offset = "0x8329E8")]
		private Dictionary<string, T> _003CvisiblyUnlockedCache_003Ek__BackingField;

		[Token(Token = "0x4001A00")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8329F8", Offset = "0x8329F8")]
		private string _003CunlockableItemType_003Ek__BackingField;

		[Token(Token = "0x17000757")]
		public Dictionary<string, T> visiblyUnlockedCache
		{
			[Token(Token = "0x60029D5")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A5BC", Offset = "0x83A5BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60029D6")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A5CC", Offset = "0x83A5CC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000758")]
		protected string unlockableItemType
		{
			[Token(Token = "0x60029D7")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A5DC", Offset = "0x83A5DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60029D8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A5EC", Offset = "0x83A5EC")]
			private set
			{
			}
		}

		[Token(Token = "0x60029D9")]
		public RuntimeVisiblyUnlockableDataCache(DepotEntity<U> depot, string inItemType, string inUnlockableItemType)
		{
		}

		[Token(Token = "0x60029DA")]
		public virtual void OnTrackProgress(string reference, long delta, ItemMinimalDetails itemDetails)
		{
		}

		[Token(Token = "0x60029DB")]
		protected virtual void SetVisiblyUnlock(string reference)
		{
		}

		[Token(Token = "0x60029DC")]
		public void SetVisiblyLocked(string runtimeDataRef)
		{
		}

		[Token(Token = "0x60029DD")]
		protected void AddToVisiblyUnlockedCache(T runtimeData)
		{
		}

		[Token(Token = "0x60029DE")]
		protected void SetItemVisibility(T runtimeData, bool visible)
		{
		}

		[Token(Token = "0x60029DF")]
		public virtual void OnAcquire(string runtimeDataRef)
		{
		}

		[Token(Token = "0x60029E0")]
		public virtual void OnUnacquire(string runtimeDataRef)
		{
		}

		[Token(Token = "0x60029E1")]
		protected bool IsVisiblyUnlocked(V visiblyUnlockableItem)
		{
			return default(bool);
		}

		[Token(Token = "0x60029E2")]
		protected override T CreateRuntimeData(string reference, U refDataDocument)
		{
			return null;
		}
	}
}
