using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001B4")]
public class RatingPopupDetector : MonoBehaviour
{
	[Token(Token = "0x4000A4E")]
	[FieldOffset(Offset = "0x0")]
	public static string s_allowRatingPromptKey;

	[Token(Token = "0x4000A4F")]
	private const string c_lvlToCheckKey = "rating_popup_check_";

	[Token(Token = "0x4000A50")]
	private const string c_sustainUpgradeRef = "power_sustain";

	[Token(Token = "0x4000A51")]
	private const string c_allowRatingPopupKey = "rating_prompt";

	[Token(Token = "0x4000A52")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	protected GameObject m_enjoyingPopupTemplate;

	[Token(Token = "0x4000A53")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	protected ConstructionViewController m_viewController;

	[Token(Token = "0x4000A54")]
	[FieldOffset(Offset = "0x28")]
	private bool m_allowRatingPopup;

	[Token(Token = "0x4000A55")]
	[FieldOffset(Offset = "0x30")]
	private long[] sustainLvlsToCheck;

	[Token(Token = "0x6000BDA")]
	[Address(RVA = "0x9EC694", Offset = "0x9EC694", VA = "0x9EC694")]
	protected void Start()
	{
	}

	[Token(Token = "0x6000BDB")]
	[Address(RVA = "0x9EC7A4", Offset = "0x9EC7A4", VA = "0x9EC7A4")]
	public void OnClickedPowerSustain()
	{
	}

	[Token(Token = "0x6000BDC")]
	[Address(RVA = "0x9ECA58", Offset = "0x9ECA58", VA = "0x9ECA58")]
	private void ShowRatingPrompt()
	{
	}

	[Token(Token = "0x6000BDD")]
	[Address(RVA = "0x9ECB4C", Offset = "0x9ECB4C", VA = "0x9ECB4C")]
	public RatingPopupDetector()
	{
	}
}
