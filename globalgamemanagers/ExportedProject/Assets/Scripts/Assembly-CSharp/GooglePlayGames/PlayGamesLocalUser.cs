using System;
using GooglePlayGames.BasicApi;
using Il2CppDummyDll;
using UnityEngine.SocialPlatforms;

namespace GooglePlayGames
{
	[Token(Token = "0x200024D")]
	public class PlayGamesLocalUser : PlayGamesUserProfile, ILocalUser, IUserProfile
	{
		[Token(Token = "0x2000681")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820718", Offset = "0x820718")]
		private sealed class _003C_003Ec__DisplayClass28_0
		{
			[Token(Token = "0x4001FDE")]
			[FieldOffset(Offset = "0x10")]
			public PlayGamesLocalUser _003C_003E4__this;

			[Token(Token = "0x4001FDF")]
			[FieldOffset(Offset = "0x18")]
			public Action<CommonStatusCodes, PlayerStats> callback;

			[Token(Token = "0x6002E27")]
			[Address(RVA = "0xE70B00", Offset = "0xE70B00", VA = "0xE70B00")]
			public _003C_003Ec__DisplayClass28_0()
			{
			}

			[Token(Token = "0x6002E28")]
			[Address(RVA = "0xE70CC0", Offset = "0xE70CC0", VA = "0xE70CC0")]
			internal void _003CGetStats_003Eb__0(CommonStatusCodes rc, PlayerStats stats)
			{
			}
		}

		[Token(Token = "0x4000CCF")]
		[FieldOffset(Offset = "0x38")]
		internal PlayGamesPlatform mPlatform;

		[Token(Token = "0x4000CD0")]
		[FieldOffset(Offset = "0x40")]
		private string emailAddress;

		[Token(Token = "0x4000CD1")]
		[FieldOffset(Offset = "0x48")]
		private PlayerStats mStats;

		[Token(Token = "0x1700027F")]
		public IUserProfile[] friends
		{
			[Token(Token = "0x60010C6")]
			[Address(RVA = "0xE6FEAC", Offset = "0xE6FEAC", VA = "0xE6FEAC", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000280")]
		public bool authenticated
		{
			[Token(Token = "0x60010C8")]
			[Address(RVA = "0xE70104", Offset = "0xE70104", VA = "0xE70104", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000281")]
		public bool underage
		{
			[Token(Token = "0x60010C9")]
			[Address(RVA = "0xE701F0", Offset = "0xE701F0", VA = "0xE701F0", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000282")]
		public new string userName
		{
			[Token(Token = "0x60010CA")]
			[Address(RVA = "0xE701F8", Offset = "0xE701F8", VA = "0xE701F8", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000283")]
		public new string id
		{
			[Token(Token = "0x60010CB")]
			[Address(RVA = "0xE70660", Offset = "0xE70660", VA = "0xE70660", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000284")]
		public new bool isFriend
		{
			[Token(Token = "0x60010CC")]
			[Address(RVA = "0xE7075C", Offset = "0xE7075C", VA = "0xE7075C", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000285")]
		public new UserState state
		{
			[Token(Token = "0x60010CD")]
			[Address(RVA = "0xE70764", Offset = "0xE70764", VA = "0xE70764", Slot = "16")]
			get
			{
				return default(UserState);
			}
		}

		[Token(Token = "0x17000286")]
		public new string AvatarURL
		{
			[Token(Token = "0x60010CE")]
			[Address(RVA = "0xE7076C", Offset = "0xE7076C", VA = "0xE7076C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000287")]
		public string Email
		{
			[Token(Token = "0x60010CF")]
			[Address(RVA = "0xE70860", Offset = "0xE70860", VA = "0xE70860")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60010C0")]
		[Address(RVA = "0xE6F96C", Offset = "0xE6F96C", VA = "0xE6F96C")]
		internal PlayGamesLocalUser(PlayGamesPlatform plaf)
		{
		}

		[Token(Token = "0x60010C1")]
		[Address(RVA = "0xE6FA44", Offset = "0xE6FA44", VA = "0xE6FA44", Slot = "9")]
		public void Authenticate(Action<bool> callback)
		{
		}

		[Token(Token = "0x60010C2")]
		[Address(RVA = "0xE6FA84", Offset = "0xE6FA84", VA = "0xE6FA84", Slot = "11")]
		public void Authenticate(Action<bool, string> callback)
		{
		}

		[Token(Token = "0x60010C3")]
		[Address(RVA = "0xE6FAC4", Offset = "0xE6FAC4", VA = "0xE6FAC4")]
		public void Authenticate(Action<bool> callback, bool silent)
		{
		}

		[Token(Token = "0x60010C4")]
		[Address(RVA = "0xE6FBC4", Offset = "0xE6FBC4", VA = "0xE6FBC4")]
		public void Authenticate(Action<bool, string> callback, bool silent)
		{
		}

		[Token(Token = "0x60010C5")]
		[Address(RVA = "0xE6FD3C", Offset = "0xE6FD3C", VA = "0xE6FD3C", Slot = "12")]
		public void LoadFriends(Action<bool> callback)
		{
		}

		[Token(Token = "0x60010C7")]
		[Address(RVA = "0xE6FFE8", Offset = "0xE6FFE8", VA = "0xE6FFE8")]
		public string GetIdToken()
		{
			return null;
		}

		[Token(Token = "0x60010D0")]
		[Address(RVA = "0xE709D4", Offset = "0xE709D4", VA = "0xE709D4")]
		public void GetStats(Action<CommonStatusCodes, PlayerStats> callback)
		{
		}
	}
}
