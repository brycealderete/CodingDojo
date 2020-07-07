class Ninja {
    constructor(name){
        this.Name= name;
        this.Health=100;
        this.Strength=3;
        this.Speed=3;
    
        }
    sayName(){
        console.log(this.Name);
    }
    showStats(){
        console.log(`welcome ${this.Name} health ${this.Health} strength ${this.Strength} speed ${this.Speed}`);
    }
    drinkSake(){
        this.Health+=10;
        console.log(this.Health);
    }

}
class Sensei extends Ninja{
    constructor(name){
        super(name);
        this.Wisdom= 10;

    }
    speakWisdom(){
        console.log("What one programmer can do in one month, two programmers can do in two months.")
    }
}



const ninja1 = new Ninja("Bryce");
ninja1.sayName();
ninja1.showStats();
ninja1.drinkSake();
const superSensei1 = new Sensei("Bryce 2.0");
console.log(superSensei1.Wisdom);
superSensei1.showStats();
superSensei1.speakWisdom();



