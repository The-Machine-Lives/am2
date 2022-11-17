using Il2CppDummyDll;
using UnityEngine;

namespace Assets.AltUnityTester.AltUnityServer.Commands
{
	[Token(Token = "0x20005BD")]
	internal class AltUnityFindObjectsByComponentCommand : AltUnityReflectionMethodsCommand
	{
		[Token(Token = "0x2000871")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x821698", Offset = "0x821698")]
		private sealed class _003C_003Ec__DisplayClass2_0
		{
			[Token(Token = "0x4002421")]
			[FieldOffset(Offset = "0x10")]
			public string cameraName;

			[Token(Token = "0x60033B8")]
			[Address(RVA = "0xC28CE8", Offset = "0xC28CE8", VA = "0xC28CE8")]
			public _003C_003Ec__DisplayClass2_0()
			{
			}

			[Token(Token = "0x60033B9")]
			[Address(RVA = "0xC28CF0", Offset = "0xC28CF0", VA = "0xC28CF0")]
			internal bool _003CExecute_003Eb__0(Camera c)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4001AA9")]
		[FieldOffset(Offset = "0x10")]
		private string methodParameters;

		[Token(Token = "0x6002B30")]
		[Address(RVA = "0xC14438", Offset = "0xC14438", VA = "0xC14438")]
		public AltUnityFindObjectsByComponentCommand(string methodParameters)
		{
		}

		[Token(Token = "0x6002B31")]
		[Address(RVA = "0xC28824", Offset = "0xC28824", VA = "0xC28824", Slot = "4")]
		public override string Execute()
		{
			return null;
		}
	}
}
