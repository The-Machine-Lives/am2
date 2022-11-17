using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	[Token(Token = "0x200005F")]
	[Preserve]
	internal class CollectionWrapper<T> : ICollection<T>, IEnumerable<T>, IEnumerable, IWrappedCollection, IList, ICollection
	{
		[Token(Token = "0x40001C8")]
		[FieldOffset(Offset = "0x0")]
		private readonly IList _list;

		[Token(Token = "0x40001C9")]
		[FieldOffset(Offset = "0x0")]
		private readonly ICollection<T> _genericCollection;

		[Token(Token = "0x40001CA")]
		[FieldOffset(Offset = "0x0")]
		private object _syncRoot;

		[Token(Token = "0x17000069")]
		public virtual int Count
		{
			[Token(Token = "0x600025E")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700006A")]
		public virtual bool IsReadOnly
		{
			[Token(Token = "0x600025F")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006B")]
		private bool System_002ECollections_002EIList_002EIsFixedSize
		{
			[Token(Token = "0x6000268")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006C")]
		private object System_002ECollections_002EIList_002EItem
		{
			[Token(Token = "0x600026A")]
			get
			{
				return null;
			}
			[Token(Token = "0x600026B")]
			set
			{
			}
		}

		[Token(Token = "0x1700006D")]
		private bool System_002ECollections_002EICollection_002EIsSynchronized
		{
			[Token(Token = "0x600026D")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006E")]
		private object System_002ECollections_002EICollection_002ESyncRoot
		{
			[Token(Token = "0x600026E")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006F")]
		public object UnderlyingCollection
		{
			[Token(Token = "0x6000271")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000258")]
		public CollectionWrapper(IList list)
		{
		}

		[Token(Token = "0x6000259")]
		public CollectionWrapper(ICollection<T> list)
		{
		}

		[Token(Token = "0x600025A")]
		public virtual void Add(T item)
		{
		}

		[Token(Token = "0x600025B")]
		public virtual void Clear()
		{
		}

		[Token(Token = "0x600025C")]
		public virtual bool Contains(T item)
		{
			return default(bool);
		}

		[Token(Token = "0x600025D")]
		public virtual void CopyTo(T[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x6000260")]
		public virtual bool Remove(T item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000261")]
		public virtual IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000262")]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000263")]
		private int System_002ECollections_002EIList_002EAdd(object value)
		{
			return default(int);
		}

		[Token(Token = "0x6000264")]
		private bool System_002ECollections_002EIList_002EContains(object value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000265")]
		private int System_002ECollections_002EIList_002EIndexOf(object value)
		{
			return default(int);
		}

		[Token(Token = "0x6000266")]
		private void System_002ECollections_002EIList_002ERemoveAt(int index)
		{
		}

		[Token(Token = "0x6000267")]
		private void System_002ECollections_002EIList_002EInsert(int index, object value)
		{
		}

		[Token(Token = "0x6000269")]
		private void System_002ECollections_002EIList_002ERemove(object value)
		{
		}

		[Token(Token = "0x600026C")]
		private void System_002ECollections_002EICollection_002ECopyTo(Array array, int arrayIndex)
		{
		}

		[Token(Token = "0x600026F")]
		private static void VerifyValueType(object value)
		{
		}

		[Token(Token = "0x6000270")]
		private static bool IsCompatibleObject(object value)
		{
			return default(bool);
		}
	}
}
