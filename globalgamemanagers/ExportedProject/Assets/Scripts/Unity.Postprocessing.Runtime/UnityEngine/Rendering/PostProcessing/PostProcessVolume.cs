using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	[Token(Token = "0x2000059")]
	[ExecuteAlways]
	[Attribute(Name = "AddComponentMenu", RVA = "0x8194DC", Offset = "0x8194DC")]
	public sealed class PostProcessVolume : MonoBehaviour
	{
		[Token(Token = "0x4000182")]
		[FieldOffset(Offset = "0x18")]
		public PostProcessProfile sharedProfile;

		[Token(Token = "0x4000183")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x81BDF0", Offset = "0x81BDF0")]
		public bool isGlobal;

		[Token(Token = "0x4000184")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "MinAttribute", RVA = "0x81BE28", Offset = "0x81BE28")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x81BE28", Offset = "0x81BE28")]
		public float blendDistance;

		[Token(Token = "0x4000185")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "RangeAttribute", RVA = "0x81BE78", Offset = "0x81BE78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x81BE78", Offset = "0x81BE78")]
		public float weight;

		[Token(Token = "0x4000186")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x81BECC", Offset = "0x81BECC")]
		public float priority;

		[Token(Token = "0x4000187")]
		[FieldOffset(Offset = "0x30")]
		private int m_PreviousLayer;

		[Token(Token = "0x4000188")]
		[FieldOffset(Offset = "0x34")]
		private float m_PreviousPriority;

		[Token(Token = "0x4000189")]
		[FieldOffset(Offset = "0x38")]
		private List<Collider> m_TempColliders;

		[Token(Token = "0x400018A")]
		[FieldOffset(Offset = "0x40")]
		private PostProcessProfile m_InternalProfile;

		[Token(Token = "0x17000024")]
		public PostProcessProfile profile
		{
			[Token(Token = "0x6000196")]
			[Address(RVA = "0x12269E4", Offset = "0x12269E4", VA = "0x12269E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000197")]
			[Address(RVA = "0x12292BC", Offset = "0x12292BC", VA = "0x12292BC")]
			set
			{
			}
		}

		[Token(Token = "0x17000025")]
		internal PostProcessProfile profileRef
		{
			[Token(Token = "0x6000198")]
			[Address(RVA = "0x1226510", Offset = "0x1226510", VA = "0x1226510")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x12292C4", Offset = "0x12292C4", VA = "0x12292C4")]
		public bool HasInstantiatedProfile()
		{
			return default(bool);
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x1229334", Offset = "0x1229334", VA = "0x1229334")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x12293E0", Offset = "0x12293E0", VA = "0x12293E0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x1229414", Offset = "0x1229414", VA = "0x1229414")]
		private void Update()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x12294D4", Offset = "0x12294D4", VA = "0x12294D4")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x1229E0C", Offset = "0x1229E0C", VA = "0x1229E0C")]
		public PostProcessVolume()
		{
		}
	}
}
