using Il2CppDummyDll;
using UnityEngine;

namespace Opencoding.Shared.Utils
{
	[Token(Token = "0x200000A")]
	public static class UIUtilities
	{
		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x0")]
		private static GUIContent _guiContent;

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x1812FE0", Offset = "0x1812FE0", VA = "0x1812FE0")]
		public static Texture2D CreateTexture(int width, int height, Color col)
		{
			return null;
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x1813170", Offset = "0x1813170", VA = "0x1813170")]
		public static Texture2D CreateTexture(Color col)
		{
			return null;
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x1813204", Offset = "0x1813204", VA = "0x1813204")]
		public static GUIContent TempGUIContent(string text)
		{
			return null;
		}
	}
}
