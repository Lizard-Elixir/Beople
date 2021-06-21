using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Instancer of type `MainMenuPage`. Inherits from `AtomEventInstancer&lt;MainMenuPage, MainMenuPageEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/MainMenuPage Event Instancer")]
    public class MainMenuPageEventInstancer : AtomEventInstancer<MainMenuPage, MainMenuPageEvent> { }
}
