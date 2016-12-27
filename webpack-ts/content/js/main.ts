import { Greeter } from './greeter'

export class Main {
    private greeter: Greeter;
    constructor(private defaultElementId: string) {
        this.greeter = new Greeter("there");
    }

    sayHello () {
        this.greeter.sayHello();
        document.getElementById(this.defaultElementId).innerHTML = this.greeter.greetingMessage;
    }

    get greetingMessage() : string {
        return this.greeter.greetingMessage;
    }
}

// testing Main class
var instanceOfMain = new Main('greeter');
instanceOfMain.sayHello();