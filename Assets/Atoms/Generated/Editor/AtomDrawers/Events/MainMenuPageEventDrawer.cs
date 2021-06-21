#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `MainMenuPage`. Inherits from `AtomDrawer&lt;MainMenuPageEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(MainMenuPageEvent))]
    public class MainMenuPageEventDrawer : AtomDrawer<MainMenuPageEvent> { }
}
#endif
