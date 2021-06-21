using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Value List of type `MainMenuPage`. Inherits from `AtomValueList&lt;MainMenuPage, MainMenuPageEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Value Lists/MainMenuPage", fileName = "MainMenuPageValueList")]
    public sealed class MainMenuPageValueList : AtomValueList<MainMenuPage, MainMenuPageEvent> { }
}
