using Il2CppDummyDll;
using Uken.Framework.Casual;

namespace AM2.ReferenceData
{
	[Token(Token = "0x20003AB")]
	public interface ISubTabItemModel : IItemModel, IInfoText
	{
		[Token(Token = "0x17000545")]
		string reference
		{
			[Token(Token = "0x6001C6F")]
			get;
		}

		[Token(Token = "0x17000546")]
		SubTab subTab
		{
			[Token(Token = "0x6001C70")]
			get;
		}

		[Token(Token = "0x17000547")]
		SubTab researchableSubTab
		{
			[Token(Token = "0x6001C71")]
			get;
		}

		[Token(Token = "0x17000548")]
		Section section
		{
			[Token(Token = "0x6001C72")]
			get;
		}

		[Token(Token = "0x17000549")]
		Section researchableSection
		{
			[Token(Token = "0x6001C73")]
			get;
		}
	}
}
