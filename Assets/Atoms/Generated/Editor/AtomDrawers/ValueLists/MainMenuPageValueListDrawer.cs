#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Value List property drawer of type `MainMenuPage`. Inherits from `AtomDrawer&lt;MainMenuPageValueList&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(MainMenuPageValueList))]
    public class MainMenuPageValueListDrawer : AtomDrawer<MainMenuPageValueList> { }
}
#endif
