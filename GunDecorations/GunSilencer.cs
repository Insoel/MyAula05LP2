using System;
using System.Collections.Generic;
using System.Text;

namespace GunDecorations
{
    public class GunSilencer : GunDecorator
    {
        public override float NoiseLevel { get; }

        public GunSilencer(Gun gun) : base (gun)
        {

        }

        public override string Render()
        {
            return gun.Render() + "with silencer";
        }
    }
}
