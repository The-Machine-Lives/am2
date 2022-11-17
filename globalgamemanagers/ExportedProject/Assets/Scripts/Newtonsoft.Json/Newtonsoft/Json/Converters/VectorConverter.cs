using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;
using UnityEngine;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x20000FE")]
	[Preserve]
	public class VectorConverter : JsonConverter
	{
		[Token(Token = "0x40003BD")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Type V2;

		[Token(Token = "0x40003BE")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Type V3;

		[Token(Token = "0x40003BF")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Type V4;

		[Token(Token = "0x40003C0")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FCE8", Offset = "0x80FCE8")]
		private bool _003CEnableVector2_003Ek__BackingField;

		[Token(Token = "0x40003C1")]
		[FieldOffset(Offset = "0x11")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FCF8", Offset = "0x80FCF8")]
		private bool _003CEnableVector3_003Ek__BackingField;

		[Token(Token = "0x40003C2")]
		[FieldOffset(Offset = "0x12")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FD08", Offset = "0x80FD08")]
		private bool _003CEnableVector4_003Ek__BackingField;

		[Token(Token = "0x17000170")]
		public bool EnableVector2
		{
			[Token(Token = "0x60007F6")]
			[Address(RVA = "0xD3ED90", Offset = "0xD3ED90", VA = "0xD3ED90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8116D4", Offset = "0x8116D4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007F7")]
			[Address(RVA = "0xD3ED98", Offset = "0xD3ED98", VA = "0xD3ED98")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8116E4", Offset = "0x8116E4")]
			set
			{
			}
		}

		[Token(Token = "0x17000171")]
		public bool EnableVector3
		{
			[Token(Token = "0x60007F8")]
			[Address(RVA = "0xD3EDA4", Offset = "0xD3EDA4", VA = "0xD3EDA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8116F4", Offset = "0x8116F4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007F9")]
			[Address(RVA = "0xD3EDAC", Offset = "0xD3EDAC", VA = "0xD3EDAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x811704", Offset = "0x811704")]
			set
			{
			}
		}

		[Token(Token = "0x17000172")]
		public bool EnableVector4
		{
			[Token(Token = "0x60007FA")]
			[Address(RVA = "0xD3EDB8", Offset = "0xD3EDB8", VA = "0xD3EDB8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x811714", Offset = "0x811714")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007FB")]
			[Address(RVA = "0xD3EDC0", Offset = "0xD3EDC0", VA = "0xD3EDC0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x811724", Offset = "0x811724")]
			set
			{
			}
		}

		[Token(Token = "0x60007FC")]
		[Address(RVA = "0xD3EDCC", Offset = "0xD3EDCC", VA = "0xD3EDCC")]
		public VectorConverter()
		{
		}

		[Token(Token = "0x60007FD")]
		[Address(RVA = "0xD3EE00", Offset = "0xD3EE00", VA = "0xD3EE00", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		[Token(Token = "0x60007FE")]
		[Address(RVA = "0xD3F080", Offset = "0xD3F080", VA = "0xD3F080")]
		private static void WriteVector(JsonWriter writer, float x, float y, float? z, float? w)
		{
		}

		[Token(Token = "0x60007FF")]
		[Address(RVA = "0xD3F28C", Offset = "0xD3F28C", VA = "0xD3F28C", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Token(Token = "0x6000800")]
		[Address(RVA = "0xD3F740", Offset = "0xD3F740", VA = "0xD3F740", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000801")]
		[Address(RVA = "0xD3F3CC", Offset = "0xD3F3CC", VA = "0xD3F3CC")]
		private static Vector2 PopulateVector2(JsonReader reader)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000802")]
		[Address(RVA = "0xD3F4B8", Offset = "0xD3F4B8", VA = "0xD3F4B8")]
		private static Vector3 PopulateVector3(JsonReader reader)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000803")]
		[Address(RVA = "0xD3F5DC", Offset = "0xD3F5DC", VA = "0xD3F5DC")]
		private static Vector4 PopulateVector4(JsonReader reader)
		{
			return default(Vector4);
		}
	}
}
