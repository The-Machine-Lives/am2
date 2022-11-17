using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Library.Inventory;
using UnityEngine;

[Token(Token = "0x2000116")]
public class SpeedBoosterItemView : BasicItemView, IVolumeModeItem
{
	[Token(Token = "0x200062D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x820458", Offset = "0x820458")]
	private sealed class _003C_003Ec__DisplayClass24_0
	{
		[Token(Token = "0x4001E5F")]
		[FieldOffset(Offset = "0x10")]
		public SpeedBoosterItemView _003C_003E4__this;

		[Token(Token = "0x4001E60")]
		[FieldOffset(Offset = "0x18")]
		public long volume;

		[Token(Token = "0x6002D1A")]
		[Address(RVA = "0xA0555C", Offset = "0xA0555C", VA = "0xA0555C")]
		public _003C_003Ec__DisplayClass24_0()
		{
		}

		[Token(Token = "0x6002D1B")]
		[Address(RVA = "0xA05890", Offset = "0xA05890", VA = "0xA05890")]
		internal void _003COnClickedButton_003Eb__0()
		{
		}
	}

	[Token(Token = "0x40006EB")]
	private const int c_confirmationRequiredForVolumeMultiplierThreshold = 100;

	[Token(Token = "0x40006EC")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Transform m_textEffectTransform;

	[Token(Token = "0x40006ED")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private AM2Text m_activateButtonText;

	[Token(Token = "0x40006EE")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private AM2Button m_button;

	[Token(Token = "0x40006EF")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private AM2Text m_totalDurationText;

	[Token(Token = "0x40006F0")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private AM2Text m_totalActiveCountText;

	[Token(Token = "0x40006F1")]
	[FieldOffset(Offset = "0x68")]
	private ProductionVolumeMode m_volumeMode;

	[Token(Token = "0x40006F2")]
	[FieldOffset(Offset = "0x70")]
	private SpeedBoosterPopupView m_parentView;

	[Token(Token = "0x40006F3")]
	[FieldOffset(Offset = "0x78")]
	private SpeedBooster m_booster;

	[Token(Token = "0x40006F4")]
	[FieldOffset(Offset = "0x80")]
	private Recipe m_recipe;

	[Token(Token = "0x40006F5")]
	[FieldOffset(Offset = "0x88")]
	private SpeedBoosterController m_speedBoosterController;

	[Token(Token = "0x40006F6")]
	[FieldOffset(Offset = "0x90")]
	private InventoryController m_inventoryController;

	[Token(Token = "0x40006F7")]
	[FieldOffset(Offset = "0x98")]
	private CasualViewMutex m_casualViewMutex;

	[Token(Token = "0x40006F8")]
	[FieldOffset(Offset = "0xA0")]
	private float m_timeUntilTextUpdate;

	[Token(Token = "0x170000EF")]
	public Transform textEffectParent
	{
		[Token(Token = "0x60007B8")]
		[Address(RVA = "0xA04498", Offset = "0xA04498", VA = "0xA04498")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60007B9")]
	[Address(RVA = "0xA044C8", Offset = "0xA044C8", VA = "0xA044C8")]
	protected void Awake()
	{
	}

	[Token(Token = "0x60007BA")]
	[Address(RVA = "0xA04578", Offset = "0xA04578", VA = "0xA04578")]
	protected void OnDestroy()
	{
	}

	[Token(Token = "0x60007BB")]
	[Address(RVA = "0xA04630", Offset = "0xA04630", VA = "0xA04630")]
	public void Initialize(SpeedBoosterPopupView parentView, SpeedBooster booster, Recipe recipe, CasualViewMutex casualViewMutex)
	{
	}

	[Token(Token = "0x60007BC")]
	[Address(RVA = "0xA048C0", Offset = "0xA048C0", VA = "0xA048C0")]
	private void UpdateView()
	{
	}

	[Token(Token = "0x60007BD")]
	[Address(RVA = "0xA04B78", Offset = "0xA04B78", VA = "0xA04B78")]
	private void UpdateActivateButton()
	{
	}

	[Token(Token = "0x60007BE")]
	[Address(RVA = "0xA04B9C", Offset = "0xA04B9C", VA = "0xA04B9C")]
	private void UpdateActivateButtonText()
	{
	}

	[Token(Token = "0x60007BF")]
	[Address(RVA = "0xA04F38", Offset = "0xA04F38", VA = "0xA04F38")]
	private void UpdateActivateButtonIsActive()
	{
	}

	[Token(Token = "0x60007C0")]
	[Address(RVA = "0xA04FF4", Offset = "0xA04FF4", VA = "0xA04FF4")]
	private long GetVolume()
	{
		return default(long);
	}

	[Token(Token = "0x60007C1")]
	[Address(RVA = "0xA05114", Offset = "0xA05114", VA = "0xA05114")]
	private void OnClickedButton()
	{
	}

	[Token(Token = "0x60007C2")]
	[Address(RVA = "0xA055B4", Offset = "0xA055B4", VA = "0xA055B4")]
	private void ReleaseOKPromptMutex()
	{
	}

	[Token(Token = "0x60007C3")]
	[Address(RVA = "0xA05564", Offset = "0xA05564", VA = "0xA05564")]
	private void ActivateBoosters(long volume)
	{
	}

	[Token(Token = "0x60007C4")]
	[Address(RVA = "0xA05814", Offset = "0xA05814", VA = "0xA05814")]
	protected void Update()
	{
	}

	[Token(Token = "0x60007C5")]
	[Address(RVA = "0xA05870", Offset = "0xA05870", VA = "0xA05870", Slot = "4")]
	public void OnChangeVolumeMode(ProductionVolumeMode volumeMode)
	{
	}

	[Token(Token = "0x60007C6")]
	[Address(RVA = "0xA05888", Offset = "0xA05888", VA = "0xA05888")]
	public SpeedBoosterItemView()
	{
	}
}
