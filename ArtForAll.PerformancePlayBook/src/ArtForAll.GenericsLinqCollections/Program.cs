using ArtForAll.GenericsLinqCollections.Models;
using ArtForAll.Performance.GenericsLinQCollections.repositories;
using ArtForAll.Performance.GenericsLinQCollections.services;
using ArtForAll.GenericsLinqCollections.reflection;
using ArtForAll.GenericsLinqCollections.reflection.Exercises;
using ArtForAll.GenericsLinqCollections.Varianza;
using Generic.Commands;
//var studentRepo = new StudentRepository();
//var studentService = new StudentService(studentRepo);
//studentService.PrintStudentsSearch("Castro");

//ReflectionSamples.Execute();
//var ex = new ContraVarianceExc();
//ex.Execute();



//var exec = new Executer();
//exec.Execute();
//BENEFITS GENERICS
//COde reuse
//Avoid casting improve performance
//TYpe safety

//WILL NOT COMPILE
//IAuthor : IEntity<string, TValue>
//IAuthor : IEntity<TKey, Author>

//WILL WORK
//IAuthor : IEntity<string, Author>
//IAuthor<TKey, TValue> : IEntity<TKey, TValue>
//IAuthor<TValue> : IEntity<string, TValue>


//IENUMERABLE
//implements the iterator pattern
//The basis for the foreach loop pattern
//Most linq method are buit on top IEnumerable

//CONSTRAINTS GENERICS
//1. where T : new()
//must have a parameterless contructor
//Must be defined at the end of the constraints list
//2. where T: notnull
//3. where T : unmanaged
//must be a non nullable unmanaged type
//implies that the type is struct
//4. where T: class, struct
//5 where T: BaseEntity, IEntity

using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
// Datos de ejemplo
var personas = new List<Persona>
{
    new Persona { Nombre = "Juan", Edad = 30 },
    new Persona { Nombre = "Oliver", Edad = 30 },
    new Persona { Nombre = "María", Edad = 25 },
    new Persona { Nombre = "Pedro", Edad = 35 },
    new Persona { Nombre = "Ana", Edad = 22 }
};

var mayoresDe25 = personas.Where(p => p.Edad > 25)
    .OrderBy(p => p.Edad);

foreach (var persona in mayoresDe25)
{
    Console.WriteLine($"Nombre: {persona.Nombre}, Edad: {persona.Edad}");
}

IEnumerable<string> selectNames = personas.Select(p => p.Nombre)
    .OrderBy(p => p);
foreach (var persona in selectNames)
{
    Console.WriteLine($"Nombre: {persona}");
}

var Exist = personas.Any(p => p.Edad < 10);
Console.WriteLine(Exist);

var allExist = personas.All(p => p.Edad > 10);
Console.WriteLine(allExist);

var juan = personas.FirstOrDefault(p => p.Nombre.Equals("Juan"));
Console.WriteLine($"Nombre: {juan.Nombre}, Edad: {juan.Edad}");

var count = personas.Count();

var grouped = personas.GroupBy(p => p.Edad);

foreach (var group in grouped)
{
    Console.WriteLine(group.Key);

    foreach (var item1 in group)
    {
        Console.WriteLine($"Nombre: {item1.Nombre}, Edad: {item1.Edad}");

    }
}

Persona sdsd = new Persona();
sdsd.AnonimousFunc();
sdsd.LambdaExpresion();


class Persona
{
    public string Nombre { get; set; }
    public int Edad { get; set; }

    public delegate string MyDel(string argument);

    public void AnonimousFunc()
    {
        MyDel delegateHere = delegate (string name) { return name.ToUpper(); };
        ReceiveDel(delegateHere);

        MyFunc((string name) => name.ToUpper());
        MyFunc(delegate (string name) 
        {
            return name.ToUpper();
        });  
    }

    public void LambdaExpresion()
    {
        MyDel lambDaf = (string name)=> name.ToUpper();
        ReceiveDel(lambDaf);

        MyAction((string name, string lastName) => Console.WriteLine($"{name} {lastName}"));
    }

    public void ReceiveDel(MyDel myDel)
    {
        Console.WriteLine(myDel("Oliver"));
    }

    public void MyFunc(Func<string, string> myFunc)
    {
        Console.WriteLine(myFunc("Oliver"));
    }

    public void MyAction(Action<string, string> action)
    {
        action("Oliver", "Castro");
    }
}



