
using UnityEngine;
namespace Solid.Liskov
{
    public class TrainManager : MonoBehaviour
    {
        private RailVehicle _railVehicle;
        // Start is called before the first frame update
        void Start()
        {
            _railVehicle.Speed = 2;
            _railVehicle.GoForward();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
