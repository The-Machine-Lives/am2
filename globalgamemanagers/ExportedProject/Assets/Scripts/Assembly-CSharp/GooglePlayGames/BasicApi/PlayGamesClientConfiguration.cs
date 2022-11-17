using System;
using System.Collections.Generic;
using GooglePlayGames.BasicApi.Multiplayer;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi
{
	[Token(Token = "0x20002E4")]
	public struct PlayGamesClientConfiguration
	{
		[Token(Token = "0x200079B")]
		public class Builder
		{
			[Serializable]
			[Token(Token = "0x2000898")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8217D8", Offset = "0x8217D8")]
			private sealed class _003C_003Ec
			{
				[Token(Token = "0x4002481")]
				[FieldOffset(Offset = "0x0")]
				public static readonly _003C_003Ec _003C_003E9;

				[Token(Token = "0x4002482")]
				[FieldOffset(Offset = "0x8")]
				public static InvitationReceivedDelegate _003C_003E9__30_0;

				[Token(Token = "0x4002483")]
				[FieldOffset(Offset = "0x10")]
				public static MatchDelegate _003C_003E9__30_1;

				[Token(Token = "0x60033F1")]
				[Address(RVA = "0x14650D4", Offset = "0x14650D4", VA = "0x14650D4")]
				public _003C_003Ec()
				{
				}

				[Token(Token = "0x60033F2")]
				[Address(RVA = "0x14650DC", Offset = "0x14650DC", VA = "0x14650DC")]
				internal void _003C_002Ector_003Eb__30_0(Invitation _003Cp0_003E, bool _003Cp1_003E)
				{
				}

				[Token(Token = "0x60033F3")]
				[Address(RVA = "0x14650E0", Offset = "0x14650E0", VA = "0x14650E0")]
				internal void _003C_002Ector_003Eb__30_1(TurnBasedMatch _003Cp0_003E, bool _003Cp1_003E)
				{
				}
			}

			[Token(Token = "0x400220A")]
			[FieldOffset(Offset = "0x10")]
			private bool mEnableSaveGames;

			[Token(Token = "0x400220B")]
			[FieldOffset(Offset = "0x18")]
			private List<string> mScopes;

			[Token(Token = "0x400220C")]
			[FieldOffset(Offset = "0x20")]
			private bool mHidePopups;

			[Token(Token = "0x400220D")]
			[FieldOffset(Offset = "0x21")]
			private bool mRequestAuthCode;

			[Token(Token = "0x400220E")]
			[FieldOffset(Offset = "0x22")]
			private bool mForceRefresh;

			[Token(Token = "0x400220F")]
			[FieldOffset(Offset = "0x23")]
			private bool mRequestEmail;

			[Token(Token = "0x4002210")]
			[FieldOffset(Offset = "0x24")]
			private bool mRequestIdToken;

			[Token(Token = "0x4002211")]
			[FieldOffset(Offset = "0x28")]
			private string mAccountName;

			[Token(Token = "0x4002212")]
			[FieldOffset(Offset = "0x30")]
			private InvitationReceivedDelegate mInvitationDelegate;

			[Token(Token = "0x4002213")]
			[FieldOffset(Offset = "0x38")]
			private MatchDelegate mMatchDelegate;

			[Token(Token = "0x600317F")]
			[Address(RVA = "0x1464EB0", Offset = "0x1464EB0", VA = "0x1464EB0")]
			public Builder EnableSavedGames()
			{
				return null;
			}

			[Token(Token = "0x6003180")]
			[Address(RVA = "0x1464EBC", Offset = "0x1464EBC", VA = "0x1464EBC")]
			public Builder EnableHidePopups()
			{
				return null;
			}

			[Token(Token = "0x6003181")]
			[Address(RVA = "0x1464EC8", Offset = "0x1464EC8", VA = "0x1464EC8")]
			public Builder RequestServerAuthCode(bool forceRefresh)
			{
				return null;
			}

			[Token(Token = "0x6003182")]
			[Address(RVA = "0x1464EDC", Offset = "0x1464EDC", VA = "0x1464EDC")]
			public Builder RequestEmail()
			{
				return null;
			}

			[Token(Token = "0x6003183")]
			[Address(RVA = "0x1464EE8", Offset = "0x1464EE8", VA = "0x1464EE8")]
			public Builder RequestIdToken()
			{
				return null;
			}

			[Token(Token = "0x6003184")]
			[Address(RVA = "0x1464EF4", Offset = "0x1464EF4", VA = "0x1464EF4")]
			public Builder SetAccountName(string accountName)
			{
				return null;
			}

			[Token(Token = "0x6003185")]
			[Address(RVA = "0x1464EFC", Offset = "0x1464EFC", VA = "0x1464EFC")]
			public Builder AddOauthScope(string scope)
			{
				return null;
			}

			[Token(Token = "0x6003186")]
			[Address(RVA = "0x1464FA0", Offset = "0x1464FA0", VA = "0x1464FA0")]
			public Builder WithInvitationDelegate(InvitationReceivedDelegate invitationDelegate)
			{
				return null;
			}

			[Token(Token = "0x6003187")]
			[Address(RVA = "0x1465008", Offset = "0x1465008", VA = "0x1465008")]
			public Builder WithMatchDelegate(MatchDelegate matchDelegate)
			{
				return null;
			}

			[Token(Token = "0x6003188")]
			[Address(RVA = "0x1464E94", Offset = "0x1464E94", VA = "0x1464E94")]
			public PlayGamesClientConfiguration Build()
			{
				return default(PlayGamesClientConfiguration);
			}

			[Token(Token = "0x6003189")]
			[Address(RVA = "0x1464B70", Offset = "0x1464B70", VA = "0x1464B70")]
			internal bool HasEnableSaveGames()
			{
				return default(bool);
			}

			[Token(Token = "0x600318A")]
			[Address(RVA = "0x1464C00", Offset = "0x1464C00", VA = "0x1464C00")]
			internal bool IsRequestingAuthCode()
			{
				return default(bool);
			}

			[Token(Token = "0x600318B")]
			[Address(RVA = "0x1464BF8", Offset = "0x1464BF8", VA = "0x1464BF8")]
			internal bool IsHidingPopups()
			{
				return default(bool);
			}

			[Token(Token = "0x600318C")]
			[Address(RVA = "0x1464C08", Offset = "0x1464C08", VA = "0x1464C08")]
			internal bool IsForcingRefresh()
			{
				return default(bool);
			}

			[Token(Token = "0x600318D")]
			[Address(RVA = "0x1464C10", Offset = "0x1464C10", VA = "0x1464C10")]
			internal bool IsRequestingEmail()
			{
				return default(bool);
			}

			[Token(Token = "0x600318E")]
			[Address(RVA = "0x1464C18", Offset = "0x1464C18", VA = "0x1464C18")]
			internal bool IsRequestingIdToken()
			{
				return default(bool);
			}

			[Token(Token = "0x600318F")]
			[Address(RVA = "0x1464C20", Offset = "0x1464C20", VA = "0x1464C20")]
			internal string GetAccountName()
			{
				return null;
			}

			[Token(Token = "0x6003190")]
			[Address(RVA = "0x1464B88", Offset = "0x1464B88", VA = "0x1464B88")]
			internal string[] getScopes()
			{
				return null;
			}

			[Token(Token = "0x6003191")]
			[Address(RVA = "0x1464B80", Offset = "0x1464B80", VA = "0x1464B80")]
			internal MatchDelegate GetMatchDelegate()
			{
				return null;
			}

			[Token(Token = "0x6003192")]
			[Address(RVA = "0x1464B78", Offset = "0x1464B78", VA = "0x1464B78")]
			internal InvitationReceivedDelegate GetInvitationDelegate()
			{
				return null;
			}

			[Token(Token = "0x6003193")]
			[Address(RVA = "0x1464D20", Offset = "0x1464D20", VA = "0x1464D20")]
			public Builder()
			{
			}
		}

		[Token(Token = "0x4000DAE")]
		[FieldOffset(Offset = "0x0")]
		public static readonly PlayGamesClientConfiguration DefaultConfiguration;

		[Token(Token = "0x4000DAF")]
		[FieldOffset(Offset = "0x0")]
		private readonly bool mEnableSavedGames;

		[Token(Token = "0x4000DB0")]
		[FieldOffset(Offset = "0x8")]
		private readonly string[] mScopes;

		[Token(Token = "0x4000DB1")]
		[FieldOffset(Offset = "0x10")]
		private readonly bool mRequestAuthCode;

		[Token(Token = "0x4000DB2")]
		[FieldOffset(Offset = "0x11")]
		private readonly bool mForceRefresh;

		[Token(Token = "0x4000DB3")]
		[FieldOffset(Offset = "0x12")]
		private readonly bool mHidePopups;

		[Token(Token = "0x4000DB4")]
		[FieldOffset(Offset = "0x13")]
		private readonly bool mRequestEmail;

		[Token(Token = "0x4000DB5")]
		[FieldOffset(Offset = "0x14")]
		private readonly bool mRequestIdToken;

		[Token(Token = "0x4000DB6")]
		[FieldOffset(Offset = "0x18")]
		private readonly string mAccountName;

		[Token(Token = "0x4000DB7")]
		[FieldOffset(Offset = "0x20")]
		private readonly InvitationReceivedDelegate mInvitationDelegate;

		[Token(Token = "0x4000DB8")]
		[FieldOffset(Offset = "0x28")]
		private readonly MatchDelegate mMatchDelegate;

		[Token(Token = "0x170002D2")]
		public bool EnableSavedGames
		{
			[Token(Token = "0x60016E0")]
			[Address(RVA = "0x8B43F4", Offset = "0x8B43F4", VA = "0x8B43F4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170002D3")]
		public bool IsHidingPopups
		{
			[Token(Token = "0x60016E1")]
			[Address(RVA = "0x8B43FC", Offset = "0x8B43FC", VA = "0x8B43FC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170002D4")]
		public bool IsRequestingAuthCode
		{
			[Token(Token = "0x60016E2")]
			[Address(RVA = "0x8B4404", Offset = "0x8B4404", VA = "0x8B4404")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170002D5")]
		public bool IsForcingRefresh
		{
			[Token(Token = "0x60016E3")]
			[Address(RVA = "0x8B440C", Offset = "0x8B440C", VA = "0x8B440C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170002D6")]
		public bool IsRequestingEmail
		{
			[Token(Token = "0x60016E4")]
			[Address(RVA = "0x8B4414", Offset = "0x8B4414", VA = "0x8B4414")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170002D7")]
		public bool IsRequestingIdToken
		{
			[Token(Token = "0x60016E5")]
			[Address(RVA = "0x8B441C", Offset = "0x8B441C", VA = "0x8B441C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170002D8")]
		public string AccountName
		{
			[Token(Token = "0x60016E6")]
			[Address(RVA = "0x8B4424", Offset = "0x8B4424", VA = "0x8B4424")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002D9")]
		public string[] Scopes
		{
			[Token(Token = "0x60016E7")]
			[Address(RVA = "0x8B442C", Offset = "0x8B442C", VA = "0x8B442C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002DA")]
		public InvitationReceivedDelegate InvitationDelegate
		{
			[Token(Token = "0x60016E8")]
			[Address(RVA = "0x8B4434", Offset = "0x8B4434", VA = "0x8B4434")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002DB")]
		public MatchDelegate MatchDelegate
		{
			[Token(Token = "0x60016E9")]
			[Address(RVA = "0x8B443C", Offset = "0x8B443C", VA = "0x8B443C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60016DF")]
		[Address(RVA = "0x8B43EC", Offset = "0x8B43EC", VA = "0x8B43EC")]
		private PlayGamesClientConfiguration(Builder builder)
		{
		}
	}
}
