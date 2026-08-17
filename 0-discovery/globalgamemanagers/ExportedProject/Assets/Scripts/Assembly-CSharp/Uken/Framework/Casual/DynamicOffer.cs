using System.Collections.Generic;
using Il2CppDummyDll;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x2000532")]
	public class DynamicOffer
	{
		[Token(Token = "0x200084C")]
		public class SaleSegment
		{
			[Token(Token = "0x40023D2")]
			[FieldOffset(Offset = "0x10")]
			public Sale m_sale;

			[Token(Token = "0x40023D3")]
			[FieldOffset(Offset = "0x18")]
			public UserSegment m_userSegment;

			[Token(Token = "0x600336F")]
			[Address(RVA = "0xA5D3FC", Offset = "0xA5D3FC", VA = "0xA5D3FC")]
			public SaleSegment(Sale sale, UserSegment userSegment)
			{
			}
		}

		[Token(Token = "0x4001897")]
		[FieldOffset(Offset = "0x10")]
		private RDDynamicOffer m_offerData;

		[Token(Token = "0x4001898")]
		[FieldOffset(Offset = "0x18")]
		private List<SaleSegment> m_saleSegments;

		[Token(Token = "0x4001899")]
		[FieldOffset(Offset = "0x20")]
		private UserProfiler m_userProfiler;

		[Token(Token = "0x170006E3")]
		public int ViewDurationInMinutes
		{
			[Token(Token = "0x60027C2")]
			[Address(RVA = "0xA5D0EC", Offset = "0xA5D0EC", VA = "0xA5D0EC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170006E4")]
		public string Reference
		{
			[Token(Token = "0x60027C3")]
			[Address(RVA = "0xA5D118", Offset = "0xA5D118", VA = "0xA5D118")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60027C1")]
		[Address(RVA = "0xA5D0AC", Offset = "0xA5D0AC", VA = "0xA5D0AC")]
		public DynamicOffer(RDDynamicOffer offerData, List<SaleSegment> saleSegments, UserProfiler userProfiler)
		{
		}

		[Token(Token = "0x60027C4")]
		[Address(RVA = "0xA5D144", Offset = "0xA5D144", VA = "0xA5D144")]
		public Sale EvaluateCurrentSale()
		{
			return null;
		}

		[Token(Token = "0x60027C5")]
		[Address(RVA = "0xA5D290", Offset = "0xA5D290", VA = "0xA5D290")]
		public Sale GetSaleByReference(string reference)
		{
			return null;
		}
	}
}
