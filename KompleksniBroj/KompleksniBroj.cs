﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom
{
    public struct KompleksniBroj
    {
        public KompleksniBroj(double realni, double imaginarni) {
            RealniDio = realni;
            ImaginarniDio = imaginarni;
        }

        static public KompleksniBroj operator +(KompleksniBroj br1, KompleksniBroj br2) {
            return new Oom.KompleksniBroj(br1.RealniDio + br2.RealniDio, br1.ImaginarniDio + br2.ImaginarniDio);
        }

        static public KompleksniBroj operator -(KompleksniBroj br1, KompleksniBroj br2)
        {
            return new Oom.KompleksniBroj(br1.RealniDio - br2.RealniDio, br1.ImaginarniDio - br2.ImaginarniDio);

        }
        public double RealniDio;
        public double ImaginarniDio;
    }
}
