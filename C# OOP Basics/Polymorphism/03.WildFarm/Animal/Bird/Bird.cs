﻿public abstract class Bird : Animal
{
    private double wingSize;

    public Bird(string name, double weight, double wingSize) 
        : base(name, weight)
    {
        this.WingSize = wingSize;
    }

    public double WingSize
    {
        get => this.wingSize;
        set => this.wingSize = value;
    }

    public override string ToString()
    {
        return $"{GetType().Name} [{this.Name}, {this.WingSize}, {this.Weight}, {this.FoodEaten}]";
    }
}
