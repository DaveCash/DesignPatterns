using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator.Decorators
{
    /* 
     Abstract class for the concrete decorators

     Decorator pattern can be implemented without this base decorator, but then every concrete decorator would need to implement every method on the interface even if it didn't need to.
     In other words, concrete decorators only need to implement methods they wish to add functionality to (see CumulativeAreaStoringDecorator)

    */
    public abstract class BaseShapeDecorator : IShape
    {
        protected IShape _decorated;

        public BaseShapeDecorator(IShape decorated)
        {
            _decorated = decorated ?? throw new ArgumentNullException(nameof(decorated));
        }

        public virtual void Draw()
        {
            _decorated.Draw();
        }

        public virtual decimal GetArea()
        {
            return _decorated.GetArea();
        }

        public virtual decimal GetCircumference()
        {
            return _decorated.GetCircumference();
        }
    }
}
