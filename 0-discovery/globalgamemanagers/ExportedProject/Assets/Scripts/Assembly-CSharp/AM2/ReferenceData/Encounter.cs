using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Library.Inventory;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000328")]
	public class Encounter : RuntimeData<RDEncounter>
	{
		[Token(Token = "0x4000FA8")]
		[FieldOffset(Offset = "0x18")]
		private List<IActionScene> m_scenes;

		[Token(Token = "0x4000FA9")]
		[FieldOffset(Offset = "0x20")]
		private bool isSelectInSequence;

		[Token(Token = "0x4000FAA")]
		[FieldOffset(Offset = "0x24")]
		private int m_totalWeight;

		[Token(Token = "0x4000FAB")]
		[FieldOffset(Offset = "0x28")]
		private InventoryController m_inventoryController;

		[Token(Token = "0x600198B")]
		[Address(RVA = "0x9B14F4", Offset = "0x9B14F4", VA = "0x9B14F4")]
		public Encounter()
		{
		}

		[Token(Token = "0x600198C")]
		[Address(RVA = "0x9B1614", Offset = "0x9B1614", VA = "0x9B1614")]
		public void Setup(Dictionary<string, IActionScene> allActionScenes)
		{
		}

		[Token(Token = "0x600198D")]
		[Address(RVA = "0x9B1A44", Offset = "0x9B1A44", VA = "0x9B1A44")]
		public void SetupWithSingleScene(IActionScene scene)
		{
		}

		[Token(Token = "0x600198E")]
		[Address(RVA = "0x9B1AC0", Offset = "0x9B1AC0", VA = "0x9B1AC0")]
		private bool IsAlreadyVisitedQuestScene(IActionScene scene)
		{
			return default(bool);
		}

		[Token(Token = "0x600198F")]
		[Address(RVA = "0x9B1878", Offset = "0x9B1878", VA = "0x9B1878")]
		private bool CanVisitScene(IActionScene scene)
		{
			return default(bool);
		}

		[Token(Token = "0x6001990")]
		[Address(RVA = "0x9B1CB0", Offset = "0x9B1CB0", VA = "0x9B1CB0")]
		public IActionScene SelectScene()
		{
			return null;
		}

		[Token(Token = "0x6001991")]
		[Address(RVA = "0x9B1E48", Offset = "0x9B1E48", VA = "0x9B1E48")]
		public int SceneCount()
		{
			return default(int);
		}
	}
}
