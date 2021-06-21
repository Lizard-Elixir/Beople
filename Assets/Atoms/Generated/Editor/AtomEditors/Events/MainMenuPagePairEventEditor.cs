#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `MainMenuPagePair`. Inherits from `AtomEventEditor&lt;MainMenuPagePair, MainMenuPagePairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(MainMenuPagePairEvent))]
    public sealed class MainMenuPagePairEventEditor : AtomEventEditor<MainMenuPagePair, MainMenuPagePairEvent> { }
}
#endif
