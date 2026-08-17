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
	[Token(Token = "0x2000024")]
	[Preserve]
	public class JsonSerializerSettings
	{
		[Token(Token = "0x2000025")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80E31C", Offset = "0x80E31C")]
		private sealed class _003C_003Ec__DisplayClass90_0
		{
			[Token(Token = "0x6000049")]
			[Address(RVA = "0xFDCA30", Offset = "0xFDCA30", VA = "0xFDCA30")]
			public _003C_003Ec__DisplayClass90_0()
			{
			}
		}

		[Token(Token = "0x400004E")]
		internal const ReferenceLoopHandling DefaultReferenceLoopHandling = ReferenceLoopHandling.Error;

		[Token(Token = "0x400004F")]
		internal const MissingMemberHandling DefaultMissingMemberHandling = MissingMemberHandling.Ignore;

		[Token(Token = "0x4000050")]
		internal const NullValueHandling DefaultNullValueHandling = NullValueHandling.Include;

		[Token(Token = "0x4000051")]
		internal const DefaultValueHandling DefaultDefaultValueHandling = DefaultValueHandling.Include;

		[Token(Token = "0x4000052")]
		internal const ObjectCreationHandling DefaultObjectCreationHandling = ObjectCreationHandling.Auto;

		[Token(Token = "0x4000053")]
		internal const PreserveReferencesHandling DefaultPreserveReferencesHandling = PreserveReferencesHandling.None;

		[Token(Token = "0x4000054")]
		internal const ConstructorHandling DefaultConstructorHandling = ConstructorHandling.Default;

		[Token(Token = "0x4000055")]
		internal const TypeNameHandling DefaultTypeNameHandling = TypeNameHandling.None;

		[Token(Token = "0x4000056")]
		internal const MetadataPropertyHandling DefaultMetadataPropertyHandling = MetadataPropertyHandling.Default;

		[Token(Token = "0x4000057")]
		internal const FormatterAssemblyStyle DefaultTypeNameAssemblyFormat = FormatterAssemblyStyle.Simple;

		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly StreamingContext DefaultContext;

		[Token(Token = "0x4000059")]
		internal const Formatting DefaultFormatting = Formatting.None;

		[Token(Token = "0x400005A")]
		internal const DateFormatHandling DefaultDateFormatHandling = DateFormatHandling.IsoDateFormat;

		[Token(Token = "0x400005B")]
		internal const DateTimeZoneHandling DefaultDateTimeZoneHandling = DateTimeZoneHandling.RoundtripKind;

		[Token(Token = "0x400005C")]
		internal const DateParseHandling DefaultDateParseHandling = DateParseHandling.DateTime;

		[Token(Token = "0x400005D")]
		internal const FloatParseHandling DefaultFloatParseHandling = FloatParseHandling.Double;

		[Token(Token = "0x400005E")]
		internal const FloatFormatHandling DefaultFloatFormatHandling = FloatFormatHandling.String;

		[Token(Token = "0x400005F")]
		internal const StringEscapeHandling DefaultStringEscapeHandling = StringEscapeHandling.Default;

		[Token(Token = "0x4000060")]
		internal const FormatterAssemblyStyle DefaultFormatterAssemblyStyle = FormatterAssemblyStyle.Simple;

		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0x10")]
		internal static readonly CultureInfo DefaultCulture;

		[Token(Token = "0x4000062")]
		internal const bool DefaultCheckAdditionalContent = false;

		[Token(Token = "0x4000063")]
		internal const string DefaultDateFormatString = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK";

		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x10")]
		internal Formatting? _formatting;

		[Token(Token = "0x4000065")]
		[FieldOffset(Offset = "0x18")]
		internal DateFormatHandling? _dateFormatHandling;

		[Token(Token = "0x4000066")]
		[FieldOffset(Offset = "0x20")]
		internal DateTimeZoneHandling? _dateTimeZoneHandling;

		[Token(Token = "0x4000067")]
		[FieldOffset(Offset = "0x28")]
		internal DateParseHandling? _dateParseHandling;

		[Token(Token = "0x4000068")]
		[FieldOffset(Offset = "0x30")]
		internal FloatFormatHandling? _floatFormatHandling;

		[Token(Token = "0x4000069")]
		[FieldOffset(Offset = "0x38")]
		internal FloatParseHandling? _floatParseHandling;

		[Token(Token = "0x400006A")]
		[FieldOffset(Offset = "0x40")]
		internal StringEscapeHandling? _stringEscapeHandling;

		[Token(Token = "0x400006B")]
		[FieldOffset(Offset = "0x48")]
		internal CultureInfo _culture;

		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0x50")]
		internal bool? _checkAdditionalContent;

		[Token(Token = "0x400006D")]
		[FieldOffset(Offset = "0x54")]
		internal int? _maxDepth;

		[Token(Token = "0x400006E")]
		[FieldOffset(Offset = "0x5C")]
		internal bool _maxDepthSet;

		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0x60")]
		internal string _dateFormatString;

		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x68")]
		internal bool _dateFormatStringSet;

		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x6C")]
		internal FormatterAssemblyStyle? _typeNameAssemblyFormat;

		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x74")]
		internal DefaultValueHandling? _defaultValueHandling;

		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x7C")]
		internal PreserveReferencesHandling? _preserveReferencesHandling;

		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x84")]
		internal NullValueHandling? _nullValueHandling;

		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x8C")]
		internal ObjectCreationHandling? _objectCreationHandling;

		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x94")]
		internal MissingMemberHandling? _missingMemberHandling;

		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x9C")]
		internal ReferenceLoopHandling? _referenceLoopHandling;

		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0xA8")]
		internal StreamingContext? _context;

		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0xC0")]
		internal ConstructorHandling? _constructorHandling;

		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0xC8")]
		internal TypeNameHandling? _typeNameHandling;

		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0xD0")]
		internal MetadataPropertyHandling? _metadataPropertyHandling;

		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F5E8", Offset = "0x80F5E8")]
		private IList<JsonConverter> _003CConverters_003Ek__BackingField;

		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F5F8", Offset = "0x80F5F8")]
		private IContractResolver _003CContractResolver_003Ek__BackingField;

		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F608", Offset = "0x80F608")]
		private IEqualityComparer _003CEqualityComparer_003Ek__BackingField;

		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F618", Offset = "0x80F618")]
		private Func<IReferenceResolver> _003CReferenceResolverProvider_003Ek__BackingField;

		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F628", Offset = "0x80F628")]
		private ITraceWriter _003CTraceWriter_003Ek__BackingField;

		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F638", Offset = "0x80F638")]
		private SerializationBinder _003CBinder_003Ek__BackingField;

		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0x108")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F648", Offset = "0x80F648")]
		private EventHandler<ErrorEventArgs> _003CError_003Ek__BackingField;

		[Token(Token = "0x1700000B")]
		public ReferenceLoopHandling ReferenceLoopHandling
		{
			[Token(Token = "0x6000031")]
			[Address(RVA = "0xFDC0F0", Offset = "0xFDC0F0", VA = "0xFDC0F0")]
			get
			{
				return default(ReferenceLoopHandling);
			}
			[Token(Token = "0x6000032")]
			[Address(RVA = "0xFDC174", Offset = "0xFDC174", VA = "0xFDC174")]
			set
			{
			}
		}

		[Token(Token = "0x1700000C")]
		public MissingMemberHandling MissingMemberHandling
		{
			[Token(Token = "0x6000033")]
			[Address(RVA = "0xFDC1E4", Offset = "0xFDC1E4", VA = "0xFDC1E4")]
			get
			{
				return default(MissingMemberHandling);
			}
		}

		[Token(Token = "0x1700000D")]
		public ObjectCreationHandling ObjectCreationHandling
		{
			[Token(Token = "0x6000034")]
			[Address(RVA = "0xFDC268", Offset = "0xFDC268", VA = "0xFDC268")]
			get
			{
				return default(ObjectCreationHandling);
			}
		}

		[Token(Token = "0x1700000E")]
		public NullValueHandling NullValueHandling
		{
			[Token(Token = "0x6000035")]
			[Address(RVA = "0xFDC2EC", Offset = "0xFDC2EC", VA = "0xFDC2EC")]
			get
			{
				return default(NullValueHandling);
			}
			[Token(Token = "0x6000036")]
			[Address(RVA = "0xFDC370", Offset = "0xFDC370", VA = "0xFDC370")]
			set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		public DefaultValueHandling DefaultValueHandling
		{
			[Token(Token = "0x6000037")]
			[Address(RVA = "0xFDC3E0", Offset = "0xFDC3E0", VA = "0xFDC3E0")]
			get
			{
				return default(DefaultValueHandling);
			}
		}

		[Token(Token = "0x17000010")]
		public IList<JsonConverter> Converters
		{
			[Token(Token = "0x6000038")]
			[Address(RVA = "0xFDC464", Offset = "0xFDC464", VA = "0xFDC464")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FEF8", Offset = "0x80FEF8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000039")]
			[Address(RVA = "0xFDC46C", Offset = "0xFDC46C", VA = "0xFDC46C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FF08", Offset = "0x80FF08")]
			set
			{
			}
		}

		[Token(Token = "0x17000011")]
		public PreserveReferencesHandling PreserveReferencesHandling
		{
			[Token(Token = "0x600003A")]
			[Address(RVA = "0xFDC474", Offset = "0xFDC474", VA = "0xFDC474")]
			get
			{
				return default(PreserveReferencesHandling);
			}
		}

		[Token(Token = "0x17000012")]
		public TypeNameHandling TypeNameHandling
		{
			[Token(Token = "0x600003B")]
			[Address(RVA = "0xFDC4F8", Offset = "0xFDC4F8", VA = "0xFDC4F8")]
			get
			{
				return default(TypeNameHandling);
			}
		}

		[Token(Token = "0x17000013")]
		public MetadataPropertyHandling MetadataPropertyHandling
		{
			[Token(Token = "0x600003C")]
			[Address(RVA = "0xFDC57C", Offset = "0xFDC57C", VA = "0xFDC57C")]
			get
			{
				return default(MetadataPropertyHandling);
			}
		}

		[Token(Token = "0x17000014")]
		public FormatterAssemblyStyle TypeNameAssemblyFormat
		{
			[Token(Token = "0x600003D")]
			[Address(RVA = "0xFDC600", Offset = "0xFDC600", VA = "0xFDC600")]
			get
			{
				return default(FormatterAssemblyStyle);
			}
		}

		[Token(Token = "0x17000015")]
		public ConstructorHandling ConstructorHandling
		{
			[Token(Token = "0x600003E")]
			[Address(RVA = "0xFDC684", Offset = "0xFDC684", VA = "0xFDC684")]
			get
			{
				return default(ConstructorHandling);
			}
		}

		[Token(Token = "0x17000016")]
		public IContractResolver ContractResolver
		{
			[Token(Token = "0x600003F")]
			[Address(RVA = "0xFDC708", Offset = "0xFDC708", VA = "0xFDC708")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FF18", Offset = "0x80FF18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000017")]
		public IEqualityComparer EqualityComparer
		{
			[Token(Token = "0x6000040")]
			[Address(RVA = "0xFDC710", Offset = "0xFDC710", VA = "0xFDC710")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FF28", Offset = "0x80FF28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000018")]
		public Func<IReferenceResolver> ReferenceResolverProvider
		{
			[Token(Token = "0x6000041")]
			[Address(RVA = "0xFDC718", Offset = "0xFDC718", VA = "0xFDC718")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FF38", Offset = "0x80FF38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000019")]
		public ITraceWriter TraceWriter
		{
			[Token(Token = "0x6000042")]
			[Address(RVA = "0xFDC720", Offset = "0xFDC720", VA = "0xFDC720")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FF48", Offset = "0x80FF48")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001A")]
		public SerializationBinder Binder
		{
			[Token(Token = "0x6000043")]
			[Address(RVA = "0xFDC728", Offset = "0xFDC728", VA = "0xFDC728")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FF58", Offset = "0x80FF58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001B")]
		public EventHandler<ErrorEventArgs> Error
		{
			[Token(Token = "0x6000044")]
			[Address(RVA = "0xFDC730", Offset = "0xFDC730", VA = "0xFDC730")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FF68", Offset = "0x80FF68")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001C")]
		public StreamingContext Context
		{
			[Token(Token = "0x6000045")]
			[Address(RVA = "0xFDC738", Offset = "0xFDC738", VA = "0xFDC738")]
			get
			{
				return default(StreamingContext);
			}
		}

		[Token(Token = "0x1700001D")]
		public StringEscapeHandling StringEscapeHandling
		{
			[Token(Token = "0x6000046")]
			[Address(RVA = "0xFDC7EC", Offset = "0xFDC7EC", VA = "0xFDC7EC")]
			set
			{
			}
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0xFDC85C", Offset = "0xFDC85C", VA = "0xFDC85C")]
		static JsonSerializerSettings()
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0xFDC8E0", Offset = "0xFDC8E0", VA = "0xFDC8E0")]
		public JsonSerializerSettings()
		{
		}
	}
}
