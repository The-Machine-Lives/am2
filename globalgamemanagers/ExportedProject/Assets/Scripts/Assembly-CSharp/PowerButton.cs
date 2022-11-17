using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Library.UkenTime;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20000E1")]
public class PowerButton : MonoBehaviour
{
	[Token(Token = "0x40004C4")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Image m_topImage;

	[Token(Token = "0x40004C5")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Image m_innerCircle;

	[Token(Token = "0x40004C6")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float m_innerCircleFadeAmount;

	[Token(Token = "0x40004C7")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float m_fadeOutButtonTextTime;

	[Token(Token = "0x40004C8")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x822F5C", Offset = "0x822F5C")]
	private bool _003CisPressed_003Ek__BackingField;

	[Token(Token = "0x40004C9")]
	[FieldOffset(Offset = "0x34")]
	private float m_pressDistance;

	[Token(Token = "0x40004CA")]
	[FieldOffset(Offset = "0x38")]
	private float m_pressSpeed;

	[Token(Token = "0x40004CB")]
	[FieldOffset(Offset = "0x3C")]
	private float m_releaseSpeed;

	[Token(Token = "0x40004CC")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private PowerRune m_powerAnimation;

	[Token(Token = "0x40004CD")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private PowerView m_powerView;

	[Token(Token = "0x40004CE")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private PowerRadial m_powerRadialAnimation;

	[Token(Token = "0x40004CF")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Color m_pressedColor;

	[Token(Token = "0x40004D0")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private AM2Text m_sustainTimeLeftText;

	[Token(Token = "0x40004D1")]
	[FieldOffset(Offset = "0x70")]
	private bool m_tapAndHoldAcknowledged;

	[Token(Token = "0x40004D2")]
	[FieldOffset(Offset = "0x74")]
	private float m_innerCircleWidth;

	[Token(Token = "0x40004D3")]
	[FieldOffset(Offset = "0x78")]
	private float m_currentPressedAmount;

	[Token(Token = "0x40004D4")]
	[FieldOffset(Offset = "0x80")]
	private Power m_power;

	[Token(Token = "0x40004D5")]
	[FieldOffset(Offset = "0x88")]
	private PowerController m_powerController;

	[Token(Token = "0x40004D6")]
	[FieldOffset(Offset = "0x90")]
	private ConstructionController m_constructionController;

	[Token(Token = "0x40004D7")]
	[FieldOffset(Offset = "0x98")]
	private UkenTimeController m_timeController;

	[Token(Token = "0x40004D8")]
	[FieldOffset(Offset = "0xA0")]
	private Localizations m_localizationController;

	[Token(Token = "0x170000D7")]
	public bool isPressed
	{
		[Token(Token = "0x6000605")]
		[Address(RVA = "0x99A7EC", Offset = "0x99A7EC", VA = "0x99A7EC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833F40", Offset = "0x833F40")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000606")]
		[Address(RVA = "0x99FFA4", Offset = "0x99FFA4", VA = "0x99FFA4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833F50", Offset = "0x833F50")]
		private set
		{
		}
	}

	[Token(Token = "0x6000607")]
	[Address(RVA = "0x99FFB0", Offset = "0x99FFB0", VA = "0x99FFB0")]
	public void Initialize()
	{
	}

	[Token(Token = "0x6000608")]
	[Address(RVA = "0x9A031C", Offset = "0x9A031C", VA = "0x9A031C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000609")]
	[Address(RVA = "0x9A032C", Offset = "0x9A032C", VA = "0x9A032C")]
	private void OnApplicationFocus(bool focus)
	{
	}

	[Token(Token = "0x600060A")]
	[Address(RVA = "0x9A0338", Offset = "0x9A0338", VA = "0x9A0338")]
	private void OnApplicationPause(bool pause)
	{
	}

	[Token(Token = "0x600060B")]
	[Address(RVA = "0x9A0344", Offset = "0x9A0344", VA = "0x9A0344")]
	private void Update()
	{
	}

	[Token(Token = "0x600060C")]
	[Address(RVA = "0x9A0A3C", Offset = "0x9A0A3C", VA = "0x9A0A3C")]
	public void OnPressed()
	{
	}

	[Token(Token = "0x600060D")]
	[Address(RVA = "0x9A0324", Offset = "0x9A0324", VA = "0x9A0324")]
	public void OnLetGo()
	{
	}

	[Token(Token = "0x600060E")]
	[Address(RVA = "0x9A0A48", Offset = "0x9A0A48", VA = "0x9A0A48")]
	public PowerButton()
	{
	}
}
