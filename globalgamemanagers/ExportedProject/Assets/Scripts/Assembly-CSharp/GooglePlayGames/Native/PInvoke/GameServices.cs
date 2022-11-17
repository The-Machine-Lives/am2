using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	[Token(Token = "0x2000269")]
	internal class GameServices : BaseReferenceHolder
	{
		[Token(Token = "0x6001230")]
		[Address(RVA = "0xC743A0", Offset = "0xC743A0", VA = "0xC743A0")]
		internal GameServices(IntPtr selfPointer)
		{
		}

		[Token(Token = "0x6001231")]
		[Address(RVA = "0xC74414", Offset = "0xC74414", VA = "0xC74414")]
		internal bool IsAuthenticated()
		{
			return default(bool);
		}

		[Token(Token = "0x6001232")]
		[Address(RVA = "0xC7442C", Offset = "0xC7442C", VA = "0xC7442C")]
		internal void SignOut()
		{
		}

		[Token(Token = "0x6001233")]
		[Address(RVA = "0xC74444", Offset = "0xC74444", VA = "0xC74444")]
		internal void StartAuthorizationUI()
		{
		}

		[Token(Token = "0x6001234")]
		[Address(RVA = "0xC7445C", Offset = "0xC7445C", VA = "0xC7445C")]
		public AchievementManager AchievementManager()
		{
			return null;
		}

		[Token(Token = "0x6001235")]
		[Address(RVA = "0xC744BC", Offset = "0xC744BC", VA = "0xC744BC")]
		public LeaderboardManager LeaderboardManager()
		{
			return null;
		}

		[Token(Token = "0x6001236")]
		[Address(RVA = "0xC7458C", Offset = "0xC7458C", VA = "0xC7458C")]
		public PlayerManager PlayerManager()
		{
			return null;
		}

		[Token(Token = "0x6001237")]
		[Address(RVA = "0xC745F0", Offset = "0xC745F0", VA = "0xC745F0")]
		public StatsManager StatsManager()
		{
			return null;
		}

		[Token(Token = "0x6001238")]
		[Address(RVA = "0xC710D8", Offset = "0xC710D8", VA = "0xC710D8")]
		internal HandleRef AsHandle()
		{
			return default(HandleRef);
		}

		[Token(Token = "0x6001239")]
		[Address(RVA = "0xC74654", Offset = "0xC74654", VA = "0xC74654", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}
	}
}
