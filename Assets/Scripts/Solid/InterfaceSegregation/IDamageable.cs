using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Solid.InterfaceSegregation
{
    public interface IDamageable
    {
        public float Health { get; set; }
        public int Defense { get; set; }
        public void Die();
        public void TakeDamage();
        public void RestoreHealth();
    }
}
