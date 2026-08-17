using Il2CppDummyDll;

namespace Assets.AltUnityTester.AltUnityServer.Commands
{
	[Token(Token = "0x200059F")]
	internal class AltUnityFindObjectCommand : AltUnityBaseClassFindObjectsCommand
	{
		[Token(Token = "0x4001A76")]
		[FieldOffset(Offset = "0x10")]
		private string stringSent;

		[Token(Token = "0x6002AF1")]
		[Address(RVA = "0xC1494C", Offset = "0xC1494C", VA = "0xC1494C")]
		public AltUnityFindObjectCommand(string stringSent)
		{
		}

		[Token(Token = "0x6002AF2")]
		[Address(RVA = "0xC27F7C", Offset = "0xC27F7C", VA = "0xC27F7C", Slot = "4")]
		public override string Execute()
		{
			return null;
		}
	}
}
