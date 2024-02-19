using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.FactoryPattern
{
    internal class ConcreteFactoryB : Factory
    {
        public override IProduct GetProduct(Vector3 position)
        {
            throw new NotImplementedException();
        }
    }
}
