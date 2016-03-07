using System;
using System.Collections.Generic;

public interface IAttack
{
    int Attack
    {
        get;
    }
}
public interface IDamageable
{

    void takedamage(int d);
}
public interface IStats
{
    int Health
    {
        get;
        set;
    }
}
public class Ninja : IAttack, IStats, IDamageable
{
    private int Damage = 5;
    private int HP = 20;
    public Ninja(int Damage, int HP)
    {
        if(HP <= 0)
        {
            Console.WriteLine("we ded");
        }
    }
    public int Attack
    {
        // Ninja n = new Ninja();
        // n.Attack;
        get
        {
            return Damage;
        }
    }
    public int Health
    {
        get
        {
            return HP;
        }
        set
        {
            HP = HP - Damage;
        }
    }

    public void takedamage(int D)
    {
        HP = HP - D;
    }
}
public class Duck : IAttack, IStats
{
    private int Damage = 10;
    private int HP = 200;
    public Duck(int Damage, int HP)
    {
        if (HP <= 0)
        {
            Console.WriteLine("we ded");
        }
    }
    public int Attack

    {
        get
        {
            return Damage;   
        }
    }
    public int Health
    {
        get
        {
            return HP;
        }
        set
        {
            HP = HP - Damage;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Ninja Jeff = new Ninja(5,20);
        Duck Dave = new Duck(10, 200);
        Jeff.takedamage(5);
        Jeff.takedamage(7);


        Console.ReadLine();
    }
}