import { Injectable } from '@angular/core';
import { IPerson } from './IPerson';
import { PERSON } from './mock-persons';
@Injectable({
  providedIn: 'root'
})
export class PersonService {
  getPersons():IPerson[]{
    return PERSON
  }
  

  addPerson(persons:IPerson): IPerson[]{
    let allPersons:IPerson[] = PERSON;
    allPersons.push(persons);
    return allPersons;
  }
  constructor() { }
}
