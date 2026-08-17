using System;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.Serialization;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x20000B0")]
	[Preserve]
	internal static class JsonTypeReflector
	{
		[Token(Token = "0x20000B1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80ED3C", Offset = "0x80ED3C")]
		private sealed class _003C_003Ec__DisplayClass18_0
		{
			[Token(Token = "0x40002B8")]
			[FieldOffset(Offset = "0x10")]
			public Type converterType;

			[Token(Token = "0x40002B9")]
			[FieldOffset(Offset = "0x18")]
			public Func<object> defaultConstructor;

			[Token(Token = "0x6000566")]
			[Address(RVA = "0xF04D54", Offset = "0xF04D54", VA = "0xF04D54")]
			public _003C_003Ec__DisplayClass18_0()
			{
			}

			[Token(Token = "0x6000567")]
			[Address(RVA = "0xF05334", Offset = "0xF05334", VA = "0xF05334")]
			internal JsonConverter _003CGetJsonConverterCreator_003Eb__0(object[] parameters)
			{
				return null;
			}
		}

		[Serializable]
		[Token(Token = "0x20000B2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80ED4C", Offset = "0x80ED4C")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x40002BA")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x40002BB")]
			[FieldOffset(Offset = "0x8")]
			public static Func<object, Type> _003C_003E9__18_1;

			[Token(Token = "0x6000569")]
			[Address(RVA = "0xF052FC", Offset = "0xF052FC", VA = "0xF052FC")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x600056A")]
			[Address(RVA = "0xF05304", Offset = "0xF05304", VA = "0xF05304")]
			internal Type _003CGetJsonConverterCreator_003Eb__18_1(object param)
			{
				return null;
			}
		}

		[Token(Token = "0x40002B4")]
		[FieldOffset(Offset = "0x0")]
		private static bool? _fullyTrusted;

		[Token(Token = "0x40002B5")]
		[FieldOffset(Offset = "0x8")]
		private static readonly ThreadSafeStore<Type, Func<object[], JsonConverter>> JsonConverterCreatorCache;

		[Token(Token = "0x40002B6")]
		[FieldOffset(Offset = "0x10")]
		private static readonly ThreadSafeStore<Type, Type> AssociatedMetadataTypesCache;

		[Token(Token = "0x40002B7")]
		[FieldOffset(Offset = "0x18")]
		private static ReflectionObject _metadataTypeAttributeReflectionObject;

		[Token(Token = "0x170000FE")]
		public static bool FullyTrusted
		{
			[Token(Token = "0x6000563")]
			[Address(RVA = "0xEF9584", Offset = "0xEF9584", VA = "0xEF9584")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000FF")]
		public static ReflectionDelegateFactory ReflectionDelegateFactory
		{
			[Token(Token = "0x6000564")]
			[Address(RVA = "0xF04D5C", Offset = "0xF04D5C", VA = "0xF04D5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000556")]
		public static T GetCachedAttribute<T>(object attributeProvider) where T : Attribute
		{
			return null;
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0xF04578", Offset = "0xF04578", VA = "0xF04578")]
		public static DataContractAttribute GetDataContractAttribute(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0xF04618", Offset = "0xF04618", VA = "0xF04618")]
		public static DataMemberAttribute GetDataMemberAttribute(MemberInfo memberInfo)
		{
			return null;
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0xF048FC", Offset = "0xF048FC", VA = "0xF048FC")]
		public static MemberSerialization GetObjectMemberSerialization(Type objectType, bool ignoreSerializableAttribute)
		{
			return default(MemberSerialization);
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0xF04A00", Offset = "0xF04A00", VA = "0xF04A00")]
		public static JsonConverter GetJsonConverter(object attributeProvider)
		{
			return null;
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0xF04B08", Offset = "0xF04B08", VA = "0xF04B08")]
		public static JsonConverter CreateJsonConverterInstance(Type converterType, object[] converterArgs)
		{
			return null;
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0xF04BC4", Offset = "0xF04BC4", VA = "0xF04BC4")]
		private static Func<object[], JsonConverter> GetJsonConverterCreator(Type converterType)
		{
			return null;
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0xF04DBC", Offset = "0xF04DBC", VA = "0xF04DBC")]
		public static TypeConverter GetTypeConverter(Type type)
		{
			return null;
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0xF04E24", Offset = "0xF04E24", VA = "0xF04E24")]
		private static Type GetAssociatedMetadataType(Type type)
		{
			return null;
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0xF04EB0", Offset = "0xF04EB0", VA = "0xF04EB0")]
		private static Type GetAssociateMetadataTypeFromAttribute(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000560")]
		private static T GetAttribute<T>(Type type) where T : Attribute
		{
			return null;
		}

		[Token(Token = "0x6000561")]
		private static T GetAttribute<T>(MemberInfo memberInfo) where T : Attribute
		{
			return null;
		}

		[Token(Token = "0x6000562")]
		public static T GetAttribute<T>(object provider) where T : Attribute
		{
			return null;
		}
	}
}
