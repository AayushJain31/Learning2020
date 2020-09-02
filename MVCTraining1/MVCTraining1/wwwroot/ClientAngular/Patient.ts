export interface IPatient{
    Add():void;
}
export class Patient implements IPatient{
    patientName:string = "";
    patientAddress:string = "";
    constructor(){
        this.patientName = "Typescript";
        this.patientAddress = "JavaScript";
    }
    Add(){
        console.log("Patient Name : " + this.patientName + " Patient Address : " + this.patientAddress);
    }
}
class PatientChild extends Patient implements IPatient{
    i:number = 0; 
    Add(){
           
    }
}