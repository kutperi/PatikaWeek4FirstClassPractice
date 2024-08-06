// Öğrencilerin ve öğretmenlerin bilgilerini yönetmek için Person adında genel bir sınıf oluşturmanız isteniyor. Bu sınıfın özellikleri şunlar olmalı: Ad, Soyad, Doğum Tarihi.

// Person adında bir sınıf oluşturun ve bu özellikleri içeren public property 'ler (get/set) tanımlayın.

// Main metodu içinde, bu sınıftan birkaç öğrenci ve öğretmen nesnesi oluşturun ve bilgilerini konsola yazdırın. 


using PatikaWeek4FirstClassPractice;

// Creating the students and setting information about them.
Person student1 = new Person();

student1.Name = "Bilal";
student1.Surname = "Bilin";
student1.Statue = "öğrenci";
student1.BirthYear = 1997;

Person student2 = new Person();
student2.Name = "Azadi";
student2.Surname = "Kaya";
student2.Statue = "öğrenci";
student2.BirthYear = 1993;

Person teacher1 = new Person();

teacher1.Name = "İlhan Sami";
teacher1.Surname = "Çomak";
teacher1.Statue = "öğretmen";
teacher1.BirthYear = 1973;

// Calling the method to print informations.
student1.Introduce();
student2.Introduce();
teacher1.Introduce();