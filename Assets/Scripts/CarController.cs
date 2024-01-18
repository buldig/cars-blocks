using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    private List<Car> _car = new List<Car>();

    public void AddCar(Car car)
    {
        _car.Add(car);
    }
}