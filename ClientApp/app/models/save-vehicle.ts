import { Contact } from './contact';
export class SaveVehicle {
    constructor(
        public makeId: number, 
        public modelId: number, 
        public isRegistered: boolean, 
        public contact: Contact, 
        public features: number[]) {}
}
