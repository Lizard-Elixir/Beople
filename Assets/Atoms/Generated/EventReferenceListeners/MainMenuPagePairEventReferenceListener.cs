using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `MainMenuPagePair`. Inherits from `AtomEventReferenceListener&lt;MainMenuPagePair, MainMenuPagePairEvent, MainMenuPagePairEventReference, MainMenuPagePairUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/MainMenuPagePair Event Reference Listener")]
    public sealed class MainMenuPagePairEventReferenceListener : AtomEventReferenceListener<
        MainMenuPagePair,
        MainMenuPagePairEvent,
        MainMenuPagePairEventReference,
        MainMenuPagePairUnityEvent>
    { }
}
