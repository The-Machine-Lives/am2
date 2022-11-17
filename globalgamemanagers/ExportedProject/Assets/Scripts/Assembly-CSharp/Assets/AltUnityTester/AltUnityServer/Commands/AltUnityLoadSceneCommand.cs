using Il2CppDummyDll;
using UnityEngine;

namespace Assets.AltUnityTester.AltUnityServer.Commands
{
	[Token(Token = "0x20005CA")]
	internal class AltUnityLoadSceneCommand : AltUnityCommand
	{
		[Token(Token = "0x4001ABD")]
		[FieldOffset(Offset = "0x10")]
		private string scene;

		[Token(Token = "0x4001ABE")]
		[FieldOffset(Offset = "0x18")]
		private AltClientSocketHandler handler;

		[Token(Token = "0x6002B4A")]
		[Address(RVA = "0xC1465C", Offset = "0xC1465C", VA = "0xC1465C")]
		public AltUnityLoadSceneCommand(string scene, AltClientSocketHandler handler)
		{
		}

		[Token(Token = "0x6002B4B")]
		[Address(RVA = "0xC2C2E4", Offset = "0xC2C2E4", VA = "0xC2C2E4", Slot = "4")]
		public override string Execute()
		{
			return null;
		}

		[Token(Token = "0x6002B4C")]
		[Address(RVA = "0xC2C420", Offset = "0xC2C420", VA = "0xC2C420")]
		private void SceneLoaded(AsyncOperation obj)
		{
		}
	}
}
