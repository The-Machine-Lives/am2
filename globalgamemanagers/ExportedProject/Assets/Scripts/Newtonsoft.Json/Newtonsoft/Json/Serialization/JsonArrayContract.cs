using System;
using System.Collections;
using System.Reflection;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x2000098")]
	[Preserve]
	public class JsonArrayContract : JsonContainerContract
	{
		[Token(Token = "0x400022E")]
		[FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F8C8", Offset = "0x80F8C8")]
		private Type _003CCollectionItemType_003Ek__BackingField;

		[Token(Token = "0x400022F")]
		[FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F8D8", Offset = "0x80F8D8")]
		private bool _003CIsMultidimensionalArray_003Ek__BackingField;

		[Token(Token = "0x4000230")]
		[FieldOffset(Offset = "0xD0")]
		private readonly Type _genericCollectionDefinitionType;

		[Token(Token = "0x4000231")]
		[FieldOffset(Offset = "0xD8")]
		private Type _genericWrapperType;

		[Token(Token = "0x4000232")]
		[FieldOffset(Offset = "0xE0")]
		private ObjectConstructor<object> _genericWrapperCreator;

		[Token(Token = "0x4000233")]
		[FieldOffset(Offset = "0xE8")]
		private Func<object> _genericTemporaryCollectionCreator;

		[Token(Token = "0x4000234")]
		[FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F8E8", Offset = "0x80F8E8")]
		private bool _003CIsArray_003Ek__BackingField;

		[Token(Token = "0x4000235")]
		[FieldOffset(Offset = "0xF1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F8F8", Offset = "0x80F8F8")]
		private bool _003CShouldCreateWrapper_003Ek__BackingField;

		[Token(Token = "0x4000236")]
		[FieldOffset(Offset = "0xF2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F908", Offset = "0x80F908")]
		private bool _003CCanDeserialize_003Ek__BackingField;

		[Token(Token = "0x4000237")]
		[FieldOffset(Offset = "0xF8")]
		private readonly ConstructorInfo _parameterizedConstructor;

		[Token(Token = "0x4000238")]
		[FieldOffset(Offset = "0x100")]
		private ObjectConstructor<object> _parameterizedCreator;

		[Token(Token = "0x4000239")]
		[FieldOffset(Offset = "0x108")]
		private ObjectConstructor<object> _overrideCreator;

		[Token(Token = "0x400023A")]
		[FieldOffset(Offset = "0x110")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F918", Offset = "0x80F918")]
		private bool _003CHasParameterizedCreator_003Ek__BackingField;

		[Token(Token = "0x170000A2")]
		public Type CollectionItemType
		{
			[Token(Token = "0x6000420")]
			[Address(RVA = "0xD0DCD4", Offset = "0xD0DCD4", VA = "0xD0DCD4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810720", Offset = "0x810720")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000421")]
			[Address(RVA = "0xD126B4", Offset = "0xD126B4", VA = "0xD126B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810730", Offset = "0x810730")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A3")]
		public bool IsMultidimensionalArray
		{
			[Token(Token = "0x6000422")]
			[Address(RVA = "0xD126BC", Offset = "0xD126BC", VA = "0xD126BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810740", Offset = "0x810740")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000423")]
			[Address(RVA = "0xD126C4", Offset = "0xD126C4", VA = "0xD126C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810750", Offset = "0x810750")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A4")]
		internal bool IsArray
		{
			[Token(Token = "0x6000424")]
			[Address(RVA = "0xD126D0", Offset = "0xD126D0", VA = "0xD126D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810760", Offset = "0x810760")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000425")]
			[Address(RVA = "0xD126D8", Offset = "0xD126D8", VA = "0xD126D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810770", Offset = "0x810770")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A5")]
		internal bool ShouldCreateWrapper
		{
			[Token(Token = "0x6000426")]
			[Address(RVA = "0xD126E4", Offset = "0xD126E4", VA = "0xD126E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810780", Offset = "0x810780")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000427")]
			[Address(RVA = "0xD126EC", Offset = "0xD126EC", VA = "0xD126EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810790", Offset = "0x810790")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A6")]
		internal bool CanDeserialize
		{
			[Token(Token = "0x6000428")]
			[Address(RVA = "0xD126F8", Offset = "0xD126F8", VA = "0xD126F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8107A0", Offset = "0x8107A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000429")]
			[Address(RVA = "0xD12700", Offset = "0xD12700", VA = "0xD12700")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8107B0", Offset = "0x8107B0")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A7")]
		internal ObjectConstructor<object> ParameterizedCreator
		{
			[Token(Token = "0x600042A")]
			[Address(RVA = "0xD1270C", Offset = "0xD1270C", VA = "0xD1270C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A8")]
		public ObjectConstructor<object> OverrideCreator
		{
			[Token(Token = "0x600042B")]
			[Address(RVA = "0xD127AC", Offset = "0xD127AC", VA = "0xD127AC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600042C")]
			[Address(RVA = "0xD0DCE8", Offset = "0xD0DCE8", VA = "0xD0DCE8")]
			set
			{
			}
		}

		[Token(Token = "0x170000A9")]
		public bool HasParameterizedCreator
		{
			[Token(Token = "0x600042D")]
			[Address(RVA = "0xD127B4", Offset = "0xD127B4", VA = "0xD127B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8107C0", Offset = "0x8107C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600042E")]
			[Address(RVA = "0xD0DCDC", Offset = "0xD0DCDC", VA = "0xD0DCDC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8107D0", Offset = "0x8107D0")]
			set
			{
			}
		}

		[Token(Token = "0x170000AA")]
		internal bool HasParameterizedCreatorInternal
		{
			[Token(Token = "0x600042F")]
			[Address(RVA = "0xD127BC", Offset = "0xD127BC", VA = "0xD127BC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0xD0D1F0", Offset = "0xD0D1F0", VA = "0xD0D1F0")]
		public JsonArrayContract(Type underlyingType)
		{
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0xD12958", Offset = "0xD12958", VA = "0xD12958")]
		internal IWrappedCollection CreateWrapper(object list)
		{
			return null;
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0xD12DDC", Offset = "0xD12DDC", VA = "0xD12DDC")]
		internal IList CreateTemporaryCollection()
		{
			return null;
		}
	}
}
