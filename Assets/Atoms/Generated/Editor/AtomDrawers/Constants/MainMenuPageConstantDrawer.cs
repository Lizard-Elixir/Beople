#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Constant property drawer of type `MainMenuPage`. Inherits from `AtomDrawer&lt;MainMenuPageConstant&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(MainMenuPageConstant))]
    public class MainMenuPageConstantDrawer : VariableDrawer<MainMenuPageConstant> { }
}
#endif
