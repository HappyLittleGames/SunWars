﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.BHTree
{
    class Munitions : Sequence
    {
        private List<Weapon> m_weaponry = new List<Weapon>();

        public Munitions()
        {
            Initialize = () =>
            {
                SetSequence(new List<IBehaviour>
                {
                    new MunitionsAim(),
                    new MunitionsFire(),
                    new MunitionsReload()
                });
            };
        }

        public void AddWeaponry(Weapon weapon)
        {
            m_weaponry.Add(weapon);
        }
    }
}
