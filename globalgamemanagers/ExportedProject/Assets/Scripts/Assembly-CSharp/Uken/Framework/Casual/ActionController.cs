using Il2CppDummyDll;
using Uken.Core;
using Uken.Library.UkenTime;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x200049F")]
	public class ActionController : UkenController
	{
		[Token(Token = "0x4001534")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82EA3C", Offset = "0x82EA3C")]
		private PlayerActorController _003CplayerController_003Ek__BackingField;

		[Token(Token = "0x4001535")]
		[FieldOffset(Offset = "0x20")]
		private ZoneController m_zoneController;

		[Token(Token = "0x4001536")]
		[FieldOffset(Offset = "0x28")]
		private AM2InventoryController m_inventoryController;

		[Token(Token = "0x4001537")]
		[FieldOffset(Offset = "0x30")]
		private UkenTimeController m_timeController;

		[Token(Token = "0x4001538")]
		[FieldOffset(Offset = "0x38")]
		private RewardGroupsController m_rewardGroupController;

		[Token(Token = "0x4001539")]
		[FieldOffset(Offset = "0x40")]
		private RunController m_runController;

		[Token(Token = "0x400153A")]
		[FieldOffset(Offset = "0x48")]
		private bool paused;

		[Token(Token = "0x170005DE")]
		public PlayerActorController playerController
		{
			[Token(Token = "0x60021FB")]
			[Address(RVA = "0xA1F624", Offset = "0xA1F624", VA = "0xA1F624")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8394F4", Offset = "0x8394F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60021FC")]
			[Address(RVA = "0xA1F62C", Offset = "0xA1F62C", VA = "0xA1F62C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x839504", Offset = "0x839504")]
			private set
			{
			}
		}

		[Token(Token = "0x60021FD")]
		[Address(RVA = "0xA1F634", Offset = "0xA1F634", VA = "0xA1F634")]
		public ActionController(CasualDataStoreController dataController, ZoneController zoneController, AM2InventoryController inventoryController, UkenTimeController timeController, RewardGroupsController rewardGroupController)
		{
		}

		[Token(Token = "0x60021FE")]
		[Address(RVA = "0xA1F680", Offset = "0xA1F680", VA = "0xA1F680")]
		private void InitPlayerController()
		{
		}

		[Token(Token = "0x60021FF")]
		[Address(RVA = "0xA1F778", Offset = "0xA1F778", VA = "0xA1F778")]
		public ActionSceneController GoToFirstScene()
		{
			return null;
		}

		[Token(Token = "0x6002200")]
		[Address(RVA = "0xA1F864", Offset = "0xA1F864", VA = "0xA1F864")]
		public ActionSceneController GoToNextScene()
		{
			return null;
		}

		[Token(Token = "0x6002201")]
		[Address(RVA = "0xA1F8B0", Offset = "0xA1F8B0", VA = "0xA1F8B0")]
		public void FinalizeRun()
		{
		}

		[Token(Token = "0x6002202")]
		[Address(RVA = "0xA1F8E8", Offset = "0xA1F8E8", VA = "0xA1F8E8", Slot = "7")]
		public override void Update(float deltaTime)
		{
		}

		[Token(Token = "0x6002203")]
		[Address(RVA = "0xA1F964", Offset = "0xA1F964", VA = "0xA1F964")]
		public void SetPause(bool pause)
		{
		}
	}
}
