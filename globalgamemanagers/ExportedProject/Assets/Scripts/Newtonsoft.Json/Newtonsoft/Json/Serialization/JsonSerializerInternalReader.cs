using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x20000A8")]
	[Preserve]
	internal class JsonSerializerInternalReader : JsonSerializerInternalBase
	{
		[Token(Token = "0x20000A9")]
		internal enum PropertyPresence
		{
			[Token(Token = "0x400029F")]
			None = 0,
			[Token(Token = "0x40002A0")]
			Null = 1,
			[Token(Token = "0x40002A1")]
			Value = 2
		}

		[Token(Token = "0x20000AA")]
		internal class CreatorPropertyContext
		{
			[Token(Token = "0x40002A2")]
			[FieldOffset(Offset = "0x10")]
			public string Name;

			[Token(Token = "0x40002A3")]
			[FieldOffset(Offset = "0x18")]
			public JsonProperty Property;

			[Token(Token = "0x40002A4")]
			[FieldOffset(Offset = "0x20")]
			public JsonProperty ConstructorProperty;

			[Token(Token = "0x40002A5")]
			[FieldOffset(Offset = "0x28")]
			public PropertyPresence? Presence;

			[Token(Token = "0x40002A6")]
			[FieldOffset(Offset = "0x30")]
			public object Value;

			[Token(Token = "0x40002A7")]
			[FieldOffset(Offset = "0x38")]
			public bool Used;

			[Token(Token = "0x6000506")]
			[Address(RVA = "0xEFC1A0", Offset = "0xEFC1A0", VA = "0xEFC1A0")]
			public CreatorPropertyContext()
			{
			}
		}

		[Token(Token = "0x20000AB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80ECDC", Offset = "0x80ECDC")]
		private sealed class _003C_003Ec__DisplayClass36_0
		{
			[Token(Token = "0x40002A8")]
			[FieldOffset(Offset = "0x10")]
			public JsonProperty property;

			[Token(Token = "0x6000507")]
			[Address(RVA = "0xEFC198", Offset = "0xEFC198", VA = "0xEFC198")]
			public _003C_003Ec__DisplayClass36_0()
			{
			}

			[Token(Token = "0x6000508")]
			[Address(RVA = "0xEFCFB8", Offset = "0xEFCFB8", VA = "0xEFCFB8")]
			internal bool _003CCreateObjectUsingCreatorWithParameters_003Eb__1(CreatorPropertyContext p)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x20000AC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80ECEC", Offset = "0x80ECEC")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x40002A9")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x40002AA")]
			[FieldOffset(Offset = "0x8")]
			public static Func<JsonProperty, string> _003C_003E9__36_0;

			[Token(Token = "0x40002AB")]
			[FieldOffset(Offset = "0x10")]
			public static Func<JsonProperty, string> _003C_003E9__36_2;

			[Token(Token = "0x40002AC")]
			[FieldOffset(Offset = "0x18")]
			public static Func<JsonProperty, JsonProperty> _003C_003E9__41_0;

			[Token(Token = "0x40002AD")]
			[FieldOffset(Offset = "0x20")]
			public static Func<JsonProperty, PropertyPresence> _003C_003E9__41_1;

			[Token(Token = "0x600050A")]
			[Address(RVA = "0xEFCF40", Offset = "0xEFCF40", VA = "0xEFCF40")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x600050B")]
			[Address(RVA = "0xEFCF48", Offset = "0xEFCF48", VA = "0xEFCF48")]
			internal string _003CCreateObjectUsingCreatorWithParameters_003Eb__36_0(JsonProperty p)
			{
				return null;
			}

			[Token(Token = "0x600050C")]
			[Address(RVA = "0xEFCF78", Offset = "0xEFCF78", VA = "0xEFCF78")]
			internal string _003CCreateObjectUsingCreatorWithParameters_003Eb__36_2(JsonProperty p)
			{
				return null;
			}

			[Token(Token = "0x600050D")]
			[Address(RVA = "0xEFCFA8", Offset = "0xEFCFA8", VA = "0xEFCFA8")]
			internal JsonProperty _003CPopulateObject_003Eb__41_0(JsonProperty m)
			{
				return null;
			}

			[Token(Token = "0x600050E")]
			[Address(RVA = "0xEFCFB0", Offset = "0xEFCFB0", VA = "0xEFCFB0")]
			internal PropertyPresence _003CPopulateObject_003Eb__41_1(JsonProperty m)
			{
				return default(PropertyPresence);
			}
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0xEEED5C", Offset = "0xEEED5C", VA = "0xEEED5C")]
		public JsonSerializerInternalReader(JsonSerializer serializer)
		{
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0xEEED64", Offset = "0xEEED64", VA = "0xEEED64")]
		public void Populate(JsonReader reader, object target)
		{
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0xEF12C8", Offset = "0xEF12C8", VA = "0xEF12C8")]
		private JsonContract GetContractSafe(Type type)
		{
			return null;
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0xEF13B4", Offset = "0xEF13B4", VA = "0xEF13B4")]
		public object Deserialize(JsonReader reader, Type objectType, bool checkAdditionalContent)
		{
			return null;
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0xEF2434", Offset = "0xEF2434", VA = "0xEF2434")]
		private JsonSerializerProxy GetInternalSerializer()
		{
			return null;
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0xEF2528", Offset = "0xEF2528", VA = "0xEF2528")]
		private JToken CreateJToken(JsonReader reader, JsonContract contract)
		{
			return null;
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0xEF27D4", Offset = "0xEF27D4", VA = "0xEF27D4")]
		private JToken CreateJObject(JsonReader reader)
		{
			return null;
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0xEF1EC4", Offset = "0xEF1EC4", VA = "0xEF1EC4")]
		private object CreateValueInternal(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue)
		{
			return null;
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0xEF4850", Offset = "0xEF4850", VA = "0xEF4850")]
		private static bool CoerceEmptyStringToNull(Type objectType, JsonContract contract, string s)
		{
			return default(bool);
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0xEF4954", Offset = "0xEF4954", VA = "0xEF4954")]
		internal string GetExpectedDescription(JsonContract contract)
		{
			return null;
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0xEF1738", Offset = "0xEF1738", VA = "0xEF1738")]
		private JsonConverter GetConverter(JsonContract contract, JsonConverter memberConverter, JsonContainerContract containerContract, JsonProperty containerProperty)
		{
			return null;
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0xEF2C0C", Offset = "0xEF2C0C", VA = "0xEF2C0C")]
		private object CreateObject(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue)
		{
			return null;
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0xEF4A08", Offset = "0xEF4A08", VA = "0xEF4A08")]
		private bool ReadMetadataPropertiesToken(JTokenReader reader, ref Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue, out object newValue, out string id)
		{
			return default(bool);
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0xEF529C", Offset = "0xEF529C", VA = "0xEF529C")]
		private bool ReadMetadataProperties(JsonReader reader, ref Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue, out object newValue, out string id)
		{
			return default(bool);
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0xEF6804", Offset = "0xEF6804", VA = "0xEF6804")]
		private void ResolveTypeName(JsonReader reader, ref Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, string qualifiedTypeName)
		{
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0xEF6DBC", Offset = "0xEF6DBC", VA = "0xEF6DBC")]
		private JsonArrayContract EnsureArrayContract(JsonReader reader, Type objectType, JsonContract contract)
		{
			return null;
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0xEF3AF8", Offset = "0xEF3AF8", VA = "0xEF3AF8")]
		private object CreateList(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, object existingValue, string id)
		{
			return null;
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0xEF5968", Offset = "0xEF5968", VA = "0xEF5968")]
		private bool HasNoDefinedType(JsonContract contract)
		{
			return default(bool);
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0xEF4448", Offset = "0xEF4448", VA = "0xEF4448")]
		private object EnsureType(JsonReader reader, object value, CultureInfo culture, JsonContract contract, Type targetType)
		{
			return null;
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0xEF7F34", Offset = "0xEF7F34", VA = "0xEF7F34")]
		private bool SetPropertyValue(JsonProperty property, JsonConverter propertyConverter, JsonContainerContract containerContract, JsonProperty containerProperty, JsonReader reader, object target)
		{
			return default(bool);
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0xEF8500", Offset = "0xEF8500", VA = "0xEF8500")]
		private bool CalculatePropertyDetails(JsonProperty property, ref JsonConverter propertyConverter, JsonContainerContract containerContract, JsonProperty containerProperty, JsonReader reader, object target, out bool useExistingValue, out object currentValue, out JsonContract propertyContract, out bool gottenCurrentValue)
		{
			return default(bool);
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0xEF8B6C", Offset = "0xEF8B6C", VA = "0xEF8B6C")]
		private void AddReference(JsonReader reader, string id, object value)
		{
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0xEF8B60", Offset = "0xEF8B60", VA = "0xEF8B60")]
		private bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag)
		{
			return default(bool);
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0xEF89DC", Offset = "0xEF89DC", VA = "0xEF89DC")]
		private bool ShouldSetPropertyValue(JsonProperty property, object value)
		{
			return default(bool);
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0xEF6F58", Offset = "0xEF6F58", VA = "0xEF6F58")]
		private IList CreateNewList(JsonReader reader, JsonArrayContract contract, out bool createdFromNonDefaultCreator)
		{
			return null;
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0xEF5D68", Offset = "0xEF5D68", VA = "0xEF5D68")]
		private IDictionary CreateNewDictionary(JsonReader reader, JsonDictionaryContract contract, out bool createdFromNonDefaultCreator)
		{
			return null;
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0xEF8F3C", Offset = "0xEF8F3C", VA = "0xEF8F3C")]
		private void OnDeserializing(JsonReader reader, JsonContract contract, object value)
		{
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0xEF91A4", Offset = "0xEF91A4", VA = "0xEF91A4")]
		private void OnDeserialized(JsonReader reader, JsonContract contract, object value)
		{
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0xEEFAD8", Offset = "0xEEFAD8", VA = "0xEEFAD8")]
		private object PopulateDictionary(IDictionary dictionary, JsonReader reader, JsonDictionaryContract contract, JsonProperty containerProperty, string id)
		{
			return null;
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0xEF73B4", Offset = "0xEF73B4", VA = "0xEF73B4")]
		private object PopulateMultidimensionalArray(IList list, JsonReader reader, JsonArrayContract contract, JsonProperty containerProperty, string id)
		{
			return null;
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0xEF940C", Offset = "0xEF940C", VA = "0xEF940C")]
		private void ThrowUnexpectedEndException(JsonReader reader, JsonContract contract, object currentObject, string message)
		{
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0xEEF4A0", Offset = "0xEEF4A0", VA = "0xEEF4A0")]
		private object PopulateList(IList list, JsonReader reader, JsonArrayContract contract, JsonProperty containerProperty, string id)
		{
			return null;
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0xEF6100", Offset = "0xEF6100", VA = "0xEF6100")]
		private object CreateISerializable(JsonReader reader, JsonISerializableContract contract, JsonProperty member, string id)
		{
			return null;
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0xEF9770", Offset = "0xEF9770", VA = "0xEF9770")]
		internal object CreateISerializableItem(JToken token, Type type, JsonISerializableContract contract, JsonProperty member)
		{
			return null;
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0xEF9880", Offset = "0xEF9880", VA = "0xEF9880")]
		private object CreateObjectUsingCreatorWithParameters(JsonReader reader, JsonObjectContract contract, JsonProperty containerProperty, ObjectConstructor<object> creator, string id)
		{
			return null;
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0xEF1A6C", Offset = "0xEF1A6C", VA = "0xEF1A6C")]
		private object DeserializeConvertable(JsonConverter converter, JsonReader reader, Type objectType, object existingValue)
		{
			return null;
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0xEFBA70", Offset = "0xEFBA70", VA = "0xEFBA70")]
		private List<CreatorPropertyContext> ResolvePropertyAndCreatorValues(JsonObjectContract contract, JsonProperty containerProperty, JsonReader reader, Type objectType)
		{
			return null;
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0xEF185C", Offset = "0xEF185C", VA = "0xEF185C")]
		private bool ReadForType(JsonReader reader, JsonContract contract, bool hasConverter)
		{
			return default(bool);
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0xEF5A1C", Offset = "0xEF5A1C", VA = "0xEF5A1C")]
		public object CreateNewObject(JsonReader reader, JsonObjectContract objectContract, JsonProperty containerMember, JsonProperty containerProperty, string id, out bool createdFromNonDefaultCreator)
		{
			return null;
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0xEF0774", Offset = "0xEF0774", VA = "0xEF0774")]
		private object PopulateObject(object newObject, JsonReader reader, JsonObjectContract contract, JsonProperty member, string id)
		{
			return null;
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0xEFCA88", Offset = "0xEFCA88", VA = "0xEFCA88")]
		private bool ShouldDeserialize(JsonReader reader, JsonProperty property, object target)
		{
			return default(bool);
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0xEF2AFC", Offset = "0xEF2AFC", VA = "0xEF2AFC")]
		private bool CheckPropertyName(JsonReader reader, string memberName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0xEFC878", Offset = "0xEFC878", VA = "0xEFC878")]
		private void SetExtensionData(JsonObjectContract contract, JsonProperty member, JsonReader reader, string memberName, object o)
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0xEFC79C", Offset = "0xEFC79C", VA = "0xEFC79C")]
		private object ReadExtensionDataValue(JsonObjectContract contract, JsonProperty member, JsonReader reader)
		{
			return null;
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0xEFC1A8", Offset = "0xEFC1A8", VA = "0xEFC1A8")]
		private void EndProcessProperty(object newObject, JsonReader reader, JsonObjectContract contract, int initialDepth, JsonProperty property, PropertyPresence presence, bool setDefaultValue)
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0xEFCD70", Offset = "0xEFCD70", VA = "0xEFCD70")]
		private void SetPropertyPresence(JsonReader reader, JsonProperty property, Dictionary<JsonProperty, PropertyPresence> requiredProperties)
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0xEF23A8", Offset = "0xEF23A8", VA = "0xEF23A8")]
		private void HandleError(JsonReader reader, bool readPastError, int initialDepth)
		{
		}
	}
}
