using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Solid.InterfaceSegregation
{
    public interface IUnitStats
    {
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Endurance { get; set; }
    }
}
