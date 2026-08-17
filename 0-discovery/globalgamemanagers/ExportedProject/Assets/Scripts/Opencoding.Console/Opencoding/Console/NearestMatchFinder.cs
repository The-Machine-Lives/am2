using System.Collections.Generic;
using Il2CppDummyDll;
using Opencoding.LogHistory;

namespace Opencoding.Console
{
	[Token(Token = "0x200000B")]
	internal class NearestMatchFinder : IComparer<LogHistoryItem>
	{
		[Token(Token = "0x6000070")]
		[Address(RVA = "0xE8FA8C", Offset = "0xE8FA8C", VA = "0xE8FA8C", Slot = "4")]
		public int Compare(LogHistoryItem x, LogHistoryItem y)
		{
			return default(int);
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0xE82890", Offset = "0xE82890", VA = "0xE82890")]
		public NearestMatchFinder()
		{
		}
	}
}
