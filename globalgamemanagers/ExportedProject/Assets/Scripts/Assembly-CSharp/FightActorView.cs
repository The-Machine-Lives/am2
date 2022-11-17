using System.Collections.Generic;
using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using UnityEngine;
using Utilities;

[Token(Token = "0x2000087")]
public class FightActorView : MonoBehaviour
{
	[Token(Token = "0x4000201")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	protected AM2Text m_nameText;

	[Token(Token = "0x4000202")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	protected AM2Text m_deathText;

	[Token(Token = "0x4000203")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	protected DelayedProgressBar m_delayedHealthBar;

	[Token(Token = "0x4000204")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	protected ProgressBar m_healthBar;

	[Token(Token = "0x4000205")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	protected Transform m_buffsParent;

	[Token(Token = "0x4000206")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	protected GameObject m_buffTemplate;

	[Token(Token = "0x4000207")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	protected GameObject m_textHitEffectTemplate;

	[Token(Token = "0x4000208")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	protected GameObject m_textHealEffectTemplate;

	[Token(Token = "0x4000209")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	protected GameObject m_textCureEffectTemplate;

	[Token(Token = "0x400020A")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	protected RectTransform m_textHitSpawnArea;

	[Token(Token = "0x400020B")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	protected AnimationView animationView;

	[Token(Token = "0x400020C")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	protected ContextualTextView m_contextualTextView;

	[Token(Token = "0x400020D")]
	[FieldOffset(Offset = "0x78")]
	protected Dictionary<string, BuffView> m_currentBuffViews;

	[Token(Token = "0x400020E")]
	[FieldOffset(Offset = "0x80")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x821D48", Offset = "0x821D48")]
	private FightActorController _003Ccontroller_003Ek__BackingField;

	[Token(Token = "0x400020F")]
	[FieldOffset(Offset = "0x88")]
	private ObjectPoolController m_objectPoolController;

	[Token(Token = "0x4000210")]
	[FieldOffset(Offset = "0x90")]
	private Localizations m_localizationController;

	[Token(Token = "0x4000211")]
	[FieldOffset(Offset = "0x98")]
	private Queue<string> cureQueue;

	[Token(Token = "0x4000212")]
	[FieldOffset(Offset = "0xA0")]
	private float m_fRefreshTime;

	[Token(Token = "0x4000213")]
	public const float c_cureDequeueDelay = 0.4f;

	[Token(Token = "0x1700004A")]
	public FightActorController controller
	{
		[Token(Token = "0x600027C")]
		[Address(RVA = "0x9CEE8C", Offset = "0x9CEE8C", VA = "0x9CEE8C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833B1C", Offset = "0x833B1C")]
		get
		{
			return null;
		}
		[Token(Token = "0x600027D")]
		[Address(RVA = "0x9CEE94", Offset = "0x9CEE94", VA = "0x9CEE94")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833B2C", Offset = "0x833B2C")]
		protected set
		{
		}
	}

	[Token(Token = "0x600027E")]
	[Address(RVA = "0x9CEE9C", Offset = "0x9CEE9C", VA = "0x9CEE9C", Slot = "4")]
	public virtual void InitializeAsAI(AIActorController controller)
	{
	}

	[Token(Token = "0x600027F")]
	[Address(RVA = "0x9CF36C", Offset = "0x9CF36C", VA = "0x9CF36C")]
	public void InitializeAsPlayer(PlayerActorController controller, ContextualTextView contextualTextView)
	{
	}

	[Token(Token = "0x6000280")]
	[Address(RVA = "0x9CEF08", Offset = "0x9CEF08", VA = "0x9CEF08")]
	private void Initialize(FightActorController controller, string readableName)
	{
	}

	[Token(Token = "0x6000281")]
	[Address(RVA = "0x9CF200", Offset = "0x9CF200", VA = "0x9CF200")]
	private void InitializeHealthBar()
	{
	}

	[Token(Token = "0x6000282")]
	[Address(RVA = "0x9CF55C", Offset = "0x9CF55C", VA = "0x9CF55C")]
	private void SetHealthBarFillAmount(float fill)
	{
	}

	[Token(Token = "0x6000283")]
	[Address(RVA = "0x9CF714", Offset = "0x9CF714", VA = "0x9CF714")]
	private float GetShakeAmountBasedOnDamage(float damage)
	{
		return default(float);
	}

	[Token(Token = "0x6000284")]
	[Address(RVA = "0x9CF3DC", Offset = "0x9CF3DC", VA = "0x9CF3DC")]
	private void CreateBuff(IBuffState buffState)
	{
	}

	[Token(Token = "0x6000285")]
	[Address(RVA = "0x9CF79C", Offset = "0x9CF79C", VA = "0x9CF79C", Slot = "5")]
	protected virtual void Update()
	{
	}

	[Token(Token = "0x6000286")]
	[Address(RVA = "0x9CFBC4", Offset = "0x9CFBC4", VA = "0x9CFBC4")]
	private void HandleCureQueue()
	{
	}

	[Token(Token = "0x6000287")]
	[Address(RVA = "0x9CFE60", Offset = "0x9CFE60", VA = "0x9CFE60", Slot = "6")]
	protected virtual void OnActorEvent(FightActorEvent actorEvent)
	{
	}

	[Token(Token = "0x6000288")]
	[Address(RVA = "0x9D0790", Offset = "0x9D0790", VA = "0x9D0790")]
	private void OnDiffHealth(DiffHealthActorEvent damageEvent)
	{
	}

	[Token(Token = "0x6000289")]
	[Address(RVA = "0x9D090C", Offset = "0x9D090C", VA = "0x9D090C")]
	private void OnReceiveBuff(BuffActorEvent buffEvent)
	{
	}

	[Token(Token = "0x600028A")]
	[Address(RVA = "0x9D18E4", Offset = "0x9D18E4", VA = "0x9D18E4", Slot = "7")]
	protected virtual void OnMiss()
	{
	}

	[Token(Token = "0x600028B")]
	[Address(RVA = "0x9D19A0", Offset = "0x9D19A0", VA = "0x9D19A0", Slot = "8")]
	protected virtual void OnDodge()
	{
	}

	[Token(Token = "0x600028C")]
	[Address(RVA = "0x9D1578", Offset = "0x9D1578", VA = "0x9D1578")]
	private void PlayBuffSound(BuffActorEvent buffEvent)
	{
	}

	[Token(Token = "0x600028D")]
	[Address(RVA = "0x9D0ED0", Offset = "0x9D0ED0", VA = "0x9D0ED0")]
	private void SpawnDiffHealthTextEffect(long healthDiff, float multiplier)
	{
	}

	[Token(Token = "0x600028E")]
	[Address(RVA = "0x9D1AD8", Offset = "0x9D1AD8", VA = "0x9D1AD8")]
	public void OnInitiateAbility(Ability ability)
	{
	}

	[Token(Token = "0x600028F")]
	[Address(RVA = "0x9D1B40", Offset = "0x9D1B40", VA = "0x9D1B40", Slot = "9")]
	protected virtual void OnDeath(DeathActorEvent deathEvent)
	{
	}

	[Token(Token = "0x6000290")]
	[Address(RVA = "0x9D0A58", Offset = "0x9D0A58", VA = "0x9D0A58")]
	private void OnCure(CureActorEvent buffEvent)
	{
	}

	[Token(Token = "0x6000291")]
	[Address(RVA = "0x9D1C8C", Offset = "0x9D1C8C", VA = "0x9D1C8C")]
	protected void HideAllBuffViews()
	{
	}

	[Token(Token = "0x6000292")]
	[Address(RVA = "0x9D1E9C", Offset = "0x9D1E9C", VA = "0x9D1E9C")]
	public FightActorView()
	{
	}
}
