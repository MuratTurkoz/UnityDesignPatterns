using System;
using UnityEngine;

namespace Assets.Scripts.FactoryPattern
{
    public class ProductB : MonoBehaviour, IProduct
    {
        public string ProductName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Initialize()
        {
            throw new NotImplementedException();
        }
    }
}
