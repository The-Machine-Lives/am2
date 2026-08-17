using System;
using Il2CppDummyDll;

namespace GooglePlayGames
{
	[Token(Token = "0x200024A")]
	internal delegate void ReportProgress(string id, double progress, Action<bool> callback);
}
