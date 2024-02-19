using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.FactoryPattern
{
    public class ProductA : MonoBehaviour, IProduct
    {
        [SerializeField] private string productName = "ProductA";
        public string ProductName
        {
            get => productName; set => productName
        = value;
        }
        private ParticleSystem particleSystem;
        public void Initialize()
        {
            // any unique logic to this product
            gameObject.name = productName;
            particleSystem = GetComponentInChildren<ParticleSystem>();
            particleSystem?.Stop();
            particleSystem?.Play();
        }
    }
}
