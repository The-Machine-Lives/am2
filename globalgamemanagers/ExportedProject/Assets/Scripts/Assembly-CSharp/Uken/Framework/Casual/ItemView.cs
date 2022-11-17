using Il2CppDummyDll;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x2000505")]
	public class ItemView
	{
		[Token(Token = "0x40017A7")]
		[FieldOffset(Offset = "0x10")]
		private RDItem m_itemData;

		[Token(Token = "0x40017A8")]
		[FieldOffset(Offset = "0x18")]
		private IRuntimeItemController m_runtimeItemCntrl;

		[Token(Token = "0x40017A9")]
		[FieldOffset(Offset = "0x20")]
		private string m_generatedReference;

		[Token(Token = "0x17000698")]
		public string LargeImage
		{
			[Token(Token = "0x600266C")]
			[Address(RVA = "0xA6B9F4", Offset = "0xA6B9F4", VA = "0xA6B9F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000699")]
		public string SmallImage
		{
			[Token(Token = "0x600266D")]
			[Address(RVA = "0xA6BA20", Offset = "0xA6BA20", VA = "0xA6BA20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700069A")]
		public string Name
		{
			[Token(Token = "0x600266E")]
			[Address(RVA = "0xA6BA4C", Offset = "0xA6BA4C", VA = "0xA6BA4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700069B")]
		public string NamePlural
		{
			[Token(Token = "0x600266F")]
			[Address(RVA = "0xA6BA78", Offset = "0xA6BA78", VA = "0xA6BA78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700069C")]
		public int FrameStyle
		{
			[Token(Token = "0x6002670")]
			[Address(RVA = "0xA6BAA4", Offset = "0xA6BAA4", VA = "0xA6BAA4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700069D")]
		private string Reference
		{
			[Token(Token = "0x6002671")]
			[Address(RVA = "0xA6BAD0", Offset = "0xA6BAD0", VA = "0xA6BAD0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002672")]
		[Address(RVA = "0xA6AB0C", Offset = "0xA6AB0C", VA = "0xA6AB0C")]
		public ItemView(RDItem itemData, IRuntimeItemController runtimeItemCntrl)
		{
		}

		[Token(Token = "0x6002673")]
		[Address(RVA = "0xA6AB44", Offset = "0xA6AB44", VA = "0xA6AB44")]
		public ItemView(string reference, RDItem itemData)
		{
		}

		[Token(Token = "0x6002674")]
		[Address(RVA = "0xA6BAFC", Offset = "0xA6BAFC", VA = "0xA6BAFC")]
		public string GetReference()
		{
			return null;
		}

		[Token(Token = "0x6002675")]
		[Address(RVA = "0xA6BB74", Offset = "0xA6BB74", VA = "0xA6BB74")]
		public string GetName(long quantity)
		{
			return null;
		}

		[Token(Token = "0x6002676")]
		[Address(RVA = "0xA6BBC0", Offset = "0xA6BBC0", VA = "0xA6BBC0")]
		public FinalizedReward GetFinalRewards(long quantity)
		{
			return null;
		}

		[Token(Token = "0x6002677")]
		[Address(RVA = "0xA6BD68", Offset = "0xA6BD68", VA = "0xA6BD68")]
		public bool IsLevelledItem()
		{
			return default(bool);
		}

		[Token(Token = "0x6002678")]
		[Address(RVA = "0xA6BD9C", Offset = "0xA6BD9C", VA = "0xA6BD9C")]
		public void GetLevelDelta(long quantityDelta, bool isPostTransaction, out ItemLevelState beforeState, out ItemLevelState afterState)
		{
		}

		[Token(Token = "0x6002679")]
		[Address(RVA = "0xA6BC7C", Offset = "0xA6BC7C", VA = "0xA6BC7C")]
		private RuntimeItem GetRuntimeItem()
		{
			return null;
		}
	}
}
