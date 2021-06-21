#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable property drawer of type `MainMenuPage`. Inherits from `AtomDrawer&lt;MainMenuPageVariable&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(MainMenuPageVariable))]
    public class MainMenuPageVariableDrawer : VariableDrawer<MainMenuPageVariable> { }
}
#endif
