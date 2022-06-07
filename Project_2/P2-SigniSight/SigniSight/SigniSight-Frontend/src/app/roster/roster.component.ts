import { Component, OnInit } from '@angular/core';
import { IPerson } from '../IPerson';
import { PersonService } from '../person.service';
@Component({
  selector: 'roster',
  templateUrl: './roster.component.html',
  styleUrls: ['./roster.component.css']
})
export class RosterComponent implements OnInit {

  
  persons:IPerson[] = []

  singlePerson:IPerson ={
    name:"",
    about:"",
    interest: ""
  }

  getPerson($event : any):void{
    this.singlePerson = $event;
    this.addPerson(this.singlePerson);
  }
  addPerson(peep:IPerson){
    this.persons = this.personService.addPerson(peep)
  }

  constructor(private personService: PersonService) { }

  ngOnInit(): void {
    this.persons = this.personService.getPersons()
  }

}
