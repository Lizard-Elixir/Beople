using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event of type `MainMenuPage`. Inherits from `AtomEvent&lt;MainMenuPage&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/MainMenuPage", fileName = "MainMenuPageEvent")]
    public sealed class MainMenuPageEvent : AtomEvent<MainMenuPage>
    {
    }
}
