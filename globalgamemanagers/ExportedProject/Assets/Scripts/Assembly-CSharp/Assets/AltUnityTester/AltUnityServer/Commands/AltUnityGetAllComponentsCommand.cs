using Il2CppDummyDll;

namespace Assets.AltUnityTester.AltUnityServer.Commands
{
	[Token(Token = "0x20005B4")]
	internal class AltUnityGetAllComponentsCommand : AltUnityCommand
	{
		[Token(Token = "0x4001A98")]
		[FieldOffset(Offset = "0x10")]
		private string objectID;

		[Token(Token = "0x6002B1C")]
		[Address(RVA = "0xC14714", Offset = "0xC14714", VA = "0xC14714")]
		public AltUnityGetAllComponentsCommand(string objectID)
		{
		}

		[Token(Token = "0x6002B1D")]
		[Address(RVA = "0xC29DA0", Offset = "0xC29DA0", VA = "0xC29DA0", Slot = "4")]
		public override string Execute()
		{
			return null;
		}
	}
}
