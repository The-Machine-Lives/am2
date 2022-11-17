using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Uken.Core;

namespace Uken.Library.AID
{
	[Token(Token = "0x200044C")]
	public class AIDRequest : WebRequest
	{
		[Token(Token = "0x6001FD4")]
		[Address(RVA = "0xAECA54", Offset = "0xAECA54", VA = "0xAECA54")]
		public AIDRequest(string endpoint, string name, string email, string guid, string category, string subject, string text, string game_name, Action<WebResponse, WebRequest> onComplete, [Optional] string level, [Optional] string platform, [Optional] string user_agent, [Optional] string user_stats, [Optional] string version)
		{
		}
	}
}
