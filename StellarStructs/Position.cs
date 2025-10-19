namespace ExoScan.StellarStructs
{
    public class Position
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Position()
        {

        }

        public Position(IReadOnlyCollection<double> coordinates)
        {
            var data = coordinates.ToArray();
            X = data[0];
            Y = data[1];
            Z = data[2];
        }

        public Position(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public Position((double, double, double) starPos)
        {
            X = starPos.Item1;
            Y = starPos.Item2;
            Z = starPos.Item3;
        }

        public double GetDistance(Position position)
        {
            var dx = position.X - X;
            var dy = position.Y - Y;
            var dz = position.Z - Z;
            return Math.Sqrt(dx * dx + dy * dy + dz * dz);
        }
    }
}
