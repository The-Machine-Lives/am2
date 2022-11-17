using Il2CppDummyDll;
using Uken.Framework.Casual;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000393")]
	public class Title : RuntimeData<RDTitle>, IItemModel, IInfoText, IReadable
	{
		[Token(Token = "0x1700050F")]
		public string readableName
		{
			[Token(Token = "0x6001C03")]
			[Address(RVA = "0x971658", Offset = "0x971658", VA = "0x971658", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000510")]
		public string readableItemName
		{
			[Token(Token = "0x6001C04")]
			[Address(RVA = "0x971684", Offset = "0x971684", VA = "0x971684", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000511")]
		public string description
		{
			[Token(Token = "0x6001C05")]
			[Address(RVA = "0x9716F4", Offset = "0x9716F4", VA = "0x9716F4", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000512")]
		public string researchInfoText
		{
			[Token(Token = "0x6001C06")]
			[Address(RVA = "0x971744", Offset = "0x971744", VA = "0x971744", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000513")]
		public string infoImageSource
		{
			[Token(Token = "0x6001C07")]
			[Address(RVA = "0x971794", Offset = "0x971794", VA = "0x971794", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001C08")]
		[Address(RVA = "0x9717E4", Offset = "0x9717E4", VA = "0x9717E4")]
		public Title()
		{
		}
	}
}
