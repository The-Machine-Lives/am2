using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	[Token(Token = "0x200000D")]
	internal interface IAmbientOcclusionMethod
	{
		[Token(Token = "0x600000C")]
		DepthTextureMode GetCameraFlags();

		[Token(Token = "0x600000D")]
		void RenderAfterOpaque(PostProcessRenderContext context);

		[Token(Token = "0x600000E")]
		void RenderAmbientOnly(PostProcessRenderContext context);

		[Token(Token = "0x600000F")]
		void CompositeAmbientOnly(PostProcessRenderContext context);

		[Token(Token = "0x6000010")]
		void Release();
	}
}
