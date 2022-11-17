using Il2CppDummyDll;

namespace Assets.AltUnityTester.AltUnityServer.Commands
{
	[Token(Token = "0x20005B6")]
	internal class AltUnityGetAllMethodsCommand : AltUnityReflectionMethodsCommand
	{
		[Token(Token = "0x4001A9B")]
		[FieldOffset(Offset = "0x10")]
		private AltUnityComponent component;

		[Token(Token = "0x4001A9C")]
		[FieldOffset(Offset = "0x20")]
		private AltUnityMethodSelection methodSelection;

		[Token(Token = "0x6002B20")]
		[Address(RVA = "0xC14780", Offset = "0xC14780", VA = "0xC14780")]
		public AltUnityGetAllMethodsCommand(AltUnityComponent component, AltUnityMethodSelection methodSelection)
		{
		}

		[Token(Token = "0x6002B21")]
		[Address(RVA = "0xC2A418", Offset = "0xC2A418", VA = "0xC2A418", Slot = "4")]
		public override string Execute()
		{
			return null;
		}
	}
}
