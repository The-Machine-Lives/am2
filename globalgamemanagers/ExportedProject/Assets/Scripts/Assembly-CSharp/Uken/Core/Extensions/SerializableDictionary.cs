using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Uken.Core.Extensions
{
	[Serializable]
	[Token(Token = "0x20003D9")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x81F9D0", Offset = "0x81F9D0")]
	public class SerializableDictionary<TKey, TValue> : ISerializationCallbackReceiver
	{
		[Token(Token = "0x400120F")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<TKey, TValue> _Dictionary;

		[Token(Token = "0x4001210")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private List<TKey> keys;

		[Token(Token = "0x4001211")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private List<TValue> values;

		[Token(Token = "0x17000586")]
		public Dictionary<TKey, TValue> Data
		{
			[Token(Token = "0x6001DB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000587")]
		public int Count
		{
			[Token(Token = "0x6001DB9")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000588")]
		public TValue this[TKey key]
		{
			[Token(Token = "0x6001DBC")]
			get
			{
				return (TValue)null;
			}
			[Token(Token = "0x6001DBD")]
			set
			{
			}
		}

		[Token(Token = "0x17000589")]
		public Dictionary<TKey, TValue>.KeyCollection Keys
		{
			[Token(Token = "0x6001DBE")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001DBA")]
		public void Add(TKey k, TValue v)
		{
		}

		[Token(Token = "0x6001DBB")]
		public void Remove(TKey k)
		{
		}

		[Token(Token = "0x6001DBF")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x6001DC0")]
		public bool ContainsKey(TKey k)
		{
			return default(bool);
		}

		[Token(Token = "0x6001DC1")]
		public void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x6001DC2")]
		public SerializableDictionary()
		{
		}
	}
}
