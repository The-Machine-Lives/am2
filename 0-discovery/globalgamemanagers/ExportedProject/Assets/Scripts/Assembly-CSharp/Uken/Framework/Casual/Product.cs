using System.Collections.Generic;
using Il2CppDummyDll;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x2000527")]
	public class Product
	{
		[Token(Token = "0x400183C")]
		[FieldOffset(Offset = "0x10")]
		protected RDProduct m_productData;

		[Token(Token = "0x170006D4")]
		public int Quantity
		{
			[Token(Token = "0x6002772")]
			[Address(RVA = "0xA78EF0", Offset = "0xA78EF0", VA = "0xA78EF0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170006D5")]
		public string ItemName
		{
			[Token(Token = "0x6002773")]
			[Address(RVA = "0xA78F1C", Offset = "0xA78F1C", VA = "0xA78F1C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006D6")]
		public bool ShowsBadge
		{
			[Token(Token = "0x6002774")]
			[Address(RVA = "0xA78F48", Offset = "0xA78F48", VA = "0xA78F48")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170006D7")]
		public float BonusMultiplier
		{
			[Token(Token = "0x6002775")]
			[Address(RVA = "0xA78F74", Offset = "0xA78F74", VA = "0xA78F74")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170006D8")]
		public ImageSourceType ItemImageSourceType
		{
			[Token(Token = "0x6002776")]
			[Address(RVA = "0xA78FA0", Offset = "0xA78FA0", VA = "0xA78FA0")]
			get
			{
				return default(ImageSourceType);
			}
		}

		[Token(Token = "0x170006D9")]
		public string ItemImageSourcePath
		{
			[Token(Token = "0x6002777")]
			[Address(RVA = "0xA78FCC", Offset = "0xA78FCC", VA = "0xA78FCC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002778")]
		[Address(RVA = "0xA78FF8", Offset = "0xA78FF8", VA = "0xA78FF8")]
		public Product(RDProduct productData)
		{
		}

		[Token(Token = "0x6002779")]
		[Address(RVA = "0xA79024", Offset = "0xA79024", VA = "0xA79024")]
		public List<string> GetImageURLs()
		{
			return null;
		}

		[Token(Token = "0x600277A")]
		[Address(RVA = "0xA7917C", Offset = "0xA7917C", VA = "0xA7917C")]
		private string FormatDisplayText(string formatString)
		{
			return null;
		}

		[Token(Token = "0x600277B")]
		[Address(RVA = "0xA793D8", Offset = "0xA793D8", VA = "0xA793D8")]
		public string GetQuantityAdjustedDisplayName()
		{
			return null;
		}

		[Token(Token = "0x600277C")]
		[Address(RVA = "0xA79454", Offset = "0xA79454", VA = "0xA79454")]
		public string GetDisplayText(ProductDisplayTextType textType)
		{
			return null;
		}

		[Token(Token = "0x600277D")]
		[Address(RVA = "0xA794C0", Offset = "0xA794C0", VA = "0xA794C0", Slot = "4")]
		public virtual int GetPurchaseScaledQuantity()
		{
			return default(int);
		}
	}
}
