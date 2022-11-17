using System;
using System.Collections;
using System.Reflection;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x20000A1")]
	[Preserve]
	public class JsonDictionaryContract : JsonContainerContract
	{
		[Token(Token = "0x400025C")]
		[FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F988", Offset = "0x80F988")]
		private Func<string, string> _003CDictionaryKeyResolver_003Ek__BackingField;

		[Token(Token = "0x400025D")]
		[FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F998", Offset = "0x80F998")]
		private Type _003CDictionaryKeyType_003Ek__BackingField;

		[Token(Token = "0x400025E")]
		[FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F9A8", Offset = "0x80F9A8")]
		private Type _003CDictionaryValueType_003Ek__BackingField;

		[Token(Token = "0x400025F")]
		[FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F9B8", Offset = "0x80F9B8")]
		private JsonContract _003CKeyContract_003Ek__BackingField;

		[Token(Token = "0x4000260")]
		[FieldOffset(Offset = "0xE0")]
		private readonly Type _genericCollectionDefinitionType;

		[Token(Token = "0x4000261")]
		[FieldOffset(Offset = "0xE8")]
		private Type _genericWrapperType;

		[Token(Token = "0x4000262")]
		[FieldOffset(Offset = "0xF0")]
		private ObjectConstructor<object> _genericWrapperCreator;

		[Token(Token = "0x4000263")]
		[FieldOffset(Offset = "0xF8")]
		private Func<object> _genericTemporaryDictionaryCreator;

		[Token(Token = "0x4000264")]
		[FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F9C8", Offset = "0x80F9C8")]
		private bool _003CShouldCreateWrapper_003Ek__BackingField;

		[Token(Token = "0x4000265")]
		[FieldOffset(Offset = "0x108")]
		private readonly ConstructorInfo _parameterizedConstructor;

		[Token(Token = "0x4000266")]
		[FieldOffset(Offset = "0x110")]
		private ObjectConstructor<object> _overrideCreator;

		[Token(Token = "0x4000267")]
		[FieldOffset(Offset = "0x118")]
		private ObjectConstructor<object> _parameterizedCreator;

		[Token(Token = "0x4000268")]
		[FieldOffset(Offset = "0x120")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F9D8", Offset = "0x80F9D8")]
		private bool _003CHasParameterizedCreator_003Ek__BackingField;

		[Token(Token = "0x170000B7")]
		public Func<string, string> DictionaryKeyResolver
		{
			[Token(Token = "0x6000462")]
			[Address(RVA = "0xD1411C", Offset = "0xD1411C", VA = "0xD1411C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8108A0", Offset = "0x8108A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000463")]
			[Address(RVA = "0xD0CE94", Offset = "0xD0CE94", VA = "0xD0CE94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8108B0", Offset = "0x8108B0")]
			set
			{
			}
		}

		[Token(Token = "0x170000B8")]
		public Type DictionaryKeyType
		{
			[Token(Token = "0x6000464")]
			[Address(RVA = "0xD0CE9C", Offset = "0xD0CE9C", VA = "0xD0CE9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8108C0", Offset = "0x8108C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000465")]
			[Address(RVA = "0xD14124", Offset = "0xD14124", VA = "0xD14124")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8108D0", Offset = "0x8108D0")]
			private set
			{
			}
		}

		[Token(Token = "0x170000B9")]
		public Type DictionaryValueType
		{
			[Token(Token = "0x6000466")]
			[Address(RVA = "0xD0CEA4", Offset = "0xD0CEA4", VA = "0xD0CEA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8108E0", Offset = "0x8108E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000467")]
			[Address(RVA = "0xD1412C", Offset = "0xD1412C", VA = "0xD1412C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8108F0", Offset = "0x8108F0")]
			private set
			{
			}
		}

		[Token(Token = "0x170000BA")]
		internal JsonContract KeyContract
		{
			[Token(Token = "0x6000468")]
			[Address(RVA = "0xD14134", Offset = "0xD14134", VA = "0xD14134")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810900", Offset = "0x810900")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000469")]
			[Address(RVA = "0xD1413C", Offset = "0xD1413C", VA = "0xD1413C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810910", Offset = "0x810910")]
			set
			{
			}
		}

		[Token(Token = "0x170000BB")]
		internal bool ShouldCreateWrapper
		{
			[Token(Token = "0x600046A")]
			[Address(RVA = "0xD14144", Offset = "0xD14144", VA = "0xD14144")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810920", Offset = "0x810920")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600046B")]
			[Address(RVA = "0xD1414C", Offset = "0xD1414C", VA = "0xD1414C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810930", Offset = "0x810930")]
			private set
			{
			}
		}

		[Token(Token = "0x170000BC")]
		internal ObjectConstructor<object> ParameterizedCreator
		{
			[Token(Token = "0x600046C")]
			[Address(RVA = "0xD14158", Offset = "0xD14158", VA = "0xD14158")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BD")]
		public ObjectConstructor<object> OverrideCreator
		{
			[Token(Token = "0x600046D")]
			[Address(RVA = "0xD141F8", Offset = "0xD141F8", VA = "0xD141F8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600046E")]
			[Address(RVA = "0xD0CEC0", Offset = "0xD0CEC0", VA = "0xD0CEC0")]
			set
			{
			}
		}

		[Token(Token = "0x170000BE")]
		public bool HasParameterizedCreator
		{
			[Token(Token = "0x600046F")]
			[Address(RVA = "0xD14200", Offset = "0xD14200", VA = "0xD14200")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810940", Offset = "0x810940")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000470")]
			[Address(RVA = "0xD0CEAC", Offset = "0xD0CEAC", VA = "0xD0CEAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810950", Offset = "0x810950")]
			set
			{
			}
		}

		[Token(Token = "0x170000BF")]
		internal bool HasParameterizedCreatorInternal
		{
			[Token(Token = "0x6000471")]
			[Address(RVA = "0xD14208", Offset = "0xD14208", VA = "0xD14208")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0xD0C7A0", Offset = "0xD0C7A0", VA = "0xD0C7A0")]
		public JsonDictionaryContract(Type underlyingType)
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0xD14230", Offset = "0xD14230", VA = "0xD14230")]
		internal IWrappedDictionary CreateWrapper(object dictionary)
		{
			return null;
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0xD14584", Offset = "0xD14584", VA = "0xD14584")]
		internal IDictionary CreateTemporaryDictionary()
		{
			return null;
		}
	}
}
