using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Assets.AltUnityTester.AltUnityServer
{
	[Token(Token = "0x2000597")]
	internal class AltUnityBaseClassFindObjectsCommand : AltUnityCommand
	{
		[Token(Token = "0x2000869")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x821618", Offset = "0x821618")]
		private sealed class _003C_003Ec__DisplayClass15_0
		{
			[Token(Token = "0x4002418")]
			[FieldOffset(Offset = "0x10")]
			public string cameraName;

			[Token(Token = "0x60033A7")]
			[Address(RVA = "0xC20C90", Offset = "0xC20C90", VA = "0xC20C90")]
			public _003C_003Ec__DisplayClass15_0()
			{
			}

			[Token(Token = "0x60033A8")]
			[Address(RVA = "0xC20CA8", Offset = "0xC20CA8", VA = "0xC20CA8")]
			internal bool _003CGetCamera_003Eb__0(Camera c)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200086A")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x821628", Offset = "0x821628")]
		private sealed class _003C_003Ec__DisplayClass15_1
		{
			[Token(Token = "0x4002419")]
			[FieldOffset(Offset = "0x10")]
			public List<GameObject> gameObjectsCameraFound;

			[Token(Token = "0x60033A9")]
			[Address(RVA = "0xC20C98", Offset = "0xC20C98", VA = "0xC20C98")]
			public _003C_003Ec__DisplayClass15_1()
			{
			}

			[Token(Token = "0x60033AA")]
			[Address(RVA = "0xC20CFC", Offset = "0xC20CFC", VA = "0xC20CFC")]
			internal bool _003CGetCamera_003Eb__1(Camera c)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200086B")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x821638", Offset = "0x821638")]
		private sealed class _003C_003Ec__DisplayClass15_2
		{
			[Token(Token = "0x400241A")]
			[FieldOffset(Offset = "0x10")]
			public Camera c;

			[Token(Token = "0x60033AB")]
			[Address(RVA = "0xC20E00", Offset = "0xC20E00", VA = "0xC20E00")]
			public _003C_003Ec__DisplayClass15_2()
			{
			}

			[Token(Token = "0x60033AC")]
			[Address(RVA = "0xC20E08", Offset = "0xC20E08", VA = "0xC20E08")]
			internal bool _003CGetCamera_003Eb__2(GameObject d)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6002ABF")]
		[Address(RVA = "0xC1E448", Offset = "0xC1E448", VA = "0xC1E448")]
		protected List<List<string>> ProcessPath(string path)
		{
			return null;
		}

		[Token(Token = "0x6002AC0")]
		[Address(RVA = "0xC1ECF4", Offset = "0xC1ECF4", VA = "0xC1ECF4")]
		private List<List<string>> AddEscapedCharactersBack(List<List<string>> pathSetCorrectly, List<char> escapeCharacters)
		{
			return null;
		}

		[Token(Token = "0x6002AC1")]
		[Address(RVA = "0xC1EA84", Offset = "0xC1EA84", VA = "0xC1EA84")]
		private List<List<string>> SetCondition(List<string> list)
		{
			return null;
		}

		[Token(Token = "0x6002AC2")]
		[Address(RVA = "0xC1F0D8", Offset = "0xC1F0D8", VA = "0xC1F0D8")]
		private List<string> ParseSelector(string selector)
		{
			return null;
		}

		[Token(Token = "0x6002AC3")]
		[Address(RVA = "0xC1E490", Offset = "0xC1E490", VA = "0xC1E490")]
		private string EliminateEscapedCharacters(string text, out List<char> escapedCharacters)
		{
			return null;
		}

		[Token(Token = "0x6002AC4")]
		[Address(RVA = "0xC1E674", Offset = "0xC1E674", VA = "0xC1E674")]
		private List<string> SeparateAxesAndSelectors(string path)
		{
			return null;
		}

		[Token(Token = "0x6002AC5")]
		[Address(RVA = "0xC1F324", Offset = "0xC1F324", VA = "0xC1F324")]
		public List<GameObject> FindObjects(GameObject gameObject, List<List<string>> conditions, int step, bool singleObject, bool directChildren, bool enabled)
		{
			return null;
		}

		[Token(Token = "0x6002AC6")]
		[Address(RVA = "0xC1FBDC", Offset = "0xC1FBDC", VA = "0xC1FBDC")]
		private bool CheckCondition(GameObject objectToCheck, List<string> listOfConditions)
		{
			return default(bool);
		}

		[Token(Token = "0x6002AC7")]
		[Address(RVA = "0xC20544", Offset = "0xC20544", VA = "0xC20544")]
		private static int CheckOption(string condition)
		{
			return default(int);
		}

		[Token(Token = "0x6002AC8")]
		[Address(RVA = "0xC1F8CC", Offset = "0xC1F8CC", VA = "0xC1F8CC")]
		private bool CheckConditionIfParent(List<string> list)
		{
			return default(bool);
		}

		[Token(Token = "0x6002AC9")]
		[Address(RVA = "0xC1F988", Offset = "0xC1F988", VA = "0xC1F988")]
		protected bool IsNextElementDirectChild(List<string> list)
		{
			return default(bool);
		}

		[Token(Token = "0x6002ACA")]
		[Address(RVA = "0xC1FB38", Offset = "0xC1FB38", VA = "0xC1FB38")]
		private List<GameObject> GetGameObjectsToCheck(GameObject gameObject)
		{
			return null;
		}

		[Token(Token = "0x6002ACB")]
		[Address(RVA = "0xC2089C", Offset = "0xC2089C", VA = "0xC2089C")]
		private List<GameObject> GetAllChildren(GameObject gameObject)
		{
			return null;
		}

		[Token(Token = "0x6002ACC")]
		[Address(RVA = "0xC206D4", Offset = "0xC206D4", VA = "0xC206D4")]
		private List<GameObject> GetAllRootObjects()
		{
			return null;
		}

		[Token(Token = "0x6002ACD")]
		[Address(RVA = "0xC209CC", Offset = "0xC209CC", VA = "0xC209CC", Slot = "4")]
		public override string Execute()
		{
			return null;
		}

		[Token(Token = "0x6002ACE")]
		[Address(RVA = "0xC20A34", Offset = "0xC20A34", VA = "0xC20A34")]
		protected Camera GetCamera(By cameraBy, string cameraPath)
		{
			return null;
		}

		[Token(Token = "0x6002ACF")]
		[Address(RVA = "0xC20CA0", Offset = "0xC20CA0", VA = "0xC20CA0")]
		public AltUnityBaseClassFindObjectsCommand()
		{
		}
	}
}
