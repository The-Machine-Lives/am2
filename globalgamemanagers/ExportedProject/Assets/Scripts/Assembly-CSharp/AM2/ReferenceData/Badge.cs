using Il2CppDummyDll;
using Uken.Framework.Casual;

namespace AM2.ReferenceData
{
	[Token(Token = "0x200038F")]
	public class Badge : RuntimeData<RDBadge>, IItemModel, IInfoText
	{
		[Token(Token = "0x170004FB")]
		public string readableName
		{
			[Token(Token = "0x6001BE8")]
			[Address(RVA = "0x9AC644", Offset = "0x9AC644", VA = "0x9AC644")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004FC")]
		public string readableItemName
		{
			[Token(Token = "0x6001BE9")]
			[Address(RVA = "0x9AC670", Offset = "0x9AC670", VA = "0x9AC670", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004FD")]
		public string imageSource
		{
			[Token(Token = "0x6001BEA")]
			[Address(RVA = "0x9AC69C", Offset = "0x9AC69C", VA = "0x9AC69C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004FE")]
		public string description
		{
			[Token(Token = "0x6001BEB")]
			[Address(RVA = "0x9AC6C8", Offset = "0x9AC6C8", VA = "0x9AC6C8", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004FF")]
		public string researchInfoText
		{
			[Token(Token = "0x6001BEC")]
			[Address(RVA = "0x9AC718", Offset = "0x9AC718", VA = "0x9AC718", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000500")]
		public string infoImageSource
		{
			[Token(Token = "0x6001BED")]
			[Address(RVA = "0x9AC768", Offset = "0x9AC768", VA = "0x9AC768", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001BEE")]
		[Address(RVA = "0x9AC7B8", Offset = "0x9AC7B8", VA = "0x9AC7B8")]
		public Badge()
		{
		}
	}
}
