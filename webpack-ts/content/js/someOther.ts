export class someOther {
    private myName: string;
    private elementId: string;

    constructor(defaultName: string, idOfElement: string){
        this.myName = defaultName;
        this.elementId = idOfElement;
    }

    sayMyName() {
        console.log(`${this.myName}`);
        document.getElementById(this.elementId).innerHTML = `Hello ${this.myName}`;
    }
}

var instanceOfSomeOther = new someOther('Geoff', 'greeting');
instanceOfSomeOther.sayMyName();