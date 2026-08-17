using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Uken.Library.Authentication
{
	[Serializable]
	[Token(Token = "0x200048D")]
	public class UkenAuthCredential
	{
		[Token(Token = "0x40014C4")]
		[FieldOffset(Offset = "0x10")]
		private string filePath;

		[Token(Token = "0x40014C5")]
		[FieldOffset(Offset = "0x18")]
		public string user_id;

		[Token(Token = "0x40014C6")]
		[FieldOffset(Offset = "0x20")]
		public bool is_native_auth_connected;

		[Token(Token = "0x40014C7")]
		[FieldOffset(Offset = "0x28")]
		public string credential;

		[Token(Token = "0x40014C8")]
		[FieldOffset(Offset = "0x30")]
		public string access_token;

		[Token(Token = "0x40014C9")]
		[FieldOffset(Offset = "0x38")]
		public string refresh_token;

		[Token(Token = "0x40014CA")]
		[FieldOffset(Offset = "0x40")]
		public bool is_valid;

		[Token(Token = "0x40014CB")]
		[FieldOffset(Offset = "0x48")]
		public double expiration_time;

		[Token(Token = "0x40014CC")]
		[FieldOffset(Offset = "0x50")]
		public double issue_time;

		[Token(Token = "0x40014CD")]
		[FieldOffset(Offset = "0x58")]
		public long userCreationDateTime;

		[Token(Token = "0x40014CE")]
		[FieldOffset(Offset = "0x60")]
		[JsonIgnore]
		public long login_time;

		[Token(Token = "0x40014CF")]
		[FieldOffset(Offset = "0x68")]
		[JsonIgnore]
		public string googlePlayAuthCode;

		[Token(Token = "0x6002158")]
		[Address(RVA = "0xAFB634", Offset = "0xAFB634", VA = "0xAFB634")]
		public UkenAuthCredential(string credentialFilePath)
		{
		}

		[Token(Token = "0x6002159")]
		[Address(RVA = "0xAFB6A4", Offset = "0xAFB6A4", VA = "0xAFB6A4")]
		public void Load()
		{
		}

		[Token(Token = "0x600215A")]
		[Address(RVA = "0xAFB6B0", Offset = "0xAFB6B0", VA = "0xAFB6B0")]
		public void Save()
		{
		}

		[Token(Token = "0x600215B")]
		[Address(RVA = "0xAFB6BC", Offset = "0xAFB6BC", VA = "0xAFB6BC", Slot = "4")]
		protected virtual void LoadGameCredentialData()
		{
		}

		[Token(Token = "0x600215C")]
		[Address(RVA = "0xAFB874", Offset = "0xAFB874", VA = "0xAFB874", Slot = "5")]
		protected virtual void SaveGameCredential()
		{
		}

		[Token(Token = "0x600215D")]
		[Address(RVA = "0xAFB9C0", Offset = "0xAFB9C0", VA = "0xAFB9C0")]
		public void RemoveFacebookLink(string newJSON)
		{
		}

		[Token(Token = "0x600215E")]
		[Address(RVA = "0xAFB9C4", Offset = "0xAFB9C4", VA = "0xAFB9C4")]
		public FacebookLinkStatus ApplyFacebookLink(string newJSON)
		{
			return default(FacebookLinkStatus);
		}

		[Token(Token = "0x600215F")]
		[Address(RVA = "0xAFBB94", Offset = "0xAFBB94", VA = "0xAFBB94")]
		public void SetNativeAuthed(bool nativeAuthed)
		{
		}

		[Token(Token = "0x6002160")]
		[Address(RVA = "0xAFBBA8", Offset = "0xAFBBA8", VA = "0xAFBBA8")]
		public void ApplyGuestCredential(string inCredential)
		{
		}

		[Token(Token = "0x6002161")]
		[Address(RVA = "0xAFBBE8", Offset = "0xAFBBE8", VA = "0xAFBBE8")]
		public void ApplyCredential(string newJSON, bool nativeAuthConnected)
		{
		}

		[Token(Token = "0x6002162")]
		[Address(RVA = "0xAFC058", Offset = "0xAFC058", VA = "0xAFC058")]
		public bool ParseAuthRefreshJSON(string newJSON)
		{
			return default(bool);
		}
	}
}
