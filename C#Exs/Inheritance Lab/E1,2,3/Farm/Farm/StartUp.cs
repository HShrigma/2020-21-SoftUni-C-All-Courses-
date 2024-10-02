/* T01 - Create class Animal with single method Eat();
 *       Create inherited class Animal->Dog with single method Bark();
 *----------------------------------------------------------------------
 * T02 - Create class Animal with single method Eat();
 *       Create inherited class Animal->Dog with single method Bark();
 *       Create inherited class Dog->Puppy with single method  Weep();
 *----------------------------------------------------------------------
 * T03 - Create class Animal with single method Eat();
 *       Create inherited class Animal->Dog with single method Bark();
 *       Create inherited class Animal->Cat with single mehthod Meow();
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace Farm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //T01:
            Animal animal = new Animal();
            animal.Eat(); //can perform own method
            Dog dog = new Dog();
            dog.Eat(); //can inherit from Animal
            dog.Bark(); //can perform own method
            //T01-------------------------

            //T02:
            Puppy puppy = new Puppy();
            puppy.Eat(); //can inherit from Animal
            puppy.Bark(); //can inherit from Dog
            puppy.Weep(); //can perform own method
            //T02-------------------------

            //T03:
            Cat cat = new Cat();
            cat.Eat(); //can inherit from Animal
            //cat.Bark(); -> returns error
            cat.Meow(); //can perform own method
            //dog.Meow(); -> returns error
            //T03-------------------------
        }
    }
}
