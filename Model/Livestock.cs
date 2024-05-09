﻿namespace Task4_MVVE.Model;

public class Livestock
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public string Type { get => this.GetType().Name; }
    public float Cost { get; set; }
    public float Weight { get; set; }
    public string Colour { get; set; }
    public override string ToString()
    {
        return $"Type {Type}, ID {Id}, Cost ${Cost}, Weight {Weight} kg, Colour {Colour}";
    }
}
[Table("Cow")]
public class Cow : Livestock
{
    public float Milk { get; set; }
    public override string ToString()
    {
        return base.ToString() + ", Milk " + Milk.ToString() + " kg";
    }
    public Cow(string cost, string weight, string colour, string milk)
    {
        Cost = Util.VerifyFloat(cost);
        Weight = Util.VerifyFloat(weight);
        Colour = colour;
        Milk = Util.VerifyFloat(milk);
    }
}
[Table("Sheep")]
public class Sheep : Livestock
{
    public float Wool { get; set; }
    public override string ToString()
    {
        return base.ToString() + ", Wool " + Wool.ToString() + " kg";
    }
    public Sheep(string cost, string weight, string colour, string wool)
    {
        Cost = Util.VerifyFloat(cost);
        Weight = Util.VerifyFloat(weight);
        Colour = colour;
        Wool = Util.VerifyFloat(wool);
    }
}
