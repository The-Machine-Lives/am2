using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Framework.Casual.View;
using Uken.Library.UkenTime;
using UnityEngine;

[Token(Token = "0x2000071")]
public class ActionSceneView : CasualViewBase
{
	[Token(Token = "0x4000190")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	protected AM2Button m_nextButton;

	[Token(Token = "0x4000191")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	protected float m_nextButtonRecoveryTime;

	[Token(Token = "0x4000192")]
	[FieldOffset(Offset = "0x90")]
	protected double m_allowNextButtonTime;

	[Token(Token = "0x4000193")]
	[FieldOffset(Offset = "0x98")]
	protected UkenTimeController m_timeController;

	[Token(Token = "0x4000194")]
	[FieldOffset(Offset = "0xA0")]
	protected ZoneView m_zoneView;

	[Token(Token = "0x4000195")]
	[FieldOffset(Offset = "0xA8")]
	private ZoneController m_zoneController;

	[Token(Token = "0x60001D2")]
	[Address(RVA = "0xACEBA4", Offset = "0xACEBA4", VA = "0xACEBA4", Slot = "4")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60001D3")]
	[Address(RVA = "0xACECA4", Offset = "0xACECA4", VA = "0xACECA4")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60001D4")]
	[Address(RVA = "0xACED98", Offset = "0xACED98", VA = "0xACED98")]
	public void Initialize(ZoneView zoneView)
	{
	}

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0xACEF98", Offset = "0xACEF98", VA = "0xACEF98", Slot = "12")]
	protected virtual void OnNextButtonPressed()
	{
	}

	[Token(Token = "0x60001D6")]
	[Address(RVA = "0xACF0C4", Offset = "0xACF0C4", VA = "0xACF0C4")]
	private void OnHideComplete()
	{
	}

	[Token(Token = "0x60001D7")]
	[Address(RVA = "0xACF100", Offset = "0xACF100", VA = "0xACF100", Slot = "13")]
	protected virtual bool ShouldActivateNextButton()
	{
		return default(bool);
	}

	[Token(Token = "0x60001D8")]
	[Address(RVA = "0xACF148", Offset = "0xACF148", VA = "0xACF148", Slot = "14")]
	protected virtual void Update()
	{
	}

	[Token(Token = "0x60001D9")]
	[Address(RVA = "0xACF1FC", Offset = "0xACF1FC", VA = "0xACF1FC")]
	public ActionSceneView()
	{
	}
}
