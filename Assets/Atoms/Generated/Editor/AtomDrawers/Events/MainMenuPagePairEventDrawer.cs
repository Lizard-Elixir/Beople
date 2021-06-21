#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `MainMenuPagePair`. Inherits from `AtomDrawer&lt;MainMenuPagePairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(MainMenuPagePairEvent))]
    public class MainMenuPagePairEventDrawer : AtomDrawer<MainMenuPagePairEvent> { }
}
#endif
