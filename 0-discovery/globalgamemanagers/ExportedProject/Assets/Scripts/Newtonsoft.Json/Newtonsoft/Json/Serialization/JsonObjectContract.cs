using System;
using System.Reflection;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x20000A5")]
	[Preserve]
	public class JsonObjectContract : JsonContainerContract
	{
		[Token(Token = "0x400028C")]
		[FieldOffset(Offset = "0xBC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FB88", Offset = "0x80FB88")]
		private MemberSerialization _003CMemberSerialization_003Ek__BackingField;

		[Token(Token = "0x400028D")]
		[FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FB98", Offset = "0x80FB98")]
		private Required? _003CItemRequired_003Ek__BackingField;

		[Token(Token = "0x400028E")]
		[FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FBA8", Offset = "0x80FBA8")]
		private JsonPropertyCollection _003CProperties_003Ek__BackingField;

		[Token(Token = "0x400028F")]
		[FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FBB8", Offset = "0x80FBB8")]
		private ExtensionDataSetter _003CExtensionDataSetter_003Ek__BackingField;

		[Token(Token = "0x4000290")]
		[FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FBC8", Offset = "0x80FBC8")]
		private ExtensionDataGetter _003CExtensionDataGetter_003Ek__BackingField;

		[Token(Token = "0x4000291")]
		[FieldOffset(Offset = "0xE0")]
		internal bool ExtensionDataIsJToken;

		[Token(Token = "0x4000292")]
		[FieldOffset(Offset = "0xE1")]
		private bool? _hasRequiredOrDefaultValueProperties;

		[Token(Token = "0x4000293")]
		[FieldOffset(Offset = "0xE8")]
		private ConstructorInfo _parametrizedConstructor;

		[Token(Token = "0x4000294")]
		[FieldOffset(Offset = "0xF0")]
		private ConstructorInfo _overrideConstructor;

		[Token(Token = "0x4000295")]
		[FieldOffset(Offset = "0xF8")]
		private ObjectConstructor<object> _overrideCreator;

		[Token(Token = "0x4000296")]
		[FieldOffset(Offset = "0x100")]
		private ObjectConstructor<object> _parameterizedCreator;

		[Token(Token = "0x4000297")]
		[FieldOffset(Offset = "0x108")]
		private JsonPropertyCollection _creatorParameters;

		[Token(Token = "0x4000298")]
		[FieldOffset(Offset = "0x110")]
		private Type _extensionDataValueType;

		[Token(Token = "0x170000DE")]
		public MemberSerialization MemberSerialization
		{
			[Token(Token = "0x60004BC")]
			[Address(RVA = "0xD089E0", Offset = "0xD089E0", VA = "0xD089E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810C80", Offset = "0x810C80")]
			get
			{
				return default(MemberSerialization);
			}
			[Token(Token = "0x60004BD")]
			[Address(RVA = "0xD089D0", Offset = "0xD089D0", VA = "0xD089D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810C90", Offset = "0x810C90")]
			set
			{
			}
		}

		[Token(Token = "0x170000DF")]
		public Required? ItemRequired
		{
			[Token(Token = "0x60004BE")]
			[Address(RVA = "0xD14C20", Offset = "0xD14C20", VA = "0xD14C20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810CA0", Offset = "0x810CA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004BF")]
			[Address(RVA = "0xD089E8", Offset = "0xD089E8", VA = "0xD089E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810CB0", Offset = "0x810CB0")]
			set
			{
			}
		}

		[Token(Token = "0x170000E0")]
		public JsonPropertyCollection Properties
		{
			[Token(Token = "0x60004C0")]
			[Address(RVA = "0xD089D8", Offset = "0xD089D8", VA = "0xD089D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810CC0", Offset = "0x810CC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004C1")]
			[Address(RVA = "0xD14C28", Offset = "0xD14C28", VA = "0xD14C28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810CD0", Offset = "0x810CD0")]
			private set
			{
			}
		}

		[Token(Token = "0x170000E1")]
		public JsonPropertyCollection CreatorParameters
		{
			[Token(Token = "0x60004C2")]
			[Address(RVA = "0xD08FA4", Offset = "0xD08FA4", VA = "0xD08FA4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E2")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x811A3C", Offset = "0x811A3C")]
		public ConstructorInfo OverrideConstructor
		{
			[Token(Token = "0x60004C3")]
			[Address(RVA = "0xD08EFC", Offset = "0xD08EFC", VA = "0xD08EFC")]
			set
			{
			}
		}

		[Token(Token = "0x170000E3")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x811A74", Offset = "0x811A74")]
		public ConstructorInfo ParametrizedConstructor
		{
			[Token(Token = "0x60004C4")]
			[Address(RVA = "0xD091A8", Offset = "0xD091A8", VA = "0xD091A8")]
			set
			{
			}
		}

		[Token(Token = "0x170000E4")]
		public ObjectConstructor<object> OverrideCreator
		{
			[Token(Token = "0x60004C5")]
			[Address(RVA = "0xD14C30", Offset = "0xD14C30", VA = "0xD14C30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E5")]
		internal ObjectConstructor<object> ParameterizedCreator
		{
			[Token(Token = "0x60004C6")]
			[Address(RVA = "0xD14C38", Offset = "0xD14C38", VA = "0xD14C38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E6")]
		public ExtensionDataSetter ExtensionDataSetter
		{
			[Token(Token = "0x60004C7")]
			[Address(RVA = "0xD14C40", Offset = "0xD14C40", VA = "0xD14C40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810CE0", Offset = "0x810CE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004C8")]
			[Address(RVA = "0xD09E0C", Offset = "0xD09E0C", VA = "0xD09E0C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810CF0", Offset = "0x810CF0")]
			set
			{
			}
		}

		[Token(Token = "0x170000E7")]
		public ExtensionDataGetter ExtensionDataGetter
		{
			[Token(Token = "0x60004C9")]
			[Address(RVA = "0xD14C48", Offset = "0xD14C48", VA = "0xD14C48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810D00", Offset = "0x810D00")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004CA")]
			[Address(RVA = "0xD09E2C", Offset = "0xD09E2C", VA = "0xD09E2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810D10", Offset = "0x810D10")]
			set
			{
			}
		}

		[Token(Token = "0x170000E8")]
		public Type ExtensionDataValueType
		{
			[Token(Token = "0x60004CB")]
			[Address(RVA = "0xD09E34", Offset = "0xD09E34", VA = "0xD09E34")]
			set
			{
			}
		}

		[Token(Token = "0x170000E9")]
		internal bool HasRequiredOrDefaultValueProperties
		{
			[Token(Token = "0x60004CC")]
			[Address(RVA = "0xD14C50", Offset = "0xD14C50", VA = "0xD14C50")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0xD0873C", Offset = "0xD0873C", VA = "0xD0873C")]
		public JsonObjectContract(Type underlyingType)
		{
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0xD150D0", Offset = "0xD150D0", VA = "0xD150D0")]
		internal object GetUninitializedObject()
		{
			return null;
		}
	}
}
