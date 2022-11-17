using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	[Token(Token = "0x200002F")]
	[Preserve]
	public abstract class JsonConverter
	{
		[Token(Token = "0x1700002A")]
		public virtual bool CanRead
		{
			[Token(Token = "0x60000CE")]
			[Address(RVA = "0xD4D3C0", Offset = "0xD4D3C0", VA = "0xD4D3C0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700002B")]
		public virtual bool CanWrite
		{
			[Token(Token = "0x60000CF")]
			[Address(RVA = "0xD4D3C8", Offset = "0xD4D3C8", VA = "0xD4D3C8", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000CB")]
		public abstract void WriteJson(JsonWriter writer, object value, JsonSerializer serializer);

		[Token(Token = "0x60000CC")]
		public abstract object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer);

		[Token(Token = "0x60000CD")]
		public abstract bool CanConvert(Type objectType);

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0xD3B75C", Offset = "0xD3B75C", VA = "0xD3B75C")]
		protected JsonConverter()
		{
		}
	}
}
