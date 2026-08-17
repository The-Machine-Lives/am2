using Il2CppDummyDll;
using UnityEngine;

namespace Assets.AltUnityTester.AltUnityServer.Commands
{
	[Token(Token = "0x20005BB")]
	internal class AltUnityFindObjectByComponentCommand : AltUnityReflectionMethodsCommand
	{
		[Token(Token = "0x200086F")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x821678", Offset = "0x821678")]
		private sealed class _003C_003Ec__DisplayClass2_0
		{
			[Token(Token = "0x400241F")]
			[FieldOffset(Offset = "0x10")]
			public string cameraName;

			[Token(Token = "0x60033B4")]
			[Address(RVA = "0xC27A5C", Offset = "0xC27A5C", VA = "0xC27A5C")]
			public _003C_003Ec__DisplayClass2_0()
			{
			}

			[Token(Token = "0x60033B5")]
			[Address(RVA = "0xC27A64", Offset = "0xC27A64", VA = "0xC27A64")]
			internal bool _003CExecute_003Eb__0(Camera c)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4001AA7")]
		[FieldOffset(Offset = "0x10")]
		private string methodParameters;

		[Token(Token = "0x6002B2C")]
		[Address(RVA = "0xC1440C", Offset = "0xC1440C", VA = "0xC1440C")]
		public AltUnityFindObjectByComponentCommand(string methodParameters)
		{
		}

		[Token(Token = "0x6002B2D")]
		[Address(RVA = "0xC275E0", Offset = "0xC275E0", VA = "0xC275E0", Slot = "4")]
		public override string Execute()
		{
			return null;
		}
	}
}
