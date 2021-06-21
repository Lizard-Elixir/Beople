using UnityEngine;
using System;

namespace UnityAtoms.BaseAtoms
{
	/// <summary>
	/// Variable of type `MainMenuPage`. Inherits from `AtomVariable&lt;MainMenuPage, MainMenuPagePair, MainMenuPageEvent, MainMenuPagePairEvent, MainMenuPageMainMenuPageFunction&gt;`.
	/// </summary>
	[EditorIcon("atom-icon-lush")]
	[CreateAssetMenu(menuName = "Unity Atoms/Variables/MainMenuPage", fileName = "MainMenuPageVariable")]
	public sealed class MainMenuPageVariable : AtomVariable<MainMenuPage, MainMenuPagePair, MainMenuPageEvent, MainMenuPagePairEvent, MainMenuPageMainMenuPageFunction>
	{
		protected override bool ValueEquals(MainMenuPage other)
		{
			return Value == other;
		}
	}
}
