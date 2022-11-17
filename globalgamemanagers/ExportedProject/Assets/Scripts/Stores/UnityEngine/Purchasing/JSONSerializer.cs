using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	[Token(Token = "0x2000006")]
	internal class JSONSerializer
	{
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x1786924", Offset = "0x1786924", VA = "0x1786924")]
		public static string SerializeProductDef(ProductDefinition product)
		{
			return null;
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x1786B40", Offset = "0x1786B40", VA = "0x1786B40")]
		public static string SerializeProductDefs(IEnumerable<ProductDefinition> products)
		{
			return null;
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x1786E30", Offset = "0x1786E30", VA = "0x1786E30")]
		public static List<ProductDescription> DeserializeProductDescriptions(string json)
		{
			return null;
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x1787510", Offset = "0x1787510", VA = "0x1787510")]
		public static PurchaseFailureDescription DeserializeFailureReason(string json)
		{
			return null;
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x17872B8", Offset = "0x17872B8", VA = "0x17872B8")]
		private static ProductMetadata DeserializeMetadata(Dictionary<string, object> data)
		{
			return null;
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x178699C", Offset = "0x178699C", VA = "0x178699C")]
		private static Dictionary<string, object> EncodeProductDef(ProductDefinition product)
		{
			return null;
		}
	}
}
