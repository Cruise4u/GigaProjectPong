using System;
public class OOPClass
{
    #region <-Abstraction ->

    #region Redudant Boiler plate code Example
    // Things to take in consideration..
    // Nested class (In this case it's okey not to have public as prefix for class since we're only using the data inside the class itself)
    // However, a great majority of times you want to make classes public so they are visible and editable in the editor or to other classes
    // To reference them..
    //public class RedudantExample
    //{
    //    class Wolf
    //    {
    //        public void Eat()
    //        {
    //            Console.WriteLine("I'm eating game! Auoooo");
    //        }
    //    }


    //    class Sheep
    //    {
    //        public void Eat()
    //        {
    //            Console.WriteLine("I'm eating grass! Mheeee");
    //        }
    //    }

    //    class AnimalWorld
    //    {
    //        Wolf wolf = new Wolf();
    //        Sheep sheep = new Sheep();

    //        public void Biome()
    //        {
    //            wolf.Eat();
    //            sheep.Eat();
    //        }
    //    }

    //    public void ExampleTest()
    //    {
    //        AnimalWorld animalWorld = new AnimalWorld();
    //        animalWorld.Biome();
    //    }
    //}
    #endregion

    #region Good Example
    public class OOPAbstractionExample
    {
        public abstract class AnimalGoodExample
        {
            public string Name { get => _name; set => _name = value; }
            private string _name;
            public abstract void Eat();
            //public abstract void DoSpecificAnimalStuff();
            //public virtual void DoDefaultAnimalStuff()
            //{
            //    Eat();
            //}
        }

        public class WolfGoodExample : AnimalGoodExample
        {
            public override void Eat()
            {
                Console.WriteLine("Like all animals, since i'm a " + Name + "I'm eating my food");
            }

            public void DoWolfStuff()
            {
                Eat();
                Console.WriteLine("I'm a wolf, i'm going to howl since tonight it's full moon!");
            }

            //public override void DoSpecificAnimalStuff()
            //{
            //    DoDefaultAnimalStuff();
            //    Console.WriteLine("I'm a wolf, i'm going to howl since tonight it's full moon!");
            //}

            //public override void DoDefaultAnimalStuff()
            //{
            //    base.DoDefaultAnimalStuff();
            //    Console.WriteLine("I'm a wolf, i'm going to howl since tonight it's full moon!");
            //}
        }

        public class SheepGoodExample : AnimalGoodExample
        {
            public override void Eat()
            {
                Console.WriteLine("Like all animals, since i'm a " + Name + "I'm eating my food");
            }

            public void DoSheepStuff()
            {
                Eat();
            }

            //public override void DoSpecificAnimalStuff()
            //{
            //    DoDefaultAnimalStuff();
            //    Console.WriteLine("I'm a sheep, i'm going to baa since i'm happy!");
            //}

            //public override void DoDefaultAnimalStuff()
            //{
            //    base.DoDefaultAnimalStuff();
            //    Console.WriteLine("I'm a sheep, i'm going to baa since i'm happy!");
            //}
        }

        public class AnimalWorldGE
        {
            WolfGoodExample wolf = new WolfGoodExample();
            SheepGoodExample sheep = new SheepGoodExample();
            public void Biome()
            {
                wolf.Name = "Wolf";
                sheep.Name = "Sheep";

                wolf.DoWolfStuff();
                sheep.DoSheepStuff();


            }



        }
    }
    #endregion

    #endregion

    #region <- Encapsulation ->
    public class OOPEncapsulationExample
    {
        public class Animal
        {
            public string Name { get; set; }
        }



        public class EncapsExample
        {
            Animal animal = new Animal();

            public void SetAnimalName(string name)
            {
                animal.Name = name;
            }
        }

        public class AnimalWorldEncapsulationExample
        {

        }
    }


    #endregion














}