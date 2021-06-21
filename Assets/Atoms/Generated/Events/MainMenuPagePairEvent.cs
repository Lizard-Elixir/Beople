using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event of type `MainMenuPagePair`. Inherits from `AtomEvent&lt;MainMenuPagePair&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/MainMenuPagePair", fileName = "MainMenuPagePairEvent")]
    public sealed class MainMenuPagePairEvent : AtomEvent<MainMenuPagePair>
    {
    }
}
