function solve(args) {
    let negative = 0
    for (let i = 0; i < args.length; i++) {
        let obj = args[i];
        if (obj < 0)
            negative++
    }

    if (negative%2==0)
        return "Positive"
    else
        return "Negative"
}