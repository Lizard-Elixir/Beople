using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Adds Variable Instancer's Variable of type MainMenuPage to a Collection or List on OnEnable and removes it on OnDestroy. 
    /// </summary>
    [AddComponentMenu("Unity Atoms/Sync Variable Instancer to Collection/Sync MainMenuPage Variable Instancer to Collection")]
    [EditorIcon("atom-icon-delicate")]
    public class SyncMainMenuPageVariableInstancerToCollection : SyncVariableInstancerToCollection<MainMenuPage, MainMenuPageVariable, MainMenuPageVariableInstancer> { }
}
