using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x200007C")]
	[Preserve]
	public class JsonContainerContract : JsonContract
	{
		[Token(Token = "0x40001E8")]
		[FieldOffset(Offset = "0x90")]
		private JsonContract _itemContract;

		[Token(Token = "0x40001E9")]
		[FieldOffset(Offset = "0x98")]
		private JsonContract _finalItemContract;

		[Token(Token = "0x40001EA")]
		[FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F798", Offset = "0x80F798")]
		private JsonConverter _003CItemConverter_003Ek__BackingField;

		[Token(Token = "0x40001EB")]
		[FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F7A8", Offset = "0x80F7A8")]
		private bool? _003CItemIsReference_003Ek__BackingField;

		[Token(Token = "0x40001EC")]
		[FieldOffset(Offset = "0xAC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F7B8", Offset = "0x80F7B8")]
		private ReferenceLoopHandling? _003CItemReferenceLoopHandling_003Ek__BackingField;

		[Token(Token = "0x40001ED")]
		[FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F7C8", Offset = "0x80F7C8")]
		private TypeNameHandling? _003CItemTypeNameHandling_003Ek__BackingField;

		[Token(Token = "0x17000083")]
		internal JsonContract ItemContract
		{
			[Token(Token = "0x6000354")]
			[Address(RVA = "0xD13054", Offset = "0xD13054", VA = "0xD13054")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000355")]
			[Address(RVA = "0xD1305C", Offset = "0xD1305C", VA = "0xD1305C")]
			set
			{
			}
		}

		[Token(Token = "0x17000084")]
		internal JsonContract FinalItemContract
		{
			[Token(Token = "0x6000356")]
			[Address(RVA = "0xD130A4", Offset = "0xD130A4", VA = "0xD130A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000085")]
		public JsonConverter ItemConverter
		{
			[Token(Token = "0x6000357")]
			[Address(RVA = "0xD130AC", Offset = "0xD130AC", VA = "0xD130AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8104B8", Offset = "0x8104B8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000358")]
			[Address(RVA = "0xD130B4", Offset = "0xD130B4", VA = "0xD130B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8104C8", Offset = "0x8104C8")]
			set
			{
			}
		}

		[Token(Token = "0x17000086")]
		public bool? ItemIsReference
		{
			[Token(Token = "0x6000359")]
			[Address(RVA = "0xD130BC", Offset = "0xD130BC", VA = "0xD130BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8104D8", Offset = "0x8104D8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600035A")]
			[Address(RVA = "0xD130C4", Offset = "0xD130C4", VA = "0xD130C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8104E8", Offset = "0x8104E8")]
			set
			{
			}
		}

		[Token(Token = "0x17000087")]
		public ReferenceLoopHandling? ItemReferenceLoopHandling
		{
			[Token(Token = "0x600035B")]
			[Address(RVA = "0xD130CC", Offset = "0xD130CC", VA = "0xD130CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8104F8", Offset = "0x8104F8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600035C")]
			[Address(RVA = "0xD130D4", Offset = "0xD130D4", VA = "0xD130D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810508", Offset = "0x810508")]
			set
			{
			}
		}

		[Token(Token = "0x17000088")]
		public TypeNameHandling? ItemTypeNameHandling
		{
			[Token(Token = "0x600035D")]
			[Address(RVA = "0xD130DC", Offset = "0xD130DC", VA = "0xD130DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810518", Offset = "0x810518")]
			get
			{
				return null;
			}
			[Token(Token = "0x600035E")]
			[Address(RVA = "0xD130E4", Offset = "0xD130E4", VA = "0xD130E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810528", Offset = "0x810528")]
			set
			{
			}
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0xD127E4", Offset = "0xD127E4", VA = "0xD127E4")]
		internal JsonContainerContract(Type underlyingType)
		{
		}
	}
}
