namespace ClassLibrary
{
    public abstract class BaseFigure
    {

        protected Lazy<double> area;

        public double Area { get { return area.Value; } }

        protected BaseFigure() 
        {
            area = new Lazy<double>(CalculateArea);        
        }

        public abstract double CalculateArea();

    }
}