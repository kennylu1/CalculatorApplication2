namespace PersonDemo
{
    public interface I3DShape
    {
        int Volume();
    }
    public interface ICircularShape
    {
        int Circumference();
    }
    public class Cuboid : Polygon, I3DShape,I2DShape
    {

        public override int Area()
        {
            throw new NotImplementedException();
        }

        double I2DShape.Perimeter()
        {
            throw new NotImplementedException();
        }

        int I3DShape.Volume()
        {
            throw new NotImplementedException();
        }
    }
}
