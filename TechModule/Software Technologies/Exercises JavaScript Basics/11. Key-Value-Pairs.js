function solve(args) {
    var element = []
    var key = args[args.length-1]

    for (var i = 0; i < args.length - 1; i++) {
        var obj = args[i].split(' ');
        var keyElement = obj[0];
        var value = obj[1];

        if (keyElement === key){
            element.splice(0,1);
            element.push(value);
        }
    }

    if (element.length !== 0){
        console.log(element[0])
    } else {
        console.log('None')
    }
}