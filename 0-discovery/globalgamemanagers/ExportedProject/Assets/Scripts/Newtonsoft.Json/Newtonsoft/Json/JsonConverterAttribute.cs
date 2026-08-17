using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	[Token(Token = "0x2000022")]
	[Preserve]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x80E26C", Offset = "0x80E26C")]
	public sealed class JsonConverterAttribute : Attribute
	{
		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0x10")]
		private readonly Type _converterType;

		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F5D8", Offset = "0x80F5D8")]
		private object[] _003CConverterParameters_003Ek__BackingField;

		[Token(Token = "0x17000008")]
		public Type ConverterType
		{
			[Token(Token = "0x600002C")]
			[Address(RVA = "0xD4D3D0", Offset = "0xD4D3D0", VA = "0xD4D3D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000009")]
		public object[] ConverterParameters
		{
			[Token(Token = "0x600002D")]
			[Address(RVA = "0xD4D3D8", Offset = "0xD4D3D8", VA = "0xD4D3D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FEE8", Offset = "0x80FEE8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0xD4D3E0", Offset = "0xD4D3E0", VA = "0xD4D3E0")]
		public JsonConverterAttribute(Type converterType)
		{
		}
	}
}
