#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `MainMenuPage`. Inherits from `AtomEventEditor&lt;MainMenuPage, MainMenuPageEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(MainMenuPageEvent))]
    public sealed class MainMenuPageEventEditor : AtomEventEditor<MainMenuPage, MainMenuPageEvent> { }
}
#endif
