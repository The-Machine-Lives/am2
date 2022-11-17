using Il2CppDummyDll;
using UnityEngine;

namespace Assets.AltUnityTester.AltUnityServer.Commands
{
	[Token(Token = "0x20005C0")]
	internal class AltUnityFindObjectWhereNameContainsCommand : AltUnityCommand
	{
		[Token(Token = "0x2000874")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8216C8", Offset = "0x8216C8")]
		private sealed class _003C_003Ec__DisplayClass2_0
		{
			[Token(Token = "0x4002424")]
			[FieldOffset(Offset = "0x10")]
			public string cameraName;

			[Token(Token = "0x60033BE")]
			[Address(RVA = "0xC287C8", Offset = "0xC287C8", VA = "0xC287C8")]
			public _003C_003Ec__DisplayClass2_0()
			{
			}

			[Token(Token = "0x60033BF")]
			[Address(RVA = "0xC287D0", Offset = "0xC287D0", VA = "0xC287D0")]
			internal bool _003CExecute_003Eb__0(Camera c)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4001AAC")]
		[FieldOffset(Offset = "0x10")]
		private string methodParameters;

		[Token(Token = "0x6002B36")]
		[Address(RVA = "0xC14388", Offset = "0xC14388", VA = "0xC14388")]
		public AltUnityFindObjectWhereNameContainsCommand(string methodParameters)
		{
		}

		[Token(Token = "0x6002B37")]
		[Address(RVA = "0xC2840C", Offset = "0xC2840C", VA = "0xC2840C", Slot = "4")]
		public override string Execute()
		{
			return null;
		}
	}
}
