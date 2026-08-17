using System.Collections.Generic;
using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Library.UkenTime;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x200010C")]
public class ResearchView : MonoBehaviour
{
	[Token(Token = "0x4000697")]
	[FieldOffset(Offset = "0x0")]
	private static ResearchablesPopupView researchablesPopup;

	[Token(Token = "0x4000698")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject m_inProgressContainer;

	[Token(Token = "0x4000699")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject m_completedContainer;

	[Token(Token = "0x400069A")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0x8240A4", Offset = "0x8240A4")]
	private Button m_swapResearchButton;

	[Token(Token = "0x400069B")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Button m_collectButton;

	[Token(Token = "0x400069C")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private AM2Text m_titleText;

	[Token(Token = "0x400069D")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private AM2Text m_quantityText;

	[Token(Token = "0x400069E")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private AM2Text m_rateText;

	[Token(Token = "0x400069F")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private AM2Text m_speedBoostText;

	[Token(Token = "0x40006A0")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private AM2Text m_costItemOverdrawText;

	[Token(Token = "0x40006A1")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private ProgressBar m_unitProgressBar;

	[Token(Token = "0x40006A2")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private Slider m_rateSlider;

	[Token(Token = "0x40006A3")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private GameObject m_researchablesPopupViewTemplate;

	[Token(Token = "0x40006A4")]
	[FieldOffset(Offset = "0x78")]
	private ConstructionViewController m_parentController;

	[Token(Token = "0x40006A5")]
	[FieldOffset(Offset = "0x80")]
	private UkenTimeController m_time;

	[Token(Token = "0x40006A6")]
	[FieldOffset(Offset = "0x88")]
	private AM2InventoryController m_inventory;

	[Token(Token = "0x40006A7")]
	[FieldOffset(Offset = "0x90")]
	private ResearchController m_researchController;

	[Token(Token = "0x40006A8")]
	[FieldOffset(Offset = "0x98")]
	private ConstructionController m_constructionController;

	[Token(Token = "0x40006A9")]
	[FieldOffset(Offset = "0xA0")]
	private SpeedBoosterController m_speedBoosterController;

	[Token(Token = "0x40006AA")]
	[FieldOffset(Offset = "0xA8")]
	private Localizations m_localizationController;

	[Token(Token = "0x40006AB")]
	[FieldOffset(Offset = "0xB0")]
	private RecipeDifferentialController m_recipeDifferentialController;

	[Token(Token = "0x40006AC")]
	[FieldOffset(Offset = "0xB8")]
	private ResearchSlotItem m_researchSlotItem;

	[Token(Token = "0x40006AD")]
	[FieldOffset(Offset = "0xC0")]
	private IResearchable m_researchable;

	[Token(Token = "0x40006AE")]
	[FieldOffset(Offset = "0xC8")]
	private ResearchSystem m_researchSystem;

	[Token(Token = "0x40006AF")]
	[FieldOffset(Offset = "0xD0")]
	private string m_localizedReadableCostName;

	[Token(Token = "0x40006B0")]
	[FieldOffset(Offset = "0xD8")]
	private int m_slotIndex;

	[Token(Token = "0x40006B1")]
	[FieldOffset(Offset = "0xDC")]
	private bool m_initialized;

	[Token(Token = "0x40006B2")]
	[FieldOffset(Offset = "0xDD")]
	private bool m_wasComplete;

	[Token(Token = "0x600075A")]
	[Address(RVA = "0x9F5D74", Offset = "0x9F5D74", VA = "0x9F5D74")]
	private void Awake()
	{
	}

	[Token(Token = "0x600075B")]
	[Address(RVA = "0x9F5E88", Offset = "0x9F5E88", VA = "0x9F5E88")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600075C")]
	[Address(RVA = "0x9F50FC", Offset = "0x9F50FC", VA = "0x9F50FC")]
	public void Initialize(ConstructionViewController parentController, ResearchSlotItem researchSlotItem, int slotIndex)
	{
	}

	[Token(Token = "0x600075D")]
	[Address(RVA = "0x9F5F9C", Offset = "0x9F5F9C", VA = "0x9F5F9C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600075E")]
	[Address(RVA = "0x9F54F8", Offset = "0x9F54F8", VA = "0x9F54F8")]
	public void RefreshWithResearchSlotItem(ResearchSlotItem newResearchSlotItem)
	{
	}

	[Token(Token = "0x600075F")]
	[Address(RVA = "0x9F6400", Offset = "0x9F6400", VA = "0x9F6400")]
	private void SetupView(bool isPopulatedWithResearch)
	{
	}

	[Token(Token = "0x6000760")]
	[Address(RVA = "0x9F67D0", Offset = "0x9F67D0", VA = "0x9F67D0")]
	public void OnSelectButtonPressed()
	{
	}

	[Token(Token = "0x6000761")]
	[Address(RVA = "0x9F6BA8", Offset = "0x9F6BA8", VA = "0x9F6BA8")]
	protected void OnCollectButtonPressed()
	{
	}

	[Token(Token = "0x6000762")]
	[Address(RVA = "0x9F6BEC", Offset = "0x9F6BEC", VA = "0x9F6BEC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000763")]
	[Address(RVA = "0x9F5FA4", Offset = "0x9F5FA4", VA = "0x9F5FA4")]
	private void UpdateView(bool forcedImmediateUpdate = false)
	{
	}

	[Token(Token = "0x6000764")]
	[Address(RVA = "0x9F6D7C", Offset = "0x9F6D7C", VA = "0x9F6D7C")]
	private void UpdateSpeedBoostText()
	{
	}

	[Token(Token = "0x6000765")]
	[Address(RVA = "0x9F6EEC", Offset = "0x9F6EEC", VA = "0x9F6EEC")]
	private void UpdateResearchOverdrawText()
	{
	}

	[Token(Token = "0x6000766")]
	[Address(RVA = "0x9F5970", Offset = "0x9F5970", VA = "0x9F5970")]
	public void ReleaseResearchSlotIfResearchIsLocked(List<IResearchable> researchables)
	{
	}

	[Token(Token = "0x6000767")]
	[Address(RVA = "0x9F675C", Offset = "0x9F675C", VA = "0x9F675C")]
	private void SetIsResearchComplete(bool isComplete)
	{
	}

	[Token(Token = "0x6000768")]
	[Address(RVA = "0x9F6518", Offset = "0x9F6518", VA = "0x9F6518")]
	private void UpdateTitleText()
	{
	}

	[Token(Token = "0x6000769")]
	[Address(RVA = "0x9F6BF4", Offset = "0x9F6BF4", VA = "0x9F6BF4")]
	private float GetProgressLerp()
	{
		return default(float);
	}

	[Token(Token = "0x600076A")]
	[Address(RVA = "0x9F6608", Offset = "0x9F6608", VA = "0x9F6608")]
	private void RefreshRateSlider()
	{
	}

	[Token(Token = "0x600076B")]
	[Address(RVA = "0x9F7184", Offset = "0x9F7184", VA = "0x9F7184")]
	public void OnSliderUpdated()
	{
	}

	[Token(Token = "0x600076C")]
	[Address(RVA = "0x9F704C", Offset = "0x9F704C", VA = "0x9F704C")]
	private void RefreshSliderText(long maxRate)
	{
	}

	[Token(Token = "0x600076D")]
	[Address(RVA = "0x9F72EC", Offset = "0x9F72EC", VA = "0x9F72EC")]
	public ResearchView()
	{
	}

	[Token(Token = "0x600076F")]
	[Address(RVA = "0x9F72F8", Offset = "0x9F72F8", VA = "0x9F72F8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x834130", Offset = "0x834130")]
	private void _003COnSelectButtonPressed_003Eb__34_0()
	{
	}
}
