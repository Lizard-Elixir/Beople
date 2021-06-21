using System;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `MainMenuPage`. Inherits from `AtomEventReference&lt;MainMenuPage, MainMenuPageVariable, MainMenuPageEvent, MainMenuPageVariableInstancer, MainMenuPageEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class MainMenuPageEventReference : AtomEventReference<
        MainMenuPage,
        MainMenuPageVariable,
        MainMenuPageEvent,
        MainMenuPageVariableInstancer,
        MainMenuPageEventInstancer>, IGetEvent 
    { }
}
