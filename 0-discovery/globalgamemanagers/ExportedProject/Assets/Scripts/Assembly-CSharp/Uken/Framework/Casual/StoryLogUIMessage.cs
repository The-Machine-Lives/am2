using System.Collections.Generic;
using Il2CppDummyDll;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x20004BE")]
	public class StoryLogUIMessage
	{
		[Token(Token = "0x400163B")]
		[FieldOffset(Offset = "0x10")]
		public List<string> unseenStoryLogs;

		[Token(Token = "0x60023D5")]
		[Address(RVA = "0xA990C4", Offset = "0xA990C4", VA = "0xA990C4")]
		public StoryLogUIMessage()
		{
		}
	}
}
