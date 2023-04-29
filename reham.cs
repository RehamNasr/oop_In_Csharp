using System;
namespace Reham{
public  class Person{
  public string Name;
  public int Age;
  public Person(){
   
  }
  public Person(String name,int age){
    Name=name;
    Age=age;
  }
 public  virtual void print (){
    Console.WriteLine($"my name is {Name} and my age is {Age} ");

 }

}

public class Student:Person{
  public int Year;
  public float Gpa;
  public Student (string name,int age,int year,float gpa){
    Name=name;
    Age=age;
    Year=year;
    Gpa=gpa;
  }
  public override void print(){
    Console.WriteLine($"my name is {Name} and my age is {Age} and my gpa is {Gpa} and my year is {Year}");
  }

}
public class Staff:Person{
  public double Salarey;
  public int JoinYear;
  public Staff(String name,int age,double salarey,int joinyear){
     Name=name;
     Age=age;
     Salarey=salarey;
     JoinYear=joinyear;
  }
  public override void print(){
    Console.WriteLine($"my name is {Name} and my age is {Age}  and my salarey is {Salarey}");
  }
}
public class Database{
  public Person[] people=new Person[50];
  public int index=0; 
  public void AddStudent(Student student){
    people[index]=student;
    index++;
  }

  public void AddStaff(Staff staff){
    people[index]=staff;
    index++;
  }

   public void AddPerson(Person person){
    people[index]=person;
    index++;
  }

  public void printarr(){
    for (int i=0;i<index;i++){
      people[i].print();
    }
  }
}
public class Reham{
       private static void Main(){
         Database database=new Database();
         while(true){

         
         Console.Write("enter your option : 1)Add student 2)Add staff 3)Add Person 4)Print all ");
         int option=int.Parse(Console.ReadLine());
         switch (option){
        case 1:
        //student name age year gpa
            Console.Write("Enter Name: ");
            String name_student=Console.ReadLine();
            Console.Write("Enter age: ");
            int age_student=int.Parse(Console.ReadLine());
            Console.Write("Enter year: ");
            int year_student=int.Parse(Console.ReadLine());
            Console.Write("Enter gpa: ");
            float gpa_student=float.Parse(Console.ReadLine());
            Student obj_student=new Student(name_student,age_student,year_student,gpa_student);
            database.AddStudent(obj_student);
        break;

        case 2:
        //staff name age salaty join
            Console.Write("Enter Name: ");
            String name_staff=Console.ReadLine();
            Console.Write("Enter age: ");
            int age_staff=int.Parse(Console.ReadLine());
            Console.Write("Enter salarey: ");
            int salarey_staff=int.Parse(Console.ReadLine());
            Console.Write("Enter joinyear: ");
            int JoinYear_staff=int.Parse(Console.ReadLine());
            Staff obj_staff=new Staff(name_staff,age_staff,salarey_staff,JoinYear_staff);
            database.AddStaff(obj_staff);
        break;

        case 3:
        //person
          Console.Write("Enter Name: ");
          String name_person=Console.ReadLine();
          Console.Write("Enter age: ");
          int age_person=int.Parse(Console.ReadLine());
          Person obj_person=new Person(name_person,age_person);
          database.AddPerson(obj_person);
          break;
          
          case 4:
          //printarr
          database.printarr();
          return;
          break;
         }


       }
       }
}
    
}

