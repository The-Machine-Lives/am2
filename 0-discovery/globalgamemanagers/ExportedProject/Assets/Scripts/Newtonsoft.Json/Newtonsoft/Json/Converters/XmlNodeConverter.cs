using System;
using System.Collections.Generic;
using System.Xml;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x2000116")]
	[Preserve]
	public class XmlNodeConverter : JsonConverter
	{
		[Token(Token = "0x40003D3")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FD28", Offset = "0x80FD28")]
		private string _003CDeserializeRootElementName_003Ek__BackingField;

		[Token(Token = "0x40003D4")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FD38", Offset = "0x80FD38")]
		private bool _003CWriteArrayAttribute_003Ek__BackingField;

		[Token(Token = "0x40003D5")]
		[FieldOffset(Offset = "0x19")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FD48", Offset = "0x80FD48")]
		private bool _003COmitRootObject_003Ek__BackingField;

		[Token(Token = "0x170001C3")]
		public string DeserializeRootElementName
		{
			[Token(Token = "0x60008A3")]
			[Address(RVA = "0xD438F0", Offset = "0xD438F0", VA = "0xD438F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x811754", Offset = "0x811754")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001C4")]
		public bool WriteArrayAttribute
		{
			[Token(Token = "0x60008A4")]
			[Address(RVA = "0xD438F8", Offset = "0xD438F8", VA = "0xD438F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x811764", Offset = "0x811764")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001C5")]
		public bool OmitRootObject
		{
			[Token(Token = "0x60008A5")]
			[Address(RVA = "0xD43900", Offset = "0xD43900", VA = "0xD43900")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x811774", Offset = "0x811774")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60008A6")]
		[Address(RVA = "0xD43908", Offset = "0xD43908", VA = "0xD43908", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		[Token(Token = "0x60008A7")]
		[Address(RVA = "0xD43A38", Offset = "0xD43A38", VA = "0xD43A38")]
		private IXmlNode WrapXml(object value)
		{
			return null;
		}

		[Token(Token = "0x60008A8")]
		[Address(RVA = "0xD43B40", Offset = "0xD43B40", VA = "0xD43B40")]
		private void PushParentNamespaces(IXmlNode node, XmlNamespaceManager manager)
		{
		}

		[Token(Token = "0x60008A9")]
		[Address(RVA = "0xD45FB4", Offset = "0xD45FB4", VA = "0xD45FB4")]
		private string ResolveFullName(IXmlNode node, XmlNamespaceManager manager)
		{
			return null;
		}

		[Token(Token = "0x60008AA")]
		[Address(RVA = "0xD46330", Offset = "0xD46330", VA = "0xD46330")]
		private string GetPropertyName(IXmlNode node, XmlNamespaceManager manager)
		{
			return null;
		}

		[Token(Token = "0x60008AB")]
		[Address(RVA = "0xD4673C", Offset = "0xD4673C", VA = "0xD4673C")]
		private bool IsArray(IXmlNode node)
		{
			return default(bool);
		}

		[Token(Token = "0x60008AC")]
		[Address(RVA = "0xD46B28", Offset = "0xD46B28", VA = "0xD46B28")]
		private void SerializeGroupedNodes(JsonWriter writer, IXmlNode node, XmlNamespaceManager manager, bool writePropertyName)
		{
		}

		[Token(Token = "0x60008AD")]
		[Address(RVA = "0xD441BC", Offset = "0xD441BC", VA = "0xD441BC")]
		private void SerializeNode(JsonWriter writer, IXmlNode node, XmlNamespaceManager manager, bool writePropertyName)
		{
		}

		[Token(Token = "0x60008AE")]
		[Address(RVA = "0xD47064", Offset = "0xD47064", VA = "0xD47064")]
		private static bool AllSameName(IXmlNode node)
		{
			return default(bool);
		}

		[Token(Token = "0x60008AF")]
		[Address(RVA = "0xD474C8", Offset = "0xD474C8", VA = "0xD474C8", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Token(Token = "0x60008B0")]
		[Address(RVA = "0xD48578", Offset = "0xD48578", VA = "0xD48578")]
		private void DeserializeValue(JsonReader reader, IXmlDocument document, XmlNamespaceManager manager, string propertyName, IXmlNode currentNode)
		{
		}

		[Token(Token = "0x60008B1")]
		[Address(RVA = "0xD47B04", Offset = "0xD47B04", VA = "0xD47B04")]
		private void ReadElement(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName, XmlNamespaceManager manager)
		{
		}

		[Token(Token = "0x60008B2")]
		[Address(RVA = "0xD4A120", Offset = "0xD4A120", VA = "0xD4A120")]
		private void CreateElement(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string elementName, XmlNamespaceManager manager, string elementPrefix, Dictionary<string, string> attributeNameValues)
		{
		}

		[Token(Token = "0x60008B3")]
		[Address(RVA = "0xD49DB8", Offset = "0xD49DB8", VA = "0xD49DB8")]
		private static void AddAttribute(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string attributeName, XmlNamespaceManager manager, string attributePrefix)
		{
		}

		[Token(Token = "0x60008B4")]
		[Address(RVA = "0xD4AA08", Offset = "0xD4AA08", VA = "0xD4AA08")]
		private string ConvertTokenToXmlValue(JsonReader reader)
		{
			return null;
		}

		[Token(Token = "0x60008B5")]
		[Address(RVA = "0xD49414", Offset = "0xD49414", VA = "0xD49414")]
		private void ReadArrayElements(JsonReader reader, IXmlDocument document, string propertyName, IXmlNode currentNode, XmlNamespaceManager manager)
		{
		}

		[Token(Token = "0x60008B6")]
		[Address(RVA = "0xD4B06C", Offset = "0xD4B06C", VA = "0xD4B06C")]
		private void AddJsonArrayAttribute(IXmlElement element, IXmlDocument document)
		{
		}

		[Token(Token = "0x60008B7")]
		[Address(RVA = "0xD49774", Offset = "0xD49774", VA = "0xD49774")]
		private Dictionary<string, string> ReadAttributeElements(JsonReader reader, XmlNamespaceManager manager)
		{
			return null;
		}

		[Token(Token = "0x60008B8")]
		[Address(RVA = "0xD48BD4", Offset = "0xD48BD4", VA = "0xD48BD4")]
		private void CreateInstruction(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName)
		{
		}

		[Token(Token = "0x60008B9")]
		[Address(RVA = "0xD49068", Offset = "0xD49068", VA = "0xD49068")]
		private void CreateDocumentType(JsonReader reader, IXmlDocument document, IXmlNode currentNode)
		{
		}

		[Token(Token = "0x60008BA")]
		[Address(RVA = "0xD4A838", Offset = "0xD4A838", VA = "0xD4A838")]
		private IXmlElement CreateElement(string elementName, IXmlDocument document, string elementPrefix, XmlNamespaceManager manager)
		{
			return null;
		}

		[Token(Token = "0x60008BB")]
		[Address(RVA = "0xD47DC8", Offset = "0xD47DC8", VA = "0xD47DC8")]
		private void DeserializeNode(JsonReader reader, IXmlDocument document, XmlNamespaceManager manager, IXmlNode currentNode)
		{
		}

		[Token(Token = "0x60008BC")]
		[Address(RVA = "0xD4B3A4", Offset = "0xD4B3A4", VA = "0xD4B3A4")]
		private bool IsNamespaceAttribute(string attributeName, out string prefix)
		{
			return default(bool);
		}

		[Token(Token = "0x60008BD")]
		[Address(RVA = "0xD47310", Offset = "0xD47310", VA = "0xD47310")]
		private bool ValueAttributes(List<IXmlNode> c)
		{
			return default(bool);
		}

		[Token(Token = "0x60008BE")]
		[Address(RVA = "0xD4B4E0", Offset = "0xD4B4E0", VA = "0xD4B4E0", Slot = "6")]
		public override bool CanConvert(Type valueType)
		{
			return default(bool);
		}

		[Token(Token = "0x60008BF")]
		[Address(RVA = "0xD4B5EC", Offset = "0xD4B5EC", VA = "0xD4B5EC")]
		public XmlNodeConverter()
		{
		}
	}
}
