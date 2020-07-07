import React, {Component} from 'react';

class PersonCard extends Component{
    constructor(props){
        super(props);
        this.state={
            Age: props.age
        };
    }
        
    addYear =()=>{
        this.setState({Age: this.state.Age+1});
    }

    render(){
        return(
            <div>
                <h1>{this.props.firstName}, {this.props.lastName}</h1>
                <p>Age: {this.state.Age}</p>
                <p>Hair Color: {this.props.hairColor}</p>
                <button onClick={this.addYear}>Birthday button for {this.props.firstName} {this.props.lastName}</button>

                

            </div>
        );
    }
}
export default PersonCard;