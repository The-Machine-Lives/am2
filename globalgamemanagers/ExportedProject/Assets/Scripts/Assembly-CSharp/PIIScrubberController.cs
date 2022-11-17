using System;
using Il2CppDummyDll;

[Token(Token = "0x2000208")]
public class PIIScrubberController
{
	[Token(Token = "0x2000669")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820648", Offset = "0x820648")]
	private sealed class _003C_003Ec__DisplayClass6_0
	{
		[Token(Token = "0x4001FA3")]
		[FieldOffset(Offset = "0x10")]
		public PIIScrubberController _003C_003E4__this;

		[Token(Token = "0x4001FA4")]
		[FieldOffset(Offset = "0x18")]
		public Action<bool> onComplete;

		[Token(Token = "0x4001FA5")]
		[FieldOffset(Offset = "0x20")]
		public Action<UnlinkResult> _003C_003E9__2;

		[Token(Token = "0x6002DBC")]
		[Address(RVA = "0x99F210", Offset = "0x99F210", VA = "0x99F210")]
		public _003C_003Ec__DisplayClass6_0()
		{
		}

		[Token(Token = "0x6002DBD")]
		[Address(RVA = "0x99F218", Offset = "0x99F218", VA = "0x99F218")]
		internal void _003CScrubPII_003Eb__0(string response)
		{
		}

		[Token(Token = "0x6002DBE")]
		[Address(RVA = "0x99F324", Offset = "0x99F324", VA = "0x99F324")]
		internal void _003CScrubPII_003Eb__2(UnlinkResult unlinkResult)
		{
		}

		[Token(Token = "0x6002DBF")]
		[Address(RVA = "0x99F39C", Offset = "0x99F39C", VA = "0x99F39C")]
		internal void _003CScrubPII_003Eb__1(long statusCode, string response)
		{
		}
	}

	[Token(Token = "0x4000B7B")]
	[FieldOffset(Offset = "0x10")]
	private bool lastScrubSuccess;

	[Token(Token = "0x4000B7C")]
	[FieldOffset(Offset = "0x18")]
	private PIIScrubberApiClient m_apiClient;

	[Token(Token = "0x4000B7D")]
	[FieldOffset(Offset = "0x20")]
	private PIIScrubberApiConfig m_apiConfig;

	[Token(Token = "0x4000B7E")]
	[FieldOffset(Offset = "0x28")]
	private AuthController m_authController;

	[Token(Token = "0x4000B7F")]
	[FieldOffset(Offset = "0x30")]
	private Action<bool> m_scrubCompleteCallback;

	[Token(Token = "0x6000DAF")]
	[Address(RVA = "0x99F024", Offset = "0x99F024", VA = "0x99F024")]
	public PIIScrubberController(AuthController authController, string gameID, string baseURL, string scrubAPIKey)
	{
	}

	[Token(Token = "0x6000DB0")]
	[Address(RVA = "0x99F0DC", Offset = "0x99F0DC", VA = "0x99F0DC")]
	public void ScrubPII(Action<bool> onComplete, string userID, string authToken)
	{
	}
}
