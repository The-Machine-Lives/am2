using Il2CppDummyDll;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x2000558")]
	public class VIPTier
	{
		[Token(Token = "0x400197C")]
		[FieldOffset(Offset = "0x10")]
		protected RDVIPTier m_tierData;

		[Token(Token = "0x1700073C")]
		public string Reference
		{
			[Token(Token = "0x60028F0")]
			[Address(RVA = "0xAA0894", Offset = "0xAA0894", VA = "0xAA0894")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700073D")]
		public float PurchaseScaleMultiplier
		{
			[Token(Token = "0x60028F1")]
			[Address(RVA = "0xAA08C0", Offset = "0xAA08C0", VA = "0xAA08C0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700073E")]
		public float DailySpinnerMultiplier
		{
			[Token(Token = "0x60028F2")]
			[Address(RVA = "0xAA08EC", Offset = "0xAA08EC", VA = "0xAA08EC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700073F")]
		public int Tier
		{
			[Token(Token = "0x60028F3")]
			[Address(RVA = "0xA9F3C0", Offset = "0xA9F3C0", VA = "0xA9F3C0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000740")]
		public string SmallIconPath
		{
			[Token(Token = "0x60028F4")]
			[Address(RVA = "0xAA0918", Offset = "0xAA0918", VA = "0xAA0918")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000741")]
		public string LargeIconPath
		{
			[Token(Token = "0x60028F5")]
			[Address(RVA = "0xAA0944", Offset = "0xAA0944", VA = "0xAA0944")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000742")]
		public string TierName
		{
			[Token(Token = "0x60028F6")]
			[Address(RVA = "0xAA0970", Offset = "0xAA0970", VA = "0xAA0970")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000743")]
		public int RequiredVIPPoints
		{
			[Token(Token = "0x60028F7")]
			[Address(RVA = "0xAA099C", Offset = "0xAA099C", VA = "0xAA099C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60028F8")]
		[Address(RVA = "0xAA09C8", Offset = "0xAA09C8", VA = "0xAA09C8")]
		public VIPTier(RDVIPTier tierData)
		{
		}

		[Token(Token = "0x60028F9")]
		[Address(RVA = "0xAA09F4", Offset = "0xAA09F4", VA = "0xAA09F4")]
		public int GetMinLevel()
		{
			return default(int);
		}
	}
}
