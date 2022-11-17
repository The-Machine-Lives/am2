using Il2CppDummyDll;

namespace Firebase.Platform.Default
{
	[Token(Token = "0x2000015")]
	internal class BaseAuthService : IAuthService
	{
		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x0")]
		private static BaseAuthService _instance;

		[Token(Token = "0x1700001A")]
		public static BaseAuthService BaseInstance
		{
			[Token(Token = "0x600005E")]
			[Address(RVA = "0x17CFB8C", Offset = "0x17CFB8C", VA = "0x17CFB8C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x17CFB84", Offset = "0x17CFB84", VA = "0x17CFB84")]
		protected BaseAuthService()
		{
		}
	}
}
