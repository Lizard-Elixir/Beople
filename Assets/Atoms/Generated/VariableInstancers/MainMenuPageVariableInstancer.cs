using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable Instancer of type `MainMenuPage`. Inherits from `AtomVariableInstancer&lt;MainMenuPageVariable, MainMenuPagePair, MainMenuPage, MainMenuPageEvent, MainMenuPagePairEvent, MainMenuPageMainMenuPageFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/MainMenuPage Variable Instancer")]
    public class MainMenuPageVariableInstancer : AtomVariableInstancer<
        MainMenuPageVariable,
        MainMenuPagePair,
        MainMenuPage,
        MainMenuPageEvent,
        MainMenuPagePairEvent,
        MainMenuPageMainMenuPageFunction>
    { }
}
