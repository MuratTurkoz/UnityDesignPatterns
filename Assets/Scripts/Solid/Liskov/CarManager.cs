
using UnityEngine;
namespace Solid.Liskov
{
    public class CarManager : MonoBehaviour
    {
        RoadVehicle roadVehicle;
        // Start is called before the first frame update
        void Start()
        {
            roadVehicle.GoForward();
            roadVehicle.Speed = 5;
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
