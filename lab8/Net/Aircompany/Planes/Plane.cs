using System.Collections.Generic;

namespace Aircompany.Planes
{
    public abstract class Plane
    {
        public string Model { get; }
        public int MaxSpeed { get; }
        public int MaxFlightDistance { get; }
        public int MaxLoadCapacity { get; }

        public Plane(string model, int maxSpeed, int maxFlightDistance, int maxLoadCapacity)
        {
            Model = model;
            MaxSpeed = maxSpeed;
            MaxFlightDistance = maxFlightDistance;
            MaxLoadCapacity = maxLoadCapacity;
        }

        public override string ToString()
        {
            return "Plane{" +
                "model='" + Model + '\'' +
                ", maxSpeed=" + MaxSpeed +
                ", maxFlightDistance=" + MaxFlightDistance +
                ", maxLoadCapacity=" + MaxLoadCapacity +
                '}';
        }

        public override bool Equals(object obj)
        {
            var plane = obj as Plane;
            return plane != null &&
                   Model == plane.Model &&
                   MaxSpeed == plane.MaxSpeed &&
                   MaxFlightDistance == plane.MaxFlightDistance &&
                   MaxLoadCapacity == plane.MaxLoadCapacity;
        }

        public override int GetHashCode()
        {
            var hashCodeResult = -1043886837;
            const int hashCodeMultiplier = -1521134295;

            hashCodeResult = hashCodeResult * hashCodeMultiplier + EqualityComparer<string>.Default.GetHashCode(Model);
            hashCodeResult = hashCodeResult * hashCodeMultiplier + MaxSpeed.GetHashCode();
            hashCodeResult = hashCodeResult * hashCodeMultiplier + MaxFlightDistance.GetHashCode();
            hashCodeResult = hashCodeResult * hashCodeMultiplier + MaxLoadCapacity.GetHashCode();

            return hashCodeResult;
        }

    }
}
