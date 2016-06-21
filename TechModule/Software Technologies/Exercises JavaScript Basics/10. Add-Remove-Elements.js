function solve(args) {
    var elements = [];
    for (var i = 0; i < args.length; i++) {
        var obj = args[i].split(' ');
        var command = obj[0];
        var argument = +obj[1];

        if (command === 'remove'){
            elements.splice(argument,1)
        } else {
            elements.push(argument)
        }
    }

    for (var obj of elements){
        console.log(obj)
    }
}