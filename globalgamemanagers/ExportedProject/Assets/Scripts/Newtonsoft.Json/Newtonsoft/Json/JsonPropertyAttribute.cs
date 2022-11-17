using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	[Token(Token = "0x200002A")]
	[Preserve]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x80E36C", Offset = "0x80E36C")]
	public sealed class JsonPropertyAttribute : Attribute
	{
		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0x10")]
		internal NullValueHandling? _nullValueHandling;

		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0x18")]
		internal DefaultValueHandling? _defaultValueHandling;

		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0x20")]
		internal ReferenceLoopHandling? _referenceLoopHandling;

		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0x28")]
		internal ObjectCreationHandling? _objectCreationHandling;

		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x30")]
		internal TypeNameHandling? _typeNameHandling;

		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0x38")]
		internal bool? _isReference;

		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0x3C")]
		internal int? _order;

		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0x44")]
		internal Required? _required;

		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0x4C")]
		internal bool? _itemIsReference;

		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0x50")]
		internal ReferenceLoopHandling? _itemReferenceLoopHandling;

		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0x58")]
		internal TypeNameHandling? _itemTypeNameHandling;

		[Token(Token = "0x40000AB")]
		[FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F658", Offset = "0x80F658")]
		private Type _003CItemConverterType_003Ek__BackingField;

		[Token(Token = "0x40000AC")]
		[FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F668", Offset = "0x80F668")]
		private object[] _003CItemConverterParameters_003Ek__BackingField;

		[Token(Token = "0x40000AD")]
		[FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F678", Offset = "0x80F678")]
		private string _003CPropertyName_003Ek__BackingField;

		[Token(Token = "0x17000020")]
		public Type ItemConverterType
		{
			[Token(Token = "0x6000085")]
			[Address(RVA = "0xD4E0EC", Offset = "0xD4E0EC", VA = "0xD4E0EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FF78", Offset = "0x80FF78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000021")]
		public object[] ItemConverterParameters
		{
			[Token(Token = "0x6000086")]
			[Address(RVA = "0xD4E0F4", Offset = "0xD4E0F4", VA = "0xD4E0F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FF88", Offset = "0x80FF88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000022")]
		public NullValueHandling NullValueHandling
		{
			[Token(Token = "0x6000087")]
			[Address(RVA = "0xD4E0FC", Offset = "0xD4E0FC", VA = "0xD4E0FC")]
			set
			{
			}
		}

		[Token(Token = "0x17000023")]
		public string PropertyName
		{
			[Token(Token = "0x6000088")]
			[Address(RVA = "0xD4E16C", Offset = "0xD4E16C", VA = "0xD4E16C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FF98", Offset = "0x80FF98")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000089")]
			[Address(RVA = "0xD4E174", Offset = "0xD4E174", VA = "0xD4E174")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FFA8", Offset = "0x80FFA8")]
			set
			{
			}
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0xD4E17C", Offset = "0xD4E17C", VA = "0xD4E17C")]
		public JsonPropertyAttribute()
		{
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0xD4E184", Offset = "0xD4E184", VA = "0xD4E184")]
		public JsonPropertyAttribute(string propertyName)
		{
		}
	}
}
