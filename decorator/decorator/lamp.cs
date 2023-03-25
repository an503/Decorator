using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lamp_decorator
{
    
        abstract class Lamp
    {
            public Lamp(string n)
            {
                this.Name = n;
            }
            public string Name { get; protected set; }
            public abstract string GetCost();
        }

        class IncandescentLamp : Lamp
    {
        public IncandescentLamp()
        {
        }

        public IncandescentLamp(IncandescentLamp lamp1) : base("Лампа розжарювання")
            { }
            public override string GetCost()
            {
                return "10";
            }
        }
        class HalogenLamp : Lamp
    {
        public HalogenLamp()
        {
        }

        public HalogenLamp(Lamp lamp2)
                : base("Галогенна лампа")
            { }
            public override string GetCost()
            {
                return "168";
            }
        }

        abstract class LampDecorator : Lamp
    {
            protected Lamp lamp;
            public LampDecorator(string n, Lamp lamp) : base(n)
            {
                this.lamp = lamp;
            }
        }

        class EfectLamp : LampDecorator
    {
            public EfectLamp(Lamp p)
                : base(p.Name + ", Ефективність 100Lm", p)
            { }

            public override string GetCost()
            {
                return lamp.GetCost() + "200";
            }
        }

        class IndexLamp : LampDecorator
    {
            public IndexLamp(Lamp p)
                : base(p.Name + ", Індекс лампи 80", p)
            { }

            public override string GetCost()
            {
                return lamp.GetCost() + "205";
            }
        }
    
}
