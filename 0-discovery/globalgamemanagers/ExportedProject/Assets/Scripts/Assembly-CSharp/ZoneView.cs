using System.Collections.Generic;
using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Library.Inventory;
using Uken.Library.UkenTime;
using UnityEngine;

[Token(Token = "0x2000093")]
public class ZoneView : MonoBehaviour
{
	[Token(Token = "0x4000257")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private FightActorView m_playerActorView;

	[Token(Token = "0x4000258")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private ContextualTextView m_contextualTextView;

	[Token(Token = "0x4000259")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject m_contextualProgressBarParent;

	[Token(Token = "0x400025A")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private ProgressBar m_contextualProgressBar;

	[Token(Token = "0x400025B")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private AM2Text m_contextualProgressBarText;

	[Token(Token = "0x400025C")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private GameObject m_gameSummaryTemplate;

	[Token(Token = "0x400025D")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private AM2Text m_titleText;

	[Token(Token = "0x400025E")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private AM2Text m_stepText;

	[Token(Token = "0x400025F")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Transform m_sceneParent;

	[Token(Token = "0x4000260")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Transform m_nextParent;

	[Token(Token = "0x4000261")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private ZoneIntroView m_zoneIntroView;

	[Token(Token = "0x4000262")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private List<AbilitySlotView> m_abilitySlotViews;

	[Token(Token = "0x4000263")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private GameObject m_playerContainer;

	[Token(Token = "0x4000264")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private GameObject m_battleLogContainer;

	[Token(Token = "0x4000265")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private GameObject m_fightSceneViewTemplate;

	[Token(Token = "0x4000266")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private GameObject m_textSceneViewTemplate;

	[Token(Token = "0x4000267")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private GameObject m_questSceneViewTemplate;

	[Token(Token = "0x4000268")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private GameObject m_choiceSceneViewTemplate;

	[Token(Token = "0x4000269")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private GameObject m_abilityViewTemplate;

	[Token(Token = "0x400026A")]
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	private GameObject m_abilityNextViewTemplate;

	[Token(Token = "0x400026B")]
	[FieldOffset(Offset = "0xB8")]
	[SerializeField]
	private AM2Button m_abandonButton;

	[Token(Token = "0x400026C")]
	[FieldOffset(Offset = "0xC0")]
	private List<AbilityView> m_abilityViews;

	[Token(Token = "0x400026D")]
	[FieldOffset(Offset = "0xC8")]
	private ActionSceneController m_currentSceneController;

	[Token(Token = "0x400026E")]
	[FieldOffset(Offset = "0xD0")]
	private bool m_bTransitionStarted;

	[Token(Token = "0x400026F")]
	[FieldOffset(Offset = "0xD1")]
	private bool m_showedGameSummary;

	[Token(Token = "0x4000270")]
	[FieldOffset(Offset = "0xD8")]
	private UkenAudioLoop m_castingLoopSound;

	[Token(Token = "0x4000271")]
	[FieldOffset(Offset = "0xE0")]
	private UkenAudioLoop m_channelingLoopSound;

	[Token(Token = "0x4000272")]
	[FieldOffset(Offset = "0xE8")]
	private BISoundEvents.EventKey m_ambientSoundKey;

	[Token(Token = "0x4000273")]
	[FieldOffset(Offset = "0xF0")]
	private ActionSceneView m_currentSceneView;

	[Token(Token = "0x4000274")]
	[FieldOffset(Offset = "0xF8")]
	private ConstructionViewController m_viewController;

	[Token(Token = "0x4000275")]
	[FieldOffset(Offset = "0x100")]
	private UkenTimeController m_timeController;

	[Token(Token = "0x4000276")]
	[FieldOffset(Offset = "0x108")]
	private ZoneController m_zoneController;

	[Token(Token = "0x4000277")]
	[FieldOffset(Offset = "0x110")]
	private LoadoutController m_loadoutController;

	[Token(Token = "0x4000278")]
	[FieldOffset(Offset = "0x118")]
	private ActionController m_actionController;

	[Token(Token = "0x4000279")]
	[FieldOffset(Offset = "0x120")]
	private Localizations m_localizationController;

	[Token(Token = "0x400027A")]
	[FieldOffset(Offset = "0x128")]
	private ZoneState m_zoneState;

	[Token(Token = "0x400027B")]
	[FieldOffset(Offset = "0x130")]
	private InventoryController m_inventoryController;

	[Token(Token = "0x400027C")]
	[FieldOffset(Offset = "0x138")]
	private AbilityView m_nextAbilityView;

	[Token(Token = "0x400027D")]
	[FieldOffset(Offset = "0x140")]
	private bool m_paused;

	[Token(Token = "0x60002EF")]
	[Address(RVA = "0xABC764", Offset = "0xABC764", VA = "0xABC764")]
	public void Initialize(ConstructionViewController viewController)
	{
	}

	[Token(Token = "0x60002F0")]
	[Address(RVA = "0xABCCF8", Offset = "0xABCCF8", VA = "0xABCCF8")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60002F1")]
	[Address(RVA = "0xAB9A04", Offset = "0xAB9A04", VA = "0xAB9A04")]
	public void GoToFirstScene()
	{
	}

	[Token(Token = "0x60002F2")]
	[Address(RVA = "0xABD338", Offset = "0xABD338", VA = "0xABD338")]
	private AbilityView CreateAbilityView(Ability targetAbility, GameObject targetTemplate, Transform targetParent, int controllerIndex)
	{
		return null;
	}

	[Token(Token = "0x60002F3")]
	[Address(RVA = "0xABD584", Offset = "0xABD584", VA = "0xABD584")]
	private void DestroyPreviousScene()
	{
	}

	[Token(Token = "0x60002F4")]
	[Address(RVA = "0xABD5B0", Offset = "0xABD5B0", VA = "0xABD5B0")]
	public void GoToNextScene()
	{
	}

	[Token(Token = "0x60002F5")]
	[Address(RVA = "0xABCDA8", Offset = "0xABCDA8", VA = "0xABCDA8")]
	public void CreateSceneViewFromCurrentScene()
	{
	}

	[Token(Token = "0x60002F6")]
	[Address(RVA = "0xABD640", Offset = "0xABD640", VA = "0xABD640")]
	protected void Update()
	{
	}

	[Token(Token = "0x60002F7")]
	[Address(RVA = "0xABDC88", Offset = "0xABDC88", VA = "0xABDC88")]
	private void UpdateSoundLoop(UkenAudioLoop loop, bool shouldBePlaying)
	{
	}

	[Token(Token = "0x60002F8")]
	[Address(RVA = "0xABDCD4", Offset = "0xABDCD4", VA = "0xABDCD4")]
	protected void TEMP_run_through_scenes()
	{
	}

	[Token(Token = "0x60002F9")]
	[Address(RVA = "0xABDAF8", Offset = "0xABDAF8", VA = "0xABDAF8")]
	private void ShowGameSummary()
	{
	}

	[Token(Token = "0x60002FA")]
	[Address(RVA = "0xABDD6C", Offset = "0xABDD6C", VA = "0xABDD6C")]
	public void GoToConstruction()
	{
	}

	[Token(Token = "0x60002FB")]
	[Address(RVA = "0xABDEBC", Offset = "0xABDEBC", VA = "0xABDEBC")]
	private void Abandon()
	{
	}

	[Token(Token = "0x60002FC")]
	[Address(RVA = "0xABE044", Offset = "0xABE044", VA = "0xABE044")]
	public ZoneView()
	{
	}

	[Token(Token = "0x60002FD")]
	[Address(RVA = "0xABE0DC", Offset = "0xABE0DC", VA = "0xABE0DC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833CDC", Offset = "0x833CDC")]
	private void _003CAbandon_003Eb__51_0()
	{
	}

	[Token(Token = "0x60002FE")]
	[Address(RVA = "0xABE134", Offset = "0xABE134", VA = "0xABE134")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833CEC", Offset = "0x833CEC")]
	private void _003CAbandon_003Eb__51_1()
	{
	}
}
