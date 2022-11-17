using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using Il2CppDummyDll;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	[Token(Token = "0x2000035")]
	[Preserve]
	public class JsonSerializer
	{
		[Token(Token = "0x40000E2")]
		[FieldOffset(Offset = "0x10")]
		internal TypeNameHandling _typeNameHandling;

		[Token(Token = "0x40000E3")]
		[FieldOffset(Offset = "0x14")]
		internal FormatterAssemblyStyle _typeNameAssemblyFormat;

		[Token(Token = "0x40000E4")]
		[FieldOffset(Offset = "0x18")]
		internal PreserveReferencesHandling _preserveReferencesHandling;

		[Token(Token = "0x40000E5")]
		[FieldOffset(Offset = "0x1C")]
		internal ReferenceLoopHandling _referenceLoopHandling;

		[Token(Token = "0x40000E6")]
		[FieldOffset(Offset = "0x20")]
		internal MissingMemberHandling _missingMemberHandling;

		[Token(Token = "0x40000E7")]
		[FieldOffset(Offset = "0x24")]
		internal ObjectCreationHandling _objectCreationHandling;

		[Token(Token = "0x40000E8")]
		[FieldOffset(Offset = "0x28")]
		internal NullValueHandling _nullValueHandling;

		[Token(Token = "0x40000E9")]
		[FieldOffset(Offset = "0x2C")]
		internal DefaultValueHandling _defaultValueHandling;

		[Token(Token = "0x40000EA")]
		[FieldOffset(Offset = "0x30")]
		internal ConstructorHandling _constructorHandling;

		[Token(Token = "0x40000EB")]
		[FieldOffset(Offset = "0x34")]
		internal MetadataPropertyHandling _metadataPropertyHandling;

		[Token(Token = "0x40000EC")]
		[FieldOffset(Offset = "0x38")]
		internal JsonConverterCollection _converters;

		[Token(Token = "0x40000ED")]
		[FieldOffset(Offset = "0x40")]
		internal IContractResolver _contractResolver;

		[Token(Token = "0x40000EE")]
		[FieldOffset(Offset = "0x48")]
		internal ITraceWriter _traceWriter;

		[Token(Token = "0x40000EF")]
		[FieldOffset(Offset = "0x50")]
		internal IEqualityComparer _equalityComparer;

		[Token(Token = "0x40000F0")]
		[FieldOffset(Offset = "0x58")]
		internal SerializationBinder _binder;

		[Token(Token = "0x40000F1")]
		[FieldOffset(Offset = "0x60")]
		internal StreamingContext _context;

		[Token(Token = "0x40000F2")]
		[FieldOffset(Offset = "0x70")]
		private IReferenceResolver _referenceResolver;

		[Token(Token = "0x40000F3")]
		[FieldOffset(Offset = "0x78")]
		private Formatting? _formatting;

		[Token(Token = "0x40000F4")]
		[FieldOffset(Offset = "0x80")]
		private DateFormatHandling? _dateFormatHandling;

		[Token(Token = "0x40000F5")]
		[FieldOffset(Offset = "0x88")]
		private DateTimeZoneHandling? _dateTimeZoneHandling;

		[Token(Token = "0x40000F6")]
		[FieldOffset(Offset = "0x90")]
		private DateParseHandling? _dateParseHandling;

		[Token(Token = "0x40000F7")]
		[FieldOffset(Offset = "0x98")]
		private FloatFormatHandling? _floatFormatHandling;

		[Token(Token = "0x40000F8")]
		[FieldOffset(Offset = "0xA0")]
		private FloatParseHandling? _floatParseHandling;

		[Token(Token = "0x40000F9")]
		[FieldOffset(Offset = "0xA8")]
		private StringEscapeHandling? _stringEscapeHandling;

		[Token(Token = "0x40000FA")]
		[FieldOffset(Offset = "0xB0")]
		private CultureInfo _culture;

		[Token(Token = "0x40000FB")]
		[FieldOffset(Offset = "0xB8")]
		private int? _maxDepth;

		[Token(Token = "0x40000FC")]
		[FieldOffset(Offset = "0xC0")]
		private bool _maxDepthSet;

		[Token(Token = "0x40000FD")]
		[FieldOffset(Offset = "0xC1")]
		private bool? _checkAdditionalContent;

		[Token(Token = "0x40000FE")]
		[FieldOffset(Offset = "0xC8")]
		private string _dateFormatString;

		[Token(Token = "0x40000FF")]
		[FieldOffset(Offset = "0xD0")]
		private bool _dateFormatStringSet;

		[Token(Token = "0x1700003B")]
		public virtual IReferenceResolver ReferenceResolver
		{
			[Token(Token = "0x6000136")]
			[Address(RVA = "0xD520CC", Offset = "0xD520CC", VA = "0xD520CC", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x1700003C")]
		public virtual SerializationBinder Binder
		{
			[Token(Token = "0x6000137")]
			[Address(RVA = "0xD52170", Offset = "0xD52170", VA = "0xD52170", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x1700003D")]
		public virtual ITraceWriter TraceWriter
		{
			[Token(Token = "0x6000138")]
			[Address(RVA = "0xD52214", Offset = "0xD52214", VA = "0xD52214", Slot = "8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000139")]
			[Address(RVA = "0xD5221C", Offset = "0xD5221C", VA = "0xD5221C", Slot = "9")]
			set
			{
			}
		}

		[Token(Token = "0x1700003E")]
		public virtual IEqualityComparer EqualityComparer
		{
			[Token(Token = "0x600013A")]
			[Address(RVA = "0xD52224", Offset = "0xD52224", VA = "0xD52224", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x1700003F")]
		public virtual TypeNameHandling TypeNameHandling
		{
			[Token(Token = "0x600013B")]
			[Address(RVA = "0xD5222C", Offset = "0xD5222C", VA = "0xD5222C", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x17000040")]
		public virtual FormatterAssemblyStyle TypeNameAssemblyFormat
		{
			[Token(Token = "0x600013C")]
			[Address(RVA = "0xD522C8", Offset = "0xD522C8", VA = "0xD522C8", Slot = "12")]
			set
			{
			}
		}

		[Token(Token = "0x17000041")]
		public virtual PreserveReferencesHandling PreserveReferencesHandling
		{
			[Token(Token = "0x600013D")]
			[Address(RVA = "0xD52364", Offset = "0xD52364", VA = "0xD52364", Slot = "13")]
			set
			{
			}
		}

		[Token(Token = "0x17000042")]
		public virtual ReferenceLoopHandling ReferenceLoopHandling
		{
			[Token(Token = "0x600013E")]
			[Address(RVA = "0xD52400", Offset = "0xD52400", VA = "0xD52400", Slot = "14")]
			set
			{
			}
		}

		[Token(Token = "0x17000043")]
		public virtual MissingMemberHandling MissingMemberHandling
		{
			[Token(Token = "0x600013F")]
			[Address(RVA = "0xD5249C", Offset = "0xD5249C", VA = "0xD5249C", Slot = "15")]
			set
			{
			}
		}

		[Token(Token = "0x17000044")]
		public virtual NullValueHandling NullValueHandling
		{
			[Token(Token = "0x6000140")]
			[Address(RVA = "0xD52538", Offset = "0xD52538", VA = "0xD52538", Slot = "16")]
			set
			{
			}
		}

		[Token(Token = "0x17000045")]
		public virtual DefaultValueHandling DefaultValueHandling
		{
			[Token(Token = "0x6000141")]
			[Address(RVA = "0xD525D4", Offset = "0xD525D4", VA = "0xD525D4", Slot = "17")]
			set
			{
			}
		}

		[Token(Token = "0x17000046")]
		public virtual ObjectCreationHandling ObjectCreationHandling
		{
			[Token(Token = "0x6000142")]
			[Address(RVA = "0xD52670", Offset = "0xD52670", VA = "0xD52670", Slot = "18")]
			get
			{
				return default(ObjectCreationHandling);
			}
			[Token(Token = "0x6000143")]
			[Address(RVA = "0xD52678", Offset = "0xD52678", VA = "0xD52678", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x17000047")]
		public virtual ConstructorHandling ConstructorHandling
		{
			[Token(Token = "0x6000144")]
			[Address(RVA = "0xD52714", Offset = "0xD52714", VA = "0xD52714", Slot = "20")]
			set
			{
			}
		}

		[Token(Token = "0x17000048")]
		public virtual MetadataPropertyHandling MetadataPropertyHandling
		{
			[Token(Token = "0x6000145")]
			[Address(RVA = "0xD527B0", Offset = "0xD527B0", VA = "0xD527B0", Slot = "21")]
			get
			{
				return default(MetadataPropertyHandling);
			}
			[Token(Token = "0x6000146")]
			[Address(RVA = "0xD527B8", Offset = "0xD527B8", VA = "0xD527B8", Slot = "22")]
			set
			{
			}
		}

		[Token(Token = "0x17000049")]
		public virtual JsonConverterCollection Converters
		{
			[Token(Token = "0x6000147")]
			[Address(RVA = "0xD52854", Offset = "0xD52854", VA = "0xD52854", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004A")]
		public virtual IContractResolver ContractResolver
		{
			[Token(Token = "0x6000148")]
			[Address(RVA = "0xD528BC", Offset = "0xD528BC", VA = "0xD528BC", Slot = "24")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000149")]
			[Address(RVA = "0xD528C4", Offset = "0xD528C4", VA = "0xD528C4", Slot = "25")]
			set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		public virtual StreamingContext Context
		{
			[Token(Token = "0x600014A")]
			[Address(RVA = "0xD5295C", Offset = "0xD5295C", VA = "0xD5295C", Slot = "26")]
			get
			{
				return default(StreamingContext);
			}
			[Token(Token = "0x600014B")]
			[Address(RVA = "0xD52968", Offset = "0xD52968", VA = "0xD52968", Slot = "27")]
			set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		public virtual Formatting Formatting
		{
			[Token(Token = "0x600014C")]
			[Address(RVA = "0xD52970", Offset = "0xD52970", VA = "0xD52970", Slot = "28")]
			get
			{
				return default(Formatting);
			}
			[Token(Token = "0x600014D")]
			[Address(RVA = "0xD529F4", Offset = "0xD529F4", VA = "0xD529F4", Slot = "29")]
			set
			{
			}
		}

		[Token(Token = "0x1700004D")]
		public virtual bool CheckAdditionalContent
		{
			[Token(Token = "0x600014E")]
			[Address(RVA = "0xD52A64", Offset = "0xD52A64", VA = "0xD52A64", Slot = "30")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600014F")]
			[Address(RVA = "0xD52AEC", Offset = "0xD52AEC", VA = "0xD52AEC", Slot = "31")]
			set
			{
			}
		}

		[Token(Token = "0x14000001")]
		public virtual event EventHandler<ErrorEventArgs> Error
		{
			[Token(Token = "0x6000134")]
			[Address(RVA = "0xD51EF4", Offset = "0xD51EF4", VA = "0xD51EF4", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8100A8", Offset = "0x8100A8")]
			add
			{
			}
			[Token(Token = "0x6000135")]
			[Address(RVA = "0xD51FE0", Offset = "0xD51FE0", VA = "0xD51FE0", Slot = "5")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8100B8", Offset = "0x8100B8")]
			remove
			{
			}
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0xD4D370", Offset = "0xD4D370", VA = "0xD4D370")]
		internal bool IsCheckAdditionalContentSet()
		{
			return default(bool);
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0xD52B5C", Offset = "0xD52B5C", VA = "0xD52B5C")]
		public JsonSerializer()
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0xD52C60", Offset = "0xD52C60", VA = "0xD52C60")]
		public static JsonSerializer Create()
		{
			return null;
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0xD52CB8", Offset = "0xD52CB8", VA = "0xD52CB8")]
		public static JsonSerializer Create(JsonSerializerSettings settings)
		{
			return null;
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0xD53808", Offset = "0xD53808", VA = "0xD53808")]
		public static JsonSerializer CreateDefault()
		{
			return null;
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0xD4CD50", Offset = "0xD4CD50", VA = "0xD4CD50")]
		public static JsonSerializer CreateDefault(JsonSerializerSettings settings)
		{
			return null;
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0xD52CF0", Offset = "0xD52CF0", VA = "0xD52CF0")]
		private static void ApplySerializerSettings(JsonSerializer serializer, JsonSerializerSettings settings)
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0xD5387C", Offset = "0xD5387C", VA = "0xD5387C")]
		public void Populate(JsonReader reader, object target)
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0xD5388C", Offset = "0xD5388C", VA = "0xD5388C", Slot = "32")]
		internal virtual void PopulateInternal(JsonReader reader, object target)
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0xD54190", Offset = "0xD54190", VA = "0xD54190")]
		public object Deserialize(JsonReader reader)
		{
			return null;
		}

		[Token(Token = "0x600015A")]
		public T Deserialize<T>(JsonReader reader)
		{
			return (T)null;
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0xD3BED8", Offset = "0xD3BED8", VA = "0xD3BED8")]
		public object Deserialize(JsonReader reader, Type objectType)
		{
			return null;
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0xD541A4", Offset = "0xD541A4", VA = "0xD541A4", Slot = "33")]
		internal virtual object DeserializeInternal(JsonReader reader, Type objectType)
		{
			return null;
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0xD53B24", Offset = "0xD53B24", VA = "0xD53B24")]
		private void SetupReader(JsonReader reader, out CultureInfo previousCulture, out DateTimeZoneHandling? previousDateTimeZoneHandling, out DateParseHandling? previousDateParseHandling, out FloatParseHandling? previousFloatParseHandling, out int? previousMaxDepth, out string previousDateFormatString)
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0xD53FAC", Offset = "0xD53FAC", VA = "0xD53FAC")]
		private void ResetReader(JsonReader reader, CultureInfo previousCulture, DateTimeZoneHandling? previousDateTimeZoneHandling, DateParseHandling? previousDateParseHandling, FloatParseHandling? previousFloatParseHandling, int? previousMaxDepth, string previousDateFormatString)
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0xD3D3B4", Offset = "0xD3D3B4", VA = "0xD3D3B4")]
		public void Serialize(JsonWriter jsonWriter, object value, Type objectType)
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0xD3DF10", Offset = "0xD3DF10", VA = "0xD3DF10")]
		public void Serialize(JsonWriter jsonWriter, object value)
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0xD54444", Offset = "0xD54444", VA = "0xD54444", Slot = "34")]
		internal virtual void SerializeInternal(JsonWriter jsonWriter, object value, Type objectType)
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0xD54DC0", Offset = "0xD54DC0", VA = "0xD54DC0")]
		internal IReferenceResolver GetReferenceResolver()
		{
			return null;
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0xD54E2C", Offset = "0xD54E2C", VA = "0xD54E2C")]
		internal JsonConverter GetMatchingConverter(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0xD54E34", Offset = "0xD54E34", VA = "0xD54E34")]
		internal static JsonConverter GetMatchingConverter(IList<JsonConverter> converters, Type objectType)
		{
			return null;
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0xD54FA0", Offset = "0xD54FA0", VA = "0xD54FA0")]
		internal void OnError(ErrorEventArgs e)
		{
		}
	}
}
