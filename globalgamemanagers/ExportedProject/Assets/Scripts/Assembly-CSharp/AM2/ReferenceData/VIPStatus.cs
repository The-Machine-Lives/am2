using Il2CppDummyDll;
using Uken.Framework.Casual;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000399")]
	public class VIPStatus : RuntimeData<RDVIPStatus>, IItemModel, IInfoText
	{
		[Token(Token = "0x17000517")]
		public string readableItemName
		{
			[Token(Token = "0x6001C18")]
			[Address(RVA = "0x972F7C", Offset = "0x972F7C", VA = "0x972F7C", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000518")]
		public string description
		{
			[Token(Token = "0x6001C19")]
			[Address(RVA = "0x972FA8", Offset = "0x972FA8", VA = "0x972FA8", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000519")]
		public string researchInfoText
		{
			[Token(Token = "0x6001C1A")]
			[Address(RVA = "0x972FD4", Offset = "0x972FD4", VA = "0x972FD4", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700051A")]
		public string infoImageSource
		{
			[Token(Token = "0x6001C1B")]
			[Address(RVA = "0x97301C", Offset = "0x97301C", VA = "0x97301C", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001C17")]
		[Address(RVA = "0x972F2C", Offset = "0x972F2C", VA = "0x972F2C")]
		public VIPStatus()
		{
		}
	}
}
