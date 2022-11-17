using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x20003B6")]
	public class Products : DepotController, ProductController
	{
		[Token(Token = "0x40011CC")]
		[FieldOffset(Offset = "0x20")]
		private DepotEntity<RDProduct> m_Products;

		[Token(Token = "0x6001CA6")]
		[Address(RVA = "0x9B94B8", Offset = "0x9B94B8", VA = "0x9B94B8")]
		public Products(DataStoreController controller)
		{
		}

		[Token(Token = "0x6001CA7")]
		[Address(RVA = "0x9B94C0", Offset = "0x9B94C0", VA = "0x9B94C0", Slot = "9")]
		public override void OnDataUpdated()
		{
		}

		[Token(Token = "0x6001CA8")]
		[Address(RVA = "0x9B9634", Offset = "0x9B9634", VA = "0x9B9634", Slot = "10")]
		public Product Get(string productReference)
		{
			return null;
		}

		[Token(Token = "0x6001CA9")]
		[Address(RVA = "0x9B9638", Offset = "0x9B9638", VA = "0x9B9638")]
		public Product GetProduct(string productReference)
		{
			return null;
		}

		[Token(Token = "0x6001CAA")]
		[Address(RVA = "0x9B96F4", Offset = "0x9B96F4", VA = "0x9B96F4", Slot = "11")]
		public List<Product> Get(List<string> productReferences)
		{
			return null;
		}
	}
}
