using Il2CppDummyDll;

namespace Assets.AltUnityTester.AltUnityServer.Commands
{
	[Token(Token = "0x20005A0")]
	internal class AltUnityFindObjectsCommand : AltUnityBaseClassFindObjectsCommand
	{
		[Token(Token = "0x4001A77")]
		[FieldOffset(Offset = "0x10")]
		private string stringSent;

		[Token(Token = "0x6002AF3")]
		[Address(RVA = "0xC14978", Offset = "0xC14978", VA = "0xC14978")]
		public AltUnityFindObjectsCommand(string stringSent)
		{
		}

		[Token(Token = "0x6002AF4")]
		[Address(RVA = "0xC29218", Offset = "0xC29218", VA = "0xC29218", Slot = "4")]
		public override string Execute()
		{
			return null;
		}
	}
}
