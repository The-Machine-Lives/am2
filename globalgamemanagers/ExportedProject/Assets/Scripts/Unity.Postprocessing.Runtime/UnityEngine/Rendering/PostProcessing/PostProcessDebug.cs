using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	[Token(Token = "0x200004B")]
	[ExecuteAlways]
	[Attribute(Name = "AddComponentMenu", RVA = "0x8193D0", Offset = "0x8193D0")]
	public sealed class PostProcessDebug : MonoBehaviour
	{
		[Token(Token = "0x4000104")]
		[FieldOffset(Offset = "0x18")]
		public PostProcessLayer postProcessLayer;

		[Token(Token = "0x4000105")]
		[FieldOffset(Offset = "0x20")]
		private PostProcessLayer m_PreviousPostProcessLayer;

		[Token(Token = "0x4000106")]
		[FieldOffset(Offset = "0x28")]
		public bool lightMeter;

		[Token(Token = "0x4000107")]
		[FieldOffset(Offset = "0x29")]
		public bool histogram;

		[Token(Token = "0x4000108")]
		[FieldOffset(Offset = "0x2A")]
		public bool waveform;

		[Token(Token = "0x4000109")]
		[FieldOffset(Offset = "0x2B")]
		public bool vectorscope;

		[Token(Token = "0x400010A")]
		[FieldOffset(Offset = "0x2C")]
		public DebugOverlay debugOverlay;

		[Token(Token = "0x400010B")]
		[FieldOffset(Offset = "0x30")]
		private Camera m_CurrentCamera;

		[Token(Token = "0x400010C")]
		[FieldOffset(Offset = "0x38")]
		private CommandBuffer m_CmdAfterEverything;

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0xD88DB4", Offset = "0xD88DB4", VA = "0xD88DB4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0xD88E38", Offset = "0xD88E38", VA = "0xD88E38")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0xD88EE4", Offset = "0xD88EE4", VA = "0xD88EE4")]
		private void Update()
		{
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0xD89188", Offset = "0xD89188", VA = "0xD89188")]
		private void Reset()
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0xD88EE8", Offset = "0xD88EE8", VA = "0xD88EE8")]
		private void UpdateStates()
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0xD89270", Offset = "0xD89270", VA = "0xD89270")]
		private void OnPostRender()
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0xD893D0", Offset = "0xD893D0", VA = "0xD893D0")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0xD89548", Offset = "0xD89548", VA = "0xD89548")]
		private void DrawMonitor(ref Rect rect, Monitor monitor, bool enabled)
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0xD896F8", Offset = "0xD896F8", VA = "0xD896F8")]
		public PostProcessDebug()
		{
		}
	}
}
