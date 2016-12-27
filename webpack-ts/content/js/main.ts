import { Greeter } from './greeter'

export class Main {
    private greeter: Greeter;
    constructor(defaultElementId: string) {
        this.greeter = new Greeter("there");
    }

    sayHello () {
        this.greeter.sayHello();
        document.getElementById('greeting').innerHTML = this.greeter.greetingMessage;
    }

    get greetingMessage() : string {
        return this.greeter.greetingMessage;
    }
}

// testing Main class
var instanceOfMain = new Main('greeter');
instanceOfMain.sayHello();
console.log(instanceOfMain.greetingMessage);