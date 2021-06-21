using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `MainMenuPage`. Inherits from `AtomEventReferenceListener&lt;MainMenuPage, MainMenuPageEvent, MainMenuPageEventReference, MainMenuPageUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/MainMenuPage Event Reference Listener")]
    public sealed class MainMenuPageEventReferenceListener : AtomEventReferenceListener<
        MainMenuPage,
        MainMenuPageEvent,
        MainMenuPageEventReference,
        MainMenuPageUnityEvent>
    { }
}
