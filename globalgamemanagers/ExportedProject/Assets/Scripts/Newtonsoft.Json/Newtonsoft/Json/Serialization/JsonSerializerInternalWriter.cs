using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x20000AD")]
	[Preserve]
	internal class JsonSerializerInternalWriter : JsonSerializerInternalBase
	{
		[Token(Token = "0x40002AE")]
		[FieldOffset(Offset = "0x38")]
		private Type _rootType;

		[Token(Token = "0x40002AF")]
		[FieldOffset(Offset = "0x40")]
		private int _rootLevel;

		[Token(Token = "0x40002B0")]
		[FieldOffset(Offset = "0x48")]
		private readonly List<object> _serializeStack;

		[Token(Token = "0x600050F")]
		[Address(RVA = "0xEFCFF4", Offset = "0xEFCFF4", VA = "0xEFCFF4")]
		public JsonSerializerInternalWriter(JsonSerializer serializer)
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0xEFD074", Offset = "0xEFD074", VA = "0xEFD074")]
		public void Serialize(JsonWriter jsonWriter, object value, Type objectType)
		{
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0xEFE250", Offset = "0xEFE250", VA = "0xEFE250")]
		private JsonSerializerProxy GetInternalSerializer()
		{
			return null;
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0xEFD2F4", Offset = "0xEFD2F4", VA = "0xEFD2F4")]
		private JsonContract GetContractSafe(object value)
		{
			return null;
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0xEFE344", Offset = "0xEFE344", VA = "0xEFE344")]
		private void SerializePrimitive(JsonWriter writer, object value, JsonPrimitiveContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty)
		{
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0xEFD894", Offset = "0xEFD894", VA = "0xEFD894")]
		private void SerializeValue(JsonWriter writer, object value, JsonContract valueContract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty)
		{
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0xF010F4", Offset = "0xF010F4", VA = "0xF010F4")]
		private bool? ResolveIsReference(JsonContract contract, JsonProperty property, JsonContainerContract collectionContract, JsonProperty containerProperty)
		{
			return null;
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0xEFD3F0", Offset = "0xEFD3F0", VA = "0xEFD3F0")]
		private bool ShouldWriteReference(object value, JsonProperty property, JsonContract valueContract, JsonContainerContract collectionContract, JsonProperty containerProperty)
		{
			return default(bool);
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0xF011FC", Offset = "0xF011FC", VA = "0xF011FC")]
		private bool ShouldWriteProperty(object memberValue, JsonProperty property)
		{
			return default(bool);
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0xF01334", Offset = "0xF01334", VA = "0xF01334")]
		private bool CheckForCircularReference(JsonWriter writer, object value, JsonProperty property, JsonContract contract, JsonContainerContract containerContract, JsonProperty containerProperty)
		{
			return default(bool);
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0xEFD5B4", Offset = "0xEFD5B4", VA = "0xEFD5B4")]
		private void WriteReference(JsonWriter writer, object value)
		{
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0xF01900", Offset = "0xF01900", VA = "0xF01900")]
		private string GetReference(JsonWriter writer, object value)
		{
			return null;
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0xF01B14", Offset = "0xF01B14", VA = "0xF01B14")]
		internal static bool TryConvertToString(object value, Type type, out string s)
		{
			return default(bool);
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0xF0013C", Offset = "0xF0013C", VA = "0xF0013C")]
		private void SerializeString(JsonWriter writer, object value, JsonStringContract contract)
		{
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0xF01D40", Offset = "0xF01D40", VA = "0xF01D40")]
		private void OnSerializing(JsonWriter writer, JsonContract contract, object value)
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0xF01F94", Offset = "0xF01F94", VA = "0xF01F94")]
		private void OnSerialized(JsonWriter writer, JsonContract contract, object value)
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0xEFF07C", Offset = "0xEFF07C", VA = "0xEFF07C")]
		private void SerializeObject(JsonWriter writer, object value, JsonObjectContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty)
		{
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0xF0236C", Offset = "0xF0236C", VA = "0xF0236C")]
		private bool CalculatePropertyValues(JsonWriter writer, object value, JsonContainerContract contract, JsonProperty member, JsonProperty property, out JsonContract memberContract, out object memberValue)
		{
			return default(bool);
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0xF021E8", Offset = "0xF021E8", VA = "0xF021E8")]
		private void WriteObjectStart(JsonWriter writer, object value, JsonContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty)
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0xF0335C", Offset = "0xF0335C", VA = "0xF0335C")]
		private void WriteReferenceIdProperty(JsonWriter writer, Type type, object value)
		{
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0xEFE858", Offset = "0xEFE858", VA = "0xEFE858")]
		private void WriteTypeProperty(JsonWriter writer, Type type)
		{
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0xF01328", Offset = "0xF01328", VA = "0xF01328")]
		private bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag)
		{
			return default(bool);
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0xF011F0", Offset = "0xF011F0", VA = "0xF011F0")]
		private bool HasFlag(PreserveReferencesHandling value, PreserveReferencesHandling flag)
		{
			return default(bool);
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0xF035C0", Offset = "0xF035C0", VA = "0xF035C0")]
		private bool HasFlag(TypeNameHandling value, TypeNameHandling flag)
		{
			return default(bool);
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0xEFEB08", Offset = "0xEFEB08", VA = "0xEFEB08")]
		private void SerializeConvertable(JsonWriter writer, JsonConverter converter, object value, JsonContract contract, JsonContainerContract collectionContract, JsonProperty containerProperty)
		{
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0xEFF848", Offset = "0xEFF848", VA = "0xEFF848")]
		private void SerializeList(JsonWriter writer, IEnumerable values, JsonArrayContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty)
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0xEFFF84", Offset = "0xEFFF84", VA = "0xEFFF84")]
		private void SerializeMultidimensionalArray(JsonWriter writer, Array values, JsonArrayContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty)
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0xF038D0", Offset = "0xF038D0", VA = "0xF038D0")]
		private void SerializeMultidimensionalArray(JsonWriter writer, Array values, JsonArrayContract contract, JsonProperty member, int initialDepth, int[] indices)
		{
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0xF035CC", Offset = "0xF035CC", VA = "0xF035CC")]
		private bool WriteStartArray(JsonWriter writer, object values, JsonArrayContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty)
		{
			return default(bool);
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0xF00BF0", Offset = "0xF00BF0", VA = "0xF00BF0")]
		private void SerializeISerializable(JsonWriter writer, ISerializable value, JsonISerializableContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty)
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0xEFE564", Offset = "0xEFE564", VA = "0xEFE564")]
		private bool ShouldWriteType(TypeNameHandling typeNameHandlingFlag, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty)
		{
			return default(bool);
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0xF001E8", Offset = "0xF001E8", VA = "0xF001E8")]
		private void SerializeDictionary(JsonWriter writer, IDictionary values, JsonDictionaryContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty)
		{
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0xF028C8", Offset = "0xF028C8", VA = "0xF028C8")]
		private string GetPropertyName(JsonWriter writer, object name, JsonContract contract, out bool escape)
		{
			return null;
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0xEFE1AC", Offset = "0xEFE1AC", VA = "0xEFE1AC")]
		private void HandleError(JsonWriter writer, int initialDepth)
		{
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0xF02D94", Offset = "0xF02D94", VA = "0xF02D94")]
		private bool ShouldSerialize(JsonWriter writer, JsonProperty property, object target)
		{
			return default(bool);
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0xF03078", Offset = "0xF03078", VA = "0xF03078")]
		private bool IsSpecified(JsonWriter writer, JsonProperty property, object target)
		{
			return default(bool);
		}
	}
}
