using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Assets.AltUnityTester.AltUnityServer
{
	[Token(Token = "0x2000599")]
	internal class AltUnityFindObjectsOldWayCommand : AltUnityCommand
	{
		[Token(Token = "0x6002ADC")]
		[Address(RVA = "0xC20E7C", Offset = "0xC20E7C", VA = "0xC20E7C")]
		protected GameObject FindObjectInScene(string objectName, bool enabled)
		{
			return null;
		}

		[Token(Token = "0x6002ADD")]
		[Address(RVA = "0xC219E8", Offset = "0xC219E8", VA = "0xC219E8")]
		private GameObject CheckChildren(GameObject obj, string[] pathList, bool enabled)
		{
			return null;
		}

		[Token(Token = "0x6002ADE")]
		[Address(RVA = "0xC2118C", Offset = "0xC2118C", VA = "0xC2118C")]
		private GameObject CheckPath(GameObject obj, string[] pathList, int pathListStep, bool enabled)
		{
			return null;
		}

		[Token(Token = "0x6002ADF")]
		[Address(RVA = "0xC22184", Offset = "0xC22184", VA = "0xC22184")]
		private GameObject CheckNextElementInPath(GameObject obj, string[] pathList, int pathListStep, bool enabled)
		{
			return null;
		}

		[Token(Token = "0x6002AE0")]
		[Address(RVA = "0xC22574", Offset = "0xC22574", VA = "0xC22574")]
		protected List<GameObject> FindObjectsInScene(string objectName, bool enabled)
		{
			return null;
		}

		[Token(Token = "0x6002AE1")]
		[Address(RVA = "0xC2335C", Offset = "0xC2335C", VA = "0xC2335C")]
		private List<GameObject> CheckChildrenForMultipleElements(GameObject obj, string[] pathList, bool enabled)
		{
			return null;
		}

		[Token(Token = "0x6002AE2")]
		[Address(RVA = "0xC228C4", Offset = "0xC228C4", VA = "0xC228C4")]
		private List<GameObject> CheckPathForMultipleElements(GameObject obj, string[] pathList, int pathListStep, bool enabled)
		{
			return null;
		}

		[Token(Token = "0x6002AE3")]
		[Address(RVA = "0xC21E4C", Offset = "0xC21E4C", VA = "0xC21E4C")]
		private static int CheckOption(string[] pathList, int pathListStep)
		{
			return default(int);
		}

		[Token(Token = "0x6002AE4")]
		[Address(RVA = "0xC23740", Offset = "0xC23740", VA = "0xC23740")]
		private List<GameObject> CheckNextElementInPathForMultipleElements(GameObject obj, string[] pathList, int pathListStep, bool enabled)
		{
			return null;
		}

		[Token(Token = "0x6002AE5")]
		[Address(RVA = "0xC23B28", Offset = "0xC23B28", VA = "0xC23B28", Slot = "4")]
		public override string Execute()
		{
			return null;
		}

		[Token(Token = "0x6002AE6")]
		[Address(RVA = "0xC23B90", Offset = "0xC23B90", VA = "0xC23B90")]
		public AltUnityFindObjectsOldWayCommand()
		{
		}
	}
}
