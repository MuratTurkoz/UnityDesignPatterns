using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.FactoryPattern
{
    internal class ConcreteFactoryA : Factory
    {
        [SerializeField] private ProductA productPrefab;
        public override IProduct GetProduct(Vector3 position)
        {
            // create a Prefab instance and get the product component
            GameObject instance = Instantiate(productPrefab.gameObject, position, Quaternion.identity);
            ProductA newProduct = instance.GetComponent<ProductA>();
            // each product contains its own logic
            newProduct.Initialize();
            return newProduct;
        }
    }
}
