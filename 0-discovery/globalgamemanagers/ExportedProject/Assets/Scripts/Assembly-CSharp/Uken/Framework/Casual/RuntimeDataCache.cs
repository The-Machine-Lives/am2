using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x2000573")]
	public class RuntimeDataCache<T, U> where T : RuntimeData<U>, new()where U : BaseEntityDocument
	{
		[Token(Token = "0x40019F8")]
		[FieldOffset(Offset = "0x0")]
		protected bool m_initializeCalled;

		[Token(Token = "0x40019F9")]
		[FieldOffset(Offset = "0x0")]
		protected Dictionary<string, T> m_runtimeDatas;

		[Token(Token = "0x40019FA")]
		[FieldOffset(Offset = "0x0")]
		protected DepotEntity<U> m_depot;

		[Token(Token = "0x40019FB")]
		[FieldOffset(Offset = "0x0")]
		protected List<T> m_allCached;

		[Token(Token = "0x40019FC")]
		[FieldOffset(Offset = "0x0")]
		protected List<string> m_allKeysCached;

		[Token(Token = "0x60029C2")]
		public RuntimeDataCache(DepotEntity<U> depot)
		{
		}

		[Token(Token = "0x60029C3")]
		public virtual void Initialize()
		{
		}

		[Token(Token = "0x60029C4")]
		public T GetFromCached(string reference)
		{
			return null;
		}

		[Token(Token = "0x60029C5")]
		public T FindOrCreate(string reference)
		{
			return null;
		}

		[Token(Token = "0x60029C6")]
		public List<T> GetAllCached()
		{
			return null;
		}

		[Token(Token = "0x60029C7")]
		public List<string> GetAllKeysCached()
		{
			return null;
		}

		[Token(Token = "0x60029C8")]
		public List<T> GetAllFromCollection(ICollection<string> stringList)
		{
			return null;
		}

		[Token(Token = "0x60029C9")]
		public int GetCount()
		{
			return default(int);
		}

		[Token(Token = "0x60029CA")]
		protected virtual T CreateRuntimeData(string reference, U refDataDocument)
		{
			return null;
		}
	}
}
