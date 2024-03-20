using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmorPellet : Pellet // : is a word for extends
{
    public ArmorPellet() : base(1)
    {
        //we already have our instance of Pellet
        //differentiate our ArmorPellet from a normal Pellet
        base.name = base.name + " : ArmorPellet";
    }
}
