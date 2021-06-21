using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Set variable value Action of type `MainMenuPage`. Inherits from `SetVariableValue&lt;MainMenuPage, MainMenuPagePair, MainMenuPageVariable, MainMenuPageConstant, MainMenuPageReference, MainMenuPageEvent, MainMenuPagePairEvent, MainMenuPageVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/MainMenuPage", fileName = "SetMainMenuPageVariableValue")]
    public sealed class SetMainMenuPageVariableValue : SetVariableValue<
        MainMenuPage,
        MainMenuPagePair,
        MainMenuPageVariable,
        MainMenuPageConstant,
        MainMenuPageReference,
        MainMenuPageEvent,
        MainMenuPagePairEvent,
        MainMenuPageMainMenuPageFunction,
        MainMenuPageVariableInstancer>
    { }
}
