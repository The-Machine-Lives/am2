using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Serialization;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x200009E")]
	[Preserve]
	public abstract class JsonContract
	{
		[Token(Token = "0x200009F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80EC4C", Offset = "0x80EC4C")]
		private sealed class _003C_003Ec__DisplayClass73_0
		{
			[Token(Token = "0x400025A")]
			[FieldOffset(Offset = "0x10")]
			public MethodInfo callbackMethodInfo;

			[Token(Token = "0x600045E")]
			[Address(RVA = "0xD13E98", Offset = "0xD13E98", VA = "0xD13E98")]
			public _003C_003Ec__DisplayClass73_0()
			{
			}

			[Token(Token = "0x600045F")]
			[Address(RVA = "0xD13EA8", Offset = "0xD13EA8", VA = "0xD13EA8")]
			internal void _003CCreateSerializationCallback_003Eb__0(object o, StreamingContext context)
			{
			}
		}

		[Token(Token = "0x20000A0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80EC5C", Offset = "0x80EC5C")]
		private sealed class _003C_003Ec__DisplayClass74_0
		{
			[Token(Token = "0x400025B")]
			[FieldOffset(Offset = "0x10")]
			public MethodInfo callbackMethodInfo;

			[Token(Token = "0x6000460")]
			[Address(RVA = "0xD13EA0", Offset = "0xD13EA0", VA = "0xD13EA0")]
			public _003C_003Ec__DisplayClass74_0()
			{
			}

			[Token(Token = "0x6000461")]
			[Address(RVA = "0xD13FBC", Offset = "0xD13FBC", VA = "0xD13FBC")]
			internal void _003CCreateSerializationErrorCallback_003Eb__0(object o, StreamingContext context, ErrorContext econtext)
			{
			}
		}

		[Token(Token = "0x4000245")]
		[FieldOffset(Offset = "0x10")]
		internal bool IsNullable;

		[Token(Token = "0x4000246")]
		[FieldOffset(Offset = "0x11")]
		internal bool IsConvertable;

		[Token(Token = "0x4000247")]
		[FieldOffset(Offset = "0x12")]
		internal bool IsEnum;

		[Token(Token = "0x4000248")]
		[FieldOffset(Offset = "0x18")]
		internal Type NonNullableUnderlyingType;

		[Token(Token = "0x4000249")]
		[FieldOffset(Offset = "0x20")]
		internal ReadType InternalReadType;

		[Token(Token = "0x400024A")]
		[FieldOffset(Offset = "0x24")]
		internal JsonContractType ContractType;

		[Token(Token = "0x400024B")]
		[FieldOffset(Offset = "0x28")]
		internal bool IsReadOnlyOrFixedSize;

		[Token(Token = "0x400024C")]
		[FieldOffset(Offset = "0x29")]
		internal bool IsSealed;

		[Token(Token = "0x400024D")]
		[FieldOffset(Offset = "0x2A")]
		internal bool IsInstantiable;

		[Token(Token = "0x400024E")]
		[FieldOffset(Offset = "0x30")]
		private List<SerializationCallback> _onDeserializedCallbacks;

		[Token(Token = "0x400024F")]
		[FieldOffset(Offset = "0x38")]
		private IList<SerializationCallback> _onDeserializingCallbacks;

		[Token(Token = "0x4000250")]
		[FieldOffset(Offset = "0x40")]
		private IList<SerializationCallback> _onSerializedCallbacks;

		[Token(Token = "0x4000251")]
		[FieldOffset(Offset = "0x48")]
		private IList<SerializationCallback> _onSerializingCallbacks;

		[Token(Token = "0x4000252")]
		[FieldOffset(Offset = "0x50")]
		private IList<SerializationErrorCallback> _onErrorCallbacks;

		[Token(Token = "0x4000253")]
		[FieldOffset(Offset = "0x58")]
		private Type _createdType;

		[Token(Token = "0x4000254")]
		[FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F928", Offset = "0x80F928")]
		private Type _003CUnderlyingType_003Ek__BackingField;

		[Token(Token = "0x4000255")]
		[FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F938", Offset = "0x80F938")]
		private bool? _003CIsReference_003Ek__BackingField;

		[Token(Token = "0x4000256")]
		[FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F948", Offset = "0x80F948")]
		private JsonConverter _003CConverter_003Ek__BackingField;

		[Token(Token = "0x4000257")]
		[FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F958", Offset = "0x80F958")]
		private JsonConverter _003CInternalConverter_003Ek__BackingField;

		[Token(Token = "0x4000258")]
		[FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F968", Offset = "0x80F968")]
		private Func<object> _003CDefaultCreator_003Ek__BackingField;

		[Token(Token = "0x4000259")]
		[FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F978", Offset = "0x80F978")]
		private bool _003CDefaultCreatorNonPublic_003Ek__BackingField;

		[Token(Token = "0x170000AB")]
		public Type UnderlyingType
		{
			[Token(Token = "0x6000443")]
			[Address(RVA = "0xD0CEB8", Offset = "0xD0CEB8", VA = "0xD0CEB8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8107E0", Offset = "0x8107E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000444")]
			[Address(RVA = "0xD13234", Offset = "0xD13234", VA = "0xD13234")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8107F0", Offset = "0x8107F0")]
			private set
			{
			}
		}

		[Token(Token = "0x170000AC")]
		public Type CreatedType
		{
			[Token(Token = "0x6000445")]
			[Address(RVA = "0xD0AFBC", Offset = "0xD0AFBC", VA = "0xD0AFBC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000446")]
			[Address(RVA = "0xD128F0", Offset = "0xD128F0", VA = "0xD128F0")]
			set
			{
			}
		}

		[Token(Token = "0x170000AD")]
		public bool? IsReference
		{
			[Token(Token = "0x6000447")]
			[Address(RVA = "0xD1323C", Offset = "0xD1323C", VA = "0xD1323C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810800", Offset = "0x810800")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000448")]
			[Address(RVA = "0xD0AFA4", Offset = "0xD0AFA4", VA = "0xD0AFA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810810", Offset = "0x810810")]
			set
			{
			}
		}

		[Token(Token = "0x170000AE")]
		public JsonConverter Converter
		{
			[Token(Token = "0x6000449")]
			[Address(RVA = "0xD13244", Offset = "0xD13244", VA = "0xD13244")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810820", Offset = "0x810820")]
			get
			{
				return null;
			}
			[Token(Token = "0x600044A")]
			[Address(RVA = "0xD0AFAC", Offset = "0xD0AFAC", VA = "0xD0AFAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810830", Offset = "0x810830")]
			set
			{
			}
		}

		[Token(Token = "0x170000AF")]
		internal JsonConverter InternalConverter
		{
			[Token(Token = "0x600044B")]
			[Address(RVA = "0xD1324C", Offset = "0xD1324C", VA = "0xD1324C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810840", Offset = "0x810840")]
			get
			{
				return null;
			}
			[Token(Token = "0x600044C")]
			[Address(RVA = "0xD0AFB4", Offset = "0xD0AFB4", VA = "0xD0AFB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810850", Offset = "0x810850")]
			set
			{
			}
		}

		[Token(Token = "0x170000B0")]
		public IList<SerializationCallback> OnDeserializedCallbacks
		{
			[Token(Token = "0x600044D")]
			[Address(RVA = "0xD0BA04", Offset = "0xD0BA04", VA = "0xD0BA04")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B1")]
		public IList<SerializationCallback> OnDeserializingCallbacks
		{
			[Token(Token = "0x600044E")]
			[Address(RVA = "0xD0B990", Offset = "0xD0B990", VA = "0xD0B990")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B2")]
		public IList<SerializationCallback> OnSerializedCallbacks
		{
			[Token(Token = "0x600044F")]
			[Address(RVA = "0xD0B91C", Offset = "0xD0B91C", VA = "0xD0B91C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B3")]
		public IList<SerializationCallback> OnSerializingCallbacks
		{
			[Token(Token = "0x6000450")]
			[Address(RVA = "0xD0B8A8", Offset = "0xD0B8A8", VA = "0xD0B8A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B4")]
		public IList<SerializationErrorCallback> OnErrorCallbacks
		{
			[Token(Token = "0x6000451")]
			[Address(RVA = "0xD0BA78", Offset = "0xD0BA78", VA = "0xD0BA78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B5")]
		public Func<object> DefaultCreator
		{
			[Token(Token = "0x6000452")]
			[Address(RVA = "0xD09024", Offset = "0xD09024", VA = "0xD09024")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810860", Offset = "0x810860")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000453")]
			[Address(RVA = "0xD0901C", Offset = "0xD0901C", VA = "0xD0901C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810870", Offset = "0x810870")]
			set
			{
			}
		}

		[Token(Token = "0x170000B6")]
		public bool DefaultCreatorNonPublic
		{
			[Token(Token = "0x6000454")]
			[Address(RVA = "0xD0902C", Offset = "0xD0902C", VA = "0xD0902C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810880", Offset = "0x810880")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000455")]
			[Address(RVA = "0xD0AFC4", Offset = "0xD0AFC4", VA = "0xD0AFC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810890", Offset = "0x810890")]
			set
			{
			}
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0xD130EC", Offset = "0xD130EC", VA = "0xD130EC")]
		internal JsonContract(Type underlyingType)
		{
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0xD13254", Offset = "0xD13254", VA = "0xD13254")]
		internal void InvokeOnSerializing(object o, StreamingContext context)
		{
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0xD13514", Offset = "0xD13514", VA = "0xD13514")]
		internal void InvokeOnSerialized(object o, StreamingContext context)
		{
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0xD137D4", Offset = "0xD137D4", VA = "0xD137D4")]
		internal void InvokeOnDeserializing(object o, StreamingContext context)
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0xD13A94", Offset = "0xD13A94", VA = "0xD13A94")]
		internal void InvokeOnDeserialized(object o, StreamingContext context)
		{
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0xD13BD0", Offset = "0xD13BD0", VA = "0xD13BD0")]
		internal void InvokeOnError(object o, StreamingContext context, ErrorContext errorContext)
		{
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0xD0C1EC", Offset = "0xD0C1EC", VA = "0xD0C1EC")]
		internal static SerializationCallback CreateSerializationCallback(MethodInfo callbackMethodInfo)
		{
			return null;
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0xD0C288", Offset = "0xD0C288", VA = "0xD0C288")]
		internal static SerializationErrorCallback CreateSerializationErrorCallback(MethodInfo callbackMethodInfo)
		{
			return null;
		}
	}
}
