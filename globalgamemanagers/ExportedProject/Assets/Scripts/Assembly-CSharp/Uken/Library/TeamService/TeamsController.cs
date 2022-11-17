using System;
using Il2CppDummyDll;
using Uken.Core;

namespace Uken.Library.TeamService
{
	[Token(Token = "0x20003EA")]
	public class TeamsController : UkenController
	{
		[Token(Token = "0x20007BC")]
		public delegate string GetUserIDFunc();

		[Token(Token = "0x20007BD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821008", Offset = "0x821008")]
		private sealed class _003C_003Ec__DisplayClass5_0
		{
			[Token(Token = "0x4002298")]
			[FieldOffset(Offset = "0x10")]
			public Action<TeamErrorCode, TeamResponse> onComplete;

			[Token(Token = "0x60031F9")]
			[Address(RVA = "0xB3E0F0", Offset = "0xB3E0F0", VA = "0xB3E0F0")]
			public _003C_003Ec__DisplayClass5_0()
			{
			}

			[Token(Token = "0x60031FA")]
			[Address(RVA = "0xB3E514", Offset = "0xB3E514", VA = "0xB3E514")]
			internal void _003CGetTeamAssignment_003Eb__0(WebResponse response, WebRequest request)
			{
			}
		}

		[Token(Token = "0x400126D")]
		[FieldOffset(Offset = "0x18")]
		private GetUserIDFunc m_GetUserID;

		[Token(Token = "0x400126E")]
		[FieldOffset(Offset = "0x20")]
		private string m_endpoint;

		[Token(Token = "0x400126F")]
		[FieldOffset(Offset = "0x28")]
		private Action<WebRequest> m_webInterfaceCB;

		[Token(Token = "0x6001E3E")]
		[Address(RVA = "0xB3DF34", Offset = "0xB3DF34", VA = "0xB3DF34")]
		public TeamsController(string endpoint, GetUserIDFunc getUserID, Action<WebRequest> webInterfaceCB)
		{
		}

		[Token(Token = "0x6001E3F")]
		[Address(RVA = "0xB3DF74", Offset = "0xB3DF74", VA = "0xB3DF74")]
		public void GetTeamAssignment(TeamEventInfo eventInfo, Action<TeamErrorCode, TeamResponse> onComplete, string entityID = "")
		{
		}
	}
}
