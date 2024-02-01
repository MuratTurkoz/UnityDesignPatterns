
using Solid.Liskov;
using UnityEngine;

namespace Solid.Liskov
{
    public class RoadVehicle : Car, IMovable, ITurnable
    {
        [SerializeField] private float _turnSpeed;
        public void GoForward()
        {

        }

        public void Reverse()
        {

        }

        public void TurnLeft()
        {

        }

        public void TurnRight()
        {

        }
    }
}


