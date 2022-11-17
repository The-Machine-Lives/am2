using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	[Token(Token = "0x2000066")]
	internal class TextureLerper
	{
		[Token(Token = "0x4000241")]
		[FieldOffset(Offset = "0x0")]
		private static TextureLerper m_Instance;

		[Token(Token = "0x4000242")]
		[FieldOffset(Offset = "0x10")]
		private CommandBuffer m_Command;

		[Token(Token = "0x4000243")]
		[FieldOffset(Offset = "0x18")]
		private PropertySheetFactory m_PropertySheets;

		[Token(Token = "0x4000244")]
		[FieldOffset(Offset = "0x20")]
		private PostProcessResources m_Resources;

		[Token(Token = "0x4000245")]
		[FieldOffset(Offset = "0x28")]
		private List<RenderTexture> m_Recycled;

		[Token(Token = "0x4000246")]
		[FieldOffset(Offset = "0x30")]
		private List<RenderTexture> m_Actives;

		[Token(Token = "0x17000042")]
		internal static TextureLerper instance
		{
			[Token(Token = "0x6000217")]
			[Address(RVA = "0x123687C", Offset = "0x123687C", VA = "0x123687C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x12368F8", Offset = "0x12368F8", VA = "0x12368F8")]
		private TextureLerper()
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x123698C", Offset = "0x123698C", VA = "0x123698C")]
		internal void BeginFrame(PostProcessRenderContext context)
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x12369FC", Offset = "0x12369FC", VA = "0x12369FC")]
		internal void EndFrame()
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x1236CD0", Offset = "0x1236CD0", VA = "0x1236CD0")]
		private RenderTexture Get(RenderTextureFormat format, int w, int h, int d = 1, bool enableRandomWrite = false, bool force3D = false)
		{
			return null;
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x1236FAC", Offset = "0x1236FAC", VA = "0x1236FAC")]
		internal Texture Lerp(Texture from, Texture to, float t)
		{
			return null;
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x1237704", Offset = "0x1237704", VA = "0x1237704")]
		internal Texture Lerp(Texture from, Color to, float t)
		{
			return null;
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x1237E08", Offset = "0x1237E08", VA = "0x1237E08")]
		internal void Clear()
		{
		}
	}
}
