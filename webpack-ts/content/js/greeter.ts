export class Greeter {
    constructor(private message: string){
    }

    sayHello(){
        console.log(this.greetingMessage);
    }

    get greetingMessage() : string{
        return `Hello ${this.message} from TypeScript`;
    }
}