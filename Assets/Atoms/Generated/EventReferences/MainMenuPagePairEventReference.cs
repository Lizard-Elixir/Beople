using System;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `MainMenuPagePair`. Inherits from `AtomEventReference&lt;MainMenuPagePair, MainMenuPageVariable, MainMenuPagePairEvent, MainMenuPageVariableInstancer, MainMenuPagePairEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class MainMenuPagePairEventReference : AtomEventReference<
        MainMenuPagePair,
        MainMenuPageVariable,
        MainMenuPagePairEvent,
        MainMenuPageVariableInstancer,
        MainMenuPagePairEventInstancer>, IGetEvent 
    { }
}
