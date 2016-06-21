function solve(args) {
    var persons = []
    for (var obj of args){
        var argumentToJSON = JSON.parse(obj);
        persons.push(argumentToJSON);
    }

    for (var person of persons){
        console.log('Name: ' + person.name)
        console.log('Age: ' + person.age)
        console.log('Date: ' + person.date)
    }
}