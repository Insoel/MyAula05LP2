using System;
using System.Collections.Generic;
using System.Text;

namespace GunDecorations
{
    public class GunClip : GunDecorator
    {
        public override int AmmoCapacity { get; }


        public GunClip(Gun gun) : base (gun) 
        {

        }

        public override string Render()
        {
            return gun.Render() + "with extended gun clip";
        }
    }
}
