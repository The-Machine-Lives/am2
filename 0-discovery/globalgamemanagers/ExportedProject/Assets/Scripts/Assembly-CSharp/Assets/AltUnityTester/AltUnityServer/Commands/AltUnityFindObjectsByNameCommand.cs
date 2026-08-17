using Il2CppDummyDll;
using UnityEngine;

namespace Assets.AltUnityTester.AltUnityServer.Commands
{
	[Token(Token = "0x20005BE")]
	internal class AltUnityFindObjectsByNameCommand : AltUnityFindObjectsOldWayCommand
	{
		[Token(Token = "0x2000872")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8216A8", Offset = "0x8216A8")]
		private sealed class _003C_003Ec__DisplayClass2_0
		{
			[Token(Token = "0x4002422")]
			[FieldOffset(Offset = "0x10")]
			public string cameraName;

			[Token(Token = "0x60033BA")]
			[Address(RVA = "0xC291BC", Offset = "0xC291BC", VA = "0xC291BC")]
			public _003C_003Ec__DisplayClass2_0()
			{
			}

			[Token(Token = "0x60033BB")]
			[Address(RVA = "0xC291C4", Offset = "0xC291C4", VA = "0xC291C4")]
			internal bool _003CExecute_003Eb__0(Camera c)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4001AAA")]
		[FieldOffset(Offset = "0x10")]
		private string methodParameters;

		[Token(Token = "0x6002B32")]
		[Address(RVA = "0xC143B4", Offset = "0xC143B4", VA = "0xC143B4")]
		public AltUnityFindObjectsByNameCommand(string methodParameters)
		{
		}

		[Token(Token = "0x6002B33")]
		[Address(RVA = "0xC28D44", Offset = "0xC28D44", VA = "0xC28D44", Slot = "4")]
		public override string Execute()
		{
			return null;
		}
	}
}
