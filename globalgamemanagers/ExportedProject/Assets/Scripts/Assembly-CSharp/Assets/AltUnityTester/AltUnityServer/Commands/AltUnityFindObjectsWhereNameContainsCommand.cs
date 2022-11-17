using Il2CppDummyDll;
using UnityEngine;

namespace Assets.AltUnityTester.AltUnityServer.Commands
{
	[Token(Token = "0x20005BF")]
	internal class AltUnityFindObjectsWhereNameContainsCommand : AltUnityCommand
	{
		[Token(Token = "0x2000873")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8216B8", Offset = "0x8216B8")]
		private sealed class _003C_003Ec__DisplayClass2_0
		{
			[Token(Token = "0x4002423")]
			[FieldOffset(Offset = "0x10")]
			public string cameraName;

			[Token(Token = "0x60033BC")]
			[Address(RVA = "0xC29B3C", Offset = "0xC29B3C", VA = "0xC29B3C")]
			public _003C_003Ec__DisplayClass2_0()
			{
			}

			[Token(Token = "0x60033BD")]
			[Address(RVA = "0xC29B44", Offset = "0xC29B44", VA = "0xC29B44")]
			internal bool _003CExecute_003Eb__0(Camera c)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4001AAB")]
		[FieldOffset(Offset = "0x10")]
		private string methodParameters;

		[Token(Token = "0x6002B34")]
		[Address(RVA = "0xC143E0", Offset = "0xC143E0", VA = "0xC143E0")]
		public AltUnityFindObjectsWhereNameContainsCommand(string methodParameters)
		{
		}

		[Token(Token = "0x6002B35")]
		[Address(RVA = "0xC29748", Offset = "0xC29748", VA = "0xC29748", Slot = "4")]
		public override string Execute()
		{
			return null;
		}
	}
}
