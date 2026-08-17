using Il2CppDummyDll;

namespace Uken.Framework.Casual.Leaderboards
{
	[Token(Token = "0x200058F")]
	public class LeaderboardDefinition
	{
		[Token(Token = "0x4001A5C")]
		private const string LEADERBOARD_SEPARATOR = "|";

		[Token(Token = "0x4001A5D")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x832C60", Offset = "0x832C60")]
		private string _003Cm_parentReference_003Ek__BackingField;

		[Token(Token = "0x4001A5E")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x832C70", Offset = "0x832C70")]
		private int _003Cm_startTimeInUnixSeconds_003Ek__BackingField;

		[Token(Token = "0x4001A5F")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x832C80", Offset = "0x832C80")]
		private string _003Cm_leaderboardSource_003Ek__BackingField;

		[Token(Token = "0x4001A60")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x832C90", Offset = "0x832C90")]
		private EventSchedule _003Cm_leaderboardSchedule_003Ek__BackingField;

		[Token(Token = "0x4001A61")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x832CA0", Offset = "0x832CA0")]
		private bool _003Cm_isValid_003Ek__BackingField;

		[Token(Token = "0x4001A62")]
		[FieldOffset(Offset = "0x38")]
		private string m_leaderboardName;

		[Token(Token = "0x17000772")]
		public string m_parentReference
		{
			[Token(Token = "0x6002A82")]
			[Address(RVA = "0xA70FB4", Offset = "0xA70FB4", VA = "0xA70FB4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A8EC", Offset = "0x83A8EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002A83")]
			[Address(RVA = "0xA70FBC", Offset = "0xA70FBC", VA = "0xA70FBC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A8FC", Offset = "0x83A8FC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000773")]
		public int m_startTimeInUnixSeconds
		{
			[Token(Token = "0x6002A84")]
			[Address(RVA = "0xA70FC4", Offset = "0xA70FC4", VA = "0xA70FC4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A90C", Offset = "0x83A90C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6002A85")]
			[Address(RVA = "0xA70FCC", Offset = "0xA70FCC", VA = "0xA70FCC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A91C", Offset = "0x83A91C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000774")]
		public string m_leaderboardSource
		{
			[Token(Token = "0x6002A86")]
			[Address(RVA = "0xA70210", Offset = "0xA70210", VA = "0xA70210")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A92C", Offset = "0x83A92C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002A87")]
			[Address(RVA = "0xA70FD4", Offset = "0xA70FD4", VA = "0xA70FD4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A93C", Offset = "0x83A93C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000775")]
		public EventSchedule m_leaderboardSchedule
		{
			[Token(Token = "0x6002A88")]
			[Address(RVA = "0xA70218", Offset = "0xA70218", VA = "0xA70218")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A94C", Offset = "0x83A94C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002A89")]
			[Address(RVA = "0xA70FDC", Offset = "0xA70FDC", VA = "0xA70FDC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A95C", Offset = "0x83A95C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000776")]
		public bool m_isValid
		{
			[Token(Token = "0x6002A8A")]
			[Address(RVA = "0xA707D0", Offset = "0xA707D0", VA = "0xA707D0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A96C", Offset = "0x83A96C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002A8B")]
			[Address(RVA = "0xA70FE4", Offset = "0xA70FE4", VA = "0xA70FE4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A97C", Offset = "0x83A97C")]
			private set
			{
			}
		}

		[Token(Token = "0x6002A7F")]
		[Address(RVA = "0xA70D18", Offset = "0xA70D18", VA = "0xA70D18")]
		public static LeaderboardDefinition CreateLeaderboardDefinitionFromRefData(string parentReference, string leaderboardSource, EventSchedule leaderboardSchedule)
		{
			return null;
		}

		[Token(Token = "0x6002A80")]
		[Address(RVA = "0xA70760", Offset = "0xA70760", VA = "0xA70760")]
		public static LeaderboardDefinition CreateLeaderboardDefinitionFromRemote(string leaderboardName, string leaderboardSource)
		{
			return null;
		}

		[Token(Token = "0x6002A81")]
		[Address(RVA = "0xA70F08", Offset = "0xA70F08", VA = "0xA70F08")]
		public static string LeaderboardNameStripped(string leaderboardName)
		{
			return null;
		}

		[Token(Token = "0x6002A8C")]
		[Address(RVA = "0xA701EC", Offset = "0xA701EC", VA = "0xA701EC")]
		public string GetRefreshedLeaderboardName()
		{
			return null;
		}

		[Token(Token = "0x6002A8D")]
		[Address(RVA = "0xA70D90", Offset = "0xA70D90", VA = "0xA70D90")]
		protected LeaderboardDefinition(string parentReference, string leaderboardSource, EventSchedule leaderboardSchedule)
		{
		}

		[Token(Token = "0x6002A8E")]
		[Address(RVA = "0xA70E38", Offset = "0xA70E38", VA = "0xA70E38")]
		protected LeaderboardDefinition(string leaderboardName, string leaderboardSource)
		{
		}

		[Token(Token = "0x6002A8F")]
		[Address(RVA = "0xA70FF0", Offset = "0xA70FF0", VA = "0xA70FF0")]
		public void RefreshLeaderboardName()
		{
		}
	}
}
