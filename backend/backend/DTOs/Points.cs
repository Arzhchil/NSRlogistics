namespace backend.DTOs
{
    public class Points
    {
        public int PointX { get; set; }
        public int PointY { get; set; }

        public override bool Equals(object obj)
        {
            if (!(obj is Points points))
            {
                return false;
            }
            return this.PointX.Equals(points.PointX)
                && this.PointY.Equals(points.PointY);
        }

        public override int GetHashCode()
        {
            return this.PointX.GetHashCode()
                ^ this.PointX.GetHashCode();
        }
    }
}
