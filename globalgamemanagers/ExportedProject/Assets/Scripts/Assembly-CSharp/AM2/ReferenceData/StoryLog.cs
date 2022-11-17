using Il2CppDummyDll;
using Uken.Framework.Casual;

namespace AM2.ReferenceData
{
	[Token(Token = "0x20003A8")]
	public class StoryLog : RuntimeData<RDStoryLog>
	{
		[Token(Token = "0x17000542")]
		public string readableText
		{
			[Token(Token = "0x6001C66")]
			[Address(RVA = "0x9704CC", Offset = "0x9704CC", VA = "0x9704CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000543")]
		public string unlockItemRef
		{
			[Token(Token = "0x6001C67")]
			[Address(RVA = "0x9704F8", Offset = "0x9704F8", VA = "0x9704F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000544")]
		public int allTimeGenerationUnlockAmount
		{
			[Token(Token = "0x6001C68")]
			[Address(RVA = "0x970524", Offset = "0x970524", VA = "0x970524")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6001C69")]
		[Address(RVA = "0x970550", Offset = "0x970550", VA = "0x970550")]
		public StoryLog()
		{
		}
	}
}
