class Card {
    constructor(name, cost){
        this.name=name;
        this.cost=cost;
    }
}
class Unit extends Card{
    constructor(name,cost,power,res){
        super(name,cost);
            this.power=power;
            this.res=res;
        
    }
    attack(target){
        if( target instanceof Unit ) {
            target.res-=this.power;
            console.log(target.res);
            // implement card text here
        } 
        else {
            throw new Error( "Target must be a unit!" );
        }
    }
        
    
    play(effect){
        // if( effect instanceof Unit ) {
            let num=effect.magnitude;
            if (effect.stat== "res"){
            this.res+=num;
            }
            if (effect.stat=="power")
            this.power+=num;
            // implement card text here
        // } else {
            // throw new Error( "Efect must be a unit!" );
        // }
    }
        
    
}

class Effect extends Card{
    constructor(name,cost,text,stat,magnitude){
        super(name,cost);
        this.text=text;
        this.stat=stat;
        this.magnitude=magnitude;
    }
}

const RedBeltNinja= new Unit("Red Belt Ninja",3,3,4);
const BlackBeltNinja= new Unit("Black Belt Ninja",4,5,4);
const HardAlgorithm=new Effect("Hard Aligorithm",2,"increase target's resilience by 3","res",3);
const UnhandledPromiseRejection=new Effect("UnhandledcPromisecRejection",1,"reduce target's resilience by 2","res",-2);
const PairProgramming=new Effect("Pair Programming",3,"increase target's power by 2	","power",2);
RedBeltNinja.play(HardAlgorithm);
console.log(RedBeltNinja.res);
RedBeltNinja.play(UnhandledPromiseRejection);
RedBeltNinja.play(PairProgramming);
RedBeltNinja.attack(BlackBeltNinja);
RedBeltNinja.attack(BlackBeltNinja);

