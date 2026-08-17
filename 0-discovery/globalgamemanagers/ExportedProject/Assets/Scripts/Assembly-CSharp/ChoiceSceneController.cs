using System.Collections.Generic;
using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Library.Inventory;

[Token(Token = "0x200006D")]
public class ChoiceSceneController : ActionSceneController
{
	[Token(Token = "0x400017F")]
	[FieldOffset(Offset = "0x58")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8219E8", Offset = "0x8219E8")]
	private ChoiceScene _003CchoiceScene_003Ek__BackingField;

	[Token(Token = "0x4000180")]
	[FieldOffset(Offset = "0x60")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8219F8", Offset = "0x8219F8")]
	private int _003Cm_choiceApplied_003Ek__BackingField;

	[Token(Token = "0x4000181")]
	[FieldOffset(Offset = "0x64")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x821A08", Offset = "0x821A08")]
	private bool _003Cm_hasTimer_003Ek__BackingField;

	[Token(Token = "0x4000182")]
	[FieldOffset(Offset = "0x68")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x821A18", Offset = "0x821A18")]
	private double _003Cm_timeLeft_003Ek__BackingField;

	[Token(Token = "0x4000183")]
	[FieldOffset(Offset = "0x70")]
	public bool choiceSelected;

	[Token(Token = "0x4000184")]
	[FieldOffset(Offset = "0x78")]
	private AbilityEffectController m_expirationChoiceEffect;

	[Token(Token = "0x4000185")]
	[FieldOffset(Offset = "0x80")]
	private List<AbilityEffectController> m_choiceEffects;

	[Token(Token = "0x4000186")]
	[FieldOffset(Offset = "0x88")]
	private ZoneController m_zoneController;

	[Token(Token = "0x4000187")]
	[FieldOffset(Offset = "0x90")]
	private Localizations m_localizationController;

	[Token(Token = "0x4000188")]
	[FieldOffset(Offset = "0x98")]
	private InventoryController m_inventoryController;

	[Token(Token = "0x4000189")]
	[FieldOffset(Offset = "0xA0")]
	private AbilitiesController m_abilitiesController;

	[Token(Token = "0x400018A")]
	[FieldOffset(Offset = "0xA8")]
	private int m_expiringIndex;

	[Token(Token = "0x17000019")]
	public ChoiceScene choiceScene
	{
		[Token(Token = "0x60001AF")]
		[Address(RVA = "0xA48E5C", Offset = "0xA48E5C", VA = "0xA48E5C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8338CC", Offset = "0x8338CC")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001B0")]
		[Address(RVA = "0xA48E64", Offset = "0xA48E64", VA = "0xA48E64")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8338DC", Offset = "0x8338DC")]
		private set
		{
		}
	}

	[Token(Token = "0x1700001A")]
	public int m_choiceApplied
	{
		[Token(Token = "0x60001B1")]
		[Address(RVA = "0xA47A04", Offset = "0xA47A04", VA = "0xA47A04")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8338EC", Offset = "0x8338EC")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60001B2")]
		[Address(RVA = "0xA48E6C", Offset = "0xA48E6C", VA = "0xA48E6C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8338FC", Offset = "0x8338FC")]
		private set
		{
		}
	}

	[Token(Token = "0x1700001B")]
	public bool m_hasTimer
	{
		[Token(Token = "0x60001B3")]
		[Address(RVA = "0xA48E74", Offset = "0xA48E74", VA = "0xA48E74")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83390C", Offset = "0x83390C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60001B4")]
		[Address(RVA = "0xA48E7C", Offset = "0xA48E7C", VA = "0xA48E7C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83391C", Offset = "0x83391C")]
		private set
		{
		}
	}

	[Token(Token = "0x1700001C")]
	public double m_timeLeft
	{
		[Token(Token = "0x60001B5")]
		[Address(RVA = "0xA48E88", Offset = "0xA48E88", VA = "0xA48E88")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83392C", Offset = "0x83392C")]
		get
		{
			return default(double);
		}
		[Token(Token = "0x60001B6")]
		[Address(RVA = "0xA48E90", Offset = "0xA48E90", VA = "0xA48E90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83393C", Offset = "0x83393C")]
		private set
		{
		}
	}

	[Token(Token = "0x60001B7")]
	[Address(RVA = "0xA48E98", Offset = "0xA48E98", VA = "0xA48E98")]
	public ChoiceSceneController(IActionScene inScene, PlayerActorController playerController)
	{
	}

	[Token(Token = "0x60001B8")]
	[Address(RVA = "0xA47608", Offset = "0xA47608", VA = "0xA47608")]
	public void SetExpiringIndex(int inExpiringIndex)
	{
	}

	[Token(Token = "0x60001B9")]
	[Address(RVA = "0xA49410", Offset = "0xA49410", VA = "0xA49410")]
	public void HandleChoiceRequest(int choiceIndex)
	{
	}

	[Token(Token = "0x60001BA")]
	[Address(RVA = "0xA498C8", Offset = "0xA498C8", VA = "0xA498C8")]
	public void ApplyExpirationChoice()
	{
	}

	[Token(Token = "0x60001BB")]
	[Address(RVA = "0xA49634", Offset = "0xA49634", VA = "0xA49634")]
	private void ApplyChoice(AbilityEffectController effectController, string bundleChoice, int choiceApplied)
	{
	}

	[Token(Token = "0x60001BC")]
	[Address(RVA = "0xA49934", Offset = "0xA49934", VA = "0xA49934")]
	public bool IsItemAnAbilityAmmo(Item requiredItem)
	{
		return default(bool);
	}

	[Token(Token = "0x60001BD")]
	[Address(RVA = "0xA49988", Offset = "0xA49988", VA = "0xA49988")]
	public bool IsAbilityRequirementsSatisfied(Item requiredItem, long requiredQuantity)
	{
		return default(bool);
	}

	[Token(Token = "0x60001BE")]
	[Address(RVA = "0xA499D8", Offset = "0xA499D8", VA = "0xA499D8")]
	public bool IsItemAnEquippedAbilityAmmo(Item requiredItem)
	{
		return default(bool);
	}

	[Token(Token = "0x60001BF")]
	[Address(RVA = "0xA49AC0", Offset = "0xA49AC0", VA = "0xA49AC0")]
	public long GetAbilityAmmoQuantity(Item requiredItem)
	{
		return default(long);
	}

	[Token(Token = "0x60001C0")]
	[Address(RVA = "0xA49A98", Offset = "0xA49A98", VA = "0xA49A98")]
	private bool HasEnoughAbilityAmmoQuantity(Item requiredItem, long requiredQuantity)
	{
		return default(bool);
	}

	[Token(Token = "0x60001C1")]
	[Address(RVA = "0xA49B14", Offset = "0xA49B14", VA = "0xA49B14")]
	public void PayRequirement(Item requiredItem, long requiredQuantity)
	{
	}

	[Token(Token = "0x60001C2")]
	[Address(RVA = "0xA49D34", Offset = "0xA49D34", VA = "0xA49D34", Slot = "9")]
	public override void Update(float deltaTime)
	{
	}
}
