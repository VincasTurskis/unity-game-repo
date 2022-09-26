using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resources
{
    private float money;
    public float GetMoney()
    {
        return money;
    }
    public void EditMoney(float amount)
    {
        money += amount;
    }


    private float oxygen;
    public float GetOxygen()
    {
        return oxygen;
    }
    public void EditOxygen(float amount)
    {
        oxygen += amount;
    }


    private float CO2;
    public float GetCO2()
    {
        return CO2;
    }
    public void EditCO2(float amount)
    {
        CO2 += amount;
    }


    private int lifeSupport;
    public int GetLifeSupport()
    {
        return lifeSupport;
    }
    public void EditLifeSupport(int amount)
    {
        lifeSupport += amount;
    }


    private float power;
    public float GetPower()
    {
        return power;
    }
    public void EditPower(float amount)
    {
        power += amount;
    }


    private float food;
    public float GetFood()
    {
        return food;
    }
    public void EditFood(float amount)
    {
        food += amount;
    }


    private float freshWater;
    public float GetFreshWater()
    {
        return freshWater;
    }
    public void EditFreshWater(float amount)
    {
        freshWater += amount;
    }


    private float dirtyWater;
    public float GetDirtyWater()
    {
        return dirtyWater;
    }
    public void EditDirtyWater(float amount)
    {
        dirtyWater += amount;
    }


    private int population;
    public int GetPopulation()
    {
        return population;
    }
    public void EditPopulation(int amount)
    {
        population += amount;
    }

    public Resources()
    {
        this.money = 0;
        this.oxygen = 0;
        this.CO2 = 0;
        this.lifeSupport = 0;
        this.power = 0;
        this.food = 0;
        this.freshWater = 0;
        this.dirtyWater = 0;
        this.population = 0;
    }
}