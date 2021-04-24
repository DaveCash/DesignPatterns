using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public interface IShape
    {
        public void Draw();

        public decimal GetArea();

        public decimal GetCircumference();
    }
}
