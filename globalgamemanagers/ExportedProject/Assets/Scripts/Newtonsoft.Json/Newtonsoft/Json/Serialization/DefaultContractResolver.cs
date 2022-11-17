using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x200008A")]
	[Preserve]
	public class DefaultContractResolver : IContractResolver
	{
		[Token(Token = "0x200008B")]
		internal class EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue> : IEnumerable<KeyValuePair<object, object>>, IEnumerable
		{
			[Token(Token = "0x200008C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80EB2C", Offset = "0x80EB2C")]
			private sealed class _003CGetEnumerator_003Ed__2 : IEnumerator<KeyValuePair<object, object>>, IDisposable, IEnumerator
			{
				[Token(Token = "0x400020F")]
				[FieldOffset(Offset = "0x0")]
				private int _003C_003E1__state;

				[Token(Token = "0x4000210")]
				[FieldOffset(Offset = "0x0")]
				private KeyValuePair<object, object> _003C_003E2__current;

				[Token(Token = "0x4000211")]
				[FieldOffset(Offset = "0x0")]
				public EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue> _003C_003E4__this;

				[Token(Token = "0x4000212")]
				[FieldOffset(Offset = "0x0")]
				private IEnumerator<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> _003C_003E7__wrap1;

				[Token(Token = "0x1700009A")]
				private KeyValuePair<object, object> System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CSystem_002EObject_002CSystem_002EObject_003E_003E_002ECurrent
				{
					[Token(Token = "0x60003F8")]
					[DebuggerHidden]
					get
					{
						return default(KeyValuePair<object, object>);
					}
				}

				[Token(Token = "0x1700009B")]
				private object System_002ECollections_002EIEnumerator_002ECurrent
				{
					[Token(Token = "0x60003FA")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Token(Token = "0x60003F4")]
				[DebuggerHidden]
				public _003CGetEnumerator_003Ed__2(int _003C_003E1__state)
				{
				}

				[Token(Token = "0x60003F5")]
				[DebuggerHidden]
				private void System_002EIDisposable_002EDispose()
				{
				}

				[Token(Token = "0x60003F6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Token(Token = "0x60003F7")]
				private void _003C_003Em__Finally1()
				{
				}

				[Token(Token = "0x60003F9")]
				[DebuggerHidden]
				private void System_002ECollections_002EIEnumerator_002EReset()
				{
				}
			}

			[Token(Token = "0x400020E")]
			[FieldOffset(Offset = "0x0")]
			private readonly IEnumerable<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> _e;

			[Token(Token = "0x60003F2")]
			public IEnumerator<KeyValuePair<object, object>> GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x60003F3")]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		[Serializable]
		[Token(Token = "0x200008D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80EB3C", Offset = "0x80EB3C")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4000213")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4000214")]
			[FieldOffset(Offset = "0x8")]
			public static Func<MemberInfo, bool> _003C_003E9__30_0;

			[Token(Token = "0x4000215")]
			[FieldOffset(Offset = "0x10")]
			public static Func<MemberInfo, bool> _003C_003E9__30_1;

			[Token(Token = "0x4000216")]
			[FieldOffset(Offset = "0x18")]
			public static Func<Type, IEnumerable<MemberInfo>> _003C_003E9__33_0;

			[Token(Token = "0x4000217")]
			[FieldOffset(Offset = "0x20")]
			public static Func<MemberInfo, bool> _003C_003E9__33_1;

			[Token(Token = "0x4000218")]
			[FieldOffset(Offset = "0x28")]
			public static Func<ConstructorInfo, bool> _003C_003E9__36_0;

			[Token(Token = "0x4000219")]
			[FieldOffset(Offset = "0x30")]
			public static Func<JsonProperty, int> _003C_003E9__60_0;

			[Token(Token = "0x60003FC")]
			[Address(RVA = "0xD0FA5C", Offset = "0xD0FA5C", VA = "0xD0FA5C")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x60003FD")]
			[Address(RVA = "0xD0FA64", Offset = "0xD0FA64", VA = "0xD0FA64")]
			internal bool _003CGetSerializableMembers_003Eb__30_0(MemberInfo m)
			{
				return default(bool);
			}

			[Token(Token = "0x60003FE")]
			[Address(RVA = "0xD0FAD8", Offset = "0xD0FAD8", VA = "0xD0FAD8")]
			internal bool _003CGetSerializableMembers_003Eb__30_1(MemberInfo m)
			{
				return default(bool);
			}

			[Token(Token = "0x60003FF")]
			[Address(RVA = "0xD0FB4C", Offset = "0xD0FB4C", VA = "0xD0FB4C")]
			internal IEnumerable<MemberInfo> _003CGetExtensionDataMemberForType_003Eb__33_0(Type baseType)
			{
				return null;
			}

			[Token(Token = "0x6000400")]
			[Address(RVA = "0xD0FC2C", Offset = "0xD0FC2C", VA = "0xD0FC2C")]
			internal bool _003CGetExtensionDataMemberForType_003Eb__33_1(MemberInfo m)
			{
				return default(bool);
			}

			[Token(Token = "0x6000401")]
			[Address(RVA = "0xD1009C", Offset = "0xD1009C", VA = "0xD1009C")]
			internal bool _003CGetAttributeConstructor_003Eb__36_0(ConstructorInfo c)
			{
				return default(bool);
			}

			[Token(Token = "0x6000402")]
			[Address(RVA = "0xD10138", Offset = "0xD10138", VA = "0xD10138")]
			internal int _003CCreateProperties_003Eb__60_0(JsonProperty p)
			{
				return default(int);
			}
		}

		[Token(Token = "0x200008E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80EB4C", Offset = "0x80EB4C")]
		private sealed class _003C_003Ec__DisplayClass34_0
		{
			[Token(Token = "0x400021A")]
			[FieldOffset(Offset = "0x10")]
			public Func<object, object> getExtensionDataDictionary;

			[Token(Token = "0x400021B")]
			[FieldOffset(Offset = "0x18")]
			public MemberInfo member;

			[Token(Token = "0x6000403")]
			[Address(RVA = "0xD09DEC", Offset = "0xD09DEC", VA = "0xD09DEC")]
			public _003C_003Ec__DisplayClass34_0()
			{
			}
		}

		[Token(Token = "0x200008F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80EB5C", Offset = "0x80EB5C")]
		private sealed class _003C_003Ec__DisplayClass34_1
		{
			[Token(Token = "0x400021C")]
			[FieldOffset(Offset = "0x10")]
			public Action<object, object> setExtensionDataDictionary;

			[Token(Token = "0x400021D")]
			[FieldOffset(Offset = "0x18")]
			public Func<object> createExtensionDataDictionary;

			[Token(Token = "0x400021E")]
			[FieldOffset(Offset = "0x20")]
			public MethodCall<object, object> setExtensionDataDictionaryValue;

			[Token(Token = "0x400021F")]
			[FieldOffset(Offset = "0x28")]
			public _003C_003Ec__DisplayClass34_0 CS_0024_003C_003E8__locals1;

			[Token(Token = "0x6000404")]
			[Address(RVA = "0xD09DF4", Offset = "0xD09DF4", VA = "0xD09DF4")]
			public _003C_003Ec__DisplayClass34_1()
			{
			}

			[Token(Token = "0x6000405")]
			[Address(RVA = "0xD101D4", Offset = "0xD101D4", VA = "0xD101D4")]
			internal void _003CSetExtensionDataDelegates_003Eb__0(object o, string key, object value)
			{
			}
		}

		[Token(Token = "0x2000090")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80EB6C", Offset = "0x80EB6C")]
		private sealed class _003C_003Ec__DisplayClass34_2
		{
			[Token(Token = "0x4000220")]
			[FieldOffset(Offset = "0x10")]
			public ObjectConstructor<object> createEnumerableWrapper;

			[Token(Token = "0x4000221")]
			[FieldOffset(Offset = "0x18")]
			public _003C_003Ec__DisplayClass34_0 CS_0024_003C_003E8__locals2;

			[Token(Token = "0x6000406")]
			[Address(RVA = "0xD09E14", Offset = "0xD09E14", VA = "0xD09E14")]
			public _003C_003Ec__DisplayClass34_2()
			{
			}

			[Token(Token = "0x6000407")]
			[Address(RVA = "0xD10460", Offset = "0xD10460", VA = "0xD10460")]
			internal IEnumerable<KeyValuePair<object, object>> _003CSetExtensionDataDelegates_003Eb__1(object o)
			{
				return null;
			}
		}

		[Token(Token = "0x2000091")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80EB7C", Offset = "0x80EB7C")]
		private sealed class _003C_003Ec__DisplayClass64_0
		{
			[Token(Token = "0x4000222")]
			[FieldOffset(Offset = "0x10")]
			public MethodCall<object, object> shouldSerializeCall;

			[Token(Token = "0x6000408")]
			[Address(RVA = "0xD0F72C", Offset = "0xD0F72C", VA = "0xD0F72C")]
			public _003C_003Ec__DisplayClass64_0()
			{
			}

			[Token(Token = "0x6000409")]
			[Address(RVA = "0xD105E8", Offset = "0xD105E8", VA = "0xD105E8")]
			internal bool _003CCreateShouldSerializeTest_003Eb__0(object o)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000092")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80EB8C", Offset = "0x80EB8C")]
		private sealed class _003C_003Ec__DisplayClass65_0
		{
			[Token(Token = "0x4000223")]
			[FieldOffset(Offset = "0x10")]
			public Func<object, object> specifiedPropertyGet;

			[Token(Token = "0x600040A")]
			[Address(RVA = "0xD0F734", Offset = "0xD0F734", VA = "0xD0F734")]
			public _003C_003Ec__DisplayClass65_0()
			{
			}

			[Token(Token = "0x600040B")]
			[Address(RVA = "0xD1068C", Offset = "0xD1068C", VA = "0xD1068C")]
			internal bool _003CSetIsSpecifiedActions_003Eb__0(object o)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000204")]
		[FieldOffset(Offset = "0x0")]
		private static readonly IContractResolver _instance;

		[Token(Token = "0x4000205")]
		[FieldOffset(Offset = "0x8")]
		private static readonly JsonConverter[] BuiltInConverters;

		[Token(Token = "0x4000206")]
		[FieldOffset(Offset = "0x10")]
		private static readonly object TypeContractCacheLock;

		[Token(Token = "0x4000207")]
		[FieldOffset(Offset = "0x18")]
		private static readonly DefaultContractResolverState _sharedState;

		[Token(Token = "0x4000208")]
		[FieldOffset(Offset = "0x10")]
		private readonly DefaultContractResolverState _instanceState;

		[Token(Token = "0x4000209")]
		[FieldOffset(Offset = "0x18")]
		private readonly bool _sharedCache;

		[Token(Token = "0x400020A")]
		[FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F828", Offset = "0x80F828")]
		private BindingFlags _003CDefaultMembersSearchFlags_003Ek__BackingField;

		[Token(Token = "0x400020B")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F838", Offset = "0x80F838")]
		private bool _003CSerializeCompilerGeneratedMembers_003Ek__BackingField;

		[Token(Token = "0x400020C")]
		[FieldOffset(Offset = "0x21")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F848", Offset = "0x80F848")]
		private bool _003CIgnoreSerializableInterface_003Ek__BackingField;

		[Token(Token = "0x400020D")]
		[FieldOffset(Offset = "0x22")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F858", Offset = "0x80F858")]
		private bool _003CIgnoreSerializableAttribute_003Ek__BackingField;

		[Token(Token = "0x17000095")]
		internal static IContractResolver Instance
		{
			[Token(Token = "0x60003C0")]
			[Address(RVA = "0xD07818", Offset = "0xD07818", VA = "0xD07818")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000096")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x811A04", Offset = "0x811A04")]
		public BindingFlags DefaultMembersSearchFlags
		{
			[Token(Token = "0x60003C1")]
			[Address(RVA = "0xD07880", Offset = "0xD07880", VA = "0xD07880")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8105B8", Offset = "0x8105B8")]
			get
			{
				return default(BindingFlags);
			}
			[Token(Token = "0x60003C2")]
			[Address(RVA = "0xD07888", Offset = "0xD07888", VA = "0xD07888")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8105C8", Offset = "0x8105C8")]
			set
			{
			}
		}

		[Token(Token = "0x17000097")]
		public bool SerializeCompilerGeneratedMembers
		{
			[Token(Token = "0x60003C3")]
			[Address(RVA = "0xD07890", Offset = "0xD07890", VA = "0xD07890")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8105D8", Offset = "0x8105D8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000098")]
		public bool IgnoreSerializableInterface
		{
			[Token(Token = "0x60003C4")]
			[Address(RVA = "0xD07898", Offset = "0xD07898", VA = "0xD07898")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8105E8", Offset = "0x8105E8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000099")]
		public bool IgnoreSerializableAttribute
		{
			[Token(Token = "0x60003C5")]
			[Address(RVA = "0xD078A0", Offset = "0xD078A0", VA = "0xD078A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8105F8", Offset = "0x8105F8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003C6")]
			[Address(RVA = "0xD078A8", Offset = "0xD078A8", VA = "0xD078A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810608", Offset = "0x810608")]
			set
			{
			}
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0xD078B4", Offset = "0xD078B4", VA = "0xD078B4")]
		public DefaultContractResolver()
		{
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0xD077E0", Offset = "0xD077E0", VA = "0xD077E0")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x810618", Offset = "0x810618")]
		public DefaultContractResolver(bool shareCache)
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0xD07994", Offset = "0xD07994", VA = "0xD07994")]
		internal DefaultContractResolverState GetState()
		{
			return null;
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0xD07A14", Offset = "0xD07A14", VA = "0xD07A14", Slot = "5")]
		public virtual JsonContract ResolveContract(Type type)
		{
			return null;
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0xD07C5C", Offset = "0xD07C5C", VA = "0xD07C5C", Slot = "6")]
		protected virtual List<MemberInfo> GetSerializableMembers(Type objectType)
		{
			return null;
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0xD083D4", Offset = "0xD083D4", VA = "0xD083D4")]
		private bool ShouldSerializeEntityMember(MemberInfo memberInfo)
		{
			return default(bool);
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0xD084E0", Offset = "0xD084E0", VA = "0xD084E0", Slot = "7")]
		protected virtual JsonObjectContract CreateObjectContract(Type objectType)
		{
			return null;
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0xD09250", Offset = "0xD09250", VA = "0xD09250")]
		private MemberInfo GetExtensionDataMemberForType(Type type)
		{
			return null;
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0xD093FC", Offset = "0xD093FC", VA = "0xD093FC")]
		private static void SetExtensionDataDelegates(JsonObjectContract contract, MemberInfo member)
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0xD089F0", Offset = "0xD089F0", VA = "0xD089F0")]
		private ConstructorInfo GetAttributeConstructor(Type objectType)
		{
			return null;
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0xD09034", Offset = "0xD09034", VA = "0xD09034")]
		private ConstructorInfo GetParameterizedConstructor(Type objectType)
		{
			return null;
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0xD09EF4", Offset = "0xD09EF4", VA = "0xD09EF4", Slot = "8")]
		protected virtual IList<JsonProperty> CreateConstructorParameters(ConstructorInfo constructor, JsonPropertyCollection memberProperties)
		{
			return null;
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0xD0A4AC", Offset = "0xD0A4AC", VA = "0xD0A4AC", Slot = "9")]
		protected virtual JsonProperty CreatePropertyFromConstructorParameter(JsonProperty matchingMemberProperty, ParameterInfo parameterInfo)
		{
			return null;
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0xD0AE94", Offset = "0xD0AE94", VA = "0xD0AE94", Slot = "10")]
		protected virtual JsonConverter ResolveContractConverter(Type objectType)
		{
			return null;
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0xD0AEFC", Offset = "0xD0AEFC", VA = "0xD0AEFC")]
		private Func<object> GetDefaultCreator(Type createdType)
		{
			return null;
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0xD087C0", Offset = "0xD087C0", VA = "0xD087C0")]
		private void InitializeContract(JsonContract contract)
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0xD0AFD0", Offset = "0xD0AFD0", VA = "0xD0AFD0")]
		private void ResolveCallbackMethods(JsonContract contract, Type t)
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0xD0B13C", Offset = "0xD0B13C", VA = "0xD0B13C")]
		private void GetCallbackMethodsForType(Type type, out List<SerializationCallback> onSerializing, out List<SerializationCallback> onSerialized, out List<SerializationCallback> onDeserializing, out List<SerializationCallback> onDeserialized, out List<SerializationErrorCallback> onError)
		{
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0xD0BAF4", Offset = "0xD0BAF4", VA = "0xD0BAF4")]
		private static bool ShouldSkipDeserialized(Type t)
		{
			return default(bool);
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0xD0BAEC", Offset = "0xD0BAEC", VA = "0xD0BAEC")]
		private static bool ShouldSkipSerializing(Type t)
		{
			return default(bool);
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0xD09CD8", Offset = "0xD09CD8", VA = "0xD09CD8")]
		private List<Type> GetClassHierarchyForType(Type type)
		{
			return null;
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0xD0C324", Offset = "0xD0C324", VA = "0xD0C324", Slot = "11")]
		protected virtual JsonDictionaryContract CreateDictionaryContract(Type objectType)
		{
			return null;
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0xD0CEC8", Offset = "0xD0CEC8", VA = "0xD0CEC8", Slot = "12")]
		protected virtual JsonArrayContract CreateArrayContract(Type objectType)
		{
			return null;
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0xD0DCF8", Offset = "0xD0DCF8", VA = "0xD0DCF8", Slot = "13")]
		protected virtual JsonPrimitiveContract CreatePrimitiveContract(Type objectType)
		{
			return null;
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0xD0DE70", Offset = "0xD0DE70", VA = "0xD0DE70", Slot = "14")]
		protected virtual JsonLinqContract CreateLinqContract(Type objectType)
		{
			return null;
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0xD0DF18", Offset = "0xD0DF18", VA = "0xD0DF18", Slot = "15")]
		protected virtual JsonISerializableContract CreateISerializableContract(Type objectType)
		{
			return null;
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0xD0E15C", Offset = "0xD0E15C", VA = "0xD0E15C", Slot = "16")]
		protected virtual JsonStringContract CreateStringContract(Type objectType)
		{
			return null;
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0xD0E1D8", Offset = "0xD0E1D8", VA = "0xD0E1D8", Slot = "17")]
		protected virtual JsonContract CreateContract(Type objectType)
		{
			return null;
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0xD0E52C", Offset = "0xD0E52C", VA = "0xD0E52C")]
		internal static bool IsJsonPrimitiveType(Type t)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0xD0E7C0", Offset = "0xD0E7C0", VA = "0xD0E7C0")]
		internal static bool IsIConvertible(Type t)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0xD0E5A0", Offset = "0xD0E5A0", VA = "0xD0E5A0")]
		internal static bool CanConvertToString(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0xD0BAFC", Offset = "0xD0BAFC", VA = "0xD0BAFC")]
		private static bool IsValidCallback(MethodInfo method, ParameterInfo[] parameters, Type attributeType, MethodInfo currentCallback, ref Type prevAttributeType)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0xD0E960", Offset = "0xD0E960", VA = "0xD0E960")]
		internal static string GetClrTypeFullName(Type type)
		{
			return null;
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0xD0EB24", Offset = "0xD0EB24", VA = "0xD0EB24", Slot = "18")]
		protected virtual IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
		{
			return null;
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0xD0EF2C", Offset = "0xD0EF2C", VA = "0xD0EF2C", Slot = "19")]
		protected virtual IValueProvider CreateMemberValueProvider(MemberInfo member)
		{
			return null;
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0xD0EF90", Offset = "0xD0EF90", VA = "0xD0EF90", Slot = "20")]
		protected virtual JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
		{
			return null;
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0xD0A820", Offset = "0xD0A820", VA = "0xD0A820")]
		private void SetPropertySettingsFromAttributes(JsonProperty property, object attributeProvider, string name, Type declaringType, MemberSerialization memberSerialization, out bool allowNonPublicAccess)
		{
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0xD0F1C8", Offset = "0xD0F1C8", VA = "0xD0F1C8")]
		private Predicate<object> CreateShouldSerializeTest(MemberInfo member)
		{
			return null;
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0xD0F408", Offset = "0xD0F408", VA = "0xD0F408")]
		private void SetIsSpecifiedActions(JsonProperty property, MemberInfo member, bool allowNonPublicAccess)
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0xD0F74C", Offset = "0xD0F74C", VA = "0xD0F74C", Slot = "21")]
		protected virtual string ResolvePropertyName(string propertyName)
		{
			return null;
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0xD0F754", Offset = "0xD0F754", VA = "0xD0F754", Slot = "22")]
		protected virtual string ResolveDictionaryKey(string dictionaryKey)
		{
			return null;
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0xD0F764", Offset = "0xD0F764", VA = "0xD0F764")]
		public string GetResolvedPropertyName(string propertyName)
		{
			return null;
		}
	}
}
