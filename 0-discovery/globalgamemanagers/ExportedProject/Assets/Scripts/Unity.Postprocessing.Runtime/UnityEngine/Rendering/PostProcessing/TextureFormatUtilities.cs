using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	[Token(Token = "0x2000065")]
	public static class TextureFormatUtilities
	{
		[Token(Token = "0x400023E")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<int, RenderTextureFormat> s_FormatAliasMap;

		[Token(Token = "0x400023F")]
		[FieldOffset(Offset = "0x8")]
		private static Dictionary<int, bool> s_SupportedRenderTextureFormats;

		[Token(Token = "0x4000240")]
		[FieldOffset(Offset = "0x10")]
		private static Dictionary<int, bool> s_SupportedTextureFormats;

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x123563C", Offset = "0x123563C", VA = "0x123563C")]
		static TextureFormatUtilities()
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x123657C", Offset = "0x123657C", VA = "0x123657C")]
		private static bool IsObsolete(object value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x1236718", Offset = "0x1236718", VA = "0x1236718")]
		public static RenderTextureFormat GetUncompressedRenderTextureFormat(Texture texture)
		{
			return default(RenderTextureFormat);
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x122DFC0", Offset = "0x122DFC0", VA = "0x122DFC0")]
		internal static bool IsSupported(this RenderTextureFormat format)
		{
			return default(bool);
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x122B420", Offset = "0x122B420", VA = "0x122B420")]
		internal static bool IsSupported(this TextureFormat format)
		{
			return default(bool);
		}
	}
}
