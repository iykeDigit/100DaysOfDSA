function buildArray(num){
    if(typeof(num) !== 'number'){
        return "num is not a number"
    }
    
    let arr = [];
    for(let i = 0; i < num; i++)
    {
        arr.push(i);
    }
    return arr;
}

function findFacts(obj){
    return `${obj.name} has a population of ${obj.population} and is located in ${obj.continent}.`
    //return obj.name + " has a population of " + obj.population + " and is located in " + obj.continent
}
let obj = {
    name: "Toronto",
    population: "6,197,000",
    continent: "North America"
}

console.log(findFacts(obj))