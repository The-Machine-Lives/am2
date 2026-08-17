using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	[Token(Token = "0x2000016")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x80E05C", Offset = "0x80E05C")]
	[Preserve]
	public class JsonExtensionDataAttribute : Attribute
	{
		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F598", Offset = "0x80F598")]
		private bool _003CWriteData_003Ek__BackingField;

		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x11")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F5A8", Offset = "0x80F5A8")]
		private bool _003CReadData_003Ek__BackingField;

		[Token(Token = "0x17000002")]
		public bool WriteData
		{
			[Token(Token = "0x6000018")]
			[Address(RVA = "0xD4D6CC", Offset = "0xD4D6CC", VA = "0xD4D6CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FE88", Offset = "0x80FE88")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000019")]
			[Address(RVA = "0xD4D6D4", Offset = "0xD4D6D4", VA = "0xD4D6D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FE98", Offset = "0x80FE98")]
			set
			{
			}
		}

		[Token(Token = "0x17000003")]
		public bool ReadData
		{
			[Token(Token = "0x600001A")]
			[Address(RVA = "0xD4D6E0", Offset = "0xD4D6E0", VA = "0xD4D6E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FEA8", Offset = "0x80FEA8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600001B")]
			[Address(RVA = "0xD4D6E8", Offset = "0xD4D6E8", VA = "0xD4D6E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FEB8", Offset = "0x80FEB8")]
			set
			{
			}
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0xD4D6F4", Offset = "0xD4D6F4", VA = "0xD4D6F4")]
		public JsonExtensionDataAttribute()
		{
		}
	}
}
