using Il2CppDummyDll;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x20004A1")]
	public class BattleReport
	{
		[Token(Token = "0x400153E")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82EA4C", Offset = "0x82EA4C")]
		private readonly EBattleReportType _003CreportType_003Ek__BackingField;

		[Token(Token = "0x400153F")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82EA5C", Offset = "0x82EA5C")]
		private readonly string _003CreportString_003Ek__BackingField;

		[Token(Token = "0x170005DF")]
		public EBattleReportType reportType
		{
			[Token(Token = "0x6002204")]
			[Address(RVA = "0xA26104", Offset = "0xA26104", VA = "0xA26104")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x839514", Offset = "0x839514")]
			get
			{
				return default(EBattleReportType);
			}
		}

		[Token(Token = "0x170005E0")]
		public string reportString
		{
			[Token(Token = "0x6002205")]
			[Address(RVA = "0xA2610C", Offset = "0xA2610C", VA = "0xA2610C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x839524", Offset = "0x839524")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002206")]
		[Address(RVA = "0xA26114", Offset = "0xA26114", VA = "0xA26114")]
		public BattleReport(EBattleReportType inReportType, string inReportString)
		{
		}
	}
}
