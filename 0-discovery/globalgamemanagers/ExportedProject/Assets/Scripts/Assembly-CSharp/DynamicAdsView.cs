using System;
using System.Runtime.InteropServices;
using AM2.ReferenceData;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.UI;

[Token(Token = "0x200009A")]
public class DynamicAdsView : MonoBehaviour
{
	[Token(Token = "0x200060F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820348", Offset = "0x820348")]
	private sealed class _003C_003Ec__DisplayClass12_0
	{
		[Token(Token = "0x4001D84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Action<DynamicAds> onButtonPressed;

		[Token(Token = "0x4001D85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public DynamicAdsView _003C_003E4__this;

		[Token(Token = "0x6002CDC")]
		[Address(RVA = "0x9C4578", Offset = "0x9C4578", VA = "0x9C4578")]
		public _003C_003Ec__DisplayClass12_0()
		{
		}

		[Token(Token = "0x6002CDD")]
		[Address(RVA = "0x9C4B78", Offset = "0x9C4B78", VA = "0x9C4B78")]
		internal void _003CInitialize_003Eb__0()
		{
		}
	}

	[Token(Token = "0x2000610")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820358", Offset = "0x820358")]
	private sealed class _003C_003Ec__DisplayClass13_0
	{
		[Token(Token = "0x4001D86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public DynamicAdsView _003C_003E4__this;

		[Token(Token = "0x4001D87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Action onHideCompleteCallback;

		[Token(Token = "0x6002CDE")]
		[Address(RVA = "0x9C4580", Offset = "0x9C4580", VA = "0x9C4580")]
		public _003C_003Ec__DisplayClass13_0()
		{
		}

		[Token(Token = "0x6002CDF")]
		[Address(RVA = "0x9C4BEC", Offset = "0x9C4BEC", VA = "0x9C4BEC")]
		internal void _003CSetDynamicAdAndShow_003Eb__0()
		{
		}
	}

	[Token(Token = "0x40002A4")]
	private const float c_dynamicAdRadius = 300f;

	[Token(Token = "0x40002A5")]
	private const float c_showHideDuration = 1f;

	[Token(Token = "0x40002A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x822178", Offset = "0x822178")]
	private AM2Button m_button;

	[Token(Token = "0x40002A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8221C4", Offset = "0x8221C4")]
	private Image m_border;

	[Token(Token = "0x40002A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x822210", Offset = "0x822210")]
	private ParticleSystem m_particleSystem;

	[Token(Token = "0x40002A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private IPositionAnimator m_positionAnimator;

	[Token(Token = "0x40002AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private DynamicAds m_dynamicAds;

	[Token(Token = "0x40002AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float m_startingZRotation;

	[Token(Token = "0x40002AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Transform m_positionConstraintSource;

	[Token(Token = "0x40002AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private PositionConstraint m_positionConstraint;

	[Token(Token = "0x6000332")]
	[Address(RVA = "0x9C3EE4", Offset = "0x9C3EE4", VA = "0x9C3EE4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000333")]
	[Address(RVA = "0x9C3F54", Offset = "0x9C3F54", VA = "0x9C3F54")]
	private void Start()
	{
	}

	[Token(Token = "0x6000334")]
	[Address(RVA = "0x9C445C", Offset = "0x9C445C", VA = "0x9C445C")]
	public void Initialize(Action<DynamicAds> onButtonPressed, Transform positionConstraintSource, float startingZRotation)
	{
	}

	[Token(Token = "0x6000335")]
	[Address(RVA = "0x9C414C", Offset = "0x9C414C", VA = "0x9C414C")]
	public void SetDynamicAdAndShow(DynamicAds dynamicAd, bool animate = true, [Optional] Action onHideCompleteCallback)
	{
	}

	[Token(Token = "0x6000336")]
	[Address(RVA = "0x9C46F4", Offset = "0x9C46F4", VA = "0x9C46F4")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000337")]
	[Address(RVA = "0x9C473C", Offset = "0x9C473C", VA = "0x9C473C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000338")]
	[Address(RVA = "0x9C4588", Offset = "0x9C4588", VA = "0x9C4588")]
	private void ShowOrHide(bool show, [Optional] Action onStart, [Optional] Action onComplete, bool animate = true)
	{
	}

	[Token(Token = "0x6000339")]
	[Address(RVA = "0x9C47F4", Offset = "0x9C47F4", VA = "0x9C47F4")]
	private void ShowOrHideAnimation(float value)
	{
	}

	[Token(Token = "0x600033A")]
	[Address(RVA = "0x9C4A80", Offset = "0x9C4A80", VA = "0x9C4A80")]
	private void OnShowStart()
	{
	}

	[Token(Token = "0x600033B")]
	[Address(RVA = "0x9C4AD0", Offset = "0x9C4AD0", VA = "0x9C4AD0")]
	private void OnShowFinish()
	{
	}

	[Token(Token = "0x600033C")]
	[Address(RVA = "0x9C4B04", Offset = "0x9C4B04", VA = "0x9C4B04")]
	private void OnHideStart()
	{
	}

	[Token(Token = "0x600033D")]
	[Address(RVA = "0x9C4B38", Offset = "0x9C4B38", VA = "0x9C4B38")]
	private void OnHideComplete()
	{
	}

	[Token(Token = "0x600033E")]
	[Address(RVA = "0x9C4B68", Offset = "0x9C4B68", VA = "0x9C4B68")]
	public DynamicAds GetDynamicAd()
	{
		return null;
	}

	[Token(Token = "0x600033F")]
	[Address(RVA = "0x9C4B70", Offset = "0x9C4B70", VA = "0x9C4B70")]
	public DynamicAdsView()
	{
	}
}
