using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable Inspector of type `MainMenuPage`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(MainMenuPageVariable))]
    public sealed class MainMenuPageVariableEditor : AtomVariableEditor<MainMenuPage, MainMenuPagePair> { }
}
