using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x20000A2")]
	[Preserve]
	public class JsonProperty
	{
		[Token(Token = "0x4000269")]
		[FieldOffset(Offset = "0x10")]
		internal Required? _required;

		[Token(Token = "0x400026A")]
		[FieldOffset(Offset = "0x18")]
		internal bool _hasExplicitDefaultValue;

		[Token(Token = "0x400026B")]
		[FieldOffset(Offset = "0x20")]
		private object _defaultValue;

		[Token(Token = "0x400026C")]
		[FieldOffset(Offset = "0x28")]
		private bool _hasGeneratedDefaultValue;

		[Token(Token = "0x400026D")]
		[FieldOffset(Offset = "0x30")]
		private string _propertyName;

		[Token(Token = "0x400026E")]
		[FieldOffset(Offset = "0x38")]
		internal bool _skipPropertyNameEscape;

		[Token(Token = "0x400026F")]
		[FieldOffset(Offset = "0x40")]
		private Type _propertyType;

		[Token(Token = "0x4000270")]
		[FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F9E8", Offset = "0x80F9E8")]
		private JsonContract _003CPropertyContract_003Ek__BackingField;

		[Token(Token = "0x4000271")]
		[FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F9F8", Offset = "0x80F9F8")]
		private Type _003CDeclaringType_003Ek__BackingField;

		[Token(Token = "0x4000272")]
		[FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FA08", Offset = "0x80FA08")]
		private int? _003COrder_003Ek__BackingField;

		[Token(Token = "0x4000273")]
		[FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FA18", Offset = "0x80FA18")]
		private string _003CUnderlyingName_003Ek__BackingField;

		[Token(Token = "0x4000274")]
		[FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FA28", Offset = "0x80FA28")]
		private IValueProvider _003CValueProvider_003Ek__BackingField;

		[Token(Token = "0x4000275")]
		[FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FA38", Offset = "0x80FA38")]
		private IAttributeProvider _003CAttributeProvider_003Ek__BackingField;

		[Token(Token = "0x4000276")]
		[FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FA48", Offset = "0x80FA48")]
		private JsonConverter _003CConverter_003Ek__BackingField;

		[Token(Token = "0x4000277")]
		[FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FA58", Offset = "0x80FA58")]
		private JsonConverter _003CMemberConverter_003Ek__BackingField;

		[Token(Token = "0x4000278")]
		[FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FA68", Offset = "0x80FA68")]
		private bool _003CIgnored_003Ek__BackingField;

		[Token(Token = "0x4000279")]
		[FieldOffset(Offset = "0x89")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FA78", Offset = "0x80FA78")]
		private bool _003CReadable_003Ek__BackingField;

		[Token(Token = "0x400027A")]
		[FieldOffset(Offset = "0x8A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FA88", Offset = "0x80FA88")]
		private bool _003CWritable_003Ek__BackingField;

		[Token(Token = "0x400027B")]
		[FieldOffset(Offset = "0x8B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FA98", Offset = "0x80FA98")]
		private bool _003CHasMemberAttribute_003Ek__BackingField;

		[Token(Token = "0x400027C")]
		[FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FAA8", Offset = "0x80FAA8")]
		private bool? _003CIsReference_003Ek__BackingField;

		[Token(Token = "0x400027D")]
		[FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FAB8", Offset = "0x80FAB8")]
		private NullValueHandling? _003CNullValueHandling_003Ek__BackingField;

		[Token(Token = "0x400027E")]
		[FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FAC8", Offset = "0x80FAC8")]
		private DefaultValueHandling? _003CDefaultValueHandling_003Ek__BackingField;

		[Token(Token = "0x400027F")]
		[FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FAD8", Offset = "0x80FAD8")]
		private ReferenceLoopHandling? _003CReferenceLoopHandling_003Ek__BackingField;

		[Token(Token = "0x4000280")]
		[FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FAE8", Offset = "0x80FAE8")]
		private ObjectCreationHandling? _003CObjectCreationHandling_003Ek__BackingField;

		[Token(Token = "0x4000281")]
		[FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FAF8", Offset = "0x80FAF8")]
		private TypeNameHandling? _003CTypeNameHandling_003Ek__BackingField;

		[Token(Token = "0x4000282")]
		[FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FB08", Offset = "0x80FB08")]
		private Predicate<object> _003CShouldSerialize_003Ek__BackingField;

		[Token(Token = "0x4000283")]
		[FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FB18", Offset = "0x80FB18")]
		private Predicate<object> _003CShouldDeserialize_003Ek__BackingField;

		[Token(Token = "0x4000284")]
		[FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FB28", Offset = "0x80FB28")]
		private Predicate<object> _003CGetIsSpecified_003Ek__BackingField;

		[Token(Token = "0x4000285")]
		[FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FB38", Offset = "0x80FB38")]
		private Action<object, object> _003CSetIsSpecified_003Ek__BackingField;

		[Token(Token = "0x4000286")]
		[FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FB48", Offset = "0x80FB48")]
		private JsonConverter _003CItemConverter_003Ek__BackingField;

		[Token(Token = "0x4000287")]
		[FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FB58", Offset = "0x80FB58")]
		private bool? _003CItemIsReference_003Ek__BackingField;

		[Token(Token = "0x4000288")]
		[FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FB68", Offset = "0x80FB68")]
		private TypeNameHandling? _003CItemTypeNameHandling_003Ek__BackingField;

		[Token(Token = "0x4000289")]
		[FieldOffset(Offset = "0xEC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FB78", Offset = "0x80FB78")]
		private ReferenceLoopHandling? _003CItemReferenceLoopHandling_003Ek__BackingField;

		[Token(Token = "0x170000C0")]
		internal JsonContract PropertyContract
		{
			[Token(Token = "0x6000475")]
			[Address(RVA = "0xD15514", Offset = "0xD15514", VA = "0xD15514")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810960", Offset = "0x810960")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000476")]
			[Address(RVA = "0xD1551C", Offset = "0xD1551C", VA = "0xD1551C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810970", Offset = "0x810970")]
			set
			{
			}
		}

		[Token(Token = "0x170000C1")]
		public string PropertyName
		{
			[Token(Token = "0x6000477")]
			[Address(RVA = "0xD0AD50", Offset = "0xD0AD50", VA = "0xD0AD50")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000478")]
			[Address(RVA = "0xD0AD58", Offset = "0xD0AD58", VA = "0xD0AD58")]
			set
			{
			}
		}

		[Token(Token = "0x170000C2")]
		public Type DeclaringType
		{
			[Token(Token = "0x6000479")]
			[Address(RVA = "0xD15524", Offset = "0xD15524", VA = "0xD15524")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810980", Offset = "0x810980")]
			get
			{
				return null;
			}
			[Token(Token = "0x600047A")]
			[Address(RVA = "0xD0F1B0", Offset = "0xD0F1B0", VA = "0xD0F1B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810990", Offset = "0x810990")]
			set
			{
			}
		}

		[Token(Token = "0x170000C3")]
		public int? Order
		{
			[Token(Token = "0x600047B")]
			[Address(RVA = "0xD101CC", Offset = "0xD101CC", VA = "0xD101CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8109A0", Offset = "0x8109A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600047C")]
			[Address(RVA = "0xD0F6EC", Offset = "0xD0F6EC", VA = "0xD0F6EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8109B0", Offset = "0x8109B0")]
			set
			{
			}
		}

		[Token(Token = "0x170000C4")]
		public string UnderlyingName
		{
			[Token(Token = "0x600047D")]
			[Address(RVA = "0xD1552C", Offset = "0xD1552C", VA = "0xD1552C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8109C0", Offset = "0x8109C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600047E")]
			[Address(RVA = "0xD0F6E4", Offset = "0xD0F6E4", VA = "0xD0F6E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8109D0", Offset = "0x8109D0")]
			set
			{
			}
		}

		[Token(Token = "0x170000C5")]
		public IValueProvider ValueProvider
		{
			[Token(Token = "0x600047F")]
			[Address(RVA = "0xD15534", Offset = "0xD15534", VA = "0xD15534")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8109E0", Offset = "0x8109E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000480")]
			[Address(RVA = "0xD0F1B8", Offset = "0xD0F1B8", VA = "0xD0F1B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8109F0", Offset = "0x8109F0")]
			set
			{
			}
		}

		[Token(Token = "0x170000C6")]
		public IAttributeProvider AttributeProvider
		{
			[Token(Token = "0x6000481")]
			[Address(RVA = "0xD0A818", Offset = "0xD0A818", VA = "0xD0A818")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810A00", Offset = "0x810A00")]
			set
			{
			}
		}

		[Token(Token = "0x170000C7")]
		public Type PropertyType
		{
			[Token(Token = "0x6000482")]
			[Address(RVA = "0xD0A248", Offset = "0xD0A248", VA = "0xD0A248")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000483")]
			[Address(RVA = "0xD0A800", Offset = "0xD0A800", VA = "0xD0A800")]
			set
			{
			}
		}

		[Token(Token = "0x170000C8")]
		public JsonConverter Converter
		{
			[Token(Token = "0x6000484")]
			[Address(RVA = "0xD0ADEC", Offset = "0xD0ADEC", VA = "0xD0ADEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810A10", Offset = "0x810A10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000485")]
			[Address(RVA = "0xD0ADF4", Offset = "0xD0ADF4", VA = "0xD0ADF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810A20", Offset = "0x810A20")]
			set
			{
			}
		}

		[Token(Token = "0x170000C9")]
		public JsonConverter MemberConverter
		{
			[Token(Token = "0x6000486")]
			[Address(RVA = "0xD0ADFC", Offset = "0xD0ADFC", VA = "0xD0ADFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810A30", Offset = "0x810A30")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000487")]
			[Address(RVA = "0xD0AE04", Offset = "0xD0AE04", VA = "0xD0AE04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810A40", Offset = "0x810A40")]
			set
			{
			}
		}

		[Token(Token = "0x170000CA")]
		public bool Ignored
		{
			[Token(Token = "0x6000488")]
			[Address(RVA = "0xD1553C", Offset = "0xD1553C", VA = "0xD1553C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810A50", Offset = "0x810A50")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000489")]
			[Address(RVA = "0xD0F700", Offset = "0xD0F700", VA = "0xD0F700")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810A60", Offset = "0x810A60")]
			set
			{
			}
		}

		[Token(Token = "0x170000CB")]
		public bool Readable
		{
			[Token(Token = "0x600048A")]
			[Address(RVA = "0xD15544", Offset = "0xD15544", VA = "0xD15544")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810A70", Offset = "0x810A70")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600048B")]
			[Address(RVA = "0xD0AD38", Offset = "0xD0AD38", VA = "0xD0AD38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810A80", Offset = "0x810A80")]
			set
			{
			}
		}

		[Token(Token = "0x170000CC")]
		public bool Writable
		{
			[Token(Token = "0x600048C")]
			[Address(RVA = "0xD1554C", Offset = "0xD1554C", VA = "0xD1554C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810A90", Offset = "0x810A90")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600048D")]
			[Address(RVA = "0xD0AD44", Offset = "0xD0AD44", VA = "0xD0AD44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810AA0", Offset = "0x810AA0")]
			set
			{
			}
		}

		[Token(Token = "0x170000CD")]
		public bool HasMemberAttribute
		{
			[Token(Token = "0x600048E")]
			[Address(RVA = "0xD0F1C0", Offset = "0xD0F1C0", VA = "0xD0F1C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810AB0", Offset = "0x810AB0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600048F")]
			[Address(RVA = "0xD0F6F4", Offset = "0xD0F6F4", VA = "0xD0F6F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810AC0", Offset = "0x810AC0")]
			set
			{
			}
		}

		[Token(Token = "0x170000CE")]
		public object DefaultValue
		{
			[Token(Token = "0x6000490")]
			[Address(RVA = "0xD0AE0C", Offset = "0xD0AE0C", VA = "0xD0AE0C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000491")]
			[Address(RVA = "0xD0AE24", Offset = "0xD0AE24", VA = "0xD0AE24")]
			set
			{
			}
		}

		[Token(Token = "0x170000CF")]
		public Required Required
		{
			[Token(Token = "0x6000493")]
			[Address(RVA = "0xD1504C", Offset = "0xD1504C", VA = "0xD1504C")]
			get
			{
				return default(Required);
			}
		}

		[Token(Token = "0x170000D0")]
		public bool? IsReference
		{
			[Token(Token = "0x6000494")]
			[Address(RVA = "0xD0AE34", Offset = "0xD0AE34", VA = "0xD0AE34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810AD0", Offset = "0x810AD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000495")]
			[Address(RVA = "0xD0AE3C", Offset = "0xD0AE3C", VA = "0xD0AE3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810AE0", Offset = "0x810AE0")]
			set
			{
			}
		}

		[Token(Token = "0x170000D1")]
		public NullValueHandling? NullValueHandling
		{
			[Token(Token = "0x6000496")]
			[Address(RVA = "0xD0AE44", Offset = "0xD0AE44", VA = "0xD0AE44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810AF0", Offset = "0x810AF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000497")]
			[Address(RVA = "0xD0AE4C", Offset = "0xD0AE4C", VA = "0xD0AE4C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810B00", Offset = "0x810B00")]
			set
			{
			}
		}

		[Token(Token = "0x170000D2")]
		public DefaultValueHandling? DefaultValueHandling
		{
			[Token(Token = "0x6000498")]
			[Address(RVA = "0xD0AE54", Offset = "0xD0AE54", VA = "0xD0AE54")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810B10", Offset = "0x810B10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000499")]
			[Address(RVA = "0xD0AE5C", Offset = "0xD0AE5C", VA = "0xD0AE5C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810B20", Offset = "0x810B20")]
			set
			{
			}
		}

		[Token(Token = "0x170000D3")]
		public ReferenceLoopHandling? ReferenceLoopHandling
		{
			[Token(Token = "0x600049A")]
			[Address(RVA = "0xD0AE64", Offset = "0xD0AE64", VA = "0xD0AE64")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810B30", Offset = "0x810B30")]
			get
			{
				return null;
			}
			[Token(Token = "0x600049B")]
			[Address(RVA = "0xD0AE6C", Offset = "0xD0AE6C", VA = "0xD0AE6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810B40", Offset = "0x810B40")]
			set
			{
			}
		}

		[Token(Token = "0x170000D4")]
		public ObjectCreationHandling? ObjectCreationHandling
		{
			[Token(Token = "0x600049C")]
			[Address(RVA = "0xD0AE74", Offset = "0xD0AE74", VA = "0xD0AE74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810B50", Offset = "0x810B50")]
			get
			{
				return null;
			}
			[Token(Token = "0x600049D")]
			[Address(RVA = "0xD0AE7C", Offset = "0xD0AE7C", VA = "0xD0AE7C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810B60", Offset = "0x810B60")]
			set
			{
			}
		}

		[Token(Token = "0x170000D5")]
		public TypeNameHandling? TypeNameHandling
		{
			[Token(Token = "0x600049E")]
			[Address(RVA = "0xD0AE84", Offset = "0xD0AE84", VA = "0xD0AE84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810B70", Offset = "0x810B70")]
			get
			{
				return null;
			}
			[Token(Token = "0x600049F")]
			[Address(RVA = "0xD0AE8C", Offset = "0xD0AE8C", VA = "0xD0AE8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810B80", Offset = "0x810B80")]
			set
			{
			}
		}

		[Token(Token = "0x170000D6")]
		public Predicate<object> ShouldSerialize
		{
			[Token(Token = "0x60004A0")]
			[Address(RVA = "0xD155F0", Offset = "0xD155F0", VA = "0xD155F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810B90", Offset = "0x810B90")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004A1")]
			[Address(RVA = "0xD0F400", Offset = "0xD0F400", VA = "0xD0F400")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810BA0", Offset = "0x810BA0")]
			set
			{
			}
		}

		[Token(Token = "0x170000D7")]
		public Predicate<object> ShouldDeserialize
		{
			[Token(Token = "0x60004A2")]
			[Address(RVA = "0xD155F8", Offset = "0xD155F8", VA = "0xD155F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810BB0", Offset = "0x810BB0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D8")]
		public Predicate<object> GetIsSpecified
		{
			[Token(Token = "0x60004A3")]
			[Address(RVA = "0xD15600", Offset = "0xD15600", VA = "0xD15600")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810BC0", Offset = "0x810BC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004A4")]
			[Address(RVA = "0xD0F73C", Offset = "0xD0F73C", VA = "0xD0F73C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810BD0", Offset = "0x810BD0")]
			set
			{
			}
		}

		[Token(Token = "0x170000D9")]
		public Action<object, object> SetIsSpecified
		{
			[Token(Token = "0x60004A5")]
			[Address(RVA = "0xD15608", Offset = "0xD15608", VA = "0xD15608")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810BE0", Offset = "0x810BE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004A6")]
			[Address(RVA = "0xD0F744", Offset = "0xD0F744", VA = "0xD0F744")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810BF0", Offset = "0x810BF0")]
			set
			{
			}
		}

		[Token(Token = "0x170000DA")]
		public JsonConverter ItemConverter
		{
			[Token(Token = "0x60004A8")]
			[Address(RVA = "0xD15618", Offset = "0xD15618", VA = "0xD15618")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810C00", Offset = "0x810C00")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004A9")]
			[Address(RVA = "0xD0F714", Offset = "0xD0F714", VA = "0xD0F714")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810C10", Offset = "0x810C10")]
			set
			{
			}
		}

		[Token(Token = "0x170000DB")]
		public bool? ItemIsReference
		{
			[Token(Token = "0x60004AA")]
			[Address(RVA = "0xD15620", Offset = "0xD15620", VA = "0xD15620")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810C20", Offset = "0x810C20")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004AB")]
			[Address(RVA = "0xD0F70C", Offset = "0xD0F70C", VA = "0xD0F70C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810C30", Offset = "0x810C30")]
			set
			{
			}
		}

		[Token(Token = "0x170000DC")]
		public TypeNameHandling? ItemTypeNameHandling
		{
			[Token(Token = "0x60004AC")]
			[Address(RVA = "0xD15628", Offset = "0xD15628", VA = "0xD15628")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810C40", Offset = "0x810C40")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004AD")]
			[Address(RVA = "0xD0F724", Offset = "0xD0F724", VA = "0xD0F724")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810C50", Offset = "0x810C50")]
			set
			{
			}
		}

		[Token(Token = "0x170000DD")]
		public ReferenceLoopHandling? ItemReferenceLoopHandling
		{
			[Token(Token = "0x60004AE")]
			[Address(RVA = "0xD15630", Offset = "0xD15630", VA = "0xD15630")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810C60", Offset = "0x810C60")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004AF")]
			[Address(RVA = "0xD0F71C", Offset = "0xD0F71C", VA = "0xD0F71C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810C70", Offset = "0x810C70")]
			set
			{
			}
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0xD15554", Offset = "0xD15554", VA = "0xD15554")]
		internal object GetResolvedDefaultValue()
		{
			return null;
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0xD15610", Offset = "0xD15610", VA = "0xD15610", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0xD15638", Offset = "0xD15638", VA = "0xD15638")]
		internal void WritePropertyName(JsonWriter writer)
		{
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0xD0A7F8", Offset = "0xD0A7F8", VA = "0xD0A7F8")]
		public JsonProperty()
		{
		}
	}
}
