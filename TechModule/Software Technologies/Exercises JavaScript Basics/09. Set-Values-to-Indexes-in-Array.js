function solve(args) {
    var arrayLength = +args[0];
    var array = new Array(arrayLength);
    for (var lineIndex = 1; lineIndex < args.length; lineIndex++) {
        var line = args[lineIndex].split(' ');
        var index = line[0];
        var value = line[2];
        array[index] = value;
    }

    for (var numberIndex = 0; numberIndex < array.length; numberIndex++) {
        if (array[numberIndex])
            console.log(array[numberIndex]);
        else {
            console.log(0);
        }
    }
}