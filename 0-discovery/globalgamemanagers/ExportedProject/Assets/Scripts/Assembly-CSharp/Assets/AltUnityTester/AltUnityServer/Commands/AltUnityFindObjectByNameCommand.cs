using Il2CppDummyDll;
using UnityEngine;

namespace Assets.AltUnityTester.AltUnityServer.Commands
{
	[Token(Token = "0x20005BC")]
	internal class AltUnityFindObjectByNameCommand : AltUnityFindObjectsOldWayCommand
	{
		[Token(Token = "0x2000870")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x821688", Offset = "0x821688")]
		private sealed class _003C_003Ec__DisplayClass2_0
		{
			[Token(Token = "0x4002420")]
			[FieldOffset(Offset = "0x10")]
			public string cameraName;

			[Token(Token = "0x60033B6")]
			[Address(RVA = "0xC27F20", Offset = "0xC27F20", VA = "0xC27F20")]
			public _003C_003Ec__DisplayClass2_0()
			{
			}

			[Token(Token = "0x60033B7")]
			[Address(RVA = "0xC27F28", Offset = "0xC27F28", VA = "0xC27F28")]
			internal bool _003CExecute_003Eb__0(Camera c)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4001AA8")]
		[FieldOffset(Offset = "0x10")]
		private string methodParameters;

		[Token(Token = "0x6002B2E")]
		[Address(RVA = "0xC1435C", Offset = "0xC1435C", VA = "0xC1435C")]
		public AltUnityFindObjectByNameCommand(string methodParameters)
		{
		}

		[Token(Token = "0x6002B2F")]
		[Address(RVA = "0xC27AB8", Offset = "0xC27AB8", VA = "0xC27AB8", Slot = "4")]
		public override string Execute()
		{
			return null;
		}
	}
}
