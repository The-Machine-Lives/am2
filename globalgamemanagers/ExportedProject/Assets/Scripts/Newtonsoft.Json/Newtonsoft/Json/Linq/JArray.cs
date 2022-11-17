using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq
{
	[Token(Token = "0x20000D2")]
	[Attribute(Name = "DefaultMemberAttribute", RVA = "0x80F108", Offset = "0x80F108")]
	[Preserve]
	public class JArray : JContainer, IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable
	{
		[Token(Token = "0x40002FE")]
		[FieldOffset(Offset = "0x48")]
		private readonly List<JToken> _values;

		[Token(Token = "0x17000125")]
		protected override IList<JToken> ChildrenTokens
		{
			[Token(Token = "0x600063F")]
			[Address(RVA = "0xFEA370", Offset = "0xFEA370", VA = "0xFEA370", Slot = "47")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000126")]
		public override JTokenType Type
		{
			[Token(Token = "0x6000640")]
			[Address(RVA = "0xFEA378", Offset = "0xFEA378", VA = "0xFEA378", Slot = "12")]
			get
			{
				return default(JTokenType);
			}
		}

		[Token(Token = "0x17000127")]
		public override JToken this[object key]
		{
			[Token(Token = "0x6000649")]
			[Address(RVA = "0xFEB2D8", Offset = "0xFEB2D8", VA = "0xFEB2D8", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000128")]
		public JToken this[int index]
		{
			[Token(Token = "0x600064A")]
			[Address(RVA = "0xFEB410", Offset = "0xFEB410", VA = "0xFEB410", Slot = "20")]
			get
			{
				return null;
			}
			[Token(Token = "0x600064B")]
			[Address(RVA = "0xFEB420", Offset = "0xFEB420", VA = "0xFEB420", Slot = "21")]
			set
			{
			}
		}

		[Token(Token = "0x17000129")]
		public bool IsReadOnly
		{
			[Token(Token = "0x6000655")]
			[Address(RVA = "0xFEB57C", Offset = "0xFEB57C", VA = "0xFEB57C", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0xFEA380", Offset = "0xFEA380", VA = "0xFEA380")]
		public JArray()
		{
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0xFEA454", Offset = "0xFEA454", VA = "0xFEA454")]
		public JArray(JArray other)
		{
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0xFEA794", Offset = "0xFEA794", VA = "0xFEA794")]
		public JArray(object content)
		{
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0xFEA824", Offset = "0xFEA824", VA = "0xFEA824", Slot = "11")]
		internal override bool DeepEquals(JToken node)
		{
			return default(bool);
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0xFEABEC", Offset = "0xFEABEC", VA = "0xFEABEC", Slot = "10")]
		internal override JToken CloneToken()
		{
			return null;
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0xFEAC4C", Offset = "0xFEAC4C", VA = "0xFEAC4C")]
		public static JArray Load(JsonReader reader)
		{
			return null;
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0xFEAC54", Offset = "0xFEAC54", VA = "0xFEAC54")]
		public static JArray Load(JsonReader reader, JsonLoadSettings settings)
		{
			return null;
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0xFEB1BC", Offset = "0xFEB1BC", VA = "0xFEB1BC", Slot = "18")]
		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0xFEB430", Offset = "0xFEB430", VA = "0xFEB430", Slot = "49")]
		internal override int IndexOfItem(JToken item)
		{
			return default(int);
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0xFEB490", Offset = "0xFEB490", VA = "0xFEB490", Slot = "22")]
		public int IndexOf(JToken item)
		{
			return default(int);
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0xFEB4A0", Offset = "0xFEB4A0", VA = "0xFEB4A0", Slot = "23")]
		public void Insert(int index, JToken item)
		{
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0xFEB4B4", Offset = "0xFEB4B4", VA = "0xFEB4B4", Slot = "24")]
		public void RemoveAt(int index)
		{
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0xFEB4C4", Offset = "0xFEB4C4", VA = "0xFEB4C4", Slot = "4")]
		public IEnumerator<JToken> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0xFEB53C", Offset = "0xFEB53C", VA = "0xFEB53C", Slot = "27")]
		public void Add(JToken item)
		{
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0xFEB54C", Offset = "0xFEB54C", VA = "0xFEB54C", Slot = "28")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0xFEB55C", Offset = "0xFEB55C", VA = "0xFEB55C", Slot = "29")]
		public bool Contains(JToken item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0xFEB56C", Offset = "0xFEB56C", VA = "0xFEB56C", Slot = "30")]
		public void CopyTo(JToken[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0xFEB584", Offset = "0xFEB584", VA = "0xFEB584", Slot = "31")]
		public bool Remove(JToken item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0xFEB594", Offset = "0xFEB594", VA = "0xFEB594", Slot = "19")]
		internal override int GetDeepHashCode()
		{
			return default(int);
		}
	}
}
