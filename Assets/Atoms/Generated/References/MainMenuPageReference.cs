using System;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Reference of type `MainMenuPage`. Inherits from `AtomReference&lt;MainMenuPage, MainMenuPagePair, MainMenuPageConstant, MainMenuPageVariable, MainMenuPageEvent, MainMenuPagePairEvent, MainMenuPageMainMenuPageFunction, MainMenuPageVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class MainMenuPageReference : AtomReference<
        MainMenuPage,
        MainMenuPagePair,
        MainMenuPageConstant,
        MainMenuPageVariable,
        MainMenuPageEvent,
        MainMenuPagePairEvent,
        MainMenuPageMainMenuPageFunction,
        MainMenuPageVariableInstancer>, IEquatable<MainMenuPageReference>
    {
        public MainMenuPageReference() : base() { }
        public MainMenuPageReference(MainMenuPage value) : base(value) { }
        public bool Equals(MainMenuPageReference other) { return base.Equals(other); }
        protected override bool ValueEquals(MainMenuPage other)
        {
            throw new NotImplementedException();
        }
    }
}
