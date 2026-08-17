using Il2CppDummyDll;
using Uken.Core;
using Uken.Library.Inventory;
using Uken.Library.UkenTime;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x20004AF")]
	public class PowerController : UkenController
	{
		[Token(Token = "0x40015C9")]
		public const float c_typicalDeltaTime = 0.016667f;

		[Token(Token = "0x40015CA")]
		public const string c_powerResourceName = "power";

		[Token(Token = "0x40015CB")]
		public const string c_tapAndHoldAcknowledged = "tap_and_hold_shown";

		[Token(Token = "0x40015CC")]
		[FieldOffset(Offset = "0x12")]
		private bool m_isTap;

		[Token(Token = "0x40015CD")]
		[FieldOffset(Offset = "0x18")]
		private InventoryController m_inventoryController;

		[Token(Token = "0x40015CE")]
		[FieldOffset(Offset = "0x20")]
		private UkenTimeController m_time;

		[Token(Token = "0x40015CF")]
		[FieldOffset(Offset = "0x28")]
		private ConstructionController m_constructionController;

		[Token(Token = "0x40015D0")]
		[FieldOffset(Offset = "0x30")]
		private PlayerDataItem m_playerData;

		[Token(Token = "0x40015D1")]
		[FieldOffset(Offset = "0x38")]
		private float framesToTreatPowerAsPressed;

		[Token(Token = "0x170005F7")]
		private float timeToTreatPowerAsPressed
		{
			[Token(Token = "0x60022F5")]
			[Address(RVA = "0xA77264", Offset = "0xA77264", VA = "0xA77264")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170005F8")]
		public double PowerSliderRate
		{
			[Token(Token = "0x60022F6")]
			[Address(RVA = "0xA77278", Offset = "0xA77278", VA = "0xA77278")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x60022F7")]
			[Address(RVA = "0xA772C0", Offset = "0xA772C0", VA = "0xA772C0")]
			set
			{
			}
		}

		[Token(Token = "0x170005F9")]
		public double PowerCyclesPerSecond
		{
			[Token(Token = "0x60022F8")]
			[Address(RVA = "0xA77318", Offset = "0xA77318", VA = "0xA77318")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x170005FA")]
		public double timeSincePowerButtonPressed
		{
			[Token(Token = "0x60022F9")]
			[Address(RVA = "0xA77360", Offset = "0xA77360", VA = "0xA77360")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x60022FA")]
		[Address(RVA = "0xA77390", Offset = "0xA77390", VA = "0xA77390")]
		public void SetPowerButtonPressed()
		{
		}

		[Token(Token = "0x60022FB")]
		[Address(RVA = "0xA773C4", Offset = "0xA773C4", VA = "0xA773C4")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x839624", Offset = "0x839624")]
		public void PowerTapped()
		{
		}

		[Token(Token = "0x60022FC")]
		[Address(RVA = "0xA773C8", Offset = "0xA773C8", VA = "0xA773C8")]
		public PowerController(InventoryController inventoryController, UkenTimeController time, ConstructionController constructionController)
		{
		}

		[Token(Token = "0x60022FD")]
		[Address(RVA = "0xA77410", Offset = "0xA77410", VA = "0xA77410", Slot = "9")]
		public override void OnDataUpdated()
		{
		}

		[Token(Token = "0x60022FE")]
		[Address(RVA = "0xA774EC", Offset = "0xA774EC", VA = "0xA774EC", Slot = "6")]
		public override bool PostLoadContent()
		{
			return default(bool);
		}

		[Token(Token = "0x60022FF")]
		[Address(RVA = "0xA77568", Offset = "0xA77568", VA = "0xA77568", Slot = "7")]
		public override void Update(float deltaTime)
		{
		}

		[Token(Token = "0x6002300")]
		[Address(RVA = "0xA77688", Offset = "0xA77688", VA = "0xA77688")]
		public bool IsTapAndHoldAcknowledged()
		{
			return default(bool);
		}

		[Token(Token = "0x6002301")]
		[Address(RVA = "0xA776E4", Offset = "0xA776E4", VA = "0xA776E4")]
		public bool TryToAcknowledgeTapAndHold()
		{
			return default(bool);
		}

		[Token(Token = "0x6002302")]
		[Address(RVA = "0xA768C8", Offset = "0xA768C8", VA = "0xA768C8")]
		public void UpdatePowerSliderRate(float deltaTime)
		{
		}

		[Token(Token = "0x6002303")]
		[Address(RVA = "0xA777CC", Offset = "0xA777CC", VA = "0xA777CC")]
		private void UpdatePowerSliderPressed(float deltaTime)
		{
		}

		[Token(Token = "0x6002304")]
		[Address(RVA = "0xA77844", Offset = "0xA77844", VA = "0xA77844")]
		private void UpdatePowerSliderRecentlyReleased(float deltaTime, double timeSincePressed)
		{
		}

		[Token(Token = "0x6002305")]
		[Address(RVA = "0xA77990", Offset = "0xA77990", VA = "0xA77990")]
		private void UpdatePowerSliderReleased(float deltaTime, double timeSincePressed)
		{
		}
	}
}
