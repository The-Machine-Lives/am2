using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	[Token(Token = "0x2000020")]
	[Preserve]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x80E1E4", Offset = "0x80E1E4")]
	public abstract class JsonContainerAttribute : Attribute
	{
		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F5B8", Offset = "0x80F5B8")]
		private Type _003CItemConverterType_003Ek__BackingField;

		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F5C8", Offset = "0x80F5C8")]
		private object[] _003CItemConverterParameters_003Ek__BackingField;

		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0x20")]
		internal bool? _isReference;

		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x22")]
		internal bool? _itemIsReference;

		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0x24")]
		internal ReferenceLoopHandling? _itemReferenceLoopHandling;

		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x2C")]
		internal TypeNameHandling? _itemTypeNameHandling;

		[Token(Token = "0x17000006")]
		public Type ItemConverterType
		{
			[Token(Token = "0x6000029")]
			[Address(RVA = "0xD4BFE0", Offset = "0xD4BFE0", VA = "0xD4BFE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FEC8", Offset = "0x80FEC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000007")]
		public object[] ItemConverterParameters
		{
			[Token(Token = "0x600002A")]
			[Address(RVA = "0xD4BFE8", Offset = "0xD4BFE8", VA = "0xD4BFE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FED8", Offset = "0x80FED8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0xD4BFD0", Offset = "0xD4BFD0", VA = "0xD4BFD0")]
		protected JsonContainerAttribute()
		{
		}
	}
}
