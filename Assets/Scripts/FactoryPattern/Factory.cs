using UnityEngine;

namespace Assets.Scripts.FactoryPattern
{
    public abstract class Factory : MonoBehaviour
    {
        public abstract IProduct GetProduct(Vector3 position);
        // shared method with all factories
        //…
    }
}
