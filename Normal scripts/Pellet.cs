using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Pellet // denotes class cannot be instanticiated directly - can never have generic pellet
{
    protected int bonus;
    protected string name;

    public Pellet(int bonus)  //  contructor
    {
        this.bonus = bonus;
        this.name = "pellet";
    }
}
   
