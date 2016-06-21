function solve(args) {
    var name = args[0].split(' ')[2];
    var surname = args[1].split(' ')[2];
    var age = args[2].split(' ')[2];
    var grade = args[3].split(' ')[2];
    var date = args[4].split(' ')[2];
    var town = args[5].split(' ')[2];

    var person = {};
    person.name = name;
    person.surname = surname;
    person.age = +age;
    person.grade = +grade;
    person.date = date;
    person.town = town;
    console.log(JSON.stringify(person));
}