using Il2CppDummyDll;

namespace Com.Uken.Analog
{
	[Token(Token = "0x200004D")]
	public class AutomaticEventConfig
	{
		[Token(Token = "0x4000127")]
		public const string INSTALL_LOGS_ENABLED_PREF = "com_uken_analoginstall_logs_enabled";

		[Token(Token = "0x4000128")]
		[FieldOffset(Offset = "0x10")]
		private bool enableInstallLogs;

		[Token(Token = "0x1700007B")]
		public static bool InstallLogEnabled
		{
			[Token(Token = "0x6000206")]
			[Address(RVA = "0x16D5F58", Offset = "0x16D5F58", VA = "0x16D5F58")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x16D5F28", Offset = "0x16D5F28", VA = "0x16D5F28")]
		public AutomaticEventConfig(bool enableInstallLogs)
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x16D03F4", Offset = "0x16D03F4", VA = "0x16D03F4")]
		public void ApplyConfig()
		{
		}
	}
}
