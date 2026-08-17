using System;
using System.Collections;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x20000AE")]
	[Preserve]
	internal class JsonSerializerProxy : JsonSerializer
	{
		[Token(Token = "0x40002B1")]
		[FieldOffset(Offset = "0xE0")]
		private readonly JsonSerializerInternalReader _serializerReader;

		[Token(Token = "0x40002B2")]
		[FieldOffset(Offset = "0xE8")]
		private readonly JsonSerializerInternalWriter _serializerWriter;

		[Token(Token = "0x40002B3")]
		[FieldOffset(Offset = "0xF0")]
		private readonly JsonSerializer _serializer;

		[Token(Token = "0x170000EB")]
		public override IReferenceResolver ReferenceResolver
		{
			[Token(Token = "0x6000535")]
			[Address(RVA = "0xF03D64", Offset = "0xF03D64", VA = "0xF03D64", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x170000EC")]
		public override ITraceWriter TraceWriter
		{
			[Token(Token = "0x6000536")]
			[Address(RVA = "0xF03DA0", Offset = "0xF03DA0", VA = "0xF03DA0", Slot = "8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000537")]
			[Address(RVA = "0xF03DD4", Offset = "0xF03DD4", VA = "0xF03DD4", Slot = "9")]
			set
			{
			}
		}

		[Token(Token = "0x170000ED")]
		public override IEqualityComparer EqualityComparer
		{
			[Token(Token = "0x6000538")]
			[Address(RVA = "0xF03E10", Offset = "0xF03E10", VA = "0xF03E10", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x170000EE")]
		public override JsonConverterCollection Converters
		{
			[Token(Token = "0x6000539")]
			[Address(RVA = "0xF03E4C", Offset = "0xF03E4C", VA = "0xF03E4C", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000EF")]
		public override DefaultValueHandling DefaultValueHandling
		{
			[Token(Token = "0x600053A")]
			[Address(RVA = "0xF03E84", Offset = "0xF03E84", VA = "0xF03E84", Slot = "17")]
			set
			{
			}
		}

		[Token(Token = "0x170000F0")]
		public override IContractResolver ContractResolver
		{
			[Token(Token = "0x600053B")]
			[Address(RVA = "0xF03EC4", Offset = "0xF03EC4", VA = "0xF03EC4", Slot = "24")]
			get
			{
				return null;
			}
			[Token(Token = "0x600053C")]
			[Address(RVA = "0xF03EFC", Offset = "0xF03EFC", VA = "0xF03EFC", Slot = "25")]
			set
			{
			}
		}

		[Token(Token = "0x170000F1")]
		public override MissingMemberHandling MissingMemberHandling
		{
			[Token(Token = "0x600053D")]
			[Address(RVA = "0xF03F3C", Offset = "0xF03F3C", VA = "0xF03F3C", Slot = "15")]
			set
			{
			}
		}

		[Token(Token = "0x170000F2")]
		public override NullValueHandling NullValueHandling
		{
			[Token(Token = "0x600053E")]
			[Address(RVA = "0xF03F7C", Offset = "0xF03F7C", VA = "0xF03F7C", Slot = "16")]
			set
			{
			}
		}

		[Token(Token = "0x170000F3")]
		public override ObjectCreationHandling ObjectCreationHandling
		{
			[Token(Token = "0x600053F")]
			[Address(RVA = "0xF03FBC", Offset = "0xF03FBC", VA = "0xF03FBC", Slot = "18")]
			get
			{
				return default(ObjectCreationHandling);
			}
			[Token(Token = "0x6000540")]
			[Address(RVA = "0xF03FF4", Offset = "0xF03FF4", VA = "0xF03FF4", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x170000F4")]
		public override ReferenceLoopHandling ReferenceLoopHandling
		{
			[Token(Token = "0x6000541")]
			[Address(RVA = "0xF04034", Offset = "0xF04034", VA = "0xF04034", Slot = "14")]
			set
			{
			}
		}

		[Token(Token = "0x170000F5")]
		public override PreserveReferencesHandling PreserveReferencesHandling
		{
			[Token(Token = "0x6000542")]
			[Address(RVA = "0xF04074", Offset = "0xF04074", VA = "0xF04074", Slot = "13")]
			set
			{
			}
		}

		[Token(Token = "0x170000F6")]
		public override TypeNameHandling TypeNameHandling
		{
			[Token(Token = "0x6000543")]
			[Address(RVA = "0xF040B0", Offset = "0xF040B0", VA = "0xF040B0", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x170000F7")]
		public override MetadataPropertyHandling MetadataPropertyHandling
		{
			[Token(Token = "0x6000544")]
			[Address(RVA = "0xF040EC", Offset = "0xF040EC", VA = "0xF040EC", Slot = "21")]
			get
			{
				return default(MetadataPropertyHandling);
			}
			[Token(Token = "0x6000545")]
			[Address(RVA = "0xF04124", Offset = "0xF04124", VA = "0xF04124", Slot = "22")]
			set
			{
			}
		}

		[Token(Token = "0x170000F8")]
		public override FormatterAssemblyStyle TypeNameAssemblyFormat
		{
			[Token(Token = "0x6000546")]
			[Address(RVA = "0xF04164", Offset = "0xF04164", VA = "0xF04164", Slot = "12")]
			set
			{
			}
		}

		[Token(Token = "0x170000F9")]
		public override ConstructorHandling ConstructorHandling
		{
			[Token(Token = "0x6000547")]
			[Address(RVA = "0xF041A0", Offset = "0xF041A0", VA = "0xF041A0", Slot = "20")]
			set
			{
			}
		}

		[Token(Token = "0x170000FA")]
		public override SerializationBinder Binder
		{
			[Token(Token = "0x6000548")]
			[Address(RVA = "0xF041E0", Offset = "0xF041E0", VA = "0xF041E0", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x170000FB")]
		public override StreamingContext Context
		{
			[Token(Token = "0x6000549")]
			[Address(RVA = "0xF0421C", Offset = "0xF0421C", VA = "0xF0421C", Slot = "26")]
			get
			{
				return default(StreamingContext);
			}
			[Token(Token = "0x600054A")]
			[Address(RVA = "0xF04254", Offset = "0xF04254", VA = "0xF04254", Slot = "27")]
			set
			{
			}
		}

		[Token(Token = "0x170000FC")]
		public override Formatting Formatting
		{
			[Token(Token = "0x600054B")]
			[Address(RVA = "0xF042A4", Offset = "0xF042A4", VA = "0xF042A4", Slot = "28")]
			get
			{
				return default(Formatting);
			}
			[Token(Token = "0x600054C")]
			[Address(RVA = "0xF042DC", Offset = "0xF042DC", VA = "0xF042DC", Slot = "29")]
			set
			{
			}
		}

		[Token(Token = "0x170000FD")]
		public override bool CheckAdditionalContent
		{
			[Token(Token = "0x600054D")]
			[Address(RVA = "0xF0431C", Offset = "0xF0431C", VA = "0xF0431C", Slot = "30")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600054E")]
			[Address(RVA = "0xF04354", Offset = "0xF04354", VA = "0xF04354", Slot = "31")]
			set
			{
			}
		}

		[Token(Token = "0x14000002")]
		public override event EventHandler<ErrorEventArgs> Error
		{
			[Token(Token = "0x6000533")]
			[Address(RVA = "0xF03CEC", Offset = "0xF03CEC", VA = "0xF03CEC", Slot = "4")]
			add
			{
			}
			[Token(Token = "0x6000534")]
			[Address(RVA = "0xF03D28", Offset = "0xF03D28", VA = "0xF03D28", Slot = "5")]
			remove
			{
			}
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0xF04394", Offset = "0xF04394", VA = "0xF04394")]
		internal JsonSerializerInternalBase GetInternalSerializer()
		{
			return null;
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0xEF24A0", Offset = "0xEF24A0", VA = "0xEF24A0")]
		public JsonSerializerProxy(JsonSerializerInternalReader serializerReader)
		{
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0xEFE2BC", Offset = "0xEFE2BC", VA = "0xEFE2BC")]
		public JsonSerializerProxy(JsonSerializerInternalWriter serializerWriter)
		{
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0xF043AC", Offset = "0xF043AC", VA = "0xF043AC", Slot = "33")]
		internal override object DeserializeInternal(JsonReader reader, Type objectType)
		{
			return null;
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0xF0441C", Offset = "0xF0441C", VA = "0xF0441C", Slot = "32")]
		internal override void PopulateInternal(JsonReader reader, object target)
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0xF04488", Offset = "0xF04488", VA = "0xF04488", Slot = "34")]
		internal override void SerializeInternal(JsonWriter jsonWriter, object value, Type rootType)
		{
		}
	}
}
