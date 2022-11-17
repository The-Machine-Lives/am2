using Il2CppDummyDll;
using Uken.Framework.Casual.View;
using UnityEngine;

[Token(Token = "0x20001B1")]
public class TierRewardDescriptionView : MonoBehaviour
{
	[Token(Token = "0x4000A46")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private InfoPopupButton m_infoPopupButton;

	[Token(Token = "0x4000A47")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AM2Text m_tierRewardText;

	[Token(Token = "0x4000A48")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private string m_itemNameColour;

	[Token(Token = "0x6000BD2")]
	[Address(RVA = "0xA13364", Offset = "0xA13364", VA = "0xA13364")]
	public void Initialize(CasualViewController parentController, string rewardItemName, long rewardQuantity)
	{
	}

	[Token(Token = "0x6000BD3")]
	[Address(RVA = "0xA1377C", Offset = "0xA1377C", VA = "0xA1377C")]
	public TierRewardDescriptionView()
	{
	}
}
