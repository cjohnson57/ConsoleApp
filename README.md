# ConsoleApp

An entityframework practice program. Connected to a database on my computer so you probably can't use it if you download it.

It's not actually a console app, it just started as one but over time it became a Windows Forms app.

The stuff I wrote is in C#, but the entityframework Powershell scripts are so long GitHub considers it a Powershell program.

Connects to a database of countries and prints a list of them (Form4.cs)

You can edit a country's properties (Form1.cs), delete a country (Form2.cs), or add a new country (Form3.cs)

You can also find a particular country so you don't have to scroll through the entire list (Form5.cs) 

For fun I added the ability to add a random country with an attempt at realistic values (besides name which is just a random string,
although then the 3-letter country code is based on that random string.)

A sample of some countries generated by the random button:


Code: XOD

Name: Xsiqowyabd

Continent: Europe

Surface Area: 180929

Population: 2.354657E+07

Life Expectancy: 73.9

GNP: 4.357083E+12

Head of State: John Johnson

---

Code: VEB

Name: Vwnemowmoba

Continent: Oceania

Surface Area: 28297

Population: 8434234

Life Expectancy: 70.69

GNP: 2.269377E+12

Head of State: James Martinez

---

Code: YRE

Name: Yirpee

Continent: Antarctica

Surface Area: 114877

Population: 5310608

Life Expectancy: 78.75

GNP: 3.721458E+12

Head of State: Maria Miller

---

Code: PRW

Name: Prow

Continent: Asia

Surface Area: 291295

Population: 1.162669E+07

Life Expectancy: 75.52

GNP: 2.375003E+12

Head of State: Thomas Robinson

---

For comparison, a few real countries:


Code: BRA

Name: Brazil

Continent: South America

Surface Area: 8516000

Population: 2.077E+08

Life Expectancy: 74.68

GNP: 3.075E+12

Head of State: Michel Temer

---

Code: GBR

Name: United Kingdom

Continent: Europe

Surface Area: 242500

Population: 6.564E+07

Life Expectancy: 81.6

GNP: 2.763E+12

Head of State: Theresa May

---

Code: EGY

Name: Egypt

Continent: Africa

Surface Area: 1001449

Population: 9.569E+07

Life Expectancy: 71.32

GNP: 1.063E+12

Head of State: Abdel Fattah el-Sisi
