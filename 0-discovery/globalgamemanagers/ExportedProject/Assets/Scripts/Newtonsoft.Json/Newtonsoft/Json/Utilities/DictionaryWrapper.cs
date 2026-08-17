using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	[Token(Token = "0x2000062")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x80E7D0", Offset = "0x80E7D0")]
	[Preserve]
	internal class DictionaryWrapper<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IWrappedDictionary, IDictionary, ICollection
	{
		[Token(Token = "0x2000063")]
		private struct DictionaryEnumerator<TEnumeratorKey, TEnumeratorValue> : IDictionaryEnumerator, IEnumerator
		{
			[Token(Token = "0x40001D1")]
			[FieldOffset(Offset = "0x0")]
			private readonly IEnumerator<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> _e;

			[Token(Token = "0x1700007A")]
			public DictionaryEntry Entry
			{
				[Token(Token = "0x60002B2")]
				get
				{
					return default(DictionaryEntry);
				}
			}

			[Token(Token = "0x1700007B")]
			public object Key
			{
				[Token(Token = "0x60002B3")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007C")]
			public object Value
			{
				[Token(Token = "0x60002B4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007D")]
			public object Current
			{
				[Token(Token = "0x60002B5")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002B1")]
			public DictionaryEnumerator(IEnumerator<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> e)
			{
			}

			[Token(Token = "0x60002B6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60002B7")]
			public void Reset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000064")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80E81C", Offset = "0x80E81C")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x40001D2")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x40001D3")]
			[FieldOffset(Offset = "0x0")]
			public static Func<DictionaryEntry, KeyValuePair<TKey, TValue>> _003C_003E9__25_0;

			[Token(Token = "0x60002B9")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x60002BA")]
			internal KeyValuePair<TKey, TValue> _003CGetEnumerator_003Eb__25_0(DictionaryEntry de)
			{
				return default(KeyValuePair<TKey, TValue>);
			}
		}

		[Token(Token = "0x40001CE")]
		[FieldOffset(Offset = "0x0")]
		private readonly IDictionary _dictionary;

		[Token(Token = "0x40001CF")]
		[FieldOffset(Offset = "0x0")]
		private readonly IDictionary<TKey, TValue> _genericDictionary;

		[Token(Token = "0x40001D0")]
		[FieldOffset(Offset = "0x0")]
		private object _syncRoot;

		[Token(Token = "0x17000071")]
		public ICollection<TKey> Keys
		{
			[Token(Token = "0x6000298")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000072")]
		public TValue this[TKey key]
		{
			[Token(Token = "0x600029B")]
			get
			{
				return (TValue)null;
			}
			[Token(Token = "0x600029C")]
			set
			{
			}
		}

		[Token(Token = "0x17000073")]
		public int Count
		{
			[Token(Token = "0x60002A1")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000074")]
		public bool IsReadOnly
		{
			[Token(Token = "0x60002A2")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000075")]
		private object System_002ECollections_002EIDictionary_002EItem
		{
			[Token(Token = "0x60002A7")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002A8")]
			set
			{
			}
		}

		[Token(Token = "0x17000076")]
		private ICollection System_002ECollections_002EIDictionary_002EKeys
		{
			[Token(Token = "0x60002AB")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000077")]
		private bool System_002ECollections_002EICollection_002EIsSynchronized
		{
			[Token(Token = "0x60002AE")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000078")]
		private object System_002ECollections_002EICollection_002ESyncRoot
		{
			[Token(Token = "0x60002AF")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000079")]
		public object UnderlyingDictionary
		{
			[Token(Token = "0x60002B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000294")]
		public DictionaryWrapper(IDictionary dictionary)
		{
		}

		[Token(Token = "0x6000295")]
		public DictionaryWrapper(IDictionary<TKey, TValue> dictionary)
		{
		}

		[Token(Token = "0x6000296")]
		public void Add(TKey key, TValue value)
		{
		}

		[Token(Token = "0x6000297")]
		public bool ContainsKey(TKey key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000299")]
		public bool Remove(TKey key)
		{
			return default(bool);
		}

		[Token(Token = "0x600029A")]
		public bool TryGetValue(TKey key, out TValue value)
		{
			return default(bool);
		}

		[Token(Token = "0x600029D")]
		public void Add(KeyValuePair<TKey, TValue> item)
		{
		}

		[Token(Token = "0x600029E")]
		public void Clear()
		{
		}

		[Token(Token = "0x600029F")]
		public bool Contains(KeyValuePair<TKey, TValue> item)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A0")]
		public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x60002A3")]
		public bool Remove(KeyValuePair<TKey, TValue> item)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A4")]
		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60002A5")]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60002A6")]
		private void System_002ECollections_002EIDictionary_002EAdd(object key, object value)
		{
		}

		[Token(Token = "0x60002A9")]
		private IDictionaryEnumerator System_002ECollections_002EIDictionary_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60002AA")]
		private bool System_002ECollections_002EIDictionary_002EContains(object key)
		{
			return default(bool);
		}

		[Token(Token = "0x60002AC")]
		public void Remove(object key)
		{
		}

		[Token(Token = "0x60002AD")]
		private void System_002ECollections_002EICollection_002ECopyTo(Array array, int index)
		{
		}
	}
}
