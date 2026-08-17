using Il2CppDummyDll;

namespace Com.Uken.Analog
{
	[Token(Token = "0x200004E")]
	public class InstallEventChecker
	{
		[Token(Token = "0x4000129")]
		private const string INSTALL_FLAG_PREF = "com_uken_analog_install_flag";

		[Token(Token = "0x1700007C")]
		public static bool ShouldSendInstallLog
		{
			[Token(Token = "0x6000208")]
			[Address(RVA = "0x16D1518", Offset = "0x16D1518", VA = "0x16D1518")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x16D1650", Offset = "0x16D1650", VA = "0x16D1650")]
		public static void MarkInstall()
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x16D95FC", Offset = "0x16D95FC", VA = "0x16D95FC")]
		public InstallEventChecker()
		{
		}
	}
}
