using Il2CppDummyDll;

namespace Assets.AltUnityTester.AltUnityServer.Commands
{
	[Token(Token = "0x200059E")]
	internal class AltUnityFindAllObjectsCommand : AltUnityCommand
	{
		[Token(Token = "0x4001A75")]
		[FieldOffset(Offset = "0x10")]
		private string methodParameter;

		[Token(Token = "0x6002AEF")]
		[Address(RVA = "0xC14330", Offset = "0xC14330", VA = "0xC14330")]
		public AltUnityFindAllObjectsCommand(string methodParameter)
		{
		}

		[Token(Token = "0x6002AF0")]
		[Address(RVA = "0xC274FC", Offset = "0xC274FC", VA = "0xC274FC", Slot = "4")]
		public override string Execute()
		{
			return null;
		}
	}
}
