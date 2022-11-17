using Il2CppDummyDll;

namespace Assets.AltUnityTester.AltUnityServer.Commands
{
	[Token(Token = "0x200059D")]
	internal class AltUnityFindActiveObjectsByNameCommand : AltUnityBaseClassFindObjectsCommand
	{
		[Token(Token = "0x4001A74")]
		[FieldOffset(Offset = "0x10")]
		private string methodParameters;

		[Token(Token = "0x6002AED")]
		[Address(RVA = "0xC149A4", Offset = "0xC149A4", VA = "0xC149A4")]
		public AltUnityFindActiveObjectsByNameCommand(string stringSent)
		{
		}

		[Token(Token = "0x6002AEE")]
		[Address(RVA = "0xC270D0", Offset = "0xC270D0", VA = "0xC270D0", Slot = "4")]
		public override string Execute()
		{
			return null;
		}
	}
}
