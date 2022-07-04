using System;
using System.Collections.Generic;
using System.Linq;

using Model.Hyperions;

namespace Model
{
    public class HyperSet
    {
        public static HyperSet WorldHyperSet = new HyperSet(10000, 0);

        private HashSet<Hyperion> _hyperions;

        private double _value;

        private int _count;

        public HyperSet(double value) : this(value, DateTime.UtcNow.Ticks) { }

        public HyperSet(double value, long seed)
        {
            _value = value;

            Random random = new Random((int)seed);

            int _base = (int)Math.Round(Math.Log(value));

            int H = random.Next(_base + 1053, _base + 1978);

            H--; // Chi

            int deltaPercent = random.Next(9, 15);
            int d = (int)Math.Round(H * (double)deltaPercent / 100);

            if ((H - d) % 2 == 1)
                d += 1;

            H -= d; // Deltas

            int e = (int)Math.Round(H / 2.0);
            H /= 2; // Epsilons

            double rPercent = random.NextDouble() * (3.55 - 1.78) + 1.78;
            int r = (int)Math.Round(H * (double)rPercent / 100);

            H -= r; // Rarions

            int h = (int)Math.Round(H * 0.25);
            H -= h;

            int t = (int)Math.Round(H * 2.55 / 4);
            H -= t;

            int ksi = (int)Math.Round(H * 0.25 / 4);
            H -= t;

            int z = H;

            _hyperions = new HashSet<Hyperion>
            {
                new Chi(),
                new Deltas(d),
                new Epsilons(e),
                new Taus(t),
                new Xis(ksi),
                new Rarions(r),
                new Zetas(z),
                new Hues(h)
            };

            foreach (var hyp in _hyperions)
            {
                hyp.OnCountUpdate += Recount;
            }

            Recount();
        }

        public void SubscribeOnCountUpdate(Hyperion.CountUpdate update)
        {
            foreach (var h in _hyperions)
            {
                h.OnCountUpdate += update;
            }
        }

        public void Recount()
        {
            int count = 0;
            foreach (var h in _hyperions)
            {
                count += h.Count;
            }

            _count = count;
        }

        public double Density()
        {
            return _count / _value;
        }

        public T Get<T>() where T : Hyperion
        {
            return _hyperions.OfType<T>().First();
        }
    }
}
