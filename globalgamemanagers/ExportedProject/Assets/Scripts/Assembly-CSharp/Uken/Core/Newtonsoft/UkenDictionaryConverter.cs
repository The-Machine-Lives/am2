using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Uken.Core.Newtonsoft
{
	[Token(Token = "0x20003DB")]
	public class UkenDictionaryConverter : CustomCreationConverter<IDictionary<string, object>>
	{
		[Token(Token = "0x6001DC7")]
		[Address(RVA = "0xA1A08C", Offset = "0xA1A08C", VA = "0xA1A08C", Slot = "9")]
		public override IDictionary<string, object> Create(Type objectType)
		{
			return null;
		}

		[Token(Token = "0x6001DC8")]
		[Address(RVA = "0xA1A0F0", Offset = "0xA1A0F0", VA = "0xA1A0F0", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		[Token(Token = "0x6001DC9")]
		[Address(RVA = "0xA1A1B0", Offset = "0xA1A1B0", VA = "0xA1A1B0", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Token(Token = "0x6001DCA")]
		[Address(RVA = "0xA1A298", Offset = "0xA1A298", VA = "0xA1A298")]
		public UkenDictionaryConverter()
		{
		}
	}
}
