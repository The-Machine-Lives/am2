using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x20000FA")]
	[Preserve]
	public class KeyValuePairConverter : JsonConverter
	{
		[Token(Token = "0x40003BA")]
		[FieldOffset(Offset = "0x0")]
		private static readonly ThreadSafeStore<Type, ReflectionObject> ReflectionObjectPerType;

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0xD3CE00", Offset = "0xD3CE00", VA = "0xD3CE00")]
		private static ReflectionObject InitializeReflectionObject(Type t)
		{
			return null;
		}

		[Token(Token = "0x60007DD")]
		[Address(RVA = "0xD3D108", Offset = "0xD3D108", VA = "0xD3D108", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		[Token(Token = "0x60007DE")]
		[Address(RVA = "0xD3D3C4", Offset = "0xD3D3C4", VA = "0xD3D3C4", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Token(Token = "0x60007DF")]
		[Address(RVA = "0xD3D8C0", Offset = "0xD3D8C0", VA = "0xD3D8C0", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0xD3D9D0", Offset = "0xD3D9D0", VA = "0xD3D9D0")]
		public KeyValuePairConverter()
		{
		}
	}
}
