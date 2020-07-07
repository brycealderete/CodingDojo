class Ninja {
    constructor(name, health){
        this.Name= name;
        this.Health=health;
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
const ninja1 = new Ninja("Bryce",100);
ninja1.sayName();
ninja1.showStats();
ninja1.drinkSake();

