using System;
using System.Collections;
using System.Collections.Generic;


namespace VirtualOverrideDemo
{
    class IEnumerableAndIEnumeratorDemo
    {
        //1. IEnumerable <T> for non generic collction
        //2. IEnumerable for generic collection
    
 
        /// <summary>
        /// IEnumerable<T> contains a single method that you must implement this interface;
        /// GetEnumerator(), which returns an IEnumerator<T> object.
        /// The returned IEnumrator<T> provides the ability to iterate through the collection 
        /// by exposing a Current property that points at the object we are currently at in the collection.
        /// 
        /// When it is recommended to use the IEnumerable Interface:
        /// - Your collection represents a massive database table,
        /// you don't want to copy the entire thing into memory and cause performance issues in your application
        
        /// When it is not recommended to use the IEnumerable Interface:
        /// you need the results right away and are possibly mutating / editing the objects later on.
        /// In this case, it is better to use an Array or a List
        /// </summary>
 
        /*
        static void Main(string[] args)
        {
            CatShelter shelter = new CatShelter();

            foreach (Cat cat in shelter)
            {
                if (!cat.IsNaughtyDog)
                {
                    cat.GiveTreat(2);
                }
                else
                {
                    cat.GiveTreat(1);
                }
            }
        }
        */
    }

    class Cat
    {
        //the name of the cat
        public string Name { get; set; }

        //is this a naughty Cat?
        public bool IsNaughtyCat { get; set; }

        //simple constructor
        public Cat(string name, bool isNaughtyDog)
        {
            this.Name = name;
            this.IsNaughtyCat = isNaughtyDog;

        }

        //This method will print how many treats the dog received
        public void GiveTreat(int numberOfTreats)
        {
            //print a message containing the number of treats and the name of the dog
            Console.WriteLine("Cat: {0} said meow {1} times!", Name, numberOfTreats);
        }
    }
    //a class named DogShelter this class contains a generic collction of type Dog
    //objects of this class can't be used inside a for each loop because it lacks an implementation of the IEnumerable interface
    class CatShelter : IEnumerable<Cat>
    {
        //list of type List<Cat>
        public List<Cat> cats;

        //this constrictor will initialize the cats list with some values
        public CatShelter()
        {
            //initialize the cats list using the collection initializer
            cats = new List<Cat>()
            {
                new Cat("Casper", false),
                new Cat("Sif", true),
                new Cat("Oreo", false),
                new Cat("Pixel", false)

            };
        }

        IEnumerator<Cat> IEnumerable<Cat>.GetEnumerator()
        {
            return cats.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }



    }
}
