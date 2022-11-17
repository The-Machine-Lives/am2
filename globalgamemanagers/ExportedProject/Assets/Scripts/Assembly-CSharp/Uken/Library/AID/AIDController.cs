using System;
using Il2CppDummyDll;
using Uken.Core;

namespace Uken.Library.AID
{
	[Token(Token = "0x200044D")]
	public class AIDController : UkenController
	{
		[Token(Token = "0x20007FE")]
		private class AIDResponse
		{
			[Token(Token = "0x400231B")]
			[FieldOffset(Offset = "0x10")]
			public string caseId;

			[Token(Token = "0x400231C")]
			[FieldOffset(Offset = "0x18")]
			public string userId;

			[Token(Token = "0x60032AC")]
			[Address(RVA = "0xAECED4", Offset = "0xAECED4", VA = "0xAECED4")]
			public AIDResponse()
			{
			}
		}

		[Token(Token = "0x20007FF")]
		public delegate string GetUserIDFunc();

		[Token(Token = "0x2000800")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8211E8", Offset = "0x8211E8")]
		private sealed class _003C_003Ec__DisplayClass9_0
		{
			[Token(Token = "0x400231D")]
			[FieldOffset(Offset = "0x10")]
			public Action<bool, string> onComplete;

			[Token(Token = "0x60032B1")]
			[Address(RVA = "0xAEC630", Offset = "0xAEC630", VA = "0xAEC630")]
			public _003C_003Ec__DisplayClass9_0()
			{
			}

			[Token(Token = "0x60032B2")]
			[Address(RVA = "0xAECD94", Offset = "0xAECD94", VA = "0xAECD94")]
			internal void _003CSendFeedback_003Eb__0(WebResponse response, WebRequest request)
			{
			}
		}

		[Token(Token = "0x40013F7")]
		[FieldOffset(Offset = "0x18")]
		private string m_endpoint;

		[Token(Token = "0x40013F8")]
		[FieldOffset(Offset = "0x20")]
		private Action<WebRequest> m_WebSend;

		[Token(Token = "0x40013F9")]
		[FieldOffset(Offset = "0x28")]
		private GetUserIDFunc m_GetUserID;

		[Token(Token = "0x40013FA")]
		[FieldOffset(Offset = "0x30")]
		private string m_GameName;

		[Token(Token = "0x40013FB")]
		[FieldOffset(Offset = "0x38")]
		private string m_AppVersion;

		[Token(Token = "0x6001FD5")]
		[Address(RVA = "0xAEC410", Offset = "0xAEC410", VA = "0xAEC410")]
		public AIDController(string endpoint, string gameName, string appVersion, GetUserIDFunc getUserID, Action<WebRequest> webSend)
		{
		}

		[Token(Token = "0x6001FD6")]
		[Address(RVA = "0xAEC4B4", Offset = "0xAEC4B4", VA = "0xAEC4B4")]
		public void SetAIDEndpoint(string endpoint)
		{
		}

		[Token(Token = "0x6001FD7")]
		[Address(RVA = "0xAEC4BC", Offset = "0xAEC4BC", VA = "0xAEC4BC")]
		public void SendFeedback(string name, string email, string feedback, string category, string subject, Action<bool, string> onComplete)
		{
		}
	}
}
