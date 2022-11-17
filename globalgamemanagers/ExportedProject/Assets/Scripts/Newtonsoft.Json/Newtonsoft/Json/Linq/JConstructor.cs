using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq
{
	[Token(Token = "0x20000CB")]
	[Attribute(Name = "DefaultMemberAttribute", RVA = "0x80EFE4", Offset = "0x80EFE4")]
	[Preserve]
	public class JConstructor : JContainer
	{
		[Token(Token = "0x40002E6")]
		[FieldOffset(Offset = "0x48")]
		private string _name;

		[Token(Token = "0x40002E7")]
		[FieldOffset(Offset = "0x50")]
		private readonly List<JToken> _values;

		[Token(Token = "0x1700010B")]
		protected override IList<JToken> ChildrenTokens
		{
			[Token(Token = "0x60005B6")]
			[Address(RVA = "0xFEB850", Offset = "0xFEB850", VA = "0xFEB850", Slot = "47")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700010C")]
		public string Name
		{
			[Token(Token = "0x60005B8")]
			[Address(RVA = "0xFEB8B8", Offset = "0xFEB8B8", VA = "0xFEB8B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700010D")]
		public override JTokenType Type
		{
			[Token(Token = "0x60005B9")]
			[Address(RVA = "0xFEB8C0", Offset = "0xFEB8C0", VA = "0xFEB8C0", Slot = "12")]
			get
			{
				return default(JTokenType);
			}
		}

		[Token(Token = "0x1700010E")]
		public override JToken this[object key]
		{
			[Token(Token = "0x60005C0")]
			[Address(RVA = "0xFEBEAC", Offset = "0xFEBEAC", VA = "0xFEBEAC", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0xFEB858", Offset = "0xFEB858", VA = "0xFEB858", Slot = "49")]
		internal override int IndexOfItem(JToken item)
		{
			return default(int);
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0xFEB8C8", Offset = "0xFEB8C8", VA = "0xFEB8C8")]
		public JConstructor()
		{
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0xFEB934", Offset = "0xFEB934", VA = "0xFEB934")]
		public JConstructor(JConstructor other)
		{
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0xFEB9C8", Offset = "0xFEB9C8", VA = "0xFEB9C8")]
		public JConstructor(string name)
		{
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0xFEBAD8", Offset = "0xFEBAD8", VA = "0xFEBAD8", Slot = "11")]
		internal override bool DeepEquals(JToken node)
		{
			return default(bool);
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0xFEBBA0", Offset = "0xFEBBA0", VA = "0xFEBBA0", Slot = "10")]
		internal override JToken CloneToken()
		{
			return null;
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0xFEBC00", Offset = "0xFEBC00", VA = "0xFEBC00", Slot = "18")]
		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0xFEBFE4", Offset = "0xFEBFE4", VA = "0xFEBFE4", Slot = "19")]
		internal override int GetDeepHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0xFEC030", Offset = "0xFEC030", VA = "0xFEC030")]
		public static JConstructor Load(JsonReader reader, JsonLoadSettings settings)
		{
			return null;
		}
	}
}
