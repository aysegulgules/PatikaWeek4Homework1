using PatikaWeek4Homework1;

//-----------Öğrenci nesneleri --------------
Console.WriteLine("---------Öğrenciler--------------");

Persons student1 = new Persons();
student1.FirstName = "Gamze";
student1.LastName = "Tekir";
student1.BirthDate = new DateTime(2012,5,22);
student1.PersonsPrint();

Persons student2 = new Persons() {

    FirstName = "Serkan",
    LastName = "Dilgen",
    BirthDate = new DateTime(2010, 11, 2)
};
student2.PersonsPrint();

//-----------Öğretmen nesneler--------------
Console.WriteLine("---------Öğretmenler--------------");

Persons teacher1 = new Persons();
teacher1.FirstName = "Serap";
teacher1.LastName = "Gökova";
teacher1.BirthDate = new DateTime(1990, 6, 5);
teacher1.PersonsPrint();

Persons teacher2 = new Persons
{
    FirstName = "Ahmet",
    LastName = "Yıldırım",
    BirthDate = new DateTime(1985, 10, 14)
};
teacher2.PersonsPrint();