
using UnityEngine;
namespace Solid.InterfaceSegregation
{
    public class ExplodingBarrel : MonoBehaviour,IDamageable,IExplodable
    {
        public float Health { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public int Defense { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public float Mass { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public float ExplosiveForce { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public float FuseDelay { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public void Die()
        {
            throw new System.NotImplementedException();
        }

        public void Explode()
        {
            throw new System.NotImplementedException();
        }

        public void RestoreHealth()
        {
            throw new System.NotImplementedException();
        }

        public void TakeDamage()
        {
            throw new System.NotImplementedException();
        }

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}

