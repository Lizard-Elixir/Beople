using System;
using UnityEngine;
namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// IPair of type `&lt;MainMenuPage&gt;`. Inherits from `IPair&lt;MainMenuPage&gt;`.
    /// </summary>
    [Serializable]
    public struct MainMenuPagePair : IPair<MainMenuPage>
    {
        public MainMenuPage Item1 { get => _item1; set => _item1 = value; }
        public MainMenuPage Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private MainMenuPage _item1;
        [SerializeField]
        private MainMenuPage _item2;

        public void Deconstruct(out MainMenuPage item1, out MainMenuPage item2) { item1 = Item1; item2 = Item2; }
    }
}