using Il2CppDummyDll;
using UnityEngine;

namespace Opencoding.Console
{
	[Token(Token = "0x2000003")]
	public class EmailTemplateFilesContainer : ScriptableObject
	{
		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x18")]
		public TextAsset _LogEmailHeaderTextAsset;

		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x20")]
		public TextAsset _LogEmailFooterTextAsset;

		[Token(Token = "0x600003E")]
		[Address(RVA = "0xE81404", Offset = "0xE81404", VA = "0xE81404")]
		public EmailTemplateFilesContainer()
		{
		}
	}
}
