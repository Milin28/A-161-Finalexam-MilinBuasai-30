using UnityEngine;

public abstract class PoewrUpBase : MonoBehaviour
{
    [SerializeField]public bool isEffectActive  = false;
    public abstract void ApplyEffect(Player player);
    
        
    

    

}

