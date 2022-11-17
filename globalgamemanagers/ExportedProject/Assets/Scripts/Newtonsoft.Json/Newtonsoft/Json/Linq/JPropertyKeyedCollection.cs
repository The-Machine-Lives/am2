using System.Collections.Generic;
using System.Collections.ObjectModel;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq
{
	[Token(Token = "0x20000BA")]
	[Attribute(Name = "DefaultMemberAttribute", RVA = "0x80EE0C", Offset = "0x80EE0C")]
	[Preserve]
	internal class JPropertyKeyedCollection : Collection<JToken>
	{
		[Token(Token = "0x40002C4")]
		[FieldOffset(Offset = "0x0")]
		private static readonly IEqualityComparer<string> Comparer;

		[Token(Token = "0x40002C5")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<string, JToken> _dictionary;

		[Token(Token = "0x17000104")]
		public ICollection<string> Keys
		{
			[Token(Token = "0x6000585")]
			[Address(RVA = "0xFF1344", Offset = "0xFF1344", VA = "0xFF1344")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0xFEFE3C", Offset = "0xFEFE3C", VA = "0xFEFE3C")]
		public JPropertyKeyedCollection()
		{
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0xFF38A4", Offset = "0xFF38A4", VA = "0xFF38A4")]
		private void AddKey(string key, JToken item)
		{
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0xFF39CC", Offset = "0xFF39CC", VA = "0xFF39CC", Slot = "35")]
		protected override void ClearItems()
		{
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0xFF125C", Offset = "0xFF125C", VA = "0xFF125C")]
		public bool Contains(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0xFF3924", Offset = "0xFF3924", VA = "0xFF3924")]
		private void EnsureDictionary()
		{
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0xFF3A40", Offset = "0xFF3A40", VA = "0xFF3A40")]
		private string GetKeyForItem(JToken item)
		{
			return null;
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0xFF3B7C", Offset = "0xFF3B7C", VA = "0xFF3B7C", Slot = "36")]
		protected override void InsertItem(int index, JToken item)
		{
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0xFF3BFC", Offset = "0xFF3BFC", VA = "0xFF3BFC", Slot = "37")]
		protected override void RemoveItem(int index)
		{
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0xFF3CFC", Offset = "0xFF3CFC", VA = "0xFF3CFC")]
		private void RemoveKey(string key)
		{
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0xFF3D70", Offset = "0xFF3D70", VA = "0xFF3D70", Slot = "38")]
		protected override void SetItem(int index, JToken item)
		{
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0xFF0888", Offset = "0xFF0888", VA = "0xFF0888")]
		public bool TryGetValue(string key, out JToken value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0xFF0418", Offset = "0xFF0418", VA = "0xFF0418")]
		public int IndexOfReference(JToken t)
		{
			return default(int);
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0xFEFFE8", Offset = "0xFEFFE8", VA = "0xFEFFE8")]
		public bool Compare(JPropertyKeyedCollection other)
		{
			return default(bool);
		}
	}
}
