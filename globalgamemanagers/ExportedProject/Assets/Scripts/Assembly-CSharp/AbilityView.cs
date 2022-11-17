using Il2CppDummyDll;
using Uken.Library.Animation;
using Uken.Library.UkenTime;
using UnityEngine;
using UnityEngine.EventSystems;

[Token(Token = "0x200006A")]
public class AbilityView : MonoBehaviour
{
	[Token(Token = "0x400015C")]
	private const float c_readyAnimScale = 1.3f;

	[Token(Token = "0x400015D")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private AM2Button m_button;

	[Token(Token = "0x400015E")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AM2Text m_ammoCountText;

	[Token(Token = "0x400015F")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private AM2Text m_abilityNameText;

	[Token(Token = "0x4000160")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private AM2Text m_cooldownText;

	[Token(Token = "0x4000161")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private GameObject m_cooldownParent;

	[Token(Token = "0x4000162")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private ProgressBar m_cooldownProgress;

	[Token(Token = "0x4000163")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private GameObject m_readyImage;

	[Token(Token = "0x4000164")]
	[FieldOffset(Offset = "0x50")]
	private AbilityController m_controller;

	[Token(Token = "0x4000165")]
	[FieldOffset(Offset = "0x58")]
	private FightActorController m_fightActorController;

	[Token(Token = "0x4000166")]
	[FieldOffset(Offset = "0x60")]
	private UkenTimeController m_timeController;

	[Token(Token = "0x4000167")]
	[FieldOffset(Offset = "0x68")]
	private IAbilityState m_state;

	[Token(Token = "0x4000168")]
	[FieldOffset(Offset = "0x70")]
	private bool m_initialized;

	[Token(Token = "0x4000169")]
	[FieldOffset(Offset = "0x71")]
	private bool m_wasStunned;

	[Token(Token = "0x400016A")]
	[FieldOffset(Offset = "0x72")]
	private bool isButtonDown;

	[Token(Token = "0x400016B")]
	[FieldOffset(Offset = "0x73")]
	private bool isPointerOnButton;

	[Token(Token = "0x400016C")]
	[FieldOffset(Offset = "0x78")]
	private EventTrigger m_eventTrigger;

	[Token(Token = "0x400016D")]
	[FieldOffset(Offset = "0x80")]
	private ZoneView m_zoneView;

	[Token(Token = "0x400016E")]
	[FieldOffset(Offset = "0x88")]
	private UkenAnimTransform m_transformAnim;

	[Token(Token = "0x400016F")]
	[FieldOffset(Offset = "0x90")]
	private bool m_isCastingNextAbility;

	[Token(Token = "0x17000011")]
	public bool isButtonInteractable
	{
		[Token(Token = "0x600017D")]
		[Address(RVA = "0xACC6C0", Offset = "0xACC6C0", VA = "0xACC6C0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0xACC6F8", Offset = "0xACC6F8", VA = "0xACC6F8")]
	private void Awake()
	{
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0xACCB68", Offset = "0xACCB68", VA = "0xACCB68")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0xACCC50", Offset = "0xACCC50", VA = "0xACCC50")]
	public void Initialize(AbilityController controller, FightActorController fightActorController, ZoneView zoneView)
	{
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0xACD134", Offset = "0xACD134", VA = "0xACD134")]
	private void UseNextAbility()
	{
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0xACD314", Offset = "0xACD314", VA = "0xACD314")]
	private void Update()
	{
	}

	[Token(Token = "0x6000183")]
	[Address(RVA = "0xACD568", Offset = "0xACD568", VA = "0xACD568")]
	private void OnPointerDownDelegate(BaseEventData data)
	{
	}

	[Token(Token = "0x6000184")]
	[Address(RVA = "0xACD5B4", Offset = "0xACD5B4", VA = "0xACD5B4")]
	private void OnPointerUpDelegate(BaseEventData data)
	{
	}

	[Token(Token = "0x6000185")]
	[Address(RVA = "0xACD5BC", Offset = "0xACD5BC", VA = "0xACD5BC")]
	private void OnPointerEnterDelegate(BaseEventData data)
	{
	}

	[Token(Token = "0x6000186")]
	[Address(RVA = "0xACD5C8", Offset = "0xACD5C8", VA = "0xACD5C8")]
	private void OnPointerExitDelegate(BaseEventData data)
	{
	}

	[Token(Token = "0x6000187")]
	[Address(RVA = "0xACD5D0", Offset = "0xACD5D0", VA = "0xACD5D0")]
	public bool OnCooldown()
	{
		return default(bool);
	}

	[Token(Token = "0x6000188")]
	[Address(RVA = "0xACD6A0", Offset = "0xACD6A0", VA = "0xACD6A0", Slot = "4")]
	public virtual void OnClickedButton()
	{
	}

	[Token(Token = "0x6000189")]
	[Address(RVA = "0xACD70C", Offset = "0xACD70C", VA = "0xACD70C")]
	public void SetButtonInteractable(bool interactable)
	{
	}

	[Token(Token = "0x600018A")]
	[Address(RVA = "0xACD760", Offset = "0xACD760", VA = "0xACD760")]
	public AbilityUpdateResult UpdateView()
	{
		return null;
	}

	[Token(Token = "0x600018B")]
	[Address(RVA = "0xACCF7C", Offset = "0xACCF7C", VA = "0xACCF7C")]
	private void OnAbilityEvent(EAbilityEvent abilityEvent, AbilityUpdateResult result)
	{
	}

	[Token(Token = "0x600018C")]
	[Address(RVA = "0xACDE40", Offset = "0xACDE40", VA = "0xACDE40")]
	protected void SetButtonColor(EAbilityEvent abilityEvent)
	{
	}

	[Token(Token = "0x600018D")]
	[Address(RVA = "0xACCE04", Offset = "0xACCE04", VA = "0xACCE04")]
	protected void UpdateAmmoText()
	{
	}

	[Token(Token = "0x600018E")]
	[Address(RVA = "0xACDB40", Offset = "0xACDB40", VA = "0xACDB40")]
	protected void UpdateCooldownBar()
	{
	}

	[Token(Token = "0x600018F")]
	[Address(RVA = "0xACE0CC", Offset = "0xACE0CC", VA = "0xACE0CC")]
	protected void SetCooldownFill(float fill)
	{
	}

	[Token(Token = "0x6000190")]
	[Address(RVA = "0xACDE94", Offset = "0xACDE94", VA = "0xACDE94")]
	private void AnimateReady()
	{
	}

	[Token(Token = "0x6000191")]
	[Address(RVA = "0xACE16C", Offset = "0xACE16C", VA = "0xACE16C")]
	public AbilityView()
	{
	}

	[Token(Token = "0x6000192")]
	[Address(RVA = "0xACE174", Offset = "0xACE174", VA = "0xACE174")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83382C", Offset = "0x83382C")]
	private void _003CAnimateReady_003Eb__40_0()
	{
	}
}
