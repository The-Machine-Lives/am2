using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x20000A3")]
	[Preserve]
	public class JsonPropertyCollection : KeyedCollection<string, JsonProperty>
	{
		[Token(Token = "0x400028A")]
		[FieldOffset(Offset = "0x38")]
		private readonly Type _type;

		[Token(Token = "0x400028B")]
		[FieldOffset(Offset = "0x40")]
		private readonly List<JsonProperty> _list;

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0xD0A0C4", Offset = "0xD0A0C4", VA = "0xD0A0C4")]
		public JsonPropertyCollection(Type type)
		{
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0xD156A8", Offset = "0xD156A8", VA = "0xD156A8", Slot = "39")]
		protected override string GetKeyForItem(JsonProperty item)
		{
			return null;
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0xD0A250", Offset = "0xD0A250", VA = "0xD0A250")]
		public void AddProperty(JsonProperty property)
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0xD0A204", Offset = "0xD0A204", VA = "0xD0A204")]
		public JsonProperty GetClosestMatchProperty(string propertyName)
		{
			return null;
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0xD157EC", Offset = "0xD157EC", VA = "0xD157EC")]
		private bool TryGetValue(string key, out JsonProperty item)
		{
			return default(bool);
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0xD156D4", Offset = "0xD156D4", VA = "0xD156D4")]
		public JsonProperty GetProperty(string propertyName, StringComparison comparisonType)
		{
			return null;
		}
	}
}
