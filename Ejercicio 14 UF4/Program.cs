using System;

namespace Ejercicio_12_UF4
{
    public class Furniture
    {
        private float weight;
        private double price;
        private bool set;
        private string name, material, color;

        public float Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public bool Set
        {
            get { return set; }
            set { set = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Material
        {
            get { return material; }
            set { material = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public Furniture(float weight, double price, bool set, string name, string material, string color)
        {
            Weight = weight;
            Price = price;
            Set = set;
            Name = name;
            Material = material;
            Color = color;
        }

        public virtual void ShowFurniture()
        {
            Console.WriteLine("Nombre: " + Name);
            Console.WriteLine("Peso: " + Weight);
            Console.WriteLine("Precio: " + Price);
            Console.WriteLine("Material: " + Material);
            Console.WriteLine("Color: " + Color);
            Console.WriteLine("¿Está montado? " + Set);
        }
    }

    public class Chair : Furniture
    {
        private int legs;

        public Chair(float weight, double price, bool set, string name, string material, string color, int legs)
            : base(weight, price, set, name, material, color)
        {
            Legs = legs;
        }

        public int Legs
        {
            get { return legs; }
            set { legs = value; }
        }

        public override void ShowFurniture()
        {
            base.ShowFurniture();
            Console.WriteLine("Número de patas: " + Legs);
        }
    }

    public class Table : Furniture
    {
        private int numberOfSeats;

        public Table(float weight, double price, bool set, string name, string material, string color, int numberOfSeats)
            : base(weight, price, set, name, material, color)
        {
            NumberOfSeats = numberOfSeats;
        }

        public int NumberOfSeats
        {
            get { return numberOfSeats; }
            set { numberOfSeats = value; }
        }

        public override void ShowFurniture()
        {
            base.ShowFurniture();
            Console.WriteLine("Número de asientos: " + NumberOfSeats);
        }
    }

    class Program
    {
        static void Main()
        {
            Furniture chair = new Chair(5.5f, 29.99, true, "Silla de cocina", "Ferro", "Blanco", 4);
            Furniture table = new Table(20.0f, 149.99, false, "Mesa de comedor", "Fusta", "Marrón", 6);

            chair.ShowFurniture();
            Console.WriteLine();
            table.ShowFurniture();
        }
    }
}
